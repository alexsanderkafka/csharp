
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int n, i;

        Console.Write("Quantos numeros voce vai digitar? ");
        n = int.Parse(Console.ReadLine());

        double[] num = new double[n];

        for (i = 0; i < n; i++)
        {
            Console.Write("Digite um numero: ");
            num[i] = double.Parse(Console.ReadLine(), CI);
        }

        Console.WriteLine();
        Console.WriteLine("NUMERO DIGITADOS: ");

        for (i = 0; i < n; i++) 
        {
            Console.WriteLine(num[i].ToString("F1", CI);
        }
    }
}
