using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            List<Rol> list = new CN_Rol().Listar();
            foreach (Rol entidad in list)
            {
                cbRol.Items.Add(new OpcionCombo()
                {
                    Valor = entidad.IdRol,
                    Texto = entidad.Descripcion
                });
            }

            cbRol.DisplayMember = "Texto";
            cbRol.ValueMember = "Valor";
            cbRol.SelectedIndex = 0;

            foreach (DataGridViewColumn col in dgvUsuarios.Columns)
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


            // Mostrar todos los usuarios
            List<Usuario> listadoUsuarios = new CN_Usuario().Listar();
            foreach (Usuario entidad in listadoUsuarios)
            {
                dgvUsuarios.Rows.Add(new object[]
                {
                    "",
                    entidad.IdUsuario,
                    entidad.Documento,
                    entidad.NombreCompleto,
                    entidad.Correo,
                    entidad.Clave,
                    entidad.oRol.IdRol,
                    entidad.oRol.Descripcion,
                    entidad.Estado == true ? 1 : 0,
                    entidad.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario entidad = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Correo = txtCorreo.Text,
                Clave = txtContrasenna.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cbRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (entidad.IdUsuario == 0)
            {
                int idUsuarioGenerado = new CN_Usuario().Registrar(entidad, out mensaje);



                if (idUsuarioGenerado != 0)
                {
                    dgvUsuarios.Rows.Add(new object[]
                    {
                    "",
                    idUsuarioGenerado,
                    txtDocumento.Text,
                    txtNombreCompleto.Text,
                    txtCorreo.Text,
                    txtContrasenna.Text,
                    ((OpcionCombo)cbRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbRol.SelectedItem).Texto.ToString(),
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

                bool resultado = new CN_Usuario().Editar(entidad, out mensaje);

                if (resultado = true)
                {
                    DataGridViewRow row = dgvUsuarios.Rows[Convert.ToInt32(txtIndice.Text)];
                    //Actualizaa el DataGridView

                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Contrasenna"].Value = txtContrasenna.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cbRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cbRol.SelectedItem).Texto.ToString();
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

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario entidad = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(entidad, out mensaje);

                    if (respuesta)
                    {
                        dgvUsuarios.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgvUsuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsuarios.Rows)
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
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    txtIndice.Text = index.ToString();
                    txtId.Text = dgvUsuarios.Rows[index].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvUsuarios.Rows[index].Cells["Documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvUsuarios.Rows[index].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvUsuarios.Rows[index].Cells["Correo"].Value.ToString();
                    txtContrasenna.Text = dgvUsuarios.Rows[index].Cells["Contrasenna"].Value.ToString();
                    txtConfirmarContrasenna.Text = dgvUsuarios.Rows[index].Cells["Contrasenna"].Value.ToString();

                    foreach (OpcionCombo oc in cbRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsuarios.Rows[index].Cells["IdRol"].Value))
                        {
                            int indiceCombo = cbRol.Items.IndexOf(oc);
                            cbRol.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsuarios.Rows[index].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtContrasenna.Text = string.Empty;
            txtConfirmarContrasenna.Text = string.Empty;
            cbEstado.SelectedIndex = 0;
            cbRol.SelectedIndex = 0;
        }

    }
}
