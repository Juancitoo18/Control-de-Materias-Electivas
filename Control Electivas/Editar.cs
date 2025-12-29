using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace Control_Electivas
{
    public partial class Editar : Form
    {
        private MateriaElectiva Mate;
        private NegocioMaterias neg;
        private NegocioCarrera NegCarre;
        public Editar(MateriaElectiva materia)
        {
            InitializeComponent();
            Mate = materia;
            neg = new NegocioMaterias();
            NegCarre = new NegocioCarrera();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            DataTable dt = NegCarre.ListarCarreras();
            cmbCarrera.DataSource = dt;
            cmbCarrera.DisplayMember = "Nombre";
            cmbCarrera.ValueMember = "Id";
            cmbCarrera.SelectedIndex = 0;

            txtNombre.Text = Mate.Nombre;
            cmbCarrera.SelectedValue = Mate.IdCarrera.Id;
            txtResolucion.Text = Mate.NumeroResolucion;
            txtCodigoMateria.Text = Mate.CodigoMateria.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Mate.Nombre = txtNombre.Text;
            Mate.IdCarrera.Id = (int)cmbCarrera.SelectedValue;
            Mate.NumeroResolucion = txtResolucion.Text;
            Mate.CodigoMateria = int.Parse(txtCodigoMateria.Text);

            if (neg.EditarMateria(Mate))
            {
                MessageBox.Show("Se Edito con Exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor selecciona una materia para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true; // Indica que la tecla fue manejada
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
