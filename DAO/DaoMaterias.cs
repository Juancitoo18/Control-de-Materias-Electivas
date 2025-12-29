using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DAO
{
    public class DaoMaterias
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable ObtenerMaterias()
        {
            string consulta = @"SELECT m.Id, 
                                   c.Nombre AS Carrera,                               
                                   m.Nombre AS [Materias Electivas],   
                                   m.CodigodeMateria AS Materia,
                                   m.CarreraId,
                                   m.NumeroResolucion AS [Resolución de Habilitación], 
                                   m.FechaAprobacion AS [Fecha de Resolucion Habilitación], 
                                   m.FechaVencimiento,
                                   m.Desde,
                                   m.Hasta,
                                   m.Estado
                            FROM MateriasElectivas m 
                            INNER JOIN Carreras c ON c.Id = m.CarreraId 
                            WHERE m.Estado = 1";
            return ds.obtenerTablaId(consulta);
        }
        public bool Agregar(MateriaElectiva materia)
        {
            string ruta = "Data Source=localhost\\sqlexpress; Initial Catalog=dbElectivas; Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(ruta))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("sp_AgregarMateriaElectiva", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@Nombre", materia.Nombre);
                        comando.Parameters.AddWithValue("@CarreraId", materia.IdCarrera.Id);
                        comando.Parameters.AddWithValue("@CodigoMateria", SqlDbType.Int).Value = materia.CodigoMateria;
                        comando.Parameters.AddWithValue("@NumeroResolucion", materia.NumeroResolucion);
                        comando.Parameters.AddWithValue("@FechaAprobacion", materia.FechaAprobacion);
                        comando.Parameters.AddWithValue("@FechaVencimiento", materia.FechaVencimiento);
                        comando.Parameters.AddWithValue("@Desde", materia.Desde);
                        comando.Parameters.AddWithValue("@Hasta", materia.Hasta);
                        comando.Parameters.AddWithValue("@Estado", materia.Estado);

                        object id = comando.ExecuteScalar();
                        materia.Id = id != null ? Convert.ToInt32(id) : 0;

                        return materia.Id > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public MateriaElectiva ObtenerPorId(int id)
        {
            string query = @"SELECT * FROM MateriasElectivas WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@Id", id);

            DataTable dt = ds.ConsultaTabla(cmd, "Materia");

            if (dt.Rows.Count == 0)
                return null;

            DataRow r = dt.Rows[0];

            return new MateriaElectiva
            {
                Id = Convert.ToInt32(r["Id"]),
                Nombre = r["Nombre"].ToString(),
                NumeroResolucion = r["NumeroResolucion"].ToString(),
                FechaAprobacion = Convert.ToDateTime(r["FechaAprobacion"]),
                FechaVencimiento = Convert.ToDateTime(r["FechaVencimiento"]),
                Desde = r["Desde"].ToString(),
                Hasta = r["Hasta"].ToString(),
                Estado = Convert.ToBoolean(r["Estado"]),
                IdCarrera = new Carrera { Id = Convert.ToInt32(r["CarreraId"]) }
            };
        }

        public MateriaElectiva BuscarPorNumeroResolucion(string numeroResolucion)
        {
            string consulta = "SELECT TOP 1 m.Id, m.Nombre, c.Nombre AS Carrera, m.NumeroResolucion FROM MateriasElectivas m INNER JOIN Carreras c ON c.Id = m.CarreraId WHERE m.NumeroResolucion = @NumeroResolucion";

            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@NumeroResolucion", numeroResolucion);

            DataTable dt = ds.ConsultaTabla(comando, "MateriaResolucion");

            if (dt.Rows.Count > 0)
            {
                return new MateriaElectiva
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Nombre = dt.Rows[0]["Nombre"].ToString(),
                    NumeroResolucion = dt.Rows[0]["NumeroResolucion"].ToString()
                };
            }

            return null; 
        }

        public bool Editar(MateriaElectiva materia)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spEditarMateria";

                ArmarParametrosMateriaEditar(ref comando, materia);

                int filas = ds.EjectuarProcedimientoAlmacenado(comando, "spEditarMateria");
                return filas > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ArmarParametrosMateriaEditar(ref SqlCommand comando, MateriaElectiva materia)
        {
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = materia.Id;
            comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = materia.Nombre;
            comando.Parameters.Add("@CarreraId", SqlDbType.Int).Value = materia.IdCarrera.Id;
            comando.Parameters.Add("@NumeroResolucion", SqlDbType.NVarChar, 50).Value = materia.NumeroResolucion;
            comando.Parameters.Add("@CodigoMateria", SqlDbType.Int).Value = materia.CodigoMateria;
            comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = materia.Estado;
        }


        public bool DarDeBaja(int id)
        {
            string consulta = "UPDATE MateriasElectivas SET Estado = 0 WHERE Id = @Id AND Estado = 1";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Id", id);
            return ds.EjecutarSQL(comando) > 0;
        }

        public DataTable ListarMateriasPorVencer(int meses, int Años)
        {
            string consulta = @"SELECT m.Id, 
                                   c.Nombre AS Carrera,                               
                                   m.Nombre AS [Materias Electivas],   
                                   m.CodigodeMateria AS Materia,
                                   m.CarreraId,
                                   m.NumeroResolucion AS [Resolución de Habilitación], 
                                   m.FechaAprobacion AS [Fecha de Resolucion Habilitación], 
                                   m.FechaVencimiento,
                                   m.Desde,
                                   m.Hasta,
                                   m.Estado
                            FROM MateriasElectivas m 
                            INNER JOIN Carreras c ON c.Id = m.CarreraId 
                            WHERE m.Estado = 1 AND m.FechaVencimiento > DATEADD(MONTH, @Meses, GETDATE()) AND m.FechaVencimiento < DATEADD(YEAR, @Años, GETDATE());";

            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Meses", meses);
            comando.Parameters.AddWithValue("@Años", Años);

            return ds.ConsultaTabla(comando, "MateriasPorVencer");
        }

        public DataTable ListarMateriasVencidas()
        {
            string consulta = @"SELECT m.Id, 
                                   c.Nombre AS Carrera,                               
                                   m.Nombre AS [Materias Electivas], 
                                   m.CodigodeMateria AS Materia,
                                   m.CarreraId,
                                   m.NumeroResolucion AS [Resolución de Habilitación], 
                                   m.FechaAprobacion AS [Fecha de Resolucion Habilitación], 
                                   m.FechaVencimiento,
                                   m.Desde,
                                   m.Hasta,
                                   m.Estado
                            FROM MateriasElectivas m 
                            INNER JOIN Carreras c ON c.Id = m.CarreraId 
                            WHERE m.Estado = 1 AND m.FechaVencimiento < GETDATE();";

            SqlCommand comando = new SqlCommand(consulta);
            return ds.ConsultaTabla(comando, "MateriasVencidas");
        }

        public bool ActualizarFechas(MateriaElectiva materia)
        {
            string query = @"
                UPDATE MateriasElectivas
                SET FechaAprobacion = @FechaAprobacion,
                    FechaVencimiento = @FechaVencimiento,
                    Desde = @Desde,
                    Hasta = @Hasta
                WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@FechaAprobacion", materia.FechaAprobacion);
            cmd.Parameters.AddWithValue("@FechaVencimiento", materia.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Desde", materia.Desde);
            cmd.Parameters.AddWithValue("@Hasta", materia.Hasta);
            cmd.Parameters.AddWithValue("@Id", materia.Id);

            return ds.EjecutarSQL(cmd) > 0;
        }


        public DataTable ListarMateriasPorCarrera(int idCarrera)
        {
            string consulta = @"SELECT m.Id, 
                                   c.Nombre AS Carrera,                               
                                   m.Nombre AS [Materias Electivas],  
                                   m.CodigodeMateria AS Materia,
                                   m.CarreraId,
                                   m.NumeroResolucion AS [Resolución de Habilitación], 
                                   m.FechaAprobacion AS [Fecha de Resolucion Habilitación], 
                                   m.FechaVencimiento,
                                   m.Desde,
                                   m.Hasta,
                                   m.Estado
                            FROM MateriasElectivas m 
                            INNER JOIN Carreras c ON c.Id = m.CarreraId 
                            WHERE m.Estado = 1 AND m.CarreraId = @IdCarrera";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@IdCarrera", idCarrera);
            return ds.ConsultaTabla(comando, "MateriasPorCarrera");
        }

        public DataTable FiltrarMaterias(FiltroMaterias filtro)
        {
            string query = @"SELECT m.Id, 
                                   c.Nombre AS Carrera,                               
                                   m.Nombre AS[Materias Electivas],
                                   m.CodigodeMateria AS Materia,
                                   m.CarreraId,
                                   m.NumeroResolucion AS[Resolución de Habilitación],
                                   m.FechaAprobacion AS[Fecha de Resolucion Habilitación],
                                   m.FechaVencimiento,
                                   m.Desde,
                                   m.Hasta,
                                   m.Estado
                            FROM MateriasElectivas m 
                            INNER JOIN Carreras c ON c.Id = m.CarreraId WHERE m.Estado=1 ";

            List<SqlParameter> parametros = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(filtro.Nombre))
            {
                query += " AND m.Nombre LIKE @Nombre ";
                parametros.Add(new SqlParameter("@Nombre", "%" + filtro.Nombre + "%"));
            }
            if (filtro.CodigoMateria > 0)
            {
                query += " AND m.CodigodeMateria = @CodigoMateria ";
                parametros.Add(new SqlParameter("@CodigoMateria ", filtro.CodigoMateria));
            }

            if (filtro.CarreraId > 0)
            {
                query += " AND m.CarreraId = @CarreraId ";
                parametros.Add(new SqlParameter("@CarreraId", filtro.CarreraId));
            }

            if (!string.IsNullOrEmpty(filtro.NumeroResolucion))
            {
                query += " AND m.NumeroResolucion LIKE @Res ";
                parametros.Add(new SqlParameter("@Res", "%" + filtro.NumeroResolucion + "%"));
            }

            if (filtro.Desde.HasValue)
            {
                query += " AND CAST(m.Desde AS INT) >= @Desde ";
                parametros.Add(new SqlParameter("@Desde", filtro.Desde.Value));
            }

            if (filtro.Hasta.HasValue)
            {
                query += " AND CAST(m.Hasta AS INT) <= @Hasta ";
                parametros.Add(new SqlParameter("@Hasta", filtro.Hasta.Value));
            }

            return ds.EjecutarConsulta(query, parametros);
        }
        public bool RenovarMateria(MateriaElectiva materia)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spRenovarMateria";

                cmd.Parameters.AddWithValue("@Id", materia.Id);
                cmd.Parameters.AddWithValue("@NumeroResolucion", materia.NumeroResolucion);
                cmd.Parameters.AddWithValue("@FechaAprobacion", materia.FechaAprobacion);
                cmd.Parameters.AddWithValue("@FechaVencimiento", materia.FechaVencimiento);

                return ds.EjectuarProcedimientoAlmacenado(cmd, "spRenovarMateria") > 0;
            }
            catch
            {
                return false;
            }
        }
        public DataTable ObtenerHistorialMateria(int materiaId)
        {
            string query = @"
                            SELECT
                                IdHistorial AS Id,
                                Nombre,
                                CodigodeMateria AS [Materia],
                                NumeroResolucion AS [Resolución],
                                FechaAprobacion AS [Aprobación],
                                FechaVencimiento AS [Vencimiento],
                                Desde,
                                Hasta,
                                FechaRegistro AS [Registrado]
                            FROM MateriasElectivasHistorial
                            WHERE MateriaId = @MateriaId
                            ORDER BY FechaRegistro DESC";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MateriaId", materiaId);

            return ds.ConsultaTabla(cmd, "HistorialMateria");
        }



    }
}
