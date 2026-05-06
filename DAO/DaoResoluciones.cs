using ENTIDADES;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DAO
{
    public class DaoResoluciones
    {
        AccesoDatos ds = new AccesoDatos();

        public bool AgregarResolucion(ResolucionMateria res)
        {
            string query = @"
                INSERT INTO ResolucionesMaterias
                (MateriaId, NumeroResolucion, Anio, NombreArchivo, UrlArchivo)
                VALUES
                (@MateriaId, @NumeroResolucion, @Anio, @NombreArchivo, @UrlArchivo)";

            SqlParameter[] parametros =
            {
                new SqlParameter("@MateriaId", res.MateriaId),
                new SqlParameter("@NumeroResolucion", res.NumeroResolucion),
                new SqlParameter("@Anio", res.Anio),
                new SqlParameter("@NombreArchivo", res.NombreArchivo),
                new SqlParameter("@UrlArchivo", res.UrlArchivo)
            };

            return ds.EjecutarConsultaConParametros(query, parametros) > 0;
        }

        public DataTable ListarPorMateria(int materiaId)
        {
            string query = @"
                SELECT * FROM ResolucionesMaterias
                WHERE MateriaId = @MateriaId";

            SqlParameter[] p =
            {
                new SqlParameter("@MateriaId", materiaId)
            };

            return ds.ObtenerTabla("Resoluciones", query.Replace("@MateriaId", materiaId.ToString()));
        }
        public DataTable ListarResoluciones()
        {
            string query = @"
                    SELECT 
                        r.Id,
                        r.MateriaId,
                        r.NumeroResolucion,
                        r.Anio,
                        r.NombreArchivo,
                        r.UrlArchivo,
                        r.FechaCarga,
                        m.Nombre AS Materia,
                        c.Nombre AS Carrera,
                        CASE 
                            WHEN r.UrlArchivo IS NULL OR r.UrlArchivo = '' 
                            THEN '❌ Sin PDF'
                            ELSE '✔ Con PDF'
                        END AS EstadoPDF
                    FROM ResolucionesMaterias r
                    INNER JOIN MateriasElectivas m ON m.Id = r.MateriaId
                    INNER JOIN Carreras c ON c.Id = m.CarreraId
                    ORDER BY r.Anio DESC, r.NumeroResolucion DESC";

            return ds.ObtenerTabla("ResolucionesMaterias", query);
        }

        public bool GuardarLinkPDF(int id, string link)
        {
            string query = @"
                UPDATE ResolucionesMaterias
                SET UrlArchivo = @UrlArchivo
                WHERE Id = @Id";

                    SqlParameter[] p =
                    {
                new SqlParameter("@UrlArchivo", link),
                new SqlParameter("@Id", id)
            };

            return ds.EjecutarConsultaConParametros(query, p) > 0;
        }
    }
}