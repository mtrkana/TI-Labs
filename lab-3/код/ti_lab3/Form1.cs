using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ti_lab3
{
    public partial class Form1 : Form
    {
        string inputFilePath;
        string outputFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2)
                return true;

            if (n % 2 == 0)
                return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            ComboBox.Items.Clear();

            int p;

            if (!int.TryParse(txtP.Text, out p))
            {
                MessageBox.Show("Введите корректное число p");
                return;
            }

            if (!IsPrime(p))
            {
                MessageBox.Show("Число p должно быть простым!");
                return;
            }

            var roots = PrimitiveRoot.FindAllPrimitiveRoots(p);

            foreach (var g in roots)
            {
                ComboBox.Items.Add(g);
            }

            label5.Text = "Найдено корней : " + roots.Count;
        }

        private void btnEnc_Click(object sender, EventArgs e)
      
        {
            int p, x, k, g;

            if (!int.TryParse(txtP.Text, out p))
            {
                MessageBox.Show("Введите p");
                return;
            }

            if (ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите g");
                return;
            }
            g = Convert.ToInt32(ComboBox.SelectedItem);

            if (!int.TryParse(txtX.Text, out x) || x <= 1 || x >= p - 1)
            {
                MessageBox.Show("Некорректное x");
                return;
            }

            if (!int.TryParse(txtK.Text, out k) || k <= 1 || k >= p - 1)
            {
                MessageBox.Show("Некорректное k");
                return;
            }

            if (string.IsNullOrEmpty(inputFilePath))
            {
                MessageBox.Show("Сначала выберите файл!");
                return;
            }

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            outputFilePath = saveFileDialog1.FileName;

            richTextBox1.Clear();

            ElGamal.EncryptFile(
                inputFilePath,
                outputFilePath,
                p, g, x, k,
                s => richTextBox1.AppendText(s)
            );
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
       
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            int p, x;

            // p
            if (!int.TryParse(txtP.Text, out p))
            {
                MessageBox.Show("Введите p");
                return;
            }

            // x
            if (!int.TryParse(txtX.Text, out x) || x <= 1 || x >= p - 1)
            {
                MessageBox.Show("Некорректное x");
                return;
            }

            // выбрать зашифрованный файл
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string inputFilePath = openFileDialog1.FileName;

            // выбрать куда сохранить
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string outputFilePath = saveFileDialog1.FileName;

            // 🔥 ВОТ СЮДА
            richTextBox1.Clear();

            ElGamal.DecryptFile(
                inputFilePath,
                outputFilePath,
                p, x,
                s => richTextBox1.AppendText(s)
            );
        }
    }
}
