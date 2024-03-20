using System;
public class Program
{
    static void Main (string[] args)
    {
        for (int multiplicador = 10; multiplicador > 0; multiplicador--)
        {
            for(int numero = 1; numero <= 10; numero++)
            {
                System.Console.WriteLine(multiplicador + " X " + numero + " = " + (multiplicador * numero));
            }
            System.Console.WriteLine();
        }
    }
}