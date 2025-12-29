
namespace Control_Electivas
{
    partial class ControldeElectivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControldeElectivas));
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistroMateriasElectivas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDardeBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActualizarFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDardeBaja2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRenovar = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMateriasPorVencer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMateriasVencidas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFiltro = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmFlitroGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.porCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TspIngCivil = new System.Windows.Forms.ToolStripMenuItem();
            this.TspIngMecanica = new System.Windows.Forms.ToolStripMenuItem();
            this.TspIngElectrica = new System.Windows.Forms.ToolStripMenuItem();
            this.TspIngAutomotriz = new System.Windows.Forms.ToolStripMenuItem();
            this.TspIngLOI = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmVerAvisos = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.TspVolver = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHistorial = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaterias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(13, 31);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(1143, 405);
            this.dgvMaterias.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(459, -2);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(225, 29);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Materias Electivas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(17, 10);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblUsuario.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu,
            this.usuarioToolStripMenuItem,
            this.TspVolver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenu
            // 
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegistroMateriasElectivas,
            this.listadosToolStripMenuItem,
            this.tsmFiltro,
            this.TsmVerAvisos});
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(60, 24);
            this.tsMenu.Text = "Menu";
            // 
            // tsmRegistroMateriasElectivas
            // 
            this.tsmRegistroMateriasElectivas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregar,
            this.tsmEditar,
            this.tsmDardeBaja,
            this.tsmActualizarFecha,
            this.tsmDardeBaja2,
            this.tsmRenovar});
            this.tsmRegistroMateriasElectivas.Name = "tsmRegistroMateriasElectivas";
            this.tsmRegistroMateriasElectivas.ShowShortcutKeys = false;
            this.tsmRegistroMateriasElectivas.Size = new System.Drawing.Size(224, 26);
            this.tsmRegistroMateriasElectivas.Text = "Registro";
            // 
            // tsmAgregar
            // 
            this.tsmAgregar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsmAgregar.Name = "tsmAgregar";
            this.tsmAgregar.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.tsmAgregar.Size = new System.Drawing.Size(209, 26);
            this.tsmAgregar.Text = "Agregar";
            this.tsmAgregar.Click += new System.EventHandler(this.tsmAgregar_Click);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmEditar.Size = new System.Drawing.Size(209, 26);
            this.tsmEditar.Text = "Editar";
            this.tsmEditar.Click += new System.EventHandler(this.tsmEditar_Click);
            // 
            // tsmDardeBaja
            // 
            this.tsmDardeBaja.Name = "tsmDardeBaja";
            this.tsmDardeBaja.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmDardeBaja.Size = new System.Drawing.Size(209, 26);
            this.tsmDardeBaja.Text = "Dar de Baja";
            this.tsmDardeBaja.Click += new System.EventHandler(this.tsmDardeBaja_Click);
            // 
            // tsmActualizarFecha
            // 
            this.tsmActualizarFecha.Name = "tsmActualizarFecha";
            this.tsmActualizarFecha.Size = new System.Drawing.Size(209, 26);
            this.tsmActualizarFecha.Text = "Actualizar Fecha";
            this.tsmActualizarFecha.Visible = false;
            this.tsmActualizarFecha.Click += new System.EventHandler(this.tsmActualizarFecha_Click);
            // 
            // tsmDardeBaja2
            // 
            this.tsmDardeBaja2.Name = "tsmDardeBaja2";
            this.tsmDardeBaja2.Size = new System.Drawing.Size(209, 26);
            this.tsmDardeBaja2.Text = "Dar de Baja";
            this.tsmDardeBaja2.Visible = false;
            this.tsmDardeBaja2.Click += new System.EventHandler(this.tsmDardeBaja2_Click);
            // 
            // tsmRenovar
            // 
            this.tsmRenovar.Name = "tsmRenovar";
            this.tsmRenovar.Size = new System.Drawing.Size(209, 26);
            this.tsmRenovar.Text = "Renovar Materia";
            this.tsmRenovar.Click += new System.EventHandler(this.renovarMateriaToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMateriasPorVencer,
            this.tsmMateriasVencidas,
            this.tsmHistorial});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // tsmMateriasPorVencer
            // 
            this.tsmMateriasPorVencer.Name = "tsmMateriasPorVencer";
            this.tsmMateriasPorVencer.Size = new System.Drawing.Size(306, 26);
            this.tsmMateriasPorVencer.Text = "Materias Por Vencer";
            this.tsmMateriasPorVencer.Click += new System.EventHandler(this.tsmMateriasPorVencer_Click);
            // 
            // tsmMateriasVencidas
            // 
            this.tsmMateriasVencidas.Name = "tsmMateriasVencidas";
            this.tsmMateriasVencidas.Size = new System.Drawing.Size(306, 26);
            this.tsmMateriasVencidas.Text = "Materias Vencidas";
            this.tsmMateriasVencidas.Click += new System.EventHandler(this.tsmMateriasVencidas_Click);
            // 
            // tsmFiltro
            // 
            this.tsmFiltro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmFlitroGeneral,
            this.porCarreraToolStripMenuItem});
            this.tsmFiltro.Name = "tsmFiltro";
            this.tsmFiltro.Size = new System.Drawing.Size(224, 26);
            this.tsmFiltro.Text = "Filtro";
            // 
            // TsmFlitroGeneral
            // 
            this.TsmFlitroGeneral.Name = "TsmFlitroGeneral";
            this.TsmFlitroGeneral.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.TsmFlitroGeneral.Size = new System.Drawing.Size(192, 26);
            this.TsmFlitroGeneral.Text = "General";
            this.TsmFlitroGeneral.Click += new System.EventHandler(this.TsmFlitroGeneral_Click);
            // 
            // porCarreraToolStripMenuItem
            // 
            this.porCarreraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TspIngCivil,
            this.TspIngMecanica,
            this.TspIngElectrica,
            this.TspIngAutomotriz,
            this.TspIngLOI});
            this.porCarreraToolStripMenuItem.Name = "porCarreraToolStripMenuItem";
            this.porCarreraToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.porCarreraToolStripMenuItem.Text = "Por Carrera";
            // 
            // TspIngCivil
            // 
            this.TspIngCivil.Name = "TspIngCivil";
            this.TspIngCivil.Size = new System.Drawing.Size(348, 26);
            this.TspIngCivil.Text = "Ingeniería Civil";
            this.TspIngCivil.Click += new System.EventHandler(this.TspIngCivil_Click);
            // 
            // TspIngMecanica
            // 
            this.TspIngMecanica.Name = "TspIngMecanica";
            this.TspIngMecanica.Size = new System.Drawing.Size(348, 26);
            this.TspIngMecanica.Text = "Ingeniería Mecánica";
            this.TspIngMecanica.Click += new System.EventHandler(this.TspIngMecanica_Click);
            // 
            // TspIngElectrica
            // 
            this.TspIngElectrica.Name = "TspIngElectrica";
            this.TspIngElectrica.Size = new System.Drawing.Size(348, 26);
            this.TspIngElectrica.Text = "Ingeniería en Energía Eléctrica";
            this.TspIngElectrica.Click += new System.EventHandler(this.TspIngElectrica_Click);
            // 
            // TspIngAutomotriz
            // 
            this.TspIngAutomotriz.Name = "TspIngAutomotriz";
            this.TspIngAutomotriz.Size = new System.Drawing.Size(348, 26);
            this.TspIngAutomotriz.Text = "Ingeniería en Industria Automotriz";
            this.TspIngAutomotriz.Click += new System.EventHandler(this.TspIngAutomotriz_Click);
            // 
            // TspIngLOI
            // 
            this.TspIngLOI.Name = "TspIngLOI";
            this.TspIngLOI.Size = new System.Drawing.Size(348, 26);
            this.TspIngLOI.Text = "Licenciatura en Organización Industrial";
            this.TspIngLOI.Click += new System.EventHandler(this.TspIngLOI_Click);
            // 
            // TsmVerAvisos
            // 
            this.TsmVerAvisos.Name = "TsmVerAvisos";
            this.TsmVerAvisos.Size = new System.Drawing.Size(224, 26);
            this.TsmVerAvisos.Text = "Ver Avisos";
            this.TsmVerAvisos.Click += new System.EventHandler(this.TsmVerAvisos_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCambiarContraseña,
            this.tsmCerrarSesion});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // tsmCambiarContraseña
            // 
            this.tsmCambiarContraseña.Name = "tsmCambiarContraseña";
            this.tsmCambiarContraseña.Size = new System.Drawing.Size(226, 26);
            this.tsmCambiarContraseña.Text = "Cambiar Contraseña";
            this.tsmCambiarContraseña.Click += new System.EventHandler(this.tsmCambiarContraseña_Click);
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(226, 26);
            this.tsmCerrarSesion.Text = "Cerrar Sesion";
            this.tsmCerrarSesion.Click += new System.EventHandler(this.tsmCerrarSesion_Click);
            // 
            // TspVolver
            // 
            this.TspVolver.Name = "TspVolver";
            this.TspVolver.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.TspVolver.Size = new System.Drawing.Size(36, 24);
            this.TspVolver.Text = "←";
            this.TspVolver.Visible = false;
            this.TspVolver.Click += new System.EventHandler(this.TspVolver_Click);
            // 
            // tsmHistorial
            // 
            this.tsmHistorial.Name = "tsmHistorial";
            this.tsmHistorial.Size = new System.Drawing.Size(306, 26);
            this.tsmHistorial.Text = "Historial de Materias Renovadas";
            this.tsmHistorial.Click += new System.EventHandler(this.tsmHistorial_Click);
            // 
            // ControldeElectivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControldeElectivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControldeElectivas_FormClosing);
            this.Load += new System.EventHandler(this.ControldeElectivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistroMateriasElectivas;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmDardeBaja;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMateriasPorVencer;
        private System.Windows.Forms.ToolStripMenuItem tsmMateriasVencidas;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizarFecha;
        private System.Windows.Forms.ToolStripMenuItem tsmDardeBaja2;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCambiarContraseña;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmFiltro;
        private System.Windows.Forms.ToolStripMenuItem TsmFlitroGeneral;
        private System.Windows.Forms.ToolStripMenuItem porCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TspIngCivil;
        private System.Windows.Forms.ToolStripMenuItem TspIngMecanica;
        private System.Windows.Forms.ToolStripMenuItem TspIngElectrica;
        private System.Windows.Forms.ToolStripMenuItem TspIngAutomotriz;
        private System.Windows.Forms.ToolStripMenuItem TspIngLOI;
        private System.Windows.Forms.ToolStripMenuItem TspVolver;
        private System.Windows.Forms.ToolStripMenuItem TsmVerAvisos;
        private System.Windows.Forms.ToolStripMenuItem tsmRenovar;
        private System.Windows.Forms.ToolStripMenuItem tsmHistorial;
    }
}