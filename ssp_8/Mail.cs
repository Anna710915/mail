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
                    MailAddress to = new MailAddress(address);
                    MailMessage message = new MailMessage(from, to);

                    message.Subject = mailEntry.header;
                    message.Body = mailEntry.body;

                    if(mailEntry.filePath != null && mailEntry.filePath != "")
                    {
                        message.Attachments.Add(new Attachment(mailEntry.filePath));
                    }
                    

                    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
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
