namespace CapaPresentacion
{
    partial class frmReporteVenta
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
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            cbBusqueda = new ComboBox();
            label11 = new Label();
            btnDescargar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnBuscarVentas = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            label6 = new Label();
            dtpFechaFin = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            dtpFechaInicio = new DateTimePicker();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
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
            btnBuscar.Location = new Point(371, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.RightToLeft = RightToLeft.No;
            btnBuscar.Size = new Size(30, 23);
            btnBuscar.TabIndex = 122;
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
            btnLimpiarBuscador.Location = new Point(407, 78);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.RightToLeft = RightToLeft.No;
            btnLimpiarBuscador.Size = new Size(30, 23);
            btnLimpiarBuscador.TabIndex = 121;
            btnLimpiarBuscador.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarBuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(245, 78);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(120, 23);
            txtBusqueda.TabIndex = 120;
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(119, 78);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(120, 23);
            cbBusqueda.TabIndex = 119;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(36, 80);
            label11.Name = "label11";
            label11.Size = new Size(77, 19);
            label11.TabIndex = 118;
            label11.Text = "Buscar por:";
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
            btnDescargar.Location = new Point(264, 32);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(155, 27);
            btnDescargar.TabIndex = 117;
            btnDescargar.Text = "Descargar Excel";
            btnDescargar.TextAlign = ContentAlignment.MiddleRight;
            btnDescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDescargar.UseVisualStyleBackColor = false;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(945, 11);
            label1.Name = "label1";
            label1.Size = new Size(279, 108);
            label1.TabIndex = 125;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuscarVentas
            // 
            btnBuscarVentas.AutoSize = true;
            btnBuscarVentas.BackColor = Color.LightSeaGreen;
            btnBuscarVentas.FlatStyle = FlatStyle.Popup;
            btnBuscarVentas.ForeColor = Color.White;
            btnBuscarVentas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarVentas.IconColor = Color.White;
            btnBuscarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarVentas.IconSize = 22;
            btnBuscarVentas.Location = new Point(978, 77);
            btnBuscarVentas.Name = "btnBuscarVentas";
            btnBuscarVentas.RightToLeft = RightToLeft.No;
            btnBuscarVentas.Size = new Size(208, 28);
            btnBuscarVentas.TabIndex = 124;
            btnBuscarVentas.Text = "Buscar";
            btnBuscarVentas.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarVentas.UseVisualStyleBackColor = false;
            btnBuscarVentas.Click += btnBuscarVentas_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoCliente, NombreCliente, CodigoProducto, NombreProducto, Categoria, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(12, 135);
            dgvdata.Name = "dgvdata";
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1212, 434);
            dgvdata.TabIndex = 116;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(978, 52);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 115;
            label6.Text = "Fecha fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarTitleBackColor = Color.PaleTurquoise;
            dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(1051, 48);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(135, 23);
            dtpFechaFin.TabIndex = 114;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(976, 23);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 113;
            label3.Text = "Fecha inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 29);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 111;
            label2.Text = "Detalle de ventas";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 11);
            label10.Name = "label10";
            label10.Size = new Size(914, 108);
            label10.TabIndex = 110;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarTitleBackColor = Color.PaleTurquoise;
            dtpFechaInicio.CustomFormat = "dddd, dd MMMM yyyy";
            dtpFechaInicio.DropDownAlign = LeftRightAlignment.Right;
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(1051, 19);
            dtpFechaInicio.MaxDate = new DateTime(2998, 12, 31, 0, 0, 0, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(135, 23);
            dtpFechaInicio.TabIndex = 109;
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
            // DocumentoCliente
            // 
            DocumentoCliente.HeaderText = "Documento Cliente";
            DocumentoCliente.Name = "DocumentoCliente";
            // 
            // NombreCliente
            // 
            NombreCliente.HeaderText = "Nombre Cliente";
            NombreCliente.Name = "NombreCliente";
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
            // frmReporteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1236, 580);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(txtBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(label11);
            Controls.Add(btnDescargar);
            Controls.Add(btnBuscarVentas);
            Controls.Add(dgvdata);
            Controls.Add(label6);
            Controls.Add(dtpFechaFin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label1);
            Name = "frmReporteVenta";
            Text = "frmReporteVenta";
            Load += frmReporteVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private TextBox txtBusqueda;
        private ComboBox cbBusqueda;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnDescargar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBuscarVentas;
        private DataGridView dgvdata;
        private Label label6;
        private DateTimePicker dtpFechaFin;
        private Label label3;
        private Label label2;
        private Label label10;
        private DateTimePicker dtpFechaInicio;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}