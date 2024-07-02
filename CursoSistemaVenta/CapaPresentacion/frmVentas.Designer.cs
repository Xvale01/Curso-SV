namespace CapaPresentacion
{
    partial class frmVentas
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
            btnCrearVenta = new FontAwesome.Sharp.IconButton();
            txtCambio = new TextBox();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            dgvVentas = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            label11 = new Label();
            txtCantidad = new NumericUpDown();
            txtStock = new TextBox();
            label9 = new Label();
            txtPrecio = new TextBox();
            groupBox1 = new GroupBox();
            cbTipoDocumento = new ComboBox();
            txtFecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtIdProveedor = new TextBox();
            btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            txtNombreCliente = new TextBox();
            txtDocCliente = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            txtIdProducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            txtProducto = new TextBox();
            txtCodProducto = new TextBox();
            label6 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            label10 = new Label();
            txtTotalPagar = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtPagaCon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearVenta
            // 
            btnCrearVenta.BackColor = Color.LightSeaGreen;
            btnCrearVenta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearVenta.ForeColor = Color.White;
            btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnCrearVenta.IconColor = Color.White;
            btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearVenta.IconSize = 20;
            btnCrearVenta.Location = new Point(921, 541);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(100, 30);
            btnCrearVenta.TabIndex = 81;
            btnCrearVenta.Text = "Registrar";
            btnCrearVenta.TextAlign = ContentAlignment.MiddleRight;
            btnCrearVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearVenta.UseVisualStyleBackColor = false;
            btnCrearVenta.Click += btnCrearVenta_Click;
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(921, 502);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(100, 23);
            txtCambio.TabIndex = 80;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightSeaGreen;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 32;
            btnAgregar.Location = new Point(921, 183);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 80);
            btnAgregar.TabIndex = 78;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(921, 484);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 79;
            label12.Text = "Cambio:";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, btnEliminar });
            dgvVentas.Location = new Point(199, 269);
            dgvVentas.Name = "dgvVentas";
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.Size = new Size(710, 302);
            dgvVentas.TabIndex = 77;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            dgvVentas.CellPainting += dgvVentas_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 250;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 110;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 110;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 110;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Width = 110;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(623, 28);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 68;
            label11.Text = "Cantidad: ";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(623, 47);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(71, 23);
            txtCantidad.TabIndex = 67;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtStock
            // 
            txtStock.Location = new Point(508, 48);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(109, 23);
            txtStock.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(508, 28);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 65;
            label9.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(393, 48);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(109, 23);
            txtPrecio.TabIndex = 64;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbTipoDocumento);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(199, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 88);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información venta";
            // 
            // cbTipoDocumento
            // 
            cbTipoDocumento.FormattingEnabled = true;
            cbTipoDocumento.Location = new Point(173, 47);
            cbTipoDocumento.Name = "cbTipoDocumento";
            cbTipoDocumento.Size = new Size(191, 23);
            cbTipoDocumento.TabIndex = 3;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(12, 47);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(155, 23);
            txtFecha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 29);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 1;
            label3.Text = "Tipo de documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 32);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 73;
            label1.Text = "Registrar venta";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtIdProveedor);
            groupBox2.Controls.Add(btnBuscarCliente);
            groupBox2.Controls.Add(txtNombreCliente);
            groupBox2.Controls.Add(txtDocCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(592, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 88);
            groupBox2.TabIndex = 75;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de cliente";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(390, 18);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(26, 23);
            txtIdProveedor.TabIndex = 61;
            txtIdProveedor.Visible = false;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.LightSeaGreen;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.ForeColor = Color.LightSeaGreen;
            btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarCliente.IconColor = Color.White;
            btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCliente.IconSize = 20;
            btnBuscarCliente.Location = new Point(173, 47);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.RightToLeft = RightToLeft.No;
            btnBuscarCliente.Size = new Size(30, 23);
            btnBuscarCliente.TabIndex = 62;
            btnBuscarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(209, 47);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(207, 23);
            txtNombreCliente.TabIndex = 3;
            // 
            // txtDocCliente
            // 
            txtDocCliente.Location = new Point(12, 47);
            txtDocCliente.Name = "txtDocCliente";
            txtDocCliente.Size = new Size(155, 23);
            txtDocCliente.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 29);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 1;
            label4.Text = "Nombre Completo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 29);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 0;
            label5.Text = "Número documento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(393, 28);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 63;
            label8.Text = "Precio:";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(114, 20);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(26, 23);
            txtIdProducto.TabIndex = 61;
            txtIdProducto.Visible = false;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.LightSeaGreen;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = Color.LightSeaGreen;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProducto.IconColor = Color.White;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProducto.IconSize = 20;
            btnBuscarProducto.Location = new Point(146, 48);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.RightToLeft = RightToLeft.No;
            btnBuscarProducto.Size = new Size(30, 23);
            btnBuscarProducto.TabIndex = 62;
            btnBuscarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(182, 47);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(205, 23);
            txtProducto.TabIndex = 3;
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(12, 47);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(128, 23);
            txtCodProducto.TabIndex = 2;
            txtCodProducto.KeyDown += txtCodProducto_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 28);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 1;
            label6.Text = "Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 29);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 0;
            label7.Text = "Cod. Producto:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(txtStock);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtPrecio);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtIdProducto);
            groupBox3.Controls.Add(btnBuscarProducto);
            groupBox3.Controls.Add(txtProducto);
            groupBox3.Controls.Add(txtCodProducto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(199, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(710, 88);
            groupBox3.TabIndex = 76;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información de producto";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(160, 22);
            label10.Name = "label10";
            label10.Size = new Size(895, 567);
            label10.TabIndex = 82;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(921, 381);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(100, 23);
            txtTotalPagar.TabIndex = 84;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(921, 363);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 83;
            label13.Text = "Total a pagar:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Location = new Point(921, 423);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 83;
            label14.Text = "Paga con:";
            // 
            // txtPagaCon
            // 
            txtPagaCon.Location = new Point(921, 441);
            txtPagaCon.Name = "txtPagaCon";
            txtPagaCon.Size = new Size(100, 23);
            txtPagaCon.TabIndex = 84;
            txtPagaCon.KeyDown += txtPagaCon_KeyDown;
            txtPagaCon.KeyPress += txtPagaCon_KeyPress;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 610);
            Controls.Add(txtPagaCon);
            Controls.Add(label14);
            Controls.Add(txtTotalPagar);
            Controls.Add(label13);
            Controls.Add(btnCrearVenta);
            Controls.Add(txtCambio);
            Controls.Add(btnAgregar);
            Controls.Add(label12);
            Controls.Add(dgvVentas);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(label10);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCrearVenta;
        private TextBox txtCambio;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label label12;
        private DataGridView dgvVentas;
        private Label label11;
        private NumericUpDown txtCantidad;
        private TextBox txtStock;
        private Label label9;
        private TextBox txtPrecio;
        private GroupBox groupBox1;
        private ComboBox cbTipoDocumento;
        private TextBox txtFecha;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtIdProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private TextBox txtNombreCliente;
        private TextBox txtDocCliente;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox txtIdProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private TextBox txtProducto;
        private TextBox txtCodProducto;
        private Label label6;
        private Label label7;
        private GroupBox groupBox3;
        private Label label10;
        private TextBox txtTotalPagar;
        private Label label13;
        private Label label14;
        private TextBox txtPagaCon;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btnEliminar;
    }
}