namespace WASSv1._0
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wASSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTrámitesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trámitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTrámitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTramiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teclasDeAccesoRápidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListaTramites = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCerrarWASS = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTeclas = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbTeclas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wASSToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.trámitesToolStripMenuItem,
            this.cálculosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wASSToolStripMenuItem
            // 
            this.wASSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.wASSToolStripMenuItem.Name = "wASSToolStripMenuItem";
            this.wASSToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.wASSToolStripMenuItem.Text = "WASS";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeTrámitesToolStripMenuItem1,
            this.nuevoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listaDeTrámitesToolStripMenuItem1
            // 
            this.listaDeTrámitesToolStripMenuItem1.Name = "listaDeTrámitesToolStripMenuItem1";
            this.listaDeTrámitesToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.listaDeTrámitesToolStripMenuItem1.Text = "Lista de Clientes";
            this.listaDeTrámitesToolStripMenuItem1.Click += new System.EventHandler(this.listaDeTrámitesToolStripMenuItem1_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // trámitesToolStripMenuItem
            // 
            this.trámitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeTrámitesToolStripMenuItem,
            this.nuevoTramiteToolStripMenuItem1});
            this.trámitesToolStripMenuItem.Name = "trámitesToolStripMenuItem";
            this.trámitesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.trámitesToolStripMenuItem.Text = "Trámites";
            // 
            // listaDeTrámitesToolStripMenuItem
            // 
            this.listaDeTrámitesToolStripMenuItem.Name = "listaDeTrámitesToolStripMenuItem";
            this.listaDeTrámitesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listaDeTrámitesToolStripMenuItem.Text = "Lista de Trámites";
            this.listaDeTrámitesToolStripMenuItem.Click += new System.EventHandler(this.listaDeTrámitesToolStripMenuItem_Click);
            // 
            // nuevoTramiteToolStripMenuItem1
            // 
            this.nuevoTramiteToolStripMenuItem1.Name = "nuevoTramiteToolStripMenuItem1";
            this.nuevoTramiteToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.nuevoTramiteToolStripMenuItem1.Text = "Nuevo";
            this.nuevoTramiteToolStripMenuItem1.Click += new System.EventHandler(this.nuevoTramiteToolStripMenuItem1_Click);
            // 
            // cálculosToolStripMenuItem
            // 
            this.cálculosToolStripMenuItem.Name = "cálculosToolStripMenuItem";
            this.cálculosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cálculosToolStripMenuItem.Text = "Cálculos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teclasDeAccesoRápidoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // teclasDeAccesoRápidoToolStripMenuItem
            // 
            this.teclasDeAccesoRápidoToolStripMenuItem.Name = "teclasDeAccesoRápidoToolStripMenuItem";
            this.teclasDeAccesoRápidoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.teclasDeAccesoRápidoToolStripMenuItem.Text = "Teclas de Acceso rápido";
            this.teclasDeAccesoRápidoToolStripMenuItem.Click += new System.EventHandler(this.teclasDeAccesoRápidoToolStripMenuItem_Click);
            // 
            // btnListaTramites
            // 
            this.btnListaTramites.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnListaTramites.Image = global::WASSv1._0.Properties.Resources.open_32;
            this.btnListaTramites.Location = new System.Drawing.Point(12, 37);
            this.btnListaTramites.Name = "btnListaTramites";
            this.btnListaTramites.Size = new System.Drawing.Size(142, 42);
            this.btnListaTramites.TabIndex = 6;
            this.btnListaTramites.Text = "Listado de Trámites";
            this.btnListaTramites.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnListaTramites.UseVisualStyleBackColor = false;
            this.btnListaTramites.Click += new System.EventHandler(this.btnListaTramites_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClientes.Image = global::WASSv1._0.Properties.Resources.User_32x32;
            this.btnClientes.Location = new System.Drawing.Point(12, 85);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(142, 42);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Listado de Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCerrarWASS
            // 
            this.btnCerrarWASS.Image = global::WASSv1._0.Properties.Resources.Log_Out_48x48;
            this.btnCerrarWASS.Location = new System.Drawing.Point(802, 434);
            this.btnCerrarWASS.Name = "btnCerrarWASS";
            this.btnCerrarWASS.Size = new System.Drawing.Size(87, 70);
            this.btnCerrarWASS.TabIndex = 7;
            this.btnCerrarWASS.UseVisualStyleBackColor = true;
            this.btnCerrarWASS.Click += new System.EventHandler(this.btnCerrarWASS_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "ESCAPE - Salir / Cerrar ventana\r\nTab - Campo Siguiente\r\n";
            // 
            // gbTeclas
            // 
            this.gbTeclas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbTeclas.BackColor = System.Drawing.SystemColors.Desktop;
            this.gbTeclas.Controls.Add(this.label4);
            this.gbTeclas.Controls.Add(this.label3);
            this.gbTeclas.Controls.Add(this.label2);
            this.gbTeclas.Controls.Add(this.label1);
            this.gbTeclas.Location = new System.Drawing.Point(12, 413);
            this.gbTeclas.Name = "gbTeclas";
            this.gbTeclas.Size = new System.Drawing.Size(784, 91);
            this.gbTeclas.TabIndex = 9;
            this.gbTeclas.TabStop = false;
            this.gbTeclas.Text = "Teclas de Acceso rápido";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 49);
            this.label4.TabIndex = 11;
            this.label4.Text = "F12   -  Cálculos\r\n\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 49);
            this.label3.TabIndex = 10;
            this.label3.Text = "F8   -  Lista de Trámites\r\nF9   -  Iniciar nuevo Trámite\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "F4   -  Lista de Clientes\r\nF5   -  Registrar nuevo Cliente";
            // 
            // btnCalculos
            // 
            this.btnCalculos.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCalculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalculos.Image = global::WASSv1._0.Properties.Resources.calculator32;
            this.btnCalculos.Location = new System.Drawing.Point(12, 133);
            this.btnCalculos.Name = "btnCalculos";
            this.btnCalculos.Size = new System.Drawing.Size(142, 42);
            this.btnCalculos.TabIndex = 10;
            this.btnCalculos.Text = "Cálculos";
            this.btnCalculos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalculos.UseVisualStyleBackColor = false;
            this.btnCalculos.Click += new System.EventHandler(this.btnCalculos_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WASSv1._0.Properties.Resources.wallpaperMain_fw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(920, 516);
            this.Controls.Add(this.btnCalculos);
            this.Controls.Add(this.gbTeclas);
            this.Controls.Add(this.btnCerrarWASS);
            this.Controls.Add(this.btnListaTramites);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "WASS - Trámites Previsionales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTeclas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wASSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trámitesToolStripMenuItem;
        private System.Windows.Forms.Button btnListaTramites;
        private System.Windows.Forms.Button btnCerrarWASS;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem listaDeTrámitesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeTrámitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teclasDeAccesoRápidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTramiteToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTeclas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cálculosToolStripMenuItem;
        private System.Windows.Forms.Button btnCalculos;
        private System.Windows.Forms.Label label4;
    }
}

