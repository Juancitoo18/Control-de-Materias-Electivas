using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DAO;
using System.Data;

namespace NEGOCIO
{
    public class NegocioMaterias
    {
        private DaoMaterias DaoMateria;
        private NegocioAvisos negAvisos;
        private NegocioCarrera negCarrera;
        public NegocioMaterias()
        {
            DaoMateria = new DaoMaterias();
            negAvisos = new NegocioAvisos();
            negCarrera = new NegocioCarrera();
        }
        public DataTable ListarMaterias()
        {
            return DaoMateria.ObtenerMaterias();
        }
        public bool AgregarMateria(MateriaElectiva materia)
        {
            bool ok = DaoMateria.Agregar(materia);

            if (!ok)
                return false;

            // Generar avisos 12 y 6 meses
            DateTime aviso12 = materia.FechaVencimiento.AddMonths(-12);
            DateTime aviso6 = materia.FechaVencimiento.AddMonths(-6);

            if (aviso12 > DateTime.Today)
                negAvisos.CrearAvisoMateria(materia.Id, 12, aviso12);

            if (aviso6 > DateTime.Today)
                negAvisos.CrearAvisoMateria(materia.Id, 6, aviso6);

            return true;
        }
        public bool EditarMateria(MateriaElectiva Materia)
        {
            return DaoMateria.Editar(Materia);
        }
        public bool DarDeBaja(int id)
        {
            return DaoMateria.DarDeBaja(id);
        }

        public DataTable ListarMateriasPorVencer(int meses, int años)
        {
            return DaoMateria.ListarMateriasPorVencer(meses, años);
        }

        public DataTable ListarMateriasVencidas()
        {
            return DaoMateria.ListarMateriasVencidas();
        }

        public MateriaElectiva BuscarPorNumeroResolucion(string numeroResolucion)
        {
            return DaoMateria.BuscarPorNumeroResolucion(numeroResolucion);
        }

        public bool ActualizarFechas(MateriaElectiva materia)
        {
            return DaoMateria.ActualizarFechas(materia);
        }

        public DataTable ListarMateriasPorCarrera(int idCarrera)
        {
            return DaoMateria.ListarMateriasPorCarrera(idCarrera);
        }

        public DataTable FiltrarMaterias(FiltroMaterias filtro)
        {
            return DaoMateria.FiltrarMaterias(filtro);
        }

        public bool RenovarMateria(MateriaElectiva materiaActualizada)
        {
            bool ok = DaoMateria.ActualizarFechas(materiaActualizada);
            if (!ok)
                return false;

            // Cancela avisos pendientes viejos
            negAvisos.CancelarPendientesPorMateria(materiaActualizada.Id);

            // Genera nuevos avisos
            negAvisos.GenerarAvisosPorMateria(materiaActualizada);

            return true;
        }

        public MateriaElectiva ObtenerPorId(int id)
        {
            return DaoMateria.ObtenerPorId(id);
        }

        public string ObtenerNombreCarrera(int idCarrera)
        {
            return negCarrera.ObtenerNombreCarrera(idCarrera);
        }
       

    }
}
