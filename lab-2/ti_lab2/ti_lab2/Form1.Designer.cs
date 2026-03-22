namespace ti_lab2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFile = new RichTextBox();
            txtKeyBin = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            txtSeed = new TextBox();
            label4 = new Label();
            txtResultBin = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(808, 73);
            button1.Name = "button1";
            button1.Size = new Size(271, 46);
            button1.TabIndex = 0;
            button1.Text = "шифровать/дешифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 80);
            label1.Name = "label1";
            label1.Size = new Size(195, 27);
            label1.TabIndex = 3;
            label1.Text = "Состояние регистра";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 153);
            label2.Name = "label2";
            label2.Size = new Size(156, 27);
            label2.TabIndex = 4;
            label2.Text = "Исходный текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 375);
            label3.Name = "label3";
            label3.Size = new Size(231, 27);
            label3.TabIndex = 5;
            label3.Text = "Сгенерированный ключ";
            // 
            // txtFile
            // 
            txtFile.Location = new Point(24, 183);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(484, 174);
            txtFile.TabIndex = 6;
            txtFile.Text = "";
            // 
            // txtKeyBin
            // 
            txtKeyBin.Location = new Point(24, 405);
            txtKeyBin.Name = "txtKeyBin";
            txtKeyBin.Size = new Size(484, 174);
            txtKeyBin.TabIndex = 7;
            txtKeyBin.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(166, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(225, 80);
            txtSeed.MaxLength = 32;
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(554, 34);
            txtSeed.TabIndex = 9;
            txtSeed.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(563, 153);
            label4.Name = "label4";
            label4.Size = new Size(216, 27);
            label4.TabIndex = 10;
            label4.Text = "Зашифрованный текст";
            // 
            // txtResultBin
            // 
            txtResultBin.Location = new Point(563, 183);
            txtResultBin.Name = "txtResultBin";
            txtResultBin.Size = new Size(493, 396);
            txtResultBin.TabIndex = 11;
            txtResultBin.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1100, 608);
            Controls.Add(txtResultBin);
            Controls.Add(label4);
            Controls.Add(txtSeed);
            Controls.Add(txtKeyBin);
            Controls.Add(txtFile);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox txtFile;
        private RichTextBox txtKeyBin;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private TextBox txtSeed;
        private Label label4;
        private RichTextBox txtResultBin;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
