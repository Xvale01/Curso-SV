using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modals;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _usuario;
        public frmCompras(Usuario entidad = null)
        {
            _usuario = entidad;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cbTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbTipoDocumento.DisplayMember = "Texto";
            cbTipoDocumento.ValueMember = "Valor";
            cbTipoDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProveedor.Text = "0";
            txtIdProducto.Text = "0";
        }


        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProveedor.Text = modal._proveedor.IdProveedor.ToString();
                    txtDocProveedor.Text = modal._proveedor.Documento;
                    txtNombreProveedor.Text = modal._proveedor.RazonSocial;
                }
                else
                {
                    txtDocProveedor.Select();
                }

            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._producto.IdProducto.ToString();
                    txtCodProducto.Text = modal._producto.Codigo;
                    txtProducto.Text = modal._producto.Nombre;
                    txtPrecioCompra.Select();

                }
                else
                {
                    txtCodProducto.Select();
                }

            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodProducto.BackColor = System.Drawing.Color.Honeydew;
                    txtIdProducto.Text = oProducto.IdProducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtCodProducto.BackColor = System.Drawing.Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto. Utilice unicamente comas para los decimales.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto. Utilice unicamente comas para los decimales.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Select();
                return;
            }


            foreach (DataGridViewRow fila in dgvCompras.Rows)
            {
                var cellValue = fila.Cells["IdProducto"].Value;
                if (cellValue != null && cellValue.ToString() == txtIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dgvCompras.Rows.Add(new object[] {
                    txtIdProducto.Text,
                    txtProducto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtCantidad.Value.ToString(),
                    (txtCantidad.Value * preciocompra).ToString("0.00")
                });
                CalcularTotal();
                LimpiarProducto();
                txtCodProducto.Select();
            }
        }

        private void LimpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtCodProducto.BackColor = System.Drawing.Color.White;
            txtProducto.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Value = 1;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCompras.Rows)
                {
                    var subtotal = row.Cells["SubTotal"].Value;
                    if (subtotal != null)
                    {
                        total += Convert.ToDecimal(subtotal.ToString());
                    }

                }
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void dgvCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //definimos la columna en la queremos la imagen
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Definir el nuevo tamaño de la imagen basado en el tamaño de la celda
                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;

                // Mantener la proporción de la imagen
                var originalWidth = Properties.Resources.Check.Width;
                var originalHeight = Properties.Resources.Check.Height;
                var aspectRatio = (float)originalWidth / originalHeight;

                int newWidth, newHeight;
                if (cellWidth / (float)cellHeight > aspectRatio)
                {
                    newHeight = cellHeight;
                    newWidth = (int)(cellHeight * aspectRatio);
                }
                else
                {
                    newWidth = cellWidth;
                    newHeight = (int)(cellWidth / aspectRatio);
                }

                var x = e.CellBounds.Left + (cellWidth - newWidth) / 2;
                var y = e.CellBounds.Top + (cellHeight - newHeight) / 2;

                e.Graphics.DrawImage(Properties.Resources.Trash, new Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompras.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    dgvCompras.Rows.RemoveAt(index);
                    CalcularTotal();
                }
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == "\b")
            {
                e.Handled = false;
                //si e.Handled = true, entonces no se puede escribir
            }
            else
            {
                if (txtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == "\b")
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvCompras.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalleCompra = new DataTable();
            detalleCompra.Columns.Add("IdProducto",typeof(int));
            detalleCompra.Columns.Add("PrecioCompra", typeof(decimal));
            detalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            detalleCompra.Columns.Add("Cantidad", typeof(int));
            detalleCompra.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                detalleCompra.Rows.Add(
                new object[] {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()

                });
            }

            int idCorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Compra entidad = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _usuario.IdUsuario, },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtIdProveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(entidad, detalleCompra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("¡Se ha creado un nueno registro! \n El número de compra generada es : " + numeroDocumento + "\n\n¿Desea copiar al " +
                    "portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                    txtIdProducto.Text = "0";
                    txtDocProveedor.Text = "";
                    txtNombreProveedor.Text = "";
                    dgvCompras.Rows.Clear();
                    CalcularTotal();
                }
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}