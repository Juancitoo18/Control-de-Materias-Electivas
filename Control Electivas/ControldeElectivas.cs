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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Control_Electivas
{
    public partial class ControldeElectivas : Form
    {
        private MateriaElectiva Mate;
        private NegocioMaterias NegMate;
        private Usuario usuarioLogueado;

        public ControldeElectivas(Usuario usuario)
        {
            InitializeComponent();
            Mate = new MateriaElectiva();
            NegMate = new NegocioMaterias();
            usuarioLogueado = usuario;

            this.KeyPreview = true;
        }

        private void ControldeElectivas_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarMaterias();
            CentrarTitulo("Materias Electivas");
            this.Text = $"Control de Electivas - {usuarioLogueado.NombreUsuario.ToUpper()}";
        }

        private void ControldeElectivas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        // =====================================================
        #region CONFIGURACIÓN GENERAL

        private void ConfigurarGrilla()
        {
            dgvMaterias.Dock = DockStyle.Fill;
            dgvMaterias.ReadOnly = true; 
            dgvMaterias.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.MultiSelect = false;
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.AllowUserToResizeRows = false;
        }

        private void TamañoColumnas(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.Columns["Id"].Visible = false;
            dgv.Columns["CarreraId"].Visible = false;
            dgv.Columns["FechaVencimiento"].Visible = false;
            dgv.Columns["Estado"].Visible = false;

            dgv.Columns["Carrera"].FillWeight = 25;
            dgv.Columns["Materias Electivas"].FillWeight = 40;
            dgv.Columns["Resolución de Habilitación"].FillWeight = 15;
            dgv.Columns["Fecha de Resolucion Habilitación"].FillWeight = 10;
            dgv.Columns["Desde"].FillWeight = 5;
            dgv.Columns["Hasta"].FillWeight = 5;
        }

        private void CentrarTitulo(string texto)
        {
            lbTitulo.Text = texto;
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
        }

        private void CargarGrilla(DataTable dt)
        {
            dgvMaterias.DataSource = dt;
            TamañoColumnas(dgvMaterias);
        }

        #endregion
        // =====================================================

        // =====================================================
        #region Cargas

        private void CargarMaterias()
        {
            CargarGrilla(NegMate.ListarMaterias());
            EstadoNormal();
            CentrarTitulo("Materias Electivas");
        }

        public void CargarMateriasVencidas()
        {
            CargarGrilla(NegMate.ListarMateriasVencidas());
            EstadoVencidas();
            CentrarTitulo("Materias Electivas Vencidas");
        }

        public void CargarMateriasFiltradas(FiltroMaterias filtro)
        {
            CargarGrilla(NegMate.FiltrarMaterias(filtro));
            EstadoConsulta();
            CentrarTitulo("Materias");
        }

        private void CargarPorCarrera(int idCarrera, string nombre)
        {
            CargarGrilla(NegMate.ListarMateriasPorCarrera(idCarrera));
            EstadoConsulta();
            CentrarTitulo($"Materias Por Especialidad - {nombre}");
        }

        #endregion
        // =====================================================

        // =====================================================
        #region ESTADOS DE PANTALLA

        private void EstadoNormal()
        {
            TspVolver.Visible = false;
            tsmAgregar.Visible = true;
            tsmEditar.Visible = true;
            tsmDardeBaja.Visible = true;
            tsmEditar.Enabled = true;
            tsmDardeBaja.Enabled = true;
            tsmDardeBaja2.Visible = false;
            tsmActualizarFecha.Visible = false;
        }

        private void EstadoConsulta()
        {
            TspVolver.Visible = true;
            tsmAgregar.Visible = false;
            tsmEditar.Visible = true;
            tsmDardeBaja.Visible = true;
            tsmEditar.Enabled = true;
            tsmDardeBaja.Enabled = true;
            tsmDardeBaja2.Visible = false;
            tsmActualizarFecha.Visible = false;
        }

        private void EstadoVencidas()
        {
            TspVolver.Visible = true;
            tsmAgregar.Visible = false;
            tsmEditar.Visible = false;
            tsmDardeBaja.Visible = false;
            tsmDardeBaja2.Visible = true;
            tsmActualizarFecha.Visible = true;

        }

        #endregion
        // =====================================================

        // =====================================================
        #region BOTONES / MENÚ

        private void TspVolver_Click(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void tsmCambiarContraseña_Click(object sender, EventArgs e)
        {
            new CambiarContraseña(usuarioLogueado).ShowDialog();
        }

        private void tsmAgregar_Click(object sender, EventArgs e)
        {
            OpenAgregar();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una materia.");
                return;
            }

            DataRowView row = (DataRowView)dgvMaterias.CurrentRow.DataBoundItem;

            MateriaElectiva materia = new MateriaElectiva
            {
                Id = Convert.ToInt32(row["Id"]),
                Nombre = row["Materias Electivas"].ToString(),
                NumeroResolucion = row["Resolución de Habilitación"].ToString(),
                FechaAprobacion = Convert.ToDateTime(row["Fecha de Resolucion Habilitación"]),
                FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]),
                Desde = row["Desde"].ToString(),
                Hasta = row["Hasta"].ToString(),
                Estado = Convert.ToBoolean(row["Estado"]),
                IdCarrera = new Carrera
                {
                    Id = Convert.ToInt32(row["CarreraId"]),
                    Nombre = row["Carrera"].ToString()
                }
            };

            if (new Editar(materia).ShowDialog() == DialogResult.OK)
                CargarMaterias();
        }

        private void tsmDardeBaja_Click(object sender, EventArgs e)
        {
            DarBaja(true);
        }

        private void tsmDardeBaja2_Click(object sender, EventArgs e)
        {
            DarBaja(false);
        }

        private void tsmMateriasPorVencer_Click(object sender, EventArgs e)
        {
            CargarGrilla(NegMate.ListarMateriasPorVencer(6, 2));
            EstadoConsulta();
            CentrarTitulo("Materias Electivas Por Vencer");
        }

        private void tsmMateriasVencidas_Click(object sender, EventArgs e)
        {
            CargarMateriasVencidas();
        }

        private void tsmActualizarFecha_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow == null) return;

            DataRowView row = (DataRowView)dgvMaterias.CurrentRow.DataBoundItem;

            MateriaElectiva materia = new MateriaElectiva
            {
                Id = Convert.ToInt32(row["Id"]),
                Nombre = row["Materias Electivas"].ToString()
            };

            Actualizar_Fecha act = new Actualizar_Fecha(materia);
            act.FechasActualizadas += CargarMateriasVencidas;
            act.ShowDialog();
        }

        private void TsmFlitroGeneral_Click(object sender, EventArgs e)
        {
            Filtro f = new Filtro();
            if (f.ShowDialog() == DialogResult.OK)
                CargarMateriasFiltradas((FiltroMaterias)f.Tag);
        }

        private void tsmCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
        private void renovarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow == null) return;

            int idMateria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["Id"].Value);
            MateriaElectiva mat = NegMate.ObtenerPorId(idMateria);

            RenovarMateriaForm frm = new RenovarMateriaForm(mat);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarMaterias(); // refrescás el grid
            }

        }
        private void TsmVerAvisos_Click(object sender, EventArgs e)
        {
            new AvisosForm().ShowDialog();
        }

        #endregion
        // =====================================================

        // =====================================================
        #region CARRERAS

        private void TspIngCivil_Click(object sender, EventArgs e)
            => CargarPorCarrera(1, "Ingeniería Civil");

        private void TspIngElectrica_Click(object sender, EventArgs e)
            => CargarPorCarrera(2, "Ingeniería en Energía Eléctrica");

        private void TspIngAutomotriz_Click(object sender, EventArgs e)
            => CargarPorCarrera(3, "Ingeniería Automotriz");

        private void TspIngMecanica_Click(object sender, EventArgs e)
            => CargarPorCarrera(4, "Ingeniería Mecánica");

        private void TspIngLOI_Click(object sender, EventArgs e)
            => CargarPorCarrera(5, "Licenciatura en Organización Industrial");

        #endregion
        // =====================================================

        // =====================================================
        #region FUNCIONES AUXILIARES

        private void DarBaja(bool esElectiva)
        {
            if (dgvMaterias.CurrentRow == null) return;

            int id = Convert.ToInt32(((DataRowView)dgvMaterias.CurrentRow.DataBoundItem)["Id"]);

            if (MessageBox.Show("¿Dar de baja la materia?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (NegMate.DarDeBaja(id))
                {
                    MessageBox.Show("Materia dada de baja.");
                    if (esElectiva) CargarMaterias();
                    else CargarMateriasVencidas();
                }
            }
        }

        private void OpenAgregar()
        {
            if (new AgregarMateriaForm().ShowDialog() == DialogResult.OK)
                CargarMaterias();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                tsMenu.ShowDropDown();
                tsmFiltro.ShowDropDown();
                porCarreraToolStripMenuItem.ShowDropDown();
            }
        }

       

        #endregion
        // =====================================================
    }
}
