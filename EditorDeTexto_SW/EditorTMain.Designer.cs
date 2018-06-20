namespace EditorDeTexto_SW
{
    partial class EditorTMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorTMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctorOrtográficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.ToolVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_AccessDire = new System.Windows.Forms.ToolStrip();
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Abrir = new System.Windows.Forms.ToolStripButton();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.GuardarComo = new System.Windows.Forms.ToolStripButton();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.btnSpellCheck = new System.Windows.Forms.ToolStripButton();
            this.txtEditexRT_Ul = new System.Windows.Forms.RichTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.toolStrip_AccessDire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources._new;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources.open;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources.save;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources.saveas;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources.exit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.fuenteToolStripMenuItem1,
            this.colorDeLetraToolStripMenuItem,
            this.colorDeFondoToolStripMenuItem,
            this.correctorOrtográficoToolStripMenuItem});
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.fuenteToolStripMenuItem.Text = "Utilitarios";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources.find1;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem1
            // 
            this.fuenteToolStripMenuItem1.Image = global::EditorDeTexto_SW.Properties.Resources.font;
            this.fuenteToolStripMenuItem1.Name = "fuenteToolStripMenuItem1";
            this.fuenteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.fuenteToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.fuenteToolStripMenuItem1.Text = "Fuente";
            this.fuenteToolStripMenuItem1.Click += new System.EventHandler(this.fuenteToolStripMenuItem1_Click);
            // 
            // colorDeLetraToolStripMenuItem
            // 
            this.colorDeLetraToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources._goto;
            this.colorDeLetraToolStripMenuItem.Name = "colorDeLetraToolStripMenuItem";
            this.colorDeLetraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.colorDeLetraToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.colorDeLetraToolStripMenuItem.Text = "Color de Letra";
            this.colorDeLetraToolStripMenuItem.Click += new System.EventHandler(this.colorDeLetraToolStripMenuItem_Click);
            // 
            // colorDeFondoToolStripMenuItem
            // 
            this.colorDeFondoToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources.undo;
            this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.colorDeFondoToolStripMenuItem.Text = "Color de Fondo";
            this.colorDeFondoToolStripMenuItem.Visible = false;
            this.colorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.colorDeFondoToolStripMenuItem_Click);
            // 
            // correctorOrtográficoToolStripMenuItem
            // 
            this.correctorOrtográficoToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources.spellcheck;
            this.correctorOrtográficoToolStripMenuItem.Name = "correctorOrtográficoToolStripMenuItem";
            this.correctorOrtográficoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.correctorOrtográficoToolStripMenuItem.Text = "Corrector Ortográfico";
            this.correctorOrtográficoToolStripMenuItem.Click += new System.EventHandler(this.correctorOrtográficoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nosotrosToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.Image = global::EditorDeTexto_SW.Properties.Resources.find;
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            this.nosotrosToolStripMenuItem.Click += new System.EventHandler(this.nosotrosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.BarraName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel1.Text = "Ubicación del Archivo:  ";
            // 
            // BarraName
            // 
            this.BarraName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BarraName.ForeColor = System.Drawing.Color.Black;
            this.BarraName.Name = "BarraName";
            this.BarraName.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolVersion});
            this.statusStrip2.Location = new System.Drawing.Point(0, 368);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(640, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // ToolVersion
            // 
            this.ToolVersion.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolVersion.Name = "ToolVersion";
            this.ToolVersion.Size = new System.Drawing.Size(11, 17);
            this.ToolVersion.Text = ".";
            // 
            // toolStrip_AccessDire
            // 
            this.toolStrip_AccessDire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Abrir,
            this.Guardar,
            this.GuardarComo,
            this.Buscar,
            this.btnSpellCheck});
            this.toolStrip_AccessDire.Location = new System.Drawing.Point(0, 46);
            this.toolStrip_AccessDire.Name = "toolStrip_AccessDire";
            this.toolStrip_AccessDire.Size = new System.Drawing.Size(640, 25);
            this.toolStrip_AccessDire.TabIndex = 5;
            this.toolStrip_AccessDire.Text = "toolStrip1";
            // 
            // Nuevo
            // 
            this.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(23, 22);
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Abrir
            // 
            this.Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Abrir.Image")));
            this.Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(23, 22);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Guardar
            // 
            this.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(23, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // GuardarComo
            // 
            this.GuardarComo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("GuardarComo.Image")));
            this.GuardarComo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarComo.Name = "GuardarComo";
            this.GuardarComo.Size = new System.Drawing.Size(23, 22);
            this.GuardarComo.Text = "Guardar Como";
            this.GuardarComo.Click += new System.EventHandler(this.GuardarComo_Click);
            // 
            // Buscar
            // 
            this.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(23, 22);
            this.Buscar.Text = "Buscar";
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // btnSpellCheck
            // 
            this.btnSpellCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSpellCheck.Image = global::EditorDeTexto_SW.Properties.Resources.spellcheck;
            this.btnSpellCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSpellCheck.Name = "btnSpellCheck";
            this.btnSpellCheck.Size = new System.Drawing.Size(23, 22);
            this.btnSpellCheck.Text = "Corrector Ortográfico";
            this.btnSpellCheck.Click += new System.EventHandler(this.btnSpellCheck_Click);
            // 
            // txtEditexRT_Ul
            // 
            this.txtEditexRT_Ul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditexRT_Ul.Location = new System.Drawing.Point(0, 71);
            this.txtEditexRT_Ul.Name = "txtEditexRT_Ul";
            this.txtEditexRT_Ul.Size = new System.Drawing.Size(628, 294);
            this.txtEditexRT_Ul.TabIndex = 8;
            this.txtEditexRT_Ul.Text = "";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // EditorTMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(640, 390);
            this.Controls.Add(this.txtEditexRT_Ul);
            this.Controls.Add(this.toolStrip_AccessDire);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditorTMain";
            this.Text = "...::: Editor de Texto GPO  ::::...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorTMain_FormClosing);
            this.Load += new System.EventHandler(this.EditorTMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.toolStrip_AccessDire.ResumeLayout(false);
            this.toolStrip_AccessDire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorDeLetraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel BarraName;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel ToolVersion;
        private System.Windows.Forms.ToolStrip toolStrip_AccessDire;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Abrir;
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripButton GuardarComo;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox txtEditexRT_Ul;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem correctorOrtográficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnSpellCheck;
    }
}