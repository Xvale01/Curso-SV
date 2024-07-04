using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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
    public partial class frmVentasDetalle : Form
    {
        public frmVentasDetalle()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtBusqueda.Text);
            if (oVenta.IdVenta != 0)
            {
                txtNumeroDocumento.Text = oVenta.NumeroDocumento;
                txtFecha.Text = oVenta.FechaRegistro;
                txtTipoDocumento.Text = oVenta.TipoDocumento;
                txtUsuario.Text = oVenta.oUsuario.NombreCompleto;
                txtDocCliente.Text = oVenta.DocumentoCliente;
                txtNombreCliente.Text = oVenta.NombreCliente;

                dgvDetalleVenta.Rows.Clear();

                try
                {
                    foreach (Detalle_Venta dc in oVenta.oDetalleVenta)
                    {
                        dgvDetalleVenta.Rows.Add(new object[]
                        {
                            dc.oProducto.Nombre, dc.PrecioVenta, dc.Cantidad, dc.SubTotal
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                txtMontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                txtMontoPago.Text = oVenta.MontoPago.ToString("0.00");
                txtMontoCambio.Text = oVenta.MontoCambio.ToString("0.00");
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtFecha.Text = "";
            txtTipoDocumento.Text = "";
            txtUsuario.Text = "";
            txtDocCliente.Text = "";
            txtNombreCliente.Text = "";

            txtMontoTotal.Text = "0.00";
            txtMontoPago.Text = "0.00";
            txtMontoCambio.Text = "0.00";

            dgvDetalleVenta.Rows.Clear();
            txtBusqueda.Select();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (txtTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textoHtml = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            textoHtml = textoHtml.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            textoHtml = textoHtml.Replace("@docnegocio", odatos.RUC);
            textoHtml = textoHtml.Replace("@direcnegocio", odatos.Direccion);

            textoHtml = textoHtml.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            textoHtml = textoHtml.Replace("@numerodocumento", txtNumeroDocumento.Text);

            textoHtml = textoHtml.Replace("@doccliente", txtDocCliente.Text);
            textoHtml = textoHtml.Replace("@nombrecliente", txtNombreCliente.Text);
            textoHtml = textoHtml.Replace("@fecharegistro", txtFecha.Text);
            textoHtml = textoHtml.Replace("@usuarioregistro", txtUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            textoHtml = textoHtml.Replace("@filas", filas);
            textoHtml = textoHtml.Replace("@montototal", txtMontoTotal.Text);
            textoHtml = textoHtml.Replace("@pagocon", txtMontoPago.Text);
            textoHtml = textoHtml.Replace("@cambio", txtMontoCambio.Text);


            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Venta_" + txtBusqueda.Text + ".pdf");
            saveFile.Filter = "Pdf Files |*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(textoHtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
