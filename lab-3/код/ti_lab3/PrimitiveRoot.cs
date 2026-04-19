using System;
using System.Collections.Generic;

public static class PrimitiveRoot
{
    // Быстрое возведение в степень по модулю
    public static long ModPow(long baseVal, long exp, long mod)
    {
        long result = 1;
        baseVal %= mod;

        while (exp > 0)
        {
            if (exp % 2 == 1)
                result = (result * baseVal) % mod;

            baseVal = (baseVal * baseVal) % mod;
            exp /= 2;
        }

        return result;
    }

    // Поиск простых делителей числа
    public static List<int> GetPrimeFactors(int n)
    {
        List<int> factors = new List<int>();

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                factors.Add(i);
                while (n % i == 0)
                    n /= i;
            }
        }

        if (n > 1)
            factors.Add(n);

        return factors;
    }

    // Проверка на первообразный корень
    public static bool IsPrimitiveRoot(int g, int p, List<int> factors)
    {
        int phi = p - 1;

        foreach (int q in factors)
        {
            if (ModPow(g, phi / q, p) == 1)
                return false;
        }

        return true;
    }

    // Главная функция — найти ВСЕ корни
    public static List<int> FindAllPrimitiveRoots(int p)
    {
        List<int> roots = new List<int>();

        int phi = p - 1;
        List<int> factors = GetPrimeFactors(phi);

        for (int g = 2; g < p; g++)
        {
            if (IsPrimitiveRoot(g, p, factors))
            {
                roots.Add(g);
            }
        }

        return roots;
    }
}