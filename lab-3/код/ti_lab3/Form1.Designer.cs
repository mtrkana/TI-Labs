namespace ti_lab3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtP = new TextBox();
            txtX = new TextBox();
            txtK = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            btnFind = new Button();
            label4 = new Label();
            ComboBox = new ComboBox();
            label5 = new Label();
            btnEnc = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 59);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 0;
            label1.Text = "P";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 195);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 199);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 2;
            label3.Text = "K";
            // 
            // txtP
            // 
            txtP.Location = new Point(127, 56);
            txtP.Name = "txtP";
            txtP.Size = new Size(125, 27);
            txtP.TabIndex = 3;
            // 
            // txtX
            // 
            txtX.Location = new Point(61, 192);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 4;
            // 
            // txtK
            // 
            txtK.Location = new Point(246, 192);
            txtK.Name = "txtK";
            txtK.Size = new Size(125, 27);
            txtK.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, очиститьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
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
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(87, 24);
            очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(354, 48);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(257, 42);
            btnFind.TabIndex = 7;
            btnFind.Text = "Найти первообразные корни";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 117);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 8;
            label4.Text = "G";
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(104, 114);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(151, 28);
            ComboBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 121);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 10;
            label5.Text = "Найдено корней:";
            // 
            // btnEnc
            // 
            btnEnc.Location = new Point(466, 184);
            btnEnc.Name = "btnEnc";
            btnEnc.Size = new Size(145, 42);
            btnEnc.TabIndex = 12;
            btnEnc.Text = "Шифровать";
            btnEnc.UseVisualStyleBackColor = true;
            btnEnc.Click += btnEnc_Click;
            // 
            // button1
            // 
            button1.Location = new Point(611, 184);
            button1.Name = "button1";
            button1.Size = new Size(145, 42);
            button1.TabIndex = 13;
            button1.Text = "Дешифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 254);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(719, 165);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(btnEnc);
            Controls.Add(label5);
            Controls.Add(ComboBox);
            Controls.Add(label4);
            Controls.Add(btnFind);
            Controls.Add(txtK);
            Controls.Add(txtX);
            Controls.Add(txtP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtP;
        private TextBox txtX;
        private TextBox txtK;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private Button btnFind;
        private Label label4;
        private ComboBox ComboBox;
        private Label label5;
        private Button btnEnc;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}
