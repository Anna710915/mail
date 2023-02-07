using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace ssp_8
{
    class Mail
    {
        private String MailFrom = "anna.merkul@bk.ru";
        private String Name = "Anonymous";

        public void Send(MailEntry mailEntry)
        {
            try
            {
                foreach (String address in mailEntry.getAddresses())
                {
                    MailAddress from = new MailAddress(MailFrom, Name);
                    // кому отправляем
                    MailAddress to = new MailAddress(address);
                    // создаем объект сообщения
                    MailMessage message = new MailMessage(from, to);
                    // тема письма
                    message.Subject = mailEntry.header;
                    // текст письма
                    message.Body = mailEntry.body;
                    // адрес smtp-сервера и порт, с которого будем отправлять письмо
                    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                    // логин и пароль
                    smtp.Credentials = new NetworkCredential("anna.merkul@bk.ru", "aRVJtxbGRUDkbyeDiph2");
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                    MessageBox.Show("Send mail to " + address);
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
