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
    public partial class RenovarMateriaForm : Form
    {
        private MateriaElectiva materia;
        private NegocioMaterias negMaterias;

        public RenovarMateriaForm(MateriaElectiva mat)
        {
            InitializeComponent();
            materia = mat;
            negMaterias = new NegocioMaterias();
        }

        private void RenovarMateriaForm_Load(object sender, EventArgs e)
        {
            lblMateria.Text = materia.Nombre;
            lblCarrera.Text = negMaterias.ObtenerNombreCarrera(materia.IdCarrera.Id);
            txtResolucion.Text = materia.NumeroResolucion;
            dtpAprobacion.Value = materia.FechaAprobacion;
            dtpVencimiento.Value = materia.FechaVencimiento;
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            if (dtpVencimiento.Value <= DateTime.Today)
            {
                MessageBox.Show("La fecha de vencimiento debe ser futura.");
                return;
            }

            materia.FechaAprobacion = dtpAprobacion.Value;
            materia.FechaVencimiento = dtpVencimiento.Value;
            materia.NumeroResolucion = txtResolucion.Text;
            materia.Desde = materia.FechaAprobacion.Year.ToString();
            materia.Hasta = materia.FechaVencimiento.Year.ToString();

            bool ok = negMaterias.RenovarMateria(materia);

            if (ok)
            {
                MessageBox.Show("✅ Materia renovada y avisos regenerados correctamente");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("❌ Error al renovar la materia");
                DialogResult = DialogResult.None;
            }

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
