using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProcesadorAvisosElectivas
{
    public static class Logger
    {
        private static readonly string rutaLog =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log_avisos.txt");

        public static void LogError(string mensaje, Exception ex)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaLog, true))
                {
                    sw.WriteLine("===================================");
                    sw.WriteLine($"Fecha: {DateTime.Now}");
                    sw.WriteLine($"Mensaje: {mensaje}");
                    sw.WriteLine($"Excepción: {ex.Message}");
                    sw.WriteLine($"StackTrace: {ex.StackTrace}");
                }
            }
            catch
            {
                // Último recurso: no hacer nada
            }
        }

        public static void LogInfo(string mensaje)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaLog, true))
                {
                    sw.WriteLine($"[{DateTime.Now}] INFO: {mensaje}");
                }
            }
            catch { }
        }
    }
}
