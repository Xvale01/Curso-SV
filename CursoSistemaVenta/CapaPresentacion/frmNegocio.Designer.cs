namespace CapaPresentacion
{
    partial class frmNegocio
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
            label9 = new Label();
            btnSubir = new FontAwesome.Sharp.IconButton();
            txtRUC = new TextBox();
            txtNombreNegocio = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtDireccion = new TextBox();
            label5 = new Label();
            label4 = new Label();
            pickLogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pickLogo).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(38, 26);
            label9.Name = "label9";
            label9.Size = new Size(174, 30);
            label9.TabIndex = 59;
            label9.Text = "Detalle Negocio";
            // 
            // btnSubir
            // 
            btnSubir.BackColor = Color.LightSeaGreen;
            btnSubir.FlatStyle = FlatStyle.Flat;
            btnSubir.ForeColor = Color.White;
            btnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnSubir.IconColor = Color.White;
            btnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubir.IconSize = 22;
            btnSubir.Location = new Point(38, 220);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(181, 31);
            btnSubir.TabIndex = 58;
            btnSubir.Text = "Subir";
            btnSubir.TextAlign = ContentAlignment.MiddleRight;
            btnSubir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSubir.UseVisualStyleBackColor = false;
            btnSubir.Click += btnSubir_Click;
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(255, 133);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(233, 23);
            txtRUC.TabIndex = 57;
            // 
            // txtNombreNegocio
            // 
            txtNombreNegocio.Location = new Point(255, 70);
            txtNombreNegocio.Name = "txtNombreNegocio";
            txtNombreNegocio.Size = new Size(233, 23);
            txtNombreNegocio.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(255, 52);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 55;
            label3.Text = "Nombre Negocio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(255, 115);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 54;
            label2.Text = "R.U.C:";
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
            label1.Size = new Size(624, 512);
            label1.TabIndex = 53;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pickLogo);
            groupBox1.Controls.Add(txtRUC);
            groupBox1.Controls.Add(btnSubir);
            groupBox1.Controls.Add(txtNombreNegocio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(38, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 292);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(464, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(24, 23);
            txtId.TabIndex = 65;
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
            btnGuardar.Location = new Point(255, 220);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(233, 31);
            btnGuardar.TabIndex = 64;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(255, 191);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(233, 23);
            txtDireccion.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(255, 173);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 62;
            label5.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 37);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 61;
            label4.Text = "Logo:";
            // 
            // pickLogo
            // 
            pickLogo.BorderStyle = BorderStyle.FixedSingle;
            pickLogo.Location = new Point(38, 55);
            pickLogo.Name = "pickLogo";
            pickLogo.Size = new Size(181, 159);
            pickLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pickLogo.TabIndex = 0;
            pickLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1062, 512);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pickLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private FontAwesome.Sharp.IconButton btnSubir;
        private TextBox txtRUC;
        private TextBox txtNombreNegocio;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pickLogo;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox textBox1;
        private TextBox txtId;
    }
}