using System;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;

namespace Control_Electivas
{
    public partial class Resoluciones : Form
    {
        private NegocioResoluciones neg = new NegocioResoluciones();
        private int idSeleccionado = 0;

        public Resoluciones()
        {
            InitializeComponent();
        }

        private void ResolucionesForm_Load(object sender, EventArgs e)
        {
            CargarResoluciones();
            dgvResoluciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResoluciones.MultiSelect = false;
            dgvResoluciones.ReadOnly = true;
        }

        private void CargarResoluciones()
        {
            dgvResoluciones.DataSource = neg.ListarResoluciones();
            foreach (DataGridViewColumn col in dgvResoluciones.Columns)
                col.Visible = false;

            dgvResoluciones.Columns["NumeroResolucion"].Visible = true;
            dgvResoluciones.Columns["Anio"].Visible = true;
            dgvResoluciones.Columns["Materia"].Visible = true;

            dgvResoluciones.Columns["NumeroResolucion"].HeaderText = "Resolución";
            dgvResoluciones.Columns["Anio"].HeaderText = "Año";
            dgvResoluciones.Columns["Materia"].HeaderText = "Materia";

            dgvResoluciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvResoluciones.Rows.Count > 0)
            {
                dgvResoluciones.Rows[0].Selected = true;
                dgvResoluciones.CurrentCell = dgvResoluciones.Rows[0].Cells["NumeroResolucion"];

                CargarDetalleDesdeFila(dgvResoluciones.Rows[0]);
            }
        }

        private void dgvResoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResoluciones.CurrentRow == null)
                return;

            CargarDetalleDesdeFila(dgvResoluciones.CurrentRow);
        }

        private async void btnCargarPDF_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná una resolución primero.");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF (*.pdf)|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string url = await SubirPDF(ofd.FileName);

                if (!string.IsNullOrEmpty(url))
                {
                    bool ok = neg.GuardarLinkPDF(idSeleccionado, url);

                    if (ok)
                    {
                        MessageBox.Show("PDF cargado y guardado correctamente");
                        txtLink.Text = url;
                        CargarResoluciones();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar en la base de datos");
                    }
                }
                else
                {
                    MessageBox.Show("Error al subir el PDF");
                }
            }
        }

        private void btnVerPDF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLink.Text))
            {
                MessageBox.Show("No hay PDF cargado.");
                return;
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = txtLink.Text,
                UseShellExecute = true
            });
        }

        private async Task<string> SubirPDF(string rutaArchivo)
        {
            using (var client = new HttpClient())
            {
                using (var form = new MultipartFormDataContent())
                {
                    byte[] fileBytes = System.IO.File.ReadAllBytes(rutaArchivo);

                    form.Add(new ByteArrayContent(fileBytes), "file", System.IO.Path.GetFileName(rutaArchivo));

                    var response = await client.PostAsync("https://localhost:7192/api/resoluciones/upload", form);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                }
            }

            return null;
        }

        private void CargarDetalleDesdeFila(DataGridViewRow row)
        {
            idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);

            txtNumero.Text = row.Cells["NumeroResolucion"].Value.ToString();
            txtAnio.Text = row.Cells["Anio"].Value.ToString();
            txtLink.Text = row.Cells["UrlArchivo"].Value?.ToString() ?? "";
        }
        private void filtroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
