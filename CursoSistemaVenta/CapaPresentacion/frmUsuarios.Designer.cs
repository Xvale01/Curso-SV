namespace CapaPresentacion
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Contrasenna = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            dgvUsuarios = new DataGridView();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            cbBusqueda = new ComboBox();
            label11 = new Label();
            txtId = new TextBox();
            label10 = new Label();
            txtIndice = new TextBox();
            label9 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            cbEstado = new ComboBox();
            cbRol = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtConfirmarContrasenna = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            txtContrasenna = new TextBox();
            txtNombreCompleto = new TextBox();
            txtDocumento = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            btnBuscar.Location = new Point(1135, 35);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.RightToLeft = RightToLeft.No;
            btnBuscar.Size = new Size(30, 23);
            btnBuscar.TabIndex = 60;
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "IdUsuario";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nº Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 120;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 220;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 220;
            // 
            // Contrasenna
            // 
            Contrasenna.HeaderText = "Contrasenna";
            Contrasenna.Name = "Contrasenna";
            Contrasenna.ReadOnly = true;
            Contrasenna.Visible = false;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, Documento, NombreCompleto, Correo, Contrasenna, IdRol, Rol, EstadoValor, Estado });
            dgvUsuarios.Location = new Point(342, 86);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightSeaGreen;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvUsuarios.RowTemplate.Height = 28;
            dgvUsuarios.Size = new Size(861, 468);
            dgvUsuarios.TabIndex = 53;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            dgvUsuarios.CellPainting += dgvUsuarios_CellPainting;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 130;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "Estado Valor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
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
            btnLimpiarBuscador.Location = new Point(1171, 36);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.RightToLeft = RightToLeft.No;
            btnLimpiarBuscador.Size = new Size(30, 23);
            btnLimpiarBuscador.TabIndex = 59;
            btnLimpiarBuscador.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarBuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(1009, 36);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(120, 23);
            txtBusqueda.TabIndex = 58;
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(883, 35);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(120, 23);
            cbBusqueda.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(800, 39);
            label11.Name = "label11";
            label11.Size = new Size(77, 19);
            label11.TabIndex = 56;
            label11.Text = "Buscar por:";
            // 
            // txtId
            // 
            txtId.Location = new Point(262, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(26, 23);
            txtId.TabIndex = 55;
            txtId.Text = "0";
            // 
            // label10
            // 
            label10.BackColor = Color.LightSeaGreen;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(342, 27);
            label10.Name = "label10";
            label10.Size = new Size(353, 45);
            label10.TabIndex = 54;
            label10.Text = "Listado de usuarios";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(230, 49);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(26, 23);
            txtIndice.TabIndex = 61;
            txtIndice.Text = "-1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(38, 27);
            label9.Name = "label9";
            label9.Size = new Size(165, 30);
            label9.TabIndex = 52;
            label9.Text = "Detalle Usuario";
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 22;
            btnEliminar.Location = new Point(38, 523);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.RightToLeft = RightToLeft.No;
            btnEliminar.Size = new Size(250, 31);
            btnEliminar.TabIndex = 51;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 22;
            btnLimpiar.Location = new Point(38, 486);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RightToLeft = RightToLeft.No;
            btnLimpiar.Size = new Size(250, 31);
            btnLimpiar.TabIndex = 50;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightSeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 22;
            btnGuardar.Location = new Point(38, 449);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(250, 31);
            btnGuardar.TabIndex = 49;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(38, 392);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 48;
            label8.Text = "Estado";
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(38, 410);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(250, 23);
            cbEstado.TabIndex = 47;
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(38, 354);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(250, 23);
            cbRol.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(38, 336);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 45;
            label7.Text = "Rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(38, 283);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 44;
            label6.Text = "Confirmar contraseña";
            // 
            // txtConfirmarContrasenna
            // 
            txtConfirmarContrasenna.Location = new Point(38, 301);
            txtConfirmarContrasenna.Name = "txtConfirmarContrasenna";
            txtConfirmarContrasenna.PasswordChar = '*';
            txtConfirmarContrasenna.Size = new Size(250, 23);
            txtConfirmarContrasenna.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(38, 231);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 42;
            label5.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(38, 195);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 23);
            txtCorreo.TabIndex = 41;
            // 
            // txtContrasenna
            // 
            txtContrasenna.Location = new Point(38, 249);
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.PasswordChar = '*';
            txtContrasenna.Size = new Size(250, 23);
            txtContrasenna.TabIndex = 40;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(38, 140);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(250, 23);
            txtNombreCompleto.TabIndex = 39;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(38, 86);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(250, 23);
            txtDocumento.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(38, 177);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 37;
            label4.Text = "Correo electrónico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(38, 68);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 36;
            label3.Text = "Número de documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(38, 122);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 35;
            label2.Text = "Nombre Completo";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 579);
            label1.TabIndex = 34;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1233, 579);
            Controls.Add(btnBuscar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(txtBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(label11);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(txtIndice);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(label8);
            Controls.Add(cbEstado);
            Controls.Add(cbRol);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtConfirmarContrasenna);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(txtContrasenna);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBuscar;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Contrasenna;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private TextBox txtBusqueda;
        private ComboBox cbBusqueda;
        private Label label11;
        private TextBox txtId;
        private Label label10;
        private TextBox txtIndice;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label label8;
        private ComboBox cbEstado;
        private ComboBox cbRol;
        private Label label7;
        private Label label6;
        private TextBox txtConfirmarContrasenna;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtContrasenna;
        private TextBox txtNombreCompleto;
        private TextBox txtDocumento;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}