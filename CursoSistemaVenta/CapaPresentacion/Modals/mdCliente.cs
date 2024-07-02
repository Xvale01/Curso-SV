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
    public partial class mdCliente : Form
    {
        public Cliente _cliente;

        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgvClientes.Columns)
            {
                cbBusqueda.Items.Add(new OpcionCombo()
                {
                    Valor = col.Name,
                    Texto = col.HeaderText
                });
            }
            cbBusqueda.DisplayMember = "Texto";
            cbBusqueda.ValueMember = "Valor";
            cbBusqueda.SelectedIndex = 0;


            // Mostrar todos los Clientes
            List<Cliente> listadoClientes = new CN_Cliente().Listar();
            foreach (Cliente entidad in listadoClientes)
            {
                if (entidad.Estado)
                    dgvClientes.Rows.Add(new object[]
                    {
                    entidad.Documento,
                    entidad.NombreCompleto
                    });
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum >= 0)
            {
                //le asignamos a la propiedad todos los atributos
                _cliente = new Cliente()
                {
                    Documento = dgvClientes.Rows[iRow].Cells["Documento"].Value.ToString(),
                    NombreCompleto = dgvClientes.Rows[iRow].Cells["NombreCompleto"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgvClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
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
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
