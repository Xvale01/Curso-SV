using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuActual = null;
        private static Form formularioActual = null;

        public Inicio(Usuario oUsuario = null)
        {
            if (usuarioActual == null)
            {
                usuarioActual = new Usuario()
                {
                    NombreCompleto = "ADMIN PREDEFINIDO",
                    IdUsuario = 1
                };
            }
            else
            {
                usuarioActual = oUsuario;
            }


            InitializeComponent();
            List<Permiso> list = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconMenuItem in menu.Items)
            {
                bool encontrado = list.Any(m => m.NombreMenu == iconMenuItem.Name);
                if (encontrado == false)
                {
                    iconMenuItem.Visible = false;
                }

            }


            lblNombreUsuario.Text = usuarioActual.NombreCompleto;
        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem iconMenuItem, Form form)
        {
            if (menuActual != null)
            {
                menuActual.BackColor = Color.White;
            }

            iconMenuItem.BackColor = Color.PaleTurquoise;
            menuActual = iconMenuItem;

            if (formularioActual != null)
            {
                formularioActual.Close();
            }

            formularioActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.LightSeaGreen;

            contenedor.Controls.Add(form);
            form.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            //menu seleccionado y formulario que queremos mostrar
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmProducto());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmVentas());

        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmVentasDetalle());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new frmCompras());

        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new frmComprasDetalle());

        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());

        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());

        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void menuAcercade_Click(object sender, EventArgs e)
        {

        }
    }
}
