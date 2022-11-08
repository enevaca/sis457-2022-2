namespace CpMinerva
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnCaProducto = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCaProveedor = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCaCliente = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnCvCompra = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCvBuscarCompra = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonGroup6 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnCvVenta = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton7 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton8 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab3 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonTab4 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnAdmEmpleado = new C1.Win.C1Ribbon.RibbonButton();
            this.btnAdmUsuario = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTab5 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton11 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton12 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(878, 154);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab4);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab5);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Catálogos";
            this.ribbonTab1.ToolTip = "Catálogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaProducto);
            this.ribbonGroup1.Items.Add(this.btnCaProveedor);
            this.ribbonGroup1.Items.Add(this.btnCaCliente);
            this.ribbonGroup1.LauncherToolTip = "Gestión de Catálogos";
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Gestión de Catálogos";
            // 
            // btnCaProducto
            // 
            this.btnCaProducto.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaProducto.LargeImage")));
            this.btnCaProducto.Name = "btnCaProducto";
            this.btnCaProducto.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaProducto.SmallImage")));
            this.btnCaProducto.Text = "Productos";
            this.btnCaProducto.ToolTip = "Gestión de Productos";
            this.btnCaProducto.Click += new System.EventHandler(this.btnCaProducto_Click);
            // 
            // btnCaProveedor
            // 
            this.btnCaProveedor.LargeImage = global::CpMinerva.Properties.Resources.provider;
            this.btnCaProveedor.Name = "btnCaProveedor";
            this.btnCaProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaProveedor.SmallImage")));
            this.btnCaProveedor.Text = "Proveedores";
            this.btnCaProveedor.ToolTip = "Gestión de Proveedores";
            // 
            // btnCaCliente
            // 
            this.btnCaCliente.LargeImage = global::CpMinerva.Properties.Resources.clients;
            this.btnCaCliente.Name = "btnCaCliente";
            this.btnCaCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaCliente.SmallImage")));
            this.btnCaCliente.Text = "Clientes";
            this.btnCaCliente.ToolTip = "Gestión de Clientes";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup2);
            this.ribbonTab2.Groups.Add(this.ribbonGroup6);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Compras y Ventas";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnCvCompra);
            this.ribbonGroup2.Items.Add(this.btnCvBuscarCompra);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Compras";
            // 
            // btnCvCompra
            // 
            this.btnCvCompra.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCvCompra.LargeImage")));
            this.btnCvCompra.Name = "btnCvCompra";
            this.btnCvCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCvCompra.SmallImage")));
            this.btnCvCompra.Text = "Registro de Compras";
            this.btnCvCompra.ToolTip = "Registro de Compras";
            this.btnCvCompra.Click += new System.EventHandler(this.btnCvCompra_Click);
            // 
            // btnCvBuscarCompra
            // 
            this.btnCvBuscarCompra.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCvBuscarCompra.LargeImage")));
            this.btnCvBuscarCompra.Name = "btnCvBuscarCompra";
            this.btnCvBuscarCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCvBuscarCompra.SmallImage")));
            this.btnCvBuscarCompra.Text = "Búsqueda de Compras";
            this.btnCvBuscarCompra.ToolTip = "Búsqueda de Compras";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.btnCvVenta);
            this.ribbonGroup6.Items.Add(this.ribbonButton7);
            this.ribbonGroup6.Items.Add(this.ribbonButton8);
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Ventas";
            // 
            // btnCvVenta
            // 
            this.btnCvVenta.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCvVenta.LargeImage")));
            this.btnCvVenta.Name = "btnCvVenta";
            this.btnCvVenta.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCvVenta.SmallImage")));
            this.btnCvVenta.Text = "Registro de Ventas";
            this.btnCvVenta.ToolTip = "Registro de Ventas";
            this.btnCvVenta.Click += new System.EventHandler(this.btnCvVenta_Click);
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.LargeImage")));
            this.ribbonButton7.Name = "ribbonButton7";
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "Búsqueda de Ventas";
            this.ribbonButton7.ToolTip = "Búsqueda de Ventas";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.LargeImage")));
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "Arqueo de Caja";
            this.ribbonButton8.ToolTip = "Arqueo de Caja";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup3);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Reportes";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Group";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Groups.Add(this.ribbonGroup4);
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Administración";
            this.ribbonTab4.ToolTip = "Administración";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.btnAdmEmpleado);
            this.ribbonGroup4.Items.Add(this.btnAdmUsuario);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Administración";
            // 
            // btnAdmEmpleado
            // 
            this.btnAdmEmpleado.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdmEmpleado.LargeImage")));
            this.btnAdmEmpleado.Name = "btnAdmEmpleado";
            this.btnAdmEmpleado.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAdmEmpleado.SmallImage")));
            this.btnAdmEmpleado.Text = "Empleados";
            this.btnAdmEmpleado.ToolTip = "Gestión de Empleados";
            this.btnAdmEmpleado.Click += new System.EventHandler(this.btnAdmEmpleado_Click);
            // 
            // btnAdmUsuario
            // 
            this.btnAdmUsuario.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdmUsuario.LargeImage")));
            this.btnAdmUsuario.Name = "btnAdmUsuario";
            this.btnAdmUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAdmUsuario.SmallImage")));
            this.btnAdmUsuario.Text = "Usuarios";
            this.btnAdmUsuario.ToolTip = "Gestión de Usuarios";
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Groups.Add(this.ribbonGroup5);
            this.ribbonTab5.Name = "ribbonTab5";
            this.ribbonTab5.Text = "Ayuda";
            this.ribbonTab5.ToolTip = "Ayuda y Manual de Usuario";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.ribbonButton11);
            this.ribbonGroup5.Items.Add(this.ribbonButton12);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Minerva";
            // 
            // ribbonButton11
            // 
            this.ribbonButton11.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton11.LargeImage")));
            this.ribbonButton11.Name = "ribbonButton11";
            this.ribbonButton11.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton11.SmallImage")));
            this.ribbonButton11.Text = "Manual de Usuario";
            this.ribbonButton11.ToolTip = "Manual de Usuario";
            // 
            // ribbonButton12
            // 
            this.ribbonButton12.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton12.LargeImage")));
            this.ribbonButton12.Name = "ribbonButton12";
            this.ribbonButton12.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton12.SmallImage")));
            this.ribbonButton12.Text = "Acerca De...";
            this.ribbonButton12.ToolTip = "Acerca De...";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CpMinerva.Properties.Resources.principal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Principal - Minerva :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.C1Ribbon.RibbonButton btnCaProducto;
        private C1.Win.C1Ribbon.RibbonButton btnCaProveedor;
        private C1.Win.C1Ribbon.RibbonButton btnCaCliente;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab2;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab3;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab4;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab5;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.C1Ribbon.RibbonButton btnCvCompra;
        private C1.Win.C1Ribbon.RibbonButton btnCvBuscarCompra;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup6;
        private C1.Win.C1Ribbon.RibbonButton btnCvVenta;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton7;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton8;
        private C1.Win.C1Ribbon.RibbonButton btnAdmEmpleado;
        private C1.Win.C1Ribbon.RibbonButton btnAdmUsuario;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton11;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}