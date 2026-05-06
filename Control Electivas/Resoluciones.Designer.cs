namespace Control_Electivas
{
    partial class Resoluciones
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvResoluciones;
        private System.Windows.Forms.Panel panelDerecho;

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblLink;

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtLink;

        private System.Windows.Forms.Button btnCargarPDF;
        private System.Windows.Forms.Button btnVerPDF;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resoluciones));
            this.dgvResoluciones = new System.Windows.Forms.DataGridView();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnCargarPDF = new System.Windows.Forms.Button();
            this.btnVerPDF = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoluciones)).BeginInit();
            this.panelDerecho.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResoluciones
            // 
            this.dgvResoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResoluciones.ColumnHeadersHeight = 29;
            this.dgvResoluciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvResoluciones.Location = new System.Drawing.Point(0, 28);
            this.dgvResoluciones.MultiSelect = false;
            this.dgvResoluciones.Name = "dgvResoluciones";
            this.dgvResoluciones.ReadOnly = true;
            this.dgvResoluciones.RowHeadersWidth = 51;
            this.dgvResoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResoluciones.Size = new System.Drawing.Size(582, 439);
            this.dgvResoluciones.TabIndex = 1;
            this.dgvResoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResoluciones_CellClick);
            // 
            // panelDerecho
            // 
            this.panelDerecho.Controls.Add(this.lblNumero);
            this.panelDerecho.Controls.Add(this.txtNumero);
            this.panelDerecho.Controls.Add(this.lblAnio);
            this.panelDerecho.Controls.Add(this.txtAnio);
            this.panelDerecho.Controls.Add(this.lblLink);
            this.panelDerecho.Controls.Add(this.txtLink);
            this.panelDerecho.Controls.Add(this.btnCargarPDF);
            this.panelDerecho.Controls.Add(this.btnVerPDF);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(582, 28);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Padding = new System.Windows.Forms.Padding(20);
            this.panelDerecho.Size = new System.Drawing.Size(318, 439);
            this.panelDerecho.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(10, 53);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(100, 23);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(10, 73);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(200, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // lblAnio
            // 
            this.lblAnio.Location = new System.Drawing.Point(10, 103);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(100, 23);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(10, 123);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.ReadOnly = true;
            this.txtAnio.Size = new System.Drawing.Size(200, 22);
            this.txtAnio.TabIndex = 3;
            // 
            // lblLink
            // 
            this.lblLink.Location = new System.Drawing.Point(10, 172);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(100, 23);
            this.lblLink.TabIndex = 6;
            this.lblLink.Text = "Link PDF:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(10, 192);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(300, 22);
            this.txtLink.TabIndex = 7;
            // 
            // btnCargarPDF
            // 
            this.btnCargarPDF.Location = new System.Drawing.Point(10, 242);
            this.btnCargarPDF.Name = "btnCargarPDF";
            this.btnCargarPDF.Size = new System.Drawing.Size(120, 23);
            this.btnCargarPDF.TabIndex = 8;
            this.btnCargarPDF.Text = "Cargar PDF";
            this.btnCargarPDF.Click += new System.EventHandler(this.btnCargarPDF_Click);
            // 
            // btnVerPDF
            // 
            this.btnVerPDF.Location = new System.Drawing.Point(140, 242);
            this.btnVerPDF.Name = "btnVerPDF";
            this.btnVerPDF.Size = new System.Drawing.Size(120, 23);
            this.btnVerPDF.TabIndex = 9;
            this.btnVerPDF.Text = "Ver PDF";
            this.btnVerPDF.Click += new System.EventHandler(this.btnVerPDF_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtroToolStripMenuItem
            // 
            this.filtroToolStripMenuItem.Name = "filtroToolStripMenuItem";
            this.filtroToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.filtroToolStripMenuItem.Text = "Filtro";
            this.filtroToolStripMenuItem.Click += new System.EventHandler(this.filtroToolStripMenuItem_Click);
            // 
            // Resoluciones
            // 
            this.ClientSize = new System.Drawing.Size(900, 467);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.dgvResoluciones);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Resoluciones";
            this.Text = "Gestión de Resoluciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResolucionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoluciones)).EndInit();
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtroToolStripMenuItem;
    }
}