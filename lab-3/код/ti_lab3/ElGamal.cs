using System;
using System.IO;

public static class ElGamal
{
    static Random rnd = new Random();

    // 🔹 ШИФРОВАНИЕ (по 2 байта)
    public static void EncryptFile(string inputFile, string outputFile, int p, int g, int x, int k, Action<string> output)
    {
        long y = PrimitiveRoot.ModPow(g, x, p);

        byte[] data = File.ReadAllBytes(inputFile);

        bool isFirst = true;

        using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Create)))
        {
            for (int i = 0; i < data.Length; i += 2)
            {
                ushort m;

                // собираем 2 байта в одно число
                if (i + 1 < data.Length)
                    m = (ushort)((data[i] << 8) | data[i + 1]);
                else
                    m = (ushort)(data[i] << 8); // если нечётное количество байт

                int currentK;

                if (isFirst)
                {
                    currentK = k;
                    isFirst = false;
                }
                else
                {
                    currentK = rnd.Next(2, p - 1);
                }

                long a = PrimitiveRoot.ModPow(g, currentK, p);
                long b = (PrimitiveRoot.ModPow(y, currentK, p) * m) % p;

                // вывод
                output?.Invoke($"({a},{b}) ");

                // записываем как int (4 байта)
                writer.Write((int)a);
                writer.Write((int)b);
            }
        }
    }

    // 🔹 ДЕШИФРОВАНИЕ
    public static void DecryptFile(string inputFile, string outputFile, int p, int x, Action<string> output)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(inputFile, FileMode.Open)))
        using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Create)))
        {
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                int a = reader.ReadInt32();
                int b = reader.ReadInt32();

                // m = b * a^(p-1-x) mod p
                long ax = PrimitiveRoot.ModPow(a, p - 1 - x, p);
                long m = (b * ax) % p;

                // разбиваем обратно в 2 байта
                byte high = (byte)(m >> 8);
                byte low = (byte)(m & 0xFF);

                writer.Write(high);
                writer.Write(low);

                // вывод
                output?.Invoke(m + " ");
            }
        }
    }
}