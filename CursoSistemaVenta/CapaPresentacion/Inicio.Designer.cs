namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            subMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            subMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            menuVentas = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            menuTitulo = new MenuStrip();
            label1 = new Label();
            contenedor = new Panel();
            lblUsuario = new Label();
            lblNombreUsuario = new Label();
            subMenuNegocio = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.Items.AddRange(new ToolStripItem[] { menuUsuarios, menuMantenedor, menuVentas, menuCompras, menuClientes, menuProveedores, menuReportes, menuAcercaDe });
            menu.Location = new Point(0, 63);
            menu.Name = "menu";
            menu.Size = new Size(1282, 73);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            menuUsuarios.AutoSize = false;
            menuUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuUsuarios.ForeColor = Color.LightSeaGreen;
            menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            menuUsuarios.IconColor = Color.LightSeaGreen;
            menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuarios.IconSize = 50;
            menuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(80, 69);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuUsuarios.Click += menuUsuarios_Click;
            // 
            // menuMantenedor
            // 
            menuMantenedor.AutoSize = false;
            menuMantenedor.DropDownItems.AddRange(new ToolStripItem[] { subMenuCategoria, subMenuProducto, subMenuNegocio });
            menuMantenedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuMantenedor.ForeColor = Color.LightSeaGreen;
            menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menuMantenedor.IconColor = Color.LightSeaGreen;
            menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMantenedor.IconSize = 50;
            menuMantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menuMantenedor.Name = "menuMantenedor";
            menuMantenedor.Size = new Size(80, 69);
            menuMantenedor.Text = "Mantenedor";
            menuMantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuCategoria
            // 
            subMenuCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            subMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuCategoria.IconColor = Color.Black;
            subMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCategoria.Name = "subMenuCategoria";
            subMenuCategoria.Size = new Size(180, 22);
            subMenuCategoria.Text = "Categoría";
            subMenuCategoria.Click += subMenuCategoria_Click;
            // 
            // subMenuProducto
            // 
            subMenuProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            subMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuProducto.IconColor = Color.Black;
            subMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuProducto.Name = "subMenuProducto";
            subMenuProducto.Size = new Size(180, 22);
            subMenuProducto.Text = "Producto";
            subMenuProducto.Click += subMenuProducto_Click;
            // 
            // menuVentas
            // 
            menuVentas.AutoSize = false;
            menuVentas.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarVenta, subMenuVerDetalleVenta });
            menuVentas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuVentas.ForeColor = Color.LightSeaGreen;
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.LightSeaGreen;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.IconSize = 50;
            menuVentas.ImageScaling = ToolStripItemImageScaling.None;
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(80, 69);
            menuVentas.Text = "Ventas";
            menuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            subMenuRegistrarVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarVenta.IconColor = Color.Black;
            subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            subMenuRegistrarVenta.Size = new Size(180, 22);
            subMenuRegistrarVenta.Text = "Registrar venta";
            subMenuRegistrarVenta.Click += subMenuRegistrarVenta_Click;
            // 
            // subMenuVerDetalleVenta
            // 
            subMenuVerDetalleVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            subMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleVenta.IconColor = Color.Black;
            subMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            subMenuVerDetalleVenta.Size = new Size(180, 22);
            subMenuVerDetalleVenta.Text = "Ver detalle";
            subMenuVerDetalleVenta.Click += subMenuVerDetalleVenta_Click;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarCompra, subMenuVerDetalleCompra });
            menuCompras.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuCompras.ForeColor = Color.LightSeaGreen;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menuCompras.IconColor = Color.LightSeaGreen;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 50;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(80, 69);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            subMenuRegistrarCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarCompra.IconColor = Color.Black;
            subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            subMenuRegistrarCompra.Size = new Size(180, 22);
            subMenuRegistrarCompra.Text = "Registrar Compra";
            subMenuRegistrarCompra.Click += subMenuRegistrarCompra_Click;
            // 
            // subMenuVerDetalleCompra
            // 
            subMenuVerDetalleCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            subMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleCompra.IconColor = Color.Black;
            subMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            subMenuVerDetalleCompra.Size = new Size(180, 22);
            subMenuVerDetalleCompra.Text = "Ver detalle";
            subMenuVerDetalleCompra.Click += subMenuVerDetalleCompra_Click;
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuClientes.ForeColor = Color.LightSeaGreen;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            menuClientes.IconColor = Color.LightSeaGreen;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 50;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(80, 69);
            menuClientes.Text = "Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.AutoSize = false;
            menuProveedores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuProveedores.ForeColor = Color.LightSeaGreen;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            menuProveedores.IconColor = Color.LightSeaGreen;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 50;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(80, 69);
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuProveedores.Click += menuProveedores_Click;
            // 
            // menuReportes
            // 
            menuReportes.AutoSize = false;
            menuReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuReportes.ForeColor = Color.LightSeaGreen;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            menuReportes.IconColor = Color.LightSeaGreen;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 50;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(80, 69);
            menuReportes.Text = "Reportes";
            menuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuReportes.Click += menuReportes_Click;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.AutoSize = false;
            menuAcercaDe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuAcercaDe.ForeColor = Color.LightSeaGreen;
            menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuAcercaDe.IconColor = Color.LightSeaGreen;
            menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcercaDe.IconSize = 50;
            menuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Size = new Size(80, 69);
            menuAcercaDe.Text = "Acerca de";
            menuAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            menuAcercaDe.Click += menuAcercade_Click;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.LightSeaGreen;
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.Size = new Size(1282, 63);
            menuTitulo.TabIndex = 1;
            menuTitulo.Text = "menuTitulo";
            menuTitulo.ItemClicked += menuTitulo_ItemClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(225, 37);
            label1.TabIndex = 2;
            label1.Text = "Sistema de venta";
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 136);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1282, 593);
            contenedor.TabIndex = 3;
            contenedor.Paint += contenedor_Paint;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.LightSeaGreen;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(756, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += label2_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.LightSeaGreen;
            lblNombreUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(811, 25);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(53, 19);
            lblNombreUsuario.TabIndex = 5;
            lblNombreUsuario.Text = "Juanito";
            lblNombreUsuario.Click += lblNombreUsuario_Click;
            // 
            // subMenuNegocio
            // 
            subMenuNegocio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            subMenuNegocio.Name = "subMenuNegocio";
            subMenuNegocio.Size = new Size(180, 22);
            subMenuNegocio.Text = "Negocio";
            subMenuNegocio.Click += subMenuNegocio_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 729);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(contenedor);
            Controls.Add(label1);
            Controls.Add(menu);
            Controls.Add(menuTitulo);
            MainMenuStrip = menu;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menuTitulo;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private Panel contenedor;
        private Label lblUsuario;
        private Label lblNombreUsuario;
        private FontAwesome.Sharp.IconMenuItem subMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem subMenuProducto;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleCompra;
        private ToolStripMenuItem subMenuNegocio;
    }
}
