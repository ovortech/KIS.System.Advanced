using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace KIS.System.Advanced.Support.Email
{
    public class EmailManagement
    {
        public EmailManagement()
        {

        }

        public static bool Send(String from, String to, String subject, String body)
        {
            bool IsSend = false;
            try
            {
                using (MailMessage mailMessage = new MailMessage(from, to, subject, body))
                {
                    mailMessage.IsBodyHtml = true;
                    using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.EnableSsl = true;
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.Credentials = new NetworkCredential("ovortech@gmail.com", "vnfe24m#ads");
                                                
                        smtpClient.Send(mailMessage);
                    }
                }

                IsSend = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsSend;
        }
    }
}
