using CapaEntidad;
using CapaNegocio;
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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            List<Categoria> list = new CN_Categoria().Listar();
            foreach (Categoria entidad in list)
            {
                cbCategoría.Items.Add(new OpcionCombo()
                {
                    Valor = entidad.IdCategoria,
                    Texto = entidad.Descripcion
                });
            }

            cbCategoría.DisplayMember = "Texto";
            cbCategoría.ValueMember = "Valor";
            cbCategoría.SelectedIndex = 0;

            foreach (DataGridViewColumn col in dgvProducto.Columns)
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


            // Mostrar todos los Productos
            List<Producto> listadoProductos = new CN_Producto().Listar();
            foreach (Producto entidad in listadoProductos)
            {
                dgvProducto.Rows.Add(new object[]
                {
                    "",
                    entidad.IdProducto,
                    entidad.Codigo,
                    entidad.Nombre,
                    entidad.Descripcion,
                    entidad.oCategoria.IdCategoria,
                    entidad.oCategoria.Descripcion,
                    entidad.Stock,
                    entidad.PrecioVenta,
                    entidad.PrecioCompra,
                    entidad.Estado == true ? 1 : 0,
                    entidad.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }


    }
}
