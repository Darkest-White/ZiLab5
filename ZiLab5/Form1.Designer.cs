namespace AES256Encryption
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtKey; // Поле для ввода ключа
        private System.Windows.Forms.Label lblInput; // Метка для ввода текста
        private System.Windows.Forms.Label lblOutput; // Метка для вывода текста
        private System.Windows.Forms.Label lblKey; // Метка для ключа
        private System.Windows.Forms.Button btnClearInput; // Кнопка для очистки ввода
        private System.Windows.Forms.Button btnClearOutput; // Кнопка для очистки вывода
        private System.Windows.Forms.Button btnLoadFromFile; // Кнопка для загрузки текста из файла
        private System.Windows.Forms.Button btnSaveToFile; // Кнопка для сохранения текста в файл

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button(); // Инициализация кнопки для сохранения
            this.SuspendLayout();

            // 
            // lblInput
            // 
            this.lblInput.Location = new System.Drawing.Point(12, 12);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(360, 23);
            this.lblInput.Text = "Input text:";

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 38);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(360, 80);
            this.txtInput.TabIndex = 0;

            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(12, 118);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(110, 23);
            this.btnLoadFromFile.TabIndex = 7;
            this.btnLoadFromFile.Text = "Load from File";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);

            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(297, 118);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(75, 23);
            this.btnClearInput.TabIndex = 1;
            this.btnClearInput.Text = "Clear";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);

            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(12, 160);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(360, 23);
            this.lblKey.Text = "Input Key:";

            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 186);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(360, 23);
            this.txtKey.TabIndex = 2;
            this.txtKey.MaxLength = 32;
            this.txtKey.PlaceholderText = "Input Key";

            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(12, 212);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(360, 23);
            this.lblOutput.Text = "Encrypted text:";

            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 238);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(360, 80);
            this.txtOutput.TabIndex = 3;

            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(12, 324);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(110, 23);
            this.btnSaveToFile.TabIndex = 8;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);

            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(297, 324);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(75, 23);
            this.btnClearOutput.TabIndex = 4;
            this.btnClearOutput.Text = "Clear";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);

            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 353);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(93, 353);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 391);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "MainForm";
            this.Text = "AES-256";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtInput.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new System.Windows.Forms.SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, txtOutput.Text);
                }
            }
        }
    }
}
