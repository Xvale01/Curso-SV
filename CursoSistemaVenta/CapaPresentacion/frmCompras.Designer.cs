namespace CapaPresentacion
{
    partial class frmCompras
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
            label10 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbTipoDocumento = new ComboBox();
            txtFecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtIdProveedor = new TextBox();
            btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            txtNombreProveedor = new TextBox();
            txtDocProveedor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            txtCantidad = new NumericUpDown();
            txtPrecioVenta = new TextBox();
            label9 = new Label();
            txtPrecioCompra = new TextBox();
            label8 = new Label();
            txtIdProducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            txtProducto = new TextBox();
            txtCodProducto = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dgvCompras = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            txtTotalPagar = new TextBox();
            label12 = new Label();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(170, 21);
            label10.Name = "label10";
            label10.Size = new Size(895, 567);
            label10.TabIndex = 55;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 31);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 56;
            label1.Text = "Registrar compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbTipoDocumento);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(209, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 88);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información compra";
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtIdProveedor);
            groupBox2.Controls.Add(btnBuscarProveedor);
            groupBox2.Controls.Add(txtNombreProveedor);
            groupBox2.Controls.Add(txtDocProveedor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(602, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 88);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de proveedor";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(390, 18);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(26, 23);
            txtIdProveedor.TabIndex = 61;
            txtIdProveedor.Visible = false;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.BackColor = Color.LightSeaGreen;
            btnBuscarProveedor.FlatStyle = FlatStyle.Flat;
            btnBuscarProveedor.ForeColor = Color.LightSeaGreen;
            btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProveedor.IconColor = Color.White;
            btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProveedor.IconSize = 20;
            btnBuscarProveedor.Location = new Point(173, 47);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.RightToLeft = RightToLeft.No;
            btnBuscarProveedor.Size = new Size(30, 23);
            btnBuscarProveedor.TabIndex = 62;
            btnBuscarProveedor.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(209, 47);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(207, 23);
            txtNombreProveedor.TabIndex = 3;
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.Location = new Point(12, 47);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(155, 23);
            txtDocProveedor.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 29);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 1;
            label4.Text = "Razón Social:";
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
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(txtPrecioVenta);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtPrecioCompra);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtIdProducto);
            groupBox3.Controls.Add(btnBuscarProducto);
            groupBox3.Controls.Add(txtProducto);
            groupBox3.Controls.Add(txtCodProducto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(209, 174);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(710, 88);
            groupBox3.TabIndex = 63;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información de producto";
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
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(508, 48);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(109, 23);
            txtPrecioVenta.TabIndex = 66;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(508, 28);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 65;
            label9.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(393, 48);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(109, 23);
            txtPrecioCompra.TabIndex = 64;
            txtPrecioCompra.KeyPress += txtPrecioCompra_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(393, 28);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 63;
            label8.Text = "Precio Compra:";
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
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, btnEliminar });
            dgvCompras.Location = new Point(209, 268);
            dgvCompras.Name = "dgvCompras";
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSeaGreen;
            dgvCompras.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCompras.RowTemplate.Height = 25;
            dgvCompras.Size = new Size(710, 302);
            dgvCompras.TabIndex = 64;
            dgvCompras.CellContentClick += dgvCompras_CellContentClick;
            dgvCompras.CellPainting += dgvCompras_CellPainting;
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
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 120;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Visible = false;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 120;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 120;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Width = 60;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.LightSeaGreen;
            btnAgregarProducto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregarProducto.IconColor = Color.White;
            btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProducto.IconSize = 32;
            btnAgregarProducto.Location = new Point(931, 182);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(100, 80);
            btnAgregarProducto.TabIndex = 65;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.TextAlign = ContentAlignment.BottomCenter;
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(931, 511);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(100, 23);
            txtTotalPagar.TabIndex = 70;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(931, 493);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 69;
            label12.Text = "Total a pagar:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightSeaGreen;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnRegistrar.IconColor = Color.White;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.IconSize = 22;
            btnRegistrar.Location = new Point(931, 540);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 30);
            btnRegistrar.TabIndex = 71;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1215, 611);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTotalPagar);
            Controls.Add(label12);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dgvCompras);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "frmCompras";
            Text = "frmCompras";
            Load += frmCompras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbTipoDocumento;
        private TextBox txtFecha;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtNombreProveedor;
        private TextBox txtDocProveedor;
        private Label label4;
        private Label label5;
        private TextBox txtIdProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private GroupBox groupBox3;
        private TextBox txtIdProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private TextBox txtProducto;
        private TextBox txtCodProducto;
        private Label label6;
        private Label label7;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private Label label8;
        private Label label11;
        private NumericUpDown txtCantidad;
        private Label label9;
        private DataGridView dgvCompras;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private TextBox txtTotalPagar;
        private Label label12;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btnEliminar;
    }
}