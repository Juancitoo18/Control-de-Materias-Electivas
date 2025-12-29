using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class NegocioRecursos
    {
        public static bool EnviarCorreo(string correo, string asunto, string mensaje)
        {
            bool resultado = false;

            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("alumnosdegradofrgp@gmail.com");
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                var smpt = new SmtpClient()
                {
                    Credentials = new NetworkCredential("alumnosdegradofrgp@gmail.com", "dyyhytgqtgzdtpnk"),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };

                smpt.Send(mail);
                resultado = true;

            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
