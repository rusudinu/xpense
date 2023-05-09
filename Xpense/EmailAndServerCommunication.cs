using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Xpense
{
    class EmailAndServerCommunication
    {
        private void send_mail(string subject, string username, string name, string errorDetails, string complains, string userUsername)
        {
          

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("dddecarmailbot@gmail.com");
            mail.To.Add("dinustefan89.ds@gmail.com");
            mail.Subject = subject;



           // mail.Body = Convert.ToString(DateTime.Now) + '\n' + '\n' + "Username : " + username + '\n' + '\n' + "True username in app : " + CurrentUserData.currentUsername + '\n' + '\n' + "Name : " + name + '\n' + '\n' + "Error details :" + '\n' + errorDetails + '\n' + '\n' + "Complains : " + '\n' + complains;
           //Attachment attachment;
           // attachment = new System.Net.Mail.Attachment( document location );
          //  mail.Attachments.Add(attachment);


            SmtpServer.Port = 587;

            SmtpServer.Credentials = new System.Net.NetworkCredential("dddecarmailbot@gmail.com", "dinu8989");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
          
        }

    }
}
