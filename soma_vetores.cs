using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture; 

        int n, i;

        Console.Write("Qauntos numeros voce vai digitar? ");
        n = int.Parse(Console.ReadLine());

        double[] numeros = new double[n];
        double soma, media;

        for (i = 0; i < n; i++) 
        {
            Console.Write("Digite um numero: ");
            numeros[i] = double.Parse(Console.ReadLine(), CI);
        }

        Console.WriteLine();
        Console.Write("VALORES = ");
        for (i = 0; i < n; i++)
        {
            Console.Write(numeros[i].ToString("F1", CI) + " ");
        }
        Console.WriteLine();

        soma = 0;
        for (i = 0; i < n; i++)
        {
            soma = soma + numeros[i];
        }

        Console.WriteLine("SOMA = " + soma.ToString("F2", CI));

        media = soma / n;
        Console.WriteLine("MEDIA = " + media.ToString("F2", CI));    


    }
}
