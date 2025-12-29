using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEGOCIO;

namespace ProcesadorAvisosElectivas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logger.LogInfo("Inicio del procesamiento de avisos");

                NegocioAvisos negAvisos = new NegocioAvisos();
                negAvisos.ProcesarAvisos();

                Logger.LogInfo("Fin del procesamiento de avisos");
            }
            catch (Exception ex)
            {
                Logger.LogError("Error general al procesar avisos", ex);
            }

        }
    }
}
