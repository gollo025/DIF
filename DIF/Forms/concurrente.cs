using System;
using System.Diagnostics;
using System.Threading;

namespace DIF
{
    public class Concurrente
    {
        private static int sumaTotal = 0;
        private static readonly object lockObject = new object();

        public static string Ejecutar(int N, int M)
        {
            int rango = N / M;
            Thread[] hilos = new Thread[M];
            sumaTotal = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < M; i++)
            {
                int inicio = i * rango + 1;
                int fin = (i == M - 1) ? N : inicio + rango - 1;
                hilos[i] = new Thread(CalcularPrimos);
                hilos[i].Start((inicio, fin));
            }

            foreach (var hilo in hilos)
            {
                hilo.Join();
            }

            stopwatch.Stop();

            return $"Suma total de números primos hasta {N}: {sumaTotal}\n" +
                   $"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
        }

        private static void CalcularPrimos(object rango)
        {
            (int inicio, int fin) = ((int, int))rango;
            int suma = 0;

            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    suma += i;
                }
            }

            lock (lockObject)
            {
                sumaTotal += suma;
            }
        }

        private static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
