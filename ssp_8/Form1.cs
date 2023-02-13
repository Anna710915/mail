using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssp_8
{
    public partial class Form1 : Form
    {
        private Mail mail = new Mail();
        private String filePath = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAddresses.Text.Length > 255)
                {
                    throw new Exception("Addresses length is more than 255");
                }
                else if (String.IsNullOrWhiteSpace(textBoxAddresses.Text))
                {
                    throw new Exception("Addresses mustn't be empty");
                }
                if (textBoxHeaders.Text.Length > 255)
                {
                    throw new Exception("Headers length is more than 255");
                }
                else if (String.IsNullOrWhiteSpace(textBoxHeaders.Text))
                {
                    throw new Exception("Header mustn't be empty");
                }
                if (textBoxBody.Text.Length > 1000)
                {
                    throw new Exception("Body length is more than 1000");
                }

                String[] addresses = textBoxAddresses.Text.Trim().Split(',');
                
               
                List<String> newAddresses = new List<String>();
                for (int i = 0; i < addresses.Length; i++)
                {
                    if (!String.IsNullOrWhiteSpace(addresses[i]))
                    {
                        newAddresses.Add(addresses[i]);
                    }
                }

                if (newAddresses.Count == 0)
                {
                    throw new Exception("Invalid addresses");
                }

                String header = textBoxHeaders.Text;
                String body = textBoxBody.Text;

                MailEntry mailEntry = new MailEntry();
                mailEntry.header = header;
                mailEntry.body = body;
                mailEntry.setAddresses(newAddresses);

                if (filePath != "")
                {
                    if (!filePath.EndsWith(".txt"))
                    {
                        throw new Exception("Invalid file extenssion");
                    }
                    mailEntry.filePath = filePath;
                    mailEntry.encrypt = checkBoxEncrypt.Checked;
                }

                mail.Send(mailEntry);
                filePath = "";
                attachedFile.Text = "";
                textBoxAddresses.Text = "";
                textBoxHeaders.Text = "";
                textBoxBody.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            int index = filename.LastIndexOf('\u005C');
            attachedFile.Text = filename.Substring(index + 1);
            filePath = filename;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attachedFile.Text = "";
            filePath = "";
        }

        private void checkBoxEncrypt_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
