namespace CapaPresentacion.Modals
{
    partial class mdCliente
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
            dgvClientes = new DataGridView();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.LightSeaGreen;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 22;
            btnBuscar.Location = new Point(423, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.RightToLeft = RightToLeft.No;
            btnBuscar.Size = new Size(30, 23);
            btnBuscar.TabIndex = 95;
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = Color.White;
            btnLimpiarBuscador.FlatStyle = FlatStyle.Flat;
            btnLimpiarBuscador.ForeColor = Color.White;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarBuscador.IconColor = Color.LightSeaGreen;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 22;
            btnLimpiarBuscador.Location = new Point(459, 72);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.RightToLeft = RightToLeft.No;
            btnLimpiarBuscador.Size = new Size(30, 23);
            btnLimpiarBuscador.TabIndex = 94;
            btnLimpiarBuscador.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarBuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(297, 72);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(120, 23);
            txtBusqueda.TabIndex = 93;
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(171, 71);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(120, 23);
            cbBusqueda.TabIndex = 92;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(88, 75);
            label11.Name = "label11";
            label11.Size = new Size(77, 19);
            label11.TabIndex = 91;
            label11.Text = "Buscar por:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Documento, NombreCompleto });
            dgvClientes.Location = new Point(85, 116);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.RowTemplate.Height = 28;
            dgvClientes.Size = new Size(491, 452);
            dgvClientes.TabIndex = 89;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nº Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 300;
            // 
            // label10
            // 
            label10.BackColor = Color.LightSeaGreen;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(88, 23);
            label10.Name = "label10";
            label10.Size = new Size(353, 45);
            label10.TabIndex = 90;
            label10.Text = "Listado de clientes";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mdCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(705, 600);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(txtBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(label11);
            Controls.Add(dgvClientes);
            Controls.Add(label10);
            Name = "mdCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdClientes";
            Load += mdCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private TextBox txtBusqueda;
        private ComboBox cbBusqueda;
        private Label label11;
        private DataGridView dgvClientes;
        private Label label10;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
    }
}