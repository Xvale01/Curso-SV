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
    public partial class mdProveedor : Form
    {
        public Proveedor _proveedor { get; set; }

        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgvProveedores.Columns)
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

            // Mostrar todos los Proveedors
            List<Proveedor> listadoProveedor = new CN_Proveedor().Listar();
            foreach (Proveedor entidad in listadoProveedor)
            {
                dgvProveedores.Rows.Add(new object[]
                {
                    entidad.IdProveedor,
                    entidad.Documento,
                    entidad.RazonSocial,
                });
            }
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvProveedores.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = dgvProveedores.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvProveedores.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
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
