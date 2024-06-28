using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;


            foreach (DataGridViewColumn col in dgvProveedores.Columns)
            {
                if (col.Visible == true && col.Name != "btnSeleccionar")
                {
                    cbBusqueda.Items.Add(new OpcionCombo()
                    {
                        Valor = col.Name,
                        Texto = col.HeaderText
                    });
                }
            }
            cbBusqueda.DisplayMember = "Texto";
            cbBusqueda.ValueMember = "Valor";
            cbBusqueda.SelectedIndex = 0;


            // Mostrar todos los Proveedors
            List<Proveedor> listadoProveedor = new CN_Proveedor().Listar();
            foreach (Proveedor entidad in listadoProveedor)
            {
                dgvProveedores.Rows.Add(new object[]
                {
                    "",
                    entidad.IdProveedor,
                    entidad.Documento,
                    entidad.RazonSocial,
                    entidad.Correo,
                    entidad.Telefono,
                    entidad.Estado == true ? 1 : 0,
                    entidad.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor entidad = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                RazonSocial = txtRazonSocial.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (entidad.IdProveedor == 0)
            {
                int idProveedorGenerado = new CN_Proveedor().Registrar(entidad, out mensaje);



                if (idProveedorGenerado != 0)
                {
                    dgvProveedores.Rows.Add(new object[]
                    {
                    "",
                    idProveedorGenerado,
                    txtDocumento.Text,
                    txtRazonSocial.Text,
                    txtCorreo.Text,
                    txtTelefono.Text,
                    ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {

                bool resultado = new CN_Proveedor().Editar(entidad, out mensaje);

                if (resultado == true)
                {
                    DataGridViewRow row = dgvProveedores.Rows[Convert.ToInt32(txtIndice.Text)];

                    //Actualiza el DataGridView

                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["RazonSocial"].Value = txtRazonSocial.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString();

                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbEstado.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar este proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedor entidad = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(entidad, out mensaje);

                    if (respuesta)
                    {
                        dgvProveedores.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    txtIndice.Text = index.ToString();
                    txtId.Text = dgvProveedores.Rows[index].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvProveedores.Rows[index].Cells["Documento"].Value.ToString();
                    txtRazonSocial.Text = dgvProveedores.Rows[index].Cells["RazonSocial"].Value.ToString();
                    txtCorreo.Text = dgvProveedores.Rows[index].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvProveedores.Rows[index].Cells["Telefono"].Value.ToString();

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProveedores.Rows[index].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }

        private void dgvProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
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

                e.Graphics.DrawImage(Properties.Resources.Check, new Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgvProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProveedores.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
