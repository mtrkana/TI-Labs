using System.Text;

namespace ti_lab1
{
    public partial class Form1 : Form
    {
        VigenereAutokey vigenere = new VigenereAutokey();
        ColumnarTransposition columnar = new ColumnarTransposition();
        public Form1()
        {
            InitializeComponent();

            rtbInput.TextChanged += ToUpper_TextChanged;
            rtbResult.TextChanged += ToUpper_TextChanged;

            rbVigenere.Checked = true;
            UpdateKeyFields();

            rbVigenere.CheckedChanged += rbVigenere_CheckedChanged;
            rbColumnar.CheckedChanged += rbVigenere_CheckedChanged;
        }

        private void ToUpper_TextChanged(object sender, EventArgs e)
        {
            RichTextBox box = sender as RichTextBox;
            if (box == null) return;

            int cursor = box.SelectionStart;

            string upper = box.Text.ToUpper();

            if (box.Text != upper)
            {
                box.Text = upper;
                box.SelectionStart = cursor;
            }
        }
        private void UpdateKeyFields()
        {
            // Проверяем на null на случай, если элементы еще не инициализированы
            if (txtKey2 != null && rbVigenere != null && rbColumnar != null)
            {
                // Поле Ключ 2 активно только если выбрана радиокнопка Столбцового метода
                txtKey2.Enabled = rbColumnar.Checked;

                // Для наглядности можно также менять цвет поля
                if (txtKey2.Enabled)
                    txtKey2.BackColor = System.Drawing.Color.White;
                else
                    txtKey2.BackColor = System.Drawing.Color.LightGray;
            }
        }
        private void rbVigenere_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKeyFields();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string text = rtbInput.Text;
            string k1 = txtKey1.Text;
            string k2 = txtKey2.Text;

            if (string.IsNullOrEmpty(k1))
            {
                MessageBox.Show("Пожалуйста, введите ключ!");
                return;
            }

            if (rbVigenere.Checked)
            {
                rtbResult.Text = vigenere.Encrypt(text, k1);
            }
            else
            {
                if (string.IsNullOrEmpty(k2))
                {
                    MessageBox.Show("Для столбцового метода нужно два ключа!");
                    return;
                }
                rtbResult.Text = columnar.DoubleEncrypt(text, k1, k2);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string text = rtbInput.Text;
            string k1 = txtKey1.Text;
            string k2 = txtKey2.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Введите текст!");
                return;
            }

            if (string.IsNullOrWhiteSpace(k1))
            {
                MessageBox.Show("Введите первый ключ!");
                return;
            }

            try
            {
                if (rbVigenere.Checked)
                {
                    // Для Виженера нужен только один ключ
                    rtbResult.Text = vigenere.Decrypt(text, k1);
                }
                else
                {
                    // Для столбцового метода нужны оба ключа
                    if (string.IsNullOrWhiteSpace(k2))
                    {
                        MessageBox.Show("Для столбцового метода нужно два ключа!");
                        return;
                    }

                    rtbResult.Text = columnar.DoubleDecrypt(text, k1, k2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при расшифровке: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            rtbResult.Clear();
            txtKey1.Clear();
            txtKey2.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rtbInput.Text = File.ReadAllText(ofd.FileName, Encoding.Default);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось прочитать файл: " + ex.Message);
                    }
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbResult.Text))
            {
                MessageBox.Show("Нет результата для сохранения!");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовые файлы (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, rtbResult.Text, Encoding.Default);
                        MessageBox.Show("Файл успешно сохранен!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось сохранить файл: " + ex.Message);
                    }
                }
            }
        }
    }
}
