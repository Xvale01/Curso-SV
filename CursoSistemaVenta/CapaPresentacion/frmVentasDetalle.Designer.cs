namespace CapaPresentacion
{
    partial class frmVentasDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnDescargar = new FontAwesome.Sharp.IconButton();
            txtMontoTotal = new TextBox();
            dgvDetalleCompras = new DataGridView();
            txtNumeroDocumento = new TextBox();
            txtNombreProveedor = new TextBox();
            txtDocCliente = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            txtUsuario = new TextBox();
            txtTipoDocumento = new TextBox();
            label6 = new Label();
            txtFecha = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnBorrarBusqueda = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMontoCambio = new TextBox();
            label7 = new Label();
            label10 = new Label();
            txtMontoPago = new TextBox();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompras).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDescargar
            // 
            btnDescargar.BackColor = Color.LightSeaGreen;
            btnDescargar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDescargar.ForeColor = Color.White;
            btnDescargar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnDescargar.IconColor = Color.White;
            btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescargar.IconSize = 22;
            btnDescargar.Location = new Point(842, 541);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(170, 33);
            btnDescargar.TabIndex = 85;
            btnDescargar.Text = "Descargar en PDF";
            btnDescargar.TextAlign = ContentAlignment.MiddleRight;
            btnDescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDescargar.UseVisualStyleBackColor = false;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(293, 548);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(77, 23);
            txtMontoTotal.TabIndex = 84;
            // 
            // dgvDetalleCompras
            // 
            dgvDetalleCompras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalleCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompras.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, SubTotal });
            dgvDetalleCompras.Location = new Point(213, 202);
            dgvDetalleCompras.Name = "dgvDetalleCompras";
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dgvDetalleCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleCompras.RowTemplate.Height = 25;
            dgvDetalleCompras.Size = new Size(799, 325);
            dgvDetalleCompras.TabIndex = 82;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(315, 18);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(27, 23);
            txtNumeroDocumento.TabIndex = 70;
            txtNumeroDocumento.Visible = false;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(132, 47);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(209, 23);
            txtNombreProveedor.TabIndex = 8;
            // 
            // txtDocCliente
            // 
            txtDocCliente.Location = new Point(7, 47);
            txtDocCliente.Name = "txtDocCliente";
            txtDocCliente.Size = new Size(119, 23);
            txtDocCliente.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 29);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 1;
            label8.Text = "Nombre Cliente:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 29);
            label9.Name = "label9";
            label9.Size = new Size(119, 15);
            label9.TabIndex = 0;
            label9.Text = "Número documento:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(213, 551);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 83;
            label12.Text = "Monto Total:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtNumeroDocumento);
            groupBox2.Controls.Add(txtNombreProveedor);
            groupBox2.Controls.Add(txtDocCliente);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(659, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 88);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información cliente";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(222, 47);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(209, 23);
            txtUsuario.TabIndex = 7;
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.Location = new Point(109, 47);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.Size = new Size(107, 23);
            txtTipoDocumento.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 29);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Usuario:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(9, 47);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(95, 23);
            txtFecha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 29);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 1;
            label3.Text = "Tipo documento:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtTipoDocumento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(213, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 88);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 29);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 0;
            label4.Text = "Fecha:";
            // 
            // btnBorrarBusqueda
            // 
            btnBorrarBusqueda.BackColor = Color.LightSeaGreen;
            btnBorrarBusqueda.FlatStyle = FlatStyle.Flat;
            btnBorrarBusqueda.ForeColor = Color.LightSeaGreen;
            btnBorrarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnBorrarBusqueda.IconColor = Color.White;
            btnBorrarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarBusqueda.IconSize = 20;
            btnBorrarBusqueda.Location = new Point(971, 41);
            btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            btnBorrarBusqueda.RightToLeft = RightToLeft.No;
            btnBorrarBusqueda.Size = new Size(30, 23);
            btnBorrarBusqueda.TabIndex = 79;
            btnBorrarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            btnBorrarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarBusqueda.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSeaGreen;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.LightSeaGreen;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(935, 41);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.RightToLeft = RightToLeft.No;
            btnBuscar.Size = new Size(30, 23);
            btnBuscar.TabIndex = 78;
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(774, 41);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(155, 23);
            txtBusqueda.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(649, 45);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 76;
            label5.Text = "Número documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(213, 36);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 75;
            label2.Text = "Detalle venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(201, 16);
            label1.Name = "label1";
            label1.Size = new Size(826, 575);
            label1.TabIndex = 74;
            // 
            // txtMontoCambio
            // 
            txtMontoCambio.Location = new Point(665, 548);
            txtMontoCambio.Name = "txtMontoCambio";
            txtMontoCambio.Size = new Size(77, 23);
            txtMontoCambio.TabIndex = 87;
            txtMontoCambio.TextChanged += txtMontoCambio_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(568, 551);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 86;
            label7.Text = "Monto Cambio:";
            label7.Click += this.label7_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(387, 551);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 86;
            label10.Text = "Monto Pago:";
            // 
            // txtMontoPago
            // 
            txtMontoPago.Location = new Point(467, 548);
            txtMontoPago.Name = "txtMontoPago";
            txtMontoPago.Size = new Size(77, 23);
            txtMontoPago.TabIndex = 87;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 300;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 150;
            // 
            // frmVentasDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 606);
            Controls.Add(txtMontoPago);
            Controls.Add(txtMontoCambio);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(btnDescargar);
            Controls.Add(txtMontoTotal);
            Controls.Add(dgvDetalleCompras);
            Controls.Add(label12);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnBorrarBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmVentasDetalle";
            Text = "frmVentasDetalle";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompras).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDescargar;
        private TextBox txtMontoTotal;
        private DataGridView dgvDetalleCompras;
        private TextBox txtNumeroDocumento;
        private TextBox txtNombreProveedor;
        private TextBox txtDocCliente;
        private Label label8;
        private Label label9;
        private Label label12;
        private GroupBox groupBox2;
        private TextBox txtUsuario;
        private TextBox txtTipoDocumento;
        private Label label6;
        private TextBox txtFecha;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnBorrarBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusqueda;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox txtMontoCambio;
        private Label label7;
        private Label label10;
        private TextBox txtMontoPago;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}