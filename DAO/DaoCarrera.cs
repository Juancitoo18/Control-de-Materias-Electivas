using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DAO
{
    public class DaoCarrera
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable ObtenerCarreras()
        {
            string consulta = "SELECT Id, Nombre FROM Carreras";
            return ds.ObtenerTabla("Carreras", consulta);
        }

        public string ObtenerNombreCarreraPorId(int idCarrera)
        {
            string consulta = "SELECT Nombre FROM Carreras WHERE Id = @Id";

            var parametros = new List<System.Data.SqlClient.SqlParameter>
            {
                new System.Data.SqlClient.SqlParameter("@Id", idCarrera)
            };

            DataTable dt = ds.EjecutarConsulta(consulta, parametros);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["Nombre"].ToString();

            return string.Empty;
        }

    }
}
