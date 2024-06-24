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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto entidad = new Producto()
            {
                IdProducto = Convert.ToInt32(txtId.Text),
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbCategoría.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (entidad.IdProducto == 0)
            {
                int idProductoGenerado = new CN_Producto().Registrar(entidad, out mensaje);

                if (idProductoGenerado != 0)
                {
                    dgvProducto.Rows.Add(new object[]
                    {
                    "",
                    idProductoGenerado,
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    ((OpcionCombo)cbCategoría.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbCategoría.SelectedItem).Texto.ToString(),
                    "0",
                    "0.00",
                    "0.00",
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

                bool resultado = new CN_Producto().Editar(entidad, out mensaje);

                if (resultado = true)
                {
                    DataGridViewRow row = dgvProducto.Rows[Convert.ToInt32(txtIndice.Text)];
                    //Actualizaa el DataGridView

                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Codigo"].Value = txtCodigo.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbCategoría.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbCategoría.SelectedItem).Texto.ToString();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar este producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto entidad = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(entidad, out mensaje);

                    if (respuesta)
                    {
                        dgvProducto.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
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

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cbEstado.SelectedIndex = 0;
            cbCategoría.SelectedIndex = 0;
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducto.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    txtIndice.Text = index.ToString();
                    txtId.Text = dgvProducto.Rows[index].Cells["Id"].Value.ToString();

                    txtCodigo.Text = dgvProducto.Rows[index].Cells["Codigo"].Value.ToString();
                    txtDescripcion.Text = dgvProducto.Rows[index].Cells["Descripcion"].Value.ToString();
                    txtNombre.Text = dgvProducto.Rows[index].Cells["Nombre"].Value.ToString();

                    foreach (OpcionCombo oc in cbCategoría.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProducto.Rows[index].Cells["IdCategoria"].Value))
                        {
                            int indiceCombo = cbCategoría.Items.IndexOf(oc);
                            cbCategoría.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProducto.Rows[index].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }

        private void dgvProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Salir si no hay datos para exportar
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in dgvProducto.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (row.Visible)
                    {
                        //con new object agregamos filas
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value,
                            row.Cells[3].Value,
                            row.Cells[4].Value,
                            row.Cells[6].Value,
                            row.Cells[7].Value,
                            row.Cells[8].Value,
                            row.Cells[9].Value,
                            row.Cells[11].Value,
                        });
                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProductos_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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
    }
}
