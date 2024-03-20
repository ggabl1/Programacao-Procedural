using System;
using System.Diagnostics.Contracts;
public class Program
{
    static void Main (string[] args)
    {
        int multiplicador = 1;
        while (multiplicador <= 10)
        {
            int contador = 1;
            while (contador <= 10)
            {
                int resultado = multiplicador * contador;
                System.Console.WriteLine(multiplicador + " x " + contador + " = " + resultado);
            contador++;
            }
            System.Console.WriteLine("\n");
            multiplicador++;
        }
    }
}
