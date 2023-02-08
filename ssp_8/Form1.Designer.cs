
namespace ssp_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAddresses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHeaders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attachedFile = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxAddresses
            // 
            this.textBoxAddresses.Location = new System.Drawing.Point(50, 48);
            this.textBoxAddresses.Name = "textBoxAddresses";
            this.textBoxAddresses.Size = new System.Drawing.Size(977, 26);
            this.textBoxAddresses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адресаты (ввод через запятую, без пробелов)";
            // 
            // textBoxHeaders
            // 
            this.textBoxHeaders.Location = new System.Drawing.Point(50, 118);
            this.textBoxHeaders.Name = "textBoxHeaders";
            this.textBoxHeaders.Size = new System.Drawing.Size(977, 26);
            this.textBoxHeaders.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заголовок";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(51, 196);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(976, 351);
            this.textBoxBody.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тело";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // attachedFile
            // 
            this.attachedFile.AutoSize = true;
            this.attachedFile.Location = new System.Drawing.Point(210, 575);
            this.attachedFile.Name = "attachedFile";
            this.attachedFile.Size = new System.Drawing.Size(178, 20);
            this.attachedFile.TabIndex = 7;
            this.attachedFile.Text = "Прикрепленный файл";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Открепить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(876, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Отправить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Прикрепить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(595, 575);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(193, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Зашифровать файл";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 618);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.attachedFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHeaders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddresses);
            this.Name = "Form1";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddresses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeaders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label attachedFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

