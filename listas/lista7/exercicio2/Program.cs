using System;
public class Program
{
    static int maiorNumero(int numero1, int numero2, int numero3)
    {
        int maiorNumero = 0;
        if (numero1 > numero2 && numero1 > numero3)
        {
            return numero1;
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            return numero2;
        }
        return numero3;
    }
    static void Main(string[] args)
    {
       int numero1 = int.Parse(Console.ReadLine());
       int numero2 = int.Parse(Console.ReadLine());
       int numero3 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("\n" + maiorNumero(numero1, numero2, numero3));
    }
}