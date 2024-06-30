using CapaDatos;
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

namespace CapaPresentacion.Modals
{
    public partial class mdProducto : Form
    {
        public Producto _producto { get; set; }

        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn col in dgvProducto.Columns)
            {
                if (col.Visible == true)
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

            List<Producto> listadoProductos = new CN_Producto().Listar().Where(p => p.Estado == true).ToList();
            foreach (Producto entidad in listadoProductos)
            {
                dgvProducto.Rows.Add(new object[]
                {

                    entidad.IdProducto,
                    entidad.Codigo,
                    entidad.Nombre,
                    entidad.oCategoria.Descripcion,
                    entidad.Stock,
                    entidad.PrecioVenta,
                    entidad.PrecioCompra
                });


            }
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dgvProducto.Rows[iRow].Cells["Id"].Value.ToString()),
                    Codigo = dgvProducto.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = dgvProducto.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvProducto.Rows[iRow].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dgvProducto.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgvProducto.Rows[iRow].Cells["PrecioVenta"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgvProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProducto.Rows)
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
            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
