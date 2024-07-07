namespace CapaPresentacion
{
    partial class frmReporteCompra
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtpFechaInicio = new DateTimePicker();
            label10 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            dtpFechaFin = new DateTimePicker();
            dgvdata = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnDescargar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            cbBusqueda = new ComboBox();
            label11 = new Label();
            cbProveedor = new ComboBox();
            btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarTitleBackColor = Color.PaleTurquoise;
            dtpFechaInicio.CustomFormat = "dddd, dd MMMM yyyy";
            dtpFechaInicio.DropDownAlign = LeftRightAlignment.Right;
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(1051, 44);
            dtpFechaInicio.MaxDate = new DateTime(2998, 12, 31, 0, 0, 0, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(135, 23);
            dtpFechaInicio.TabIndex = 0;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 10);
            label10.Name = "label10";
            label10.Size = new Size(914, 128);
            label10.TabIndex = 83;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(975, 19);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 87;
            label5.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 31);
            label2.Name = "label2";
            label2.Size = new Size(224, 32);
            label2.TabIndex = 86;
            label2.Text = "Detalle de compras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(976, 48);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 91;
            label3.Text = "Fecha inicio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(978, 77);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 95;
            label6.Text = "Fecha fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarTitleBackColor = Color.PaleTurquoise;
            dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(1051, 73);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(135, 23);
            dtpFechaFin.TabIndex = 94;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(12, 153);
            dgvdata.Name = "dgvdata";
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSeaGreen;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1212, 415);
            dgvdata.TabIndex = 98;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.Name = "FechaRegistro";
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.Name = "TipoDocumento";
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.Name = "NumeroDocumento";
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.Name = "MontoTotal";
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.Name = "UsuarioRegistro";
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor";
            DocumentoProveedor.Name = "DocumentoProveedor";
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.Name = "CodigoProducto";
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            // 
            // btnDescargar
            // 
            btnDescargar.BackColor = Color.LightSeaGreen;
            btnDescargar.FlatStyle = FlatStyle.Popup;
            btnDescargar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDescargar.ForeColor = Color.White;
            btnDescargar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnDescargar.IconColor = Color.White;
            btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescargar.IconSize = 22;
            btnDescargar.Location = new Point(264, 34);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(155, 27);
            btnDescargar.TabIndex = 99;
            btnDescargar.Text = "Descargar Excel";
            btnDescargar.TextAlign = ContentAlignment.MiddleRight;
            btnDescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDescargar.UseVisualStyleBackColor = false;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSeaGreen;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.LightSeaGreen;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 22;
            btnBuscar.Location = new Point(371, 86);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.RightToLeft = RightToLeft.No;
            btnBuscar.Size = new Size(30, 23);
            btnBuscar.TabIndex = 105;
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = Color.LightSeaGreen;
            btnLimpiarBuscador.FlatStyle = FlatStyle.Flat;
            btnLimpiarBuscador.ForeColor = Color.LightSeaGreen;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarBuscador.IconColor = Color.White;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 22;
            btnLimpiarBuscador.Location = new Point(407, 86);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.RightToLeft = RightToLeft.No;
            btnLimpiarBuscador.Size = new Size(30, 23);
            btnLimpiarBuscador.TabIndex = 104;
            btnLimpiarBuscador.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarBuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(245, 86);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(120, 23);
            txtBusqueda.TabIndex = 103;
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(119, 86);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(120, 23);
            cbBusqueda.TabIndex = 102;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(36, 88);
            label11.Name = "label11";
            label11.Size = new Size(77, 19);
            label11.TabIndex = 101;
            label11.Text = "Buscar por:";
            // 
            // cbProveedor
            // 
            cbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(1051, 15);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(135, 23);
            cbProveedor.TabIndex = 106;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.AutoSize = true;
            btnBuscarProveedor.BackColor = Color.LightSeaGreen;
            btnBuscarProveedor.FlatStyle = FlatStyle.Popup;
            btnBuscarProveedor.ForeColor = Color.White;
            btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProveedor.IconColor = Color.White;
            btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProveedor.IconSize = 22;
            btnBuscarProveedor.Location = new Point(978, 102);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.RightToLeft = RightToLeft.No;
            btnBuscarProveedor.Size = new Size(208, 28);
            btnBuscarProveedor.TabIndex = 107;
            btnBuscarProveedor.Text = "Buscar";
            btnBuscarProveedor.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(945, 10);
            label1.Name = "label1";
            label1.Size = new Size(279, 128);
            label1.TabIndex = 108;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmReporteCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1236, 580);
            Controls.Add(btnBuscarProveedor);
            Controls.Add(cbProveedor);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(txtBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(label11);
            Controls.Add(btnDescargar);
            Controls.Add(dgvdata);
            Controls.Add(label6);
            Controls.Add(dtpFechaFin);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label10);
            Controls.Add(label1);
            Name = "frmReporteCompra";
            Text = "frmReporteCompra";
            Load += frmReporteCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaInicio;
        private Label label10;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label6;
        private DateTimePicker dtpFechaFin;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnDescargar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private TextBox txtBusqueda;
        private ComboBox cbBusqueda;
        private Label label11;
        private ComboBox cbProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label1;
    }
}