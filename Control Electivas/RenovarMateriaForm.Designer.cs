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
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Renovar Materia";
            // 
            // lblMateriaTitulo
            // 
            this.lblMateriaTitulo.AutoSize = true;
            this.lblMateriaTitulo.Location = new System.Drawing.Point(30, 80);
            this.lblMateriaTitulo.Name = "lblMateriaTitulo";
            this.lblMateriaTitulo.Size = new System.Drawing.Size(45, 13);
            this.lblMateriaTitulo.TabIndex = 1;
            this.lblMateriaTitulo.Text = "Materia:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMateria.Location = new System.Drawing.Point(120, 80);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(12, 15);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "-";
            // 
            // lblCarreraTitulo
            // 
            this.lblCarreraTitulo.AutoSize = true;
            this.lblCarreraTitulo.Location = new System.Drawing.Point(30, 110);
            this.lblCarreraTitulo.Name = "lblCarreraTitulo";
            this.lblCarreraTitulo.Size = new System.Drawing.Size(44, 13);
            this.lblCarreraTitulo.TabIndex = 3;
            this.lblCarreraTitulo.Text = "Carrera:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCarrera.Location = new System.Drawing.Point(120, 110);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(12, 15);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "-";
            // 
            // lblAprobacion
            // 
            this.lblAprobacion.AutoSize = true;
            this.lblAprobacion.Location = new System.Drawing.Point(30, 160);
            this.lblAprobacion.Name = "lblAprobacion";
            this.lblAprobacion.Size = new System.Drawing.Size(96, 13);
            this.lblAprobacion.TabIndex = 5;
            this.lblAprobacion.Text = "Fecha aprobación:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(30, 200);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(100, 13);
            this.lblVencimiento.TabIndex = 7;
            this.lblVencimiento.Text = "Fecha vencimiento:";
            // 
            // dtpAprobacion
            // 
            this.dtpAprobacion.Location = new System.Drawing.Point(160, 155);
            this.dtpAprobacion.Name = "dtpAprobacion";
            this.dtpAprobacion.Size = new System.Drawing.Size(200, 20);
            this.dtpAprobacion.TabIndex = 6;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(160, 195);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimiento.TabIndex = 8;
            // 
            // btnRenovar
            // 
            this.btnRenovar.Location = new System.Drawing.Point(160, 260);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(120, 35);
            this.btnRenovar.TabIndex = 9;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RenovarMateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 340);
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
