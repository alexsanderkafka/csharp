using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c, menor;

        Console.Write("Primeiro valor: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Terceiro valor: ");
        c = int.Parse(Console.ReadLine());

        menor = 0;
        if (a < b && a < c)
        {
            menor = a;
        }
        else if (b < c)
        {
            menor = b;
        }
        else
        {
            menor = c;
        }

        Console.WriteLine("MENOR = " + menor);
    }
}