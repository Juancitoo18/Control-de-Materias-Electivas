namespace Control_Electivas
{
    partial class RenovarMateriaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMateriaTitulo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCarreraTitulo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNumeroResolucion;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.Label lblAprobacion;
        private System.Windows.Forms.Label lblVencimiento;

        private System.Windows.Forms.DateTimePicker dtpAprobacion;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;

        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenovarMateriaForm));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMateriaTitulo = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCarreraTitulo = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNumeroResolucion = new System.Windows.Forms.Label();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.lblAprobacion = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.dtpAprobacion = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(27, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Renovar Materia";
            // 
            // lblMateriaTitulo
            // 
            this.lblMateriaTitulo.AutoSize = true;
            this.lblMateriaTitulo.Location = new System.Drawing.Point(40, 98);
            this.lblMateriaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriaTitulo.Name = "lblMateriaTitulo";
            this.lblMateriaTitulo.Size = new System.Drawing.Size(55, 16);
            this.lblMateriaTitulo.TabIndex = 1;
            this.lblMateriaTitulo.Text = "Materia:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMateria.Location = new System.Drawing.Point(160, 98);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(15, 20);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "-";
            // 
            // lblCarreraTitulo
            // 
            this.lblCarreraTitulo.AutoSize = true;
            this.lblCarreraTitulo.Location = new System.Drawing.Point(40, 135);
            this.lblCarreraTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarreraTitulo.Name = "lblCarreraTitulo";
            this.lblCarreraTitulo.Size = new System.Drawing.Size(55, 16);
            this.lblCarreraTitulo.TabIndex = 3;
            this.lblCarreraTitulo.Text = "Carrera:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCarrera.Location = new System.Drawing.Point(160, 135);
            this.lblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(15, 20);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "-";
            // 
            // lblNumeroResolucion
            // 
            this.lblNumeroResolucion.AutoSize = true;
            this.lblNumeroResolucion.Location = new System.Drawing.Point(40, 171);
            this.lblNumeroResolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroResolucion.Name = "lblNumeroResolucion";
            this.lblNumeroResolucion.Size = new System.Drawing.Size(148, 16);
            this.lblNumeroResolucion.TabIndex = 11;
            this.lblNumeroResolucion.Text = "Numero de Resolución:";
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(213, 170);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(200, 22);
            this.txtResolucion.TabIndex = 12;
            // 
            // lblAprobacion
            // 
            this.lblAprobacion.AutoSize = true;
            this.lblAprobacion.Location = new System.Drawing.Point(40, 221);
            this.lblAprobacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAprobacion.Name = "lblAprobacion";
            this.lblAprobacion.Size = new System.Drawing.Size(120, 16);
            this.lblAprobacion.TabIndex = 5;
            this.lblAprobacion.Text = "Fecha aprobación:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(40, 270);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(123, 16);
            this.lblVencimiento.TabIndex = 7;
            this.lblVencimiento.Text = "Fecha vencimiento:";
            // 
            // dtpAprobacion
            // 
            this.dtpAprobacion.Location = new System.Drawing.Point(213, 215);
            this.dtpAprobacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpAprobacion.Name = "dtpAprobacion";
            this.dtpAprobacion.Size = new System.Drawing.Size(265, 22);
            this.dtpAprobacion.TabIndex = 6;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(213, 264);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(265, 22);
            this.dtpVencimiento.TabIndex = 8;
            // 
            // btnRenovar
            // 
            this.btnRenovar.Location = new System.Drawing.Point(213, 320);
            this.btnRenovar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(160, 43);
            this.btnRenovar.TabIndex = 9;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 320);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 43);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RenovarMateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 418);
            this.Controls.Add(this.txtResolucion);
            this.Controls.Add(this.lblNumeroResolucion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMateriaTitulo);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblCarreraTitulo);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblAprobacion);
            this.Controls.Add(this.dtpAprobacion);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "RenovarMateriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renovar materia";
            this.Load += new System.EventHandler(this.RenovarMateriaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
    }
}
