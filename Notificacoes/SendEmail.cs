using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Notificacoes
{
    public class SendEmail
    {
        public bool EnvioDeEmails(string de, string para,string senha,string usuario)
        {
            string subject = "MATER DEY CADASTRO DE USUARIO";

            string body = @"<div style='background-color: lightpink;height: 244px;width: 500px;text-align: center;font-size: large;font-weight: bold;color: white;font-family: initial;text-shadow: black 4px 7px 5px;'>SEU USUARIO<br>"
                           + "   <span>"+ usuario + "</span>"                                                                                                        
                           + "    <hr>                                                                                                                                                                                                    "
                           + "    senha é:"+ senha + "<br>                                                                                                                                                                                     "
                           + "    <span>CADA UM FAZENDO A SUA PARTE..</span>                                                                                                                                                              "
                           + "    <span>VIOLENCIA E CRIME NÃO ACEITE..</span>                                                                                                                                                             "
                           + "    <hr>                                                                                                                                                                                                    "
                           + "     <span>DISK DENUNCIA TELL (11) 1111-1111..</span>"
                           + "</div>";

            try
            {
                //Instância classe email
                MailMessage mail = new MailMessage();
                mail.To.Add(de == "" ? "paulo000natale@gmail.com" : de);
                mail.From = new MailAddress(para == "" ? "paulo000natale@gmail.com" : para);
                mail.Subject = subject;
                string Body = body;
                mail.Body = Body;
                mail.IsBodyHtml = true;

                //Instância smtp do servidor, neste caso o gmail.
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new System.Net.NetworkCredential
                ("paulo000natale", "P@ulo82929262");// Login e senha do e-mail.
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;

        }
    }
}
