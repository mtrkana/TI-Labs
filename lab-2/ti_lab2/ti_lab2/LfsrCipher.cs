using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LFSR_App
{
    public class LfsrCipher
    {
        private uint _state;
        // Полином для 32-й степени (Вариант 10): x^32 + x^22 + x^2 + x^1 + 1
        // Индексы отводов: 31, 21, 1, 0
        private readonly int[] _taps = { 31, 21, 1, 0 };

        public LfsrCipher(string seed)
        {
            if (seed.Length != 32) throw new ArgumentException("Ключ должен быть 32 бита.");
            _state = Convert.ToUInt32(seed, 2);
            if (_state == 0) throw new ArgumentException("Начальное состояние не может быть нулевым.");
        }

        // Генерация одного байта гаммы (8 тактов регистра)
        private byte GetNextGammaByte()
        {
            byte result = 0;
            for (int i = 0; i < 8; i++)
            {
                // Вычисляем новый бит обратной связи
                uint newBit = 0;
                foreach (var tap in _taps)
                    newBit ^= (_state >> tap) & 1;

                // Выходной бит (самый правый)
                uint outputBit = _state & 1;

                // Сдвиг и вставка нового бита в 31-ю позицию
                _state = (_state >> 1) | (newBit << 31);

                // Формируем байт из выходящих битов
                result |= (byte)(outputBit << i);
            }
            return result;
        }

        // Генерирует строку из 0 и 1 для отображения сгенерированного ключа (гаммы)
        public string GenerateKeyString(int byteCount)
        {
            StringBuilder sb = new StringBuilder();
            // Сохраняем состояние, чтобы не испортить его перед шифрованием
            uint tempState = _state;

            for (int i = 0; i < byteCount; i++)
            {
                byte b = GetNextGammaByte();
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
            }

            _state = tempState; // Возвращаем состояние назад
            return sb.ToString();
        }

        // Основная функция шифрования/дешифрования
        public byte[] EncryptDecrypt(byte[] data)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ GetNextGammaByte());
            }
            return result;
        }

        // Статический метод для перевода любого массива байт в строку 0 и 1
        public static string ToBinaryString(byte[] data)
        {
            if (data == null) return "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(Convert.ToString(data[i], 2).PadLeft(8, '0') + " ");
                if ((i + 1) % 8 == 0) sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}