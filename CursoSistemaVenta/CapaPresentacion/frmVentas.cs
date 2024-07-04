using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modals;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuario _usuario;
        public frmVentas(Usuario entidad = null)
        {
            _usuario = entidad;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cbTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbTipoDocumento.DisplayMember = "Texto";
            cbTipoDocumento.ValueMember = "Valor";
            cbTipoDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProveedor.Text = "0";
            txtIdProducto.Text = "0";
            txtPagaCon.Text = "";
            txtCambio.Text = "";
            txtTotalPagar.Text = "0";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._producto.IdProducto.ToString();
                    txtCodProducto.Text = modal._producto.Codigo.ToString();
                    txtProducto.Text = modal._producto.Nombre;
                    txtPrecio.Text = modal._producto.PrecioVenta.ToString();
                    txtStock.Text = modal._producto.Stock.ToString();
                    txtCantidad.Select();

                }
                else
                {
                    txtCodProducto.Select();
                }

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtDocCliente.Text = modal._cliente.Documento;
                    txtNombreCliente.Text = modal._cliente.NombreCompleto;
                    txtDocCliente.Select();
                }
                else
                {
                    txtDocCliente.Select();
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
                    txtCodProducto.Text = oProducto.Codigo;
                    txtProducto.Text = oProducto.Nombre;

                    txtPrecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtStock.Text = oProducto.Stock.ToString();

                    txtCantidad.Select();

                }
                else
                {
                    txtCodProducto.BackColor = System.Drawing.Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                }
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto. Utilice unicamente comas para los decimales.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow fila in dgvVentas.Rows)
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

                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtIdProducto.Text),
                    Convert.ToInt32(txtCantidad.Value.ToString())
                    );

                if (respuesta)
                {

                    dgvVentas.Rows.Add(new object[]
                    {
                        txtIdProducto.Text,
                        txtProducto.Text,
                        precio.ToString("0.00"),
                        txtCantidad.Value.ToString(),
                        (txtCantidad.Value * precio).ToString("0.00")
                    });

                    calcularTotal();
                    LimpiarProducto();
                    txtCodProducto.Select();
                }

            }
        }

        private void LimpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtCodProducto.BackColor = System.Drawing.Color.White;
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVentas.Rows)
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

        private void dgvVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //definimos la columna en la queremos la imagen
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Definir el nuevo tamaño de la imagen basado en el tamaño de la celda
                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;

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

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {

                    bool respuesta = new CN_Venta().SumarStock
                    (
                        Convert.ToInt32(dgvVentas.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvVentas.Rows[index].Cells["Cantidad"].Value.ToString())
                    );

                    if (respuesta)
                    {
                        dgvVentas.Rows.RemoveAt(index);
                        calcularTotal();
                    }


                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == "\b" || e.KeyChar.ToString() == ",")
            {
                if (e.KeyChar.ToString() == "," && textBox.Text.Trim().Length == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_KeyPress(sender, e, txtPrecio);
        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_KeyPress(sender, e, txtPagaCon);
        }


        private void calcularCambio()
        {
            if (txtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Text);

            if (txtPagaCon.Text.Trim() == "")
            {
                txtPagaCon.Text = "0";
            }

            if (decimal.TryParse(txtPagaCon.Text.Trim(), out pagacon))
            {
                if (pagacon < totalPagar)
                {
                    txtCambio.Text = "0.00";
                    MessageBox.Show("No esta ingresando la cantidad necesaria para efectuar el pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    txtCambio.Text = "0.00";
                    decimal cambio = pagacon - totalPagar;
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularCambio();
            }
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocCliente.Text))
            {
                MessageBox.Show("Debe ingresar documento de cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvVentas.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos para realizar una venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalleVenta = new DataTable();

            detalleVenta.Columns.Add("IdProducto", typeof(int));
            detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                detalleVenta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value?.ToString(),
                    row.Cells["Cantidad"].Value?.ToString(),
                    row.Cells["SubTotal"].Value?.ToString()
                });
            }

            int idCorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

                Venta entidad = new Venta()
                {
                    oUsuario = new Usuario() { IdUsuario = _usuario.IdUsuario },
                    TipoDocumento = ((OpcionCombo)cbTipoDocumento.SelectedItem).Texto,
                    NumeroDocumento = numeroDocumento,
                    DocumentoCliente = txtDocCliente.Text,
                    NombreCliente = txtNombreCliente.Text,
                    MontoCambio = Convert.ToDecimal(txtCambio.Text.Trim()),
                    MontoPago = Convert.ToDecimal(txtPagaCon.Text.Trim()),
                    MontoTotal = Convert.ToDecimal(txtTotalPagar.Text.Trim()),
                };

                string mensaje = string.Empty;
                bool respuesta = new CN_Venta().Registrar(entidad, detalleVenta, out mensaje);

                if (respuesta)
                {
                    var result = MessageBox.Show("¡Se ha creado un nuevo registro! \n El número de venta generada es : " + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Clipboard.SetText(numeroDocumento);
                    }

                    txtDocCliente.Text = "";
                    txtNombreCliente.Text = "";
                    dgvVentas.Rows.Clear();
                    calcularTotal();
                    txtPagaCon.Text = "";
                    txtCambio.Text = "";
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

        }

    }
}
