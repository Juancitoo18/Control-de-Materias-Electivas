using ENTIDADES;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Electivas
{
    public partial class Filtro : Form
    {
        private MateriaElectiva Mate;
        private NegocioMaterias NegMate;
        private NegocioCarrera NegCarre;
        private FiltroMaterias filtro;

        public Filtro()
        {
            InitializeComponent();
            Mate = new MateriaElectiva();
            NegMate = new NegocioMaterias();
            NegCarre = new NegocioCarrera();
            filtro = new FiltroMaterias();
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

        private void Filtro_Load(object sender, EventArgs e)
        {
            DataTable dt = NegCarre.ListarCarreras();

            DataRow fila = dt.NewRow();
            fila["Id"] = 0;
            fila["Nombre"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            cmbCarrera.DataSource = dt;
            cmbCarrera.DisplayMember = "Nombre";
            cmbCarrera.ValueMember = "Id";
            cmbCarrera.SelectedIndex = 0;

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                filtro.Nombre = txtNombre.Text;

            if (cmbCarrera.SelectedIndex > 0)
                filtro.CarreraId = Convert.ToInt32(cmbCarrera.SelectedValue);

            if (!string.IsNullOrWhiteSpace(txtResolucion.Text))
                filtro.NumeroResolucion = txtResolucion.Text;

            if (int.TryParse(txtCodigoMateria.Text, out int Codigo))
                filtro.CodigoMateria = Codigo;

            if (int.TryParse(txtDesde.Text, out int desde))
                filtro.Desde = desde;

            if (int.TryParse(txtHasta.Text, out int hasta))
                filtro.Hasta = hasta;

            this.Tag = filtro;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
