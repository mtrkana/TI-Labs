using System;
using System.Text;

public class VigenereAutokey
{
    // Наш рабочий алфавит
    private const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

    // Вспомогательный метод для поиска индекса буквы (вместо IndexOf)
    private int GetAlphabetIndex(char c)
    {
        for (int i = 0; i < Alphabet.Length; i++)
        {
            if (Alphabet[i] == c) return i;
        }
        return -1; // Если символ не найден
    }

    // Метод для очистки текста (вместо LINQ)
    private string PrepareText(string input)
    {
        StringBuilder sb = new StringBuilder();
        string upperInput = input.ToUpper();

        for (int i = 0; i < upperInput.Length; i++)
        {
            if (GetAlphabetIndex(upperInput[i]) != -1)
            {
                sb.Append(upperInput[i]);
            }
        }
        return sb.ToString();
    }

    public string Encrypt(string message, string key)
    {
        string T = PrepareText(message);
        string K = PrepareText(key);

        if (T.Length == 0 || K.Length == 0)
            return "Ошибка: пустой текст или ключ";

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < T.Length; i++)
        {
            // Находим индекс буквы сообщения
            int mIndex = GetAlphabetIndex(T[i]);

            // Находим индекс буквы ключа
            // Если i меньше длины начального ключа — берем из K
            // Если больше — берем из самого сообщения T (самогенерирующийся ключ)
            int kIndex;
            if (i < K.Length)
            {
                kIndex = GetAlphabetIndex(K[i]);
            }
            else
            {
                // По условию: последующие символы ключа — это исходный текст
                kIndex = GetAlphabetIndex(T[i - K.Length]);
            }

            // Шифрование
            int cIndex = (mIndex + kIndex) % Alphabet.Length;
            result.Append(Alphabet[cIndex]);
        }

        return result.ToString();
    }

    public string Decrypt(string cipherText, string key)
    {
        string C = PrepareText(cipherText);
        string K = PrepareText(key);

        if (C.Length == 0 || K.Length == 0)
            return "Ошибка: нечего дешифровать";

        StringBuilder result = new StringBuilder();

        // Массив для хранения расшифрованных символов (чтобы использовать их в ключе)
        char[] decryptedChars = new char[C.Length];

        for (int i = 0; i < C.Length; i++)
        {
            int cIndex = GetAlphabetIndex(C[i]);

            int kIndex;
            if (i < K.Length)
            {
                kIndex = GetAlphabetIndex(K[i]);
            }
            else
            {
                // Берем уже расшифрованный нами ранее символ
                kIndex = GetAlphabetIndex(decryptedChars[i - K.Length]);
            }

            // Дешифрование
            int mIndex = (cIndex - kIndex + Alphabet.Length) % Alphabet.Length;
            decryptedChars[i] = Alphabet[mIndex];
            result.Append(Alphabet[mIndex]);
        }

        return result.ToString();
    }
}