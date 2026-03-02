namespace ti_lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEncrypt = new Button();
            rbColumnar = new RadioButton();
            rbVigenere = new RadioButton();
            btnDecrypt = new Button();
            btnClear = new Button();
            btnOpenFile = new Button();
            txtKey2 = new TextBox();
            txtKey1 = new TextBox();
            rtbInput = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rtbResult = new RichTextBox();
            btnSaveFile = new Button();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI", 14F);
            btnEncrypt.Location = new Point(620, 413);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(250, 43);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Шифровать";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // rbColumnar
            // 
            rbColumnar.AutoSize = true;
            rbColumnar.Font = new Font("Segoe UI", 14F);
            rbColumnar.Location = new Point(349, 72);
            rbColumnar.Name = "rbColumnar";
            rbColumnar.Size = new Size(247, 36);
            rbColumnar.TabIndex = 1;
            rbColumnar.TabStop = true;
            rbColumnar.Text = "Столбцовый метод";
            rbColumnar.UseVisualStyleBackColor = true;
            // 
            // rbVigenere
            // 
            rbVigenere.AutoSize = true;
            rbVigenere.Font = new Font("Segoe UI", 14F);
            rbVigenere.Location = new Point(51, 72);
            rbVigenere.Name = "rbVigenere";
            rbVigenere.Size = new Size(260, 36);
            rbVigenere.TabIndex = 2;
            rbVigenere.TabStop = true;
            rbVigenere.Text = "Алгоритм Виженера";
            rbVigenere.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI", 14F);
            btnDecrypt.Location = new Point(620, 489);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(250, 43);
            btnDecrypt.TabIndex = 3;
            btnDecrypt.Text = "Дешифровать";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14F);
            btnClear.Location = new Point(620, 183);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 43);
            btnClear.TabIndex = 4;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("Segoe UI", 14F);
            btnOpenFile.Location = new Point(620, 38);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(250, 43);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "Прочитать из файла";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // txtKey2
            // 
            txtKey2.CharacterCasing = CharacterCasing.Upper;
            txtKey2.Location = new Point(279, 350);
            txtKey2.Name = "txtKey2";
            txtKey2.Size = new Size(201, 27);
            txtKey2.TabIndex = 6;
            // 
            // txtKey1
            // 
            txtKey1.CharacterCasing = CharacterCasing.Upper;
            txtKey1.Location = new Point(50, 350);
            txtKey1.Name = "txtKey1";
            txtKey1.Size = new Size(201, 27);
            txtKey1.TabIndex = 7;
            // 
            // rtbInput
            // 
            rtbInput.Location = new Point(50, 195);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(430, 84);
            rtbInput.TabIndex = 8;
            rtbInput.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(50, 160);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 9;
            label1.Text = "Исходный текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(50, 315);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 10;
            label2.Text = "Ключ 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(279, 315);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 11;
            label3.Text = "Ключ 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(50, 413);
            label4.Name = "label4";
            label4.Size = new Size(120, 32);
            label4.TabIndex = 12;
            label4.Text = "Результат";
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(50, 448);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(430, 84);
            rtbResult.TabIndex = 13;
            rtbResult.Text = "";
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("Segoe UI", 14F);
            btnSaveFile.Location = new Point(620, 111);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(250, 43);
            btnSaveFile.TabIndex = 14;
            btnSaveFile.Text = "Сохранить в файл";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(925, 579);
            Controls.Add(btnSaveFile);
            Controls.Add(rtbResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbInput);
            Controls.Add(txtKey1);
            Controls.Add(txtKey2);
            Controls.Add(btnOpenFile);
            Controls.Add(btnClear);
            Controls.Add(btnDecrypt);
            Controls.Add(rbVigenere);
            Controls.Add(rbColumnar);
            Controls.Add(btnEncrypt);
            Name = "Form1";
            Text = "ТИ ЛР-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private RadioButton rbColumnar;
        private RadioButton rbVigenere;
        private Button btnDecrypt;
        private Button btnClear;
        private Button btnOpenFile;
        private TextBox txtKey2;
        private TextBox txtKey1;
        private RichTextBox rtbInput;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox rtbResult;
        private Button btnSaveFile;
    }
}
