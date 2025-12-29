using DAO;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;

namespace NEGOCIO
{
    public class NegocioAvisos
    {
        private DaoAviso daoAvisos = new DaoAviso();
        private DaoMaterias daoMaterias = new DaoMaterias();

        public bool CrearAvisoMateria(int materiaId, int tipoAviso, DateTime fecha)
        {
            AvisoMateria aviso = new AvisoMateria
            {
                MateriaId = materiaId,
                TipoAviso = tipoAviso,
                FechaProgramada = fecha,
                Estado = "Pendiente"
            };

            return daoAvisos.InsertarAvisoMateria(aviso);
        }

        public List<AvisoMateria> ObtenerPendientes()
        {
            return daoAvisos.ObtenerPendientes();
        }
        private List<string> ObtenerDestinatarios(AvisoMateria aviso)
        {
            List<string> lista = new List<string>
            {
                "jrios@red.frgp.utn.edu.ar"
            };

            MateriaElectiva materia = daoMaterias.ObtenerPorId(aviso.MateriaId);
            int carreraId = materia.IdCarrera.Id;
            /*
            switch (carreraId)
            {
                case 1:
                    lista.Add("Juansuarezpn@gmail.com");
                    break;
                case 2:
                    lista.Add("electrica@departamentos.frgp.utn.edu.ar");
                    break;
                case 3:
                    lista.Add("ingautomotriz@departamentos.frgp.utn.edu.ar");
                    break;
                case 4:
                    lista.Add("mecanica@departamentos.frgp.utn.edu.ar");
                    break;
                case 5:
                    lista.Add("loi@departamentos.frgp.utn.edu.ar");
                    break;
            }
            */
            return lista;
        }

        public void ProcesarAvisos()
        {
            List<AvisoMateria> avisos = daoAvisos.ObtenerPendientes();

            foreach (AvisoMateria aviso in avisos)
            {
                MateriaElectiva materia = daoMaterias.ObtenerPorId(aviso.MateriaId);
                NegocioMaterias negMaterias = new NegocioMaterias();
                string nombreCarrera = negMaterias.ObtenerNombreCarrera(materia.IdCarrera.Id);

                string mensaje = GenerarMensajeAviso(materia, nombreCarrera, aviso.TipoAviso, false);

                List<string> destinatarios = ObtenerDestinatarios(aviso);
                bool enviadoATodos = true;

                foreach (string mail in destinatarios)
                {
                    bool ok = NegocioRecursos.EnviarCorreo(
                        mail,
                        "Aviso de vencimiento de materia",
                        mensaje
                    );
                    daoAvisos.RegistrarEnvio(aviso.IdAviso, mail, ok);
                    if (!ok)
                    {
                        enviadoATodos = false;
                        break;
                    }
                }

                if (enviadoATodos)
                {
                    daoAvisos.MarcarComoEnviado(aviso.IdAviso);
                }
            }
        }

        private string GenerarMensajeAviso(MateriaElectiva materia, string nombreCarrera, int tipoAviso, bool esManual)
        {
            int mesesRestantes = tipoAviso;

            if (esManual)
            {
                DateTime hoy = DateTime.Today;
                DateTime vencimiento = materia.FechaVencimiento;

                mesesRestantes = ((vencimiento.Year - hoy.Year) * 12) + vencimiento.Month - hoy.Month;

                if (vencimiento.Day < hoy.Day)
                    mesesRestantes--;

                if (mesesRestantes < 0) mesesRestantes = 0; 
            }

            return $@"
                <html>
                  <body style='font-family: Arial, sans-serif; background-color:#f4f6f8; padding:20px;'>
                    <div style='max-width:600px; margin:auto; background:#ffffff; padding:20px; border-radius:8px; border:1px solid #ddd;'>

                      <h2 style='color:#2c3e50; text-align:center;'>
                        📌 Aviso de vencimiento
                      </h2>

                      <p style='font-size:15px; color:#333;'>
                        La materia <strong>{materia.Nombre}</strong> de la 
                        <strong>Carrera: {nombreCarrera}</strong> tiene una fecha de vencimiento próxima.
                      </p>

                      <div style='background:#f9fafb; padding:12px; border-left:4px solid #3498db; margin:15px 0;'>
                        <p style='margin:0; font-size:14px;'>
                          ⏳ <strong>Vence en:</strong> {mesesRestantes} meses<br/>
                          📅 <strong>Fecha de vencimiento:</strong> {materia.FechaVencimiento:dd/MM/yyyy}
                        </p>
                      </div>

                      <p style='font-size:14px; color:#555;'>
                        Se recomienda iniciar los trámites de habilitación correspondientes
                        con anticipación para evitar futuros inconvenientes.
                      </p>

                      <hr style='border:none; border-top:1px solid #eee; margin:20px 0;' />

                      <p style='font-size:12px; color:#999; text-align:center;'>
                        Este es un mensaje automático. Por favor, no responder.
                      </p>

                    </div>
                  </body>
                </html>";
        }


        public void GenerarAvisosPorMateria(MateriaElectiva materia)
        {
            DateTime fecha12 = materia.FechaVencimiento.AddMonths(-12);
            DateTime fecha6 = materia.FechaVencimiento.AddMonths(-6);

            if (fecha12 > DateTime.Today)
                CrearAvisoMateria(materia.Id, 12, fecha12);

            if (fecha6 > DateTime.Today)
                CrearAvisoMateria(materia.Id, 6, fecha6);
        }

        public bool RenovarMateria(MateriaElectiva materiaActualizada)
        {
            bool ok = daoMaterias.ActualizarFechas(materiaActualizada);
            if (!ok) return false;

            daoAvisos.CancelarPendientesPorMateria(materiaActualizada.Id);
            GenerarAvisosPorMateria(materiaActualizada);

            return true;
        }
        public bool CancelarPendientesPorMateria(int materiaId)
        {
            return daoAvisos.CancelarPendientesPorMateria(materiaId);
        }
        public DataTable ListarAvisos(string estado)
        {
            return daoAvisos.ListarAvisos(estado);
        }

        public bool EnviarAvisoManual(AvisoMateria aviso)
        {
            MateriaElectiva materia = daoMaterias.ObtenerPorId(aviso.MateriaId);
            if (materia == null)
                return false;

            NegocioMaterias negMaterias = new NegocioMaterias();
            string nombreCarrera = negMaterias.ObtenerNombreCarrera(materia.IdCarrera.Id);

            string mensaje = GenerarMensajeAviso(
                materia,
                nombreCarrera,
                aviso.TipoAviso,
                true
            );

            // Obtener todos los destinatarios según la carrera
            List<string> destinatarios = ObtenerDestinatarios(aviso);

            bool todosEnviados = true;

            foreach (string correo in destinatarios)
            {
                bool enviado = NegocioRecursos.EnviarCorreo(
                    correo,
                    "Aviso de vencimiento de materia",
                    mensaje
                );

                if (!enviado)
                {
                    todosEnviados = false; // si falla al menos un envío, marcamos false
                }
            }

            if (todosEnviados)
            {
                daoAvisos.MarcarComoEnviado(aviso.IdAviso);
            }

            return todosEnviados;
        }

        public bool CancelarAviso(int idAviso)
        {
            return daoAvisos.CancelarAviso(idAviso);
        }

    }
}
