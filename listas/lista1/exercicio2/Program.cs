using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("digite o valor da base: ");
        double medidaBase = double.Parse(Console.ReadLine());
        Console.WriteLine("digite o valor da altura: ");
        double medidaAltura = double.Parse(Console.ReadLine());
        double area = (medidaBase * medidaAltura) / 2;
        bool maiorQueVinte = area > 20;
        Console.WriteLine("a área do triangulo é maior que 20?" + maiorQueVinte);

    }
}
