using System;
using System.Text;

public class ColumnarTransposition
{
    private const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

    // =========================
    // Нормализация текста
    // =========================
    private string Normalize(string input)
    {
        input = input.ToUpper();
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (Alphabet.Contains(c))
                sb.Append(c);
        }

        return sb.ToString();
    }

    // =========================
    // Получение порядка столбцов
    // =========================
    private int[] GetColumnOrder(string key)
    {
        key = Normalize(key);

        int len = key.Length;
        int[] order = new int[len];
        bool[] used = new bool[len];

        for (int i = 0; i < len; i++)
        {
            int minIndex = -1;

            for (int j = 0; j < len; j++)
            {
                if (!used[j])
                {
                    if (minIndex == -1 ||
                        Alphabet.IndexOf(key[j]) < Alphabet.IndexOf(key[minIndex]))
                    {
                        minIndex = j;
                    }
                }
            }

            order[i] = minIndex;
            used[minIndex] = true;
        }

        return order;
    }

    // =========================
    // ШИФРОВАНИЕ (строгая классика)
    // =========================
    public string Encrypt(string text, string key)
    {
        string t = Normalize(text);
        string k = Normalize(key);

        if (t.Length == 0 || k.Length == 0)
            return "";

        int cols = k.Length;
        int rows = (int)Math.Ceiling((double)t.Length / cols);
        int[] order = GetColumnOrder(k);

        StringBuilder result = new StringBuilder();

        // Чтение по столбцам
        for (int kIdx = 0; kIdx < cols; kIdx++)
        {
            int col = order[kIdx];

            for (int r = 0; r < rows; r++)
            {
                int pos = r * cols + col;

                if (pos < t.Length)
                    result.Append(t[pos]);
            }
        }

        return result.ToString();
    }

    // =========================
    // РАСШИФРОВКА (строгая классика)
    // =========================
    public string Decrypt(string cipher, string key)
    {
        string c = Normalize(cipher);
        string k = Normalize(key);

        if (c.Length == 0 || k.Length == 0)
            return "";

        int cols = k.Length;
        int rows = (int)Math.Ceiling((double)c.Length / cols);
        int remainder = c.Length % cols;

        int[] order = GetColumnOrder(k);
        char[] result = new char[c.Length];

        int index = 0;

        for (int kIdx = 0; kIdx < cols; kIdx++)
        {
            int col = order[kIdx];

            int colLength = rows;

            if (remainder != 0 && col >= remainder)
                colLength--;

            for (int r = 0; r < colLength; r++)
            {
                int pos = r * cols + col;

                if (pos < result.Length)
                    result[pos] = c[index++];
            }
        }

        return new string(result);
    }

    // =========================
    // Двойное шифрование
    // =========================
    public string DoubleEncrypt(string text, string k1, string k2)
    {
        return Encrypt(Encrypt(text, k1), k2);
    }

    // =========================
    // Двойная расшифровка
    // =========================
    public string DoubleDecrypt(string text, string k1, string k2)
    {
        return Decrypt(Decrypt(text, k2), k1);
    }
}