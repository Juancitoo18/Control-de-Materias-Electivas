using NEGOCIO;
using System;
using System.Data;
using System.Windows.Forms;
using ENTIDADES;

namespace Control_Electivas
{
    public partial class AvisosForm : Form
    {
        private NegocioAvisos negAvisos = new NegocioAvisos();

        public AvisosForm()
        {
            InitializeComponent();
        }

        private void AvisosForm_Load(object sender, EventArgs e)
        {
            dgvAvisos.EnableHeadersVisualStyles = false;
            dgvAvisos.DefaultCellStyle.SelectionBackColor = dgvAvisos.DefaultCellStyle.BackColor;
            dgvAvisos.DefaultCellStyle.SelectionForeColor = dgvAvisos.DefaultCellStyle.ForeColor;
            cboEstado.Items.AddRange(new string[] { "Todos", "Pendiente", "Enviado", "Cancelado" });
            cboEstado.SelectedIndex = 0;
            CargarAvisos();
        }

        private void CargarAvisos()
        {
            dgvAvisos.DataSource = negAvisos.ListarAvisos(cboEstado.Text);
            dgvAvisos.Columns["MateriaId"].Visible = false;
            dgvAvisos.Columns["IdAviso"].Visible = false;
            PintarFilas();
        }

        private void FormatearGrid()
        {
            dgvAvisos.Columns["IdAviso"].Visible = false;
            dgvAvisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvisos.ReadOnly = true;
            dgvAvisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvisos.AllowUserToAddRows = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarAvisos();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvAvisos.CurrentRow == null)
                return;

            DataRowView row = (DataRowView)dgvAvisos.CurrentRow.DataBoundItem;

            DateTime? fechaEnvio = null;

            if (row["FechaEnvio"] != DBNull.Value)
            {
                fechaEnvio = Convert.ToDateTime(row["FechaEnvio"]);
            }

            AvisoMateria aviso = new AvisoMateria
            {
                IdAviso = Convert.ToInt32(row["IdAviso"]),
                MateriaId = Convert.ToInt32(row["MateriaId"]),
                TipoAviso = Convert.ToInt32(row["Meses"]),
                FechaProgramada = Convert.ToDateTime(row["FechaProgramada"]),
                FechaEnvio = fechaEnvio,
                Estado = row["Estado"].ToString()
            };

            if (aviso.Estado != "Pendiente")
            {
                MessageBox.Show("Solo se pueden enviar avisos pendientes");
                return;
            }

            bool ok = negAvisos.EnviarAvisoManual(aviso);

            if (ok)
            {
                MessageBox.Show("✅ Aviso enviado correctamente");
                CargarAvisos();
            }
            else
            {
                MessageBox.Show("❌ No se pudo enviar el aviso");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvAvisos.SelectedRows.Count == 0)
                return;

            int idAviso = (int)dgvAvisos.SelectedRows[0].Cells["IdAviso"].Value;

            if (MessageBox.Show("¿Cancelar este aviso?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                negAvisos.CancelarAviso(idAviso);
                CargarAvisos();
            }
        }
        private void PintarFilas()
        {
            foreach (DataGridViewRow fila in dgvAvisos.Rows)
            {
                if (fila.Cells["Estado"].Value == null)
                    continue;

                string estado = fila.Cells["Estado"].Value.ToString();

                switch (estado)
                {
                    case "Pendiente":
                        fila.DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
                        break;

                    case "Enviado":
                        fila.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        break;

                    case "Cancelado":
                        fila.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                        break;
                }
            }
        }

    }
}
