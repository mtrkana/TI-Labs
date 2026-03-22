using LFSR_App;
using System.Text;

namespace ti_lab2
{
    
    public partial class Form1 : Form
    {
        private string _selectedFilePath = "";
    
        private byte[] _lastProcessedData;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только '0' и '1'
            if (e.KeyChar != '0' && e.KeyChar != '1')
            {
                // Разрешаем клавишу Backspace (код 8), чтобы пользователь мог стирать ошибки
                if (e.KeyChar != (char)Keys.Back)
                {
                    // Устанавливаем Handled в true, чтобы событие не обрабатывалось дальше 
                    // (символ не будет напечатан)
                    e.Handled = true;
                }
            }
        }

        public byte[] ReadFileToBytes(string filePath)
        {
            // Проверяем, существует ли файл, чтобы программа не вылетела
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден по указанному пути.");

            // Читаем всё содержимое как поток байтов
            return File.ReadAllBytes(filePath);
        }

        public string ConvertBytesToBinaryString(byte[] data)
        {
            if (data == null || data.Length == 0) return "Файл пуст";

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                // Переводим байт в 8 бит
                sb.Append(Convert.ToString(data[i], 2).PadLeft(8, '0'));

                // Разделитель для читаемости
                sb.Append(" ");

                // Красивый перенос строки каждые 8 байт
                if ((i + 1) % 8 == 0)
                    sb.AppendLine();
            }

            return sb.ToString();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Все файлы (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedFilePath = ofd.FileName;
                    // 1. Читаем данные в локальную переменную метода
                    byte[] fileData = ReadFileToBytes(ofd.FileName);

                    // 2. Преобразуем и выводим в окно
                    txtFile.Text = ConvertBytesToBinaryString(fileData);

                    // 3. (Опционально) Если нужно сразу зашифровать, 
                    // передаем fileData дальше в метод шифрования
                    // ProcessEncryption(fileData); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
       
        {
            if (string.IsNullOrEmpty(_selectedFilePath))
            {
                MessageBox.Show("Сначала выберите файл!");
                return;
            }

            if (txtSeed.Text.Length != 32)
            {
                MessageBox.Show("Регистр должен содержать 32 символа (0 и 1)!");
                return;
            }

            try
            {
                byte[] inputBytes = File.ReadAllBytes(_selectedFilePath);
                LfsrCipher cipher = new LfsrCipher(txtSeed.Text);

                // 1. Генерируем и выводим ключ (гамму) в третье поле
                // Генерируем гамму такой же длины, как и файл
                txtKeyBin.Text = cipher.GenerateKeyString(inputBytes.Length);

                // 2. Шифруем и выводим результат в четвертое поле
                _lastProcessedData = cipher.EncryptDecrypt(inputBytes);
                txtResultBin.Text = LfsrCipher.ToBinaryString(_lastProcessedData);

                MessageBox.Show("Шифрование завершено успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке: " + ex.Message);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
            if (_lastProcessedData == null)
            {
                MessageBox.Show("Нет данных для сохранения!");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Все файлы (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, _lastProcessedData);
                    MessageBox.Show("Файл сохранен!");
                }
            }
        }
    }

}
