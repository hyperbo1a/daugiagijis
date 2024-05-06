using System;
using System.Diagnostics;
using System.Threading;

public class MatricuSkaiciavimas
{
    public MatricuSkaiciavimas()
    {
        // Konstruktorius
    }

    // Metodas, skirtas padauginti du masyvus
    internal int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
    {
        // Gauti matricų matmenis
        int x1 = firstMatrix.GetLength(0); // Pirmojo masyvo eilučių skaičius
        int y1 = firstMatrix.GetLength(1); // Pirmojo masyvo stulpelių skaičius
        int x2 = secondMatrix.GetLength(0); // Antrojo masyvo eilučių skaičius
        int y2 = secondMatrix.GetLength(1); // Antrojo masyvo stulpelių skaičius

        // Inicializuojamas rezultato masyvas
        int[,] ResultMatrix = new int[x1, y2];

        // Patikrinama, ar galima padauginti matricas
        if (y1 != x2)
        {
            throw new Exception("Matricos negali būti padaugintos");
        }

        // Matricų daugybą vykdoma naudojant kelių gijų (threads) technologiją
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        Thread[] threads = new Thread[x1]; // Sukuriamas masyvas gijų (threads)

        // Kiekvienai pirmosios matricos eilutei sukuriamos atskiros gijos, kurios vykdo daugybą
        for (int i = 0; i < x1; i++)
        {
            int x = i; // Saugoma eilutės indeksas, kad jis būtų pasiekiamas vidinėje gijos srityje
            threads[i] = new Thread(() =>
            {
                // Dauginama kiekviena eilutė i-tame stulpelyje ir saugomas rezultatas
                for (int j = 0; j < y2; j++)
                {
                    ResultMatrix[x, j] = MultiplyRowByColumn(firstMatrix, secondMatrix, x, j);
                }
            });
            threads[i].Start(); // Paleidžiama gija
        }

        // Palaukiama, kol visos gijos baigs darbą
        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed; // Apskaičiuojamas praejęs laikas
        stopwatch.Reset();

        return ResultMatrix; // Grąžinamas padaugintų matricų rezultatas
    }

    // Metodas, skirtas padauginti konkretų pirmosios matricos eilutę su antrojo masyvo stulpeliu
    private int MultiplyRowByColumn(int[,] firstMatrix, int[,] secondMatrix, int rowIndex, int columnIndex)
    {
        int result = 0;

        // Vykdant matricų daugybą, kiekvienas pirmojo masyvo stulpelio elementas dauginamas su antrojo masyvo stulpelio elementu ir pridedamas prie rezultato
        for (int i = 0; i < firstMatrix.GetLength(1); i++)
        {
            result += firstMatrix[rowIndex, i] * secondMatrix[i, columnIndex];
        }

        return result; // Grąžinamas daugybų rezultatas
    }
}
