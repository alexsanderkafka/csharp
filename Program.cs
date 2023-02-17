
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture; 

        double altura, base1, area, perimetro, diagonal;

        Console.Write("Base do retangulo: ");
        base1 = double.Parse(Console.ReadLine(), CI);

        Console.Write("Altura do retangulo: ");
        altura = double.Parse(Console.ReadLine(), CI);

        Console.WriteLine();

        area = base1 * altura;
        Console.WriteLine("AREA = " + area.ToString("F4", CI));

        perimetro = 2 * (altura + base1);
        Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));

        diagonal = Math.Sqrt(Math.Pow(base1, 2) + Math.Pow(altura, 2));
        Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));

    }
}