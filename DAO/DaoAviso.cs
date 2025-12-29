using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoAviso
    {
        private AccesoDatos ds = new AccesoDatos();

        public bool InsertarAvisoMateria(AvisoMateria aviso)
        {
            string query = @"
                INSERT INTO AvisosMateria
                (MateriaId, TipoAviso, FechaProgramada, Estado)
                VALUES
                (@MateriaId, @TipoAviso, @FechaProgramada, @Estado)";

            SqlParameter[] parametros =
            {
                new SqlParameter("@MateriaId", aviso.MateriaId),
                new SqlParameter("@TipoAviso", aviso.TipoAviso),
                new SqlParameter("@FechaProgramada", aviso.FechaProgramada),
                new SqlParameter("@Estado", aviso.Estado)
            };

            return ds.EjecutarConsultaConParametros(query, parametros) > 0;
        }

        public List<AvisoMateria> ObtenerPendientes()
        {
            List<AvisoMateria> lista = new List<AvisoMateria>();

            string query = @"
                SELECT *
                FROM AvisosMateria
                WHERE Estado = 'Pendiente'
                  AND FechaProgramada <= CAST(GETDATE() AS DATE)";

            DataTable dt = ds.ObtenerTabla("AvisosMaterias", query);

            foreach (DataRow row in dt.Rows)
            {
                DateTime? fechaEnvio = null;
                if (row["FechaEnvio"] != DBNull.Value)
                    fechaEnvio = Convert.ToDateTime(row["FechaEnvio"]);

                lista.Add(new AvisoMateria
                {
                    IdAviso = Convert.ToInt32(row["IdAviso"]),
                    MateriaId = Convert.ToInt32(row["MateriaId"]),
                    TipoAviso = Convert.ToInt32(row["TipoAviso"]),
                    FechaProgramada = Convert.ToDateTime(row["FechaProgramada"]),
                    FechaEnvio = fechaEnvio,
                    Estado = row["Estado"].ToString()
                });
            }

            return lista;
        }

        public bool MarcarComoEnviado(int idAviso)
        {
            string query = @"
                UPDATE AvisosMateria
                SET Estado = 'Enviado',
                FechaEnvio = GETDATE()
                WHERE IdAviso = @IdAviso";

            SqlParameter param = new SqlParameter("@IdAviso", idAviso);
            return ds.EjecutarConsultaConParametros(query, new[] { param }) > 0;
        }

        public bool CancelarPendientesPorMateria(int materiaId)
        {
            string query = @"
                UPDATE AvisosMateria
                SET Estado = 'Cancelado'
                WHERE MateriaId = @MateriaId
                  AND Estado = 'Pendiente'";

            SqlParameter param = new SqlParameter("@MateriaId", materiaId);
            return ds.EjecutarConsultaConParametros(query, new[] { param }) > 0;
        }

        public DataTable ListarAvisos(string estado)
        {
            string query = @"
                             SELECT 
                                a.IdAviso,
                                m.Nombre AS Materia,
                                a.MateriaId,
                                c.Nombre AS Carrera,
                                a.TipoAviso AS Meses,
                                a.FechaProgramada,
                                a.FechaEnvio,
                                a.Estado
                            FROM AvisosMateria a
                            INNER JOIN MateriasElectivas m ON m.Id = a.MateriaId
                            INNER JOIN Carreras c ON c.Id = m.CarreraId
                            WHERE (@Estado = 'Todos' OR a.Estado = @Estado)
                            ORDER BY a.FechaProgramada DESC";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@Estado", estado);

            return ds.ConsultaTabla(cmd, "AvisosMateria");
        }

        public bool MarcarComoEnviadoManual(int idAviso)
        {
            string query = @"
                            UPDATE AvisosMateria
                            SET Estado = 'Enviado',
                                FechaEnvio = GETDATE()
                            WHERE IdAviso = @IdAviso";

            SqlParameter p = new SqlParameter("@IdAviso", idAviso);
            return ds.EjecutarConsultaConParametros(query, new[] { p }) > 0;
        }
        public bool CancelarAviso(int idAviso)
        {
            string query = @"
                            UPDATE AvisosMateria
                            SET Estado = 'Cancelado'
                            WHERE IdAviso = @IdAviso";

            SqlParameter p = new SqlParameter("@IdAviso", idAviso);
            return ds.EjecutarConsultaConParametros(query, new[] { p }) > 0;
        }
        public void RegistrarEnvio(int idAviso, string email, bool enviado)
        {
            string query = @"
                INSERT INTO AvisosEnvios (IdAviso, EmailDestino, Estado)
                VALUES (@IdAviso, @Email, @Estado)";

            SqlParameter[] parametros =
            {
                new SqlParameter("@IdAviso", idAviso),
                new SqlParameter("@Email", email),
                new SqlParameter("@Estado", enviado ? "Enviado" : "Error")
            };
            ds.EjecutarConsultaConParametros(query, parametros);
        }

    }
}
