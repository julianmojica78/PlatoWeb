using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class Correo
    {
        public void enviarCorreo(String correoDestino, String userToken, String mensaje)
        {

            try
            {
                var Emailtemplate = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "Plantilla\\mailer.html"));
                var strBody = string.Format(Emailtemplate.ReadToEnd(), userToken);
                Emailtemplate.Close(); Emailtemplate.Dispose(); Emailtemplate = null;

                strBody = strBody.Replace("#TOKEN#", mensaje);
                //Configuración del Mensaje
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
                mail.From = new MailAddress("security@security.com", "Pasando la Materia");

                //Aquí ponemos el asunto del correo
                mail.Subject = "Recuperación Contraseña";
                //Aquí ponemos el mensaje que incluirá el correo
                mail.Body = strBody;
                //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
                mail.To.Add(correoDestino);
                //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
                //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));
                mail.IsBodyHtml = true;

                mail.Priority = MailPriority.Normal;
                //Configuracion del SMTP
                SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
                                       //Especificamos las credenciales con las que enviaremos el mail
                SmtpServer.Credentials = new System.Net.NetworkCredential("prueba1998isw@gmail.com", "Prueba1234");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
