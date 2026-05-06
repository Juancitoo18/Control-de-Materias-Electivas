using DAO;
using ENTIDADES;
using System.Data;

namespace NEGOCIO
{
    public class NegocioResoluciones
    {
        private DaoResoluciones dao = new DaoResoluciones();

        public bool AgregarResolucion(ResolucionMateria res)
        {
            return dao.AgregarResolucion(res);
        }

        public DataTable ListarPorMateria(int materiaId)
        {
            return dao.ListarPorMateria(materiaId);
        }

        public bool GuardarLinkPDF(int idResolucion, string link)
        {
            return dao.GuardarLinkPDF(idResolucion, link);
        }

        public DataTable ListarResoluciones()
        {
            return dao.ListarResoluciones();
        }
    }
}
