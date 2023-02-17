using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int n, i, j;

        Console.Write("Qual a ordem da matriz? ");
        n = int.Parse(Console.ReadLine());

        double[,] mat = new double[n, n];

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write("Elemento [" + i + " , " + j + "]: ");
                mat[i, j] = double.Parse(Console.ReadLine(), CI);
            }
        }

        double somaPosi = 0;
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (mat[i, j] > 0)
                {
                    somaPosi += mat[i, j];
                }
            }
        }

        Console.WriteLine("\nSOMA DOS POSITIVOS --> " + somaPosi.ToString("F1", CI));

        // imprimindo uma linha
        int linha;
        Console.Write("Escolha uma linha: ");
        linha = int.Parse(Console.ReadLine());
        Console.Write("LINHA ESCOLHIDA --> ");
        for (i = 0; i < n; i++)
        {
            Console.Write(mat[linha, i].ToString("F1", CI) + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        // imprimindo uma coluna
        int coluna;
        Console.Write("Digite uma coluna: ");
        coluna = int.Parse(Console.ReadLine());
        Console.Write("LINHA COLUNA --> ");
        for (i = 0; i < n; i++)
        {
            Console.Write(mat[i, coluna].ToString("F1", CI) + " ");
        }

        // diagonal principal
        Console.Write("\n\nDIAGONAL PRINCIPAL --> ");
        for(i = 0; i < n; i++)
        {
            Console.Write(mat[i, i].ToString("F1", CI) + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        // matriz alterada, todos números negativos^2
        Console.WriteLine("MATRIZ ALTERADA: ");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (mat[i, j] < 2)
                {
                    mat[i, j] = Math.Pow(mat[i, j], 2);
                }

                Console.Write(mat[i, j].ToString("F1", CI) + " ");
            }
            Console.WriteLine();
        }

    }
}