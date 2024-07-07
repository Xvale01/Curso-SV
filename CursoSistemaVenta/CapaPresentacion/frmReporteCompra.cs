using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmReporteCompra : Form
    {
        public frmReporteCompra()
        {
            InitializeComponent();
        }

        private void frmReporteCompra_Load(object sender, EventArgs e)
        {
            //combo box de proveedor
            List<Proveedor> lista = new CN_Proveedor().Listar();
            cbProveedor.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "Todos"
            });
            foreach (Proveedor entidad in lista)
            {
                cbProveedor.Items.Add(new OpcionCombo()
                {
                    Valor = entidad.IdProveedor,
                    Texto = entidad.RazonSocial
                });

            }
            cbProveedor.DisplayMember = "Texto";
            cbProveedor.ValueMember = "Valor";
            cbProveedor.SelectedIndex = 0;


            foreach (DataGridViewColumn col in dgvdata.Columns)
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
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;
            int idProveedor = Convert.ToInt32(((OpcionCombo)cbProveedor.SelectedItem).Valor.ToString());

            try
            {
                List<ReporteCompra> lista = new List<ReporteCompra>();
                lista = new CN_Reporte().Compra(dtpFechaInicio.Value.ToString("dd/MM/yyyy"),
                    dtpFechaFin.Value.ToString("dd/MM/yyyy"), idProveedor, out mensaje);

                dgvdata.Rows.Clear();

                foreach (ReporteCompra entidad in lista)
                {
                    dgvdata.Rows.Add(new object[]
                    {
                    entidad.FechaRegistro,
                    entidad.TipoDocumento,
                    entidad.NumeroDocumento,
                    entidad.MontoTotal,
                    entidad.UsuarioRegistro,
                    entidad.DocumentoProveedor,
                    entidad.RazonSocial,
                    entidad.CodigoProducto,
                    entidad.NombreProducto,
                    entidad.Categoria,
                    entidad.PrecioCompra,
                    entidad.PrecioVenta,
                    entidad.Cantidad,
                    entidad.SubTotal
                    });
                }

                if (mensaje == "")
                {
                    return;
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in dgvdata.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                    {
                        //con new object agregamos filas
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString()
                        });
                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
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
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}