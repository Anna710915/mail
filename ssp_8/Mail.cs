using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;


namespace ssp_8
{

    class Mail
    {
        private String MailFrom = "anna.merkul@bk.ru";
        private String Name = "Anonymous";

        byte[] abc;
        byte[,] table;

        public Mail()
        {
            abc = new byte[256];

            for (int i = 0; i < 256; i++)
            {
                abc[i] = Convert.ToByte(i);
            }

            table = new byte[256, 256];

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }
            }

        }

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
                        if(mailEntry.encrypt)
                        {
                            mailEntry.filePath = encrypt(mailEntry.filePath);
                        }
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

        private String encrypt(String filePath)
        {
            String newFileName = "";
            try
            {
                byte[] fileContent = File.ReadAllBytes(filePath);
                byte[] passwordTmp = Encoding.ASCII.GetBytes("pass");
                byte[] keys = new byte[fileContent.Length];

                for(int i = 0; i < fileContent.Length; i++)
                {
                    keys[i] = passwordTmp[i % passwordTmp.Length];
                }

                byte[] result = new byte[fileContent.Length];

                for(int i = 0; i < fileContent.Length; i++)
                {
                    byte value = fileContent[i];
                    byte key = keys[i];
                    int valueIndex = -1, keyIndex = -1;

                    for(int j = 0; j < 256; j++)
                    {
                        if(abc[j] == value)
                        {
                            valueIndex = j;
                            break;
                        }
                    }

                    for (int j = 0; j < 256; j++)
                    {
                        if (abc[j] == key)
                        { 
                            keyIndex = j;
                            break;
                        }
                    }

                    result[i] = table[keyIndex, valueIndex];
                }

                String fileExtention = Path.GetExtension(filePath);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Files (*" + fileExtention + ") | *" + fileExtention;

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, result);
                    newFileName = saveFileDialog.FileName;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return newFileName;
        }

    }
}
