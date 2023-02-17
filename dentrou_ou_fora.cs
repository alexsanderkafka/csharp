using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // problema dentro ou fora
        // dentro números que estao no intervalo entre 10 e 20
        // fora numeros que estão fora desse intervalo

        int x, n, dentro, fora;

        Console.Write("Quantos numeros voce vai digitar? ");
        n = int.Parse(Console.ReadLine());

        dentro = 0;
        fora = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite um numero: ");
            x = int.Parse(Console.ReadLine());

            if (x >= 10 && x <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
        }

        Console.WriteLine(dentro + " DENTRO");
        Console.WriteLine(fora + " FORA");

    }
}
