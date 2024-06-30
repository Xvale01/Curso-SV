using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Configuration;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //boton de ingresar
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Usuario entidad = new CN_Usuario().Listar().Where(u => u.Documento == txtDocumento.Text && u.Clave == txtContrasenna.Text).FirstOrDefault();

            if (entidad != null)
            {
                Inicio form = new Inicio(entidad);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtDocumento.Text = string.Empty;
            txtContrasenna.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
