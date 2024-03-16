using System;
using System.Reflection;
public class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("digite o numero");
        int fimDaLinhaEContador = int.Parse(Console.ReadLine());
        while (fimDaLinhaEContador < 1 || fimDaLinhaEContador > 9)
        {
            if (fimDaLinhaEContador < 1 || fimDaLinhaEContador > 9)
                System.Console.WriteLine("altura invalida. insira uma altura entre 1 e 9");
            fimDaLinhaEContador = int.Parse(Console.ReadLine());
        }
        for (int contadorDeLinhas = 1; contadorDeLinhas <= fimDaLinhaEContador; contadorDeLinhas++)
        {
            int contador = 1;
            if (fimDaLinhaEContador > 1 || fimDaLinhaEContador < 9)
            {
                while (contador <= contadorDeLinhas)
                {
                    System.Console.Write(contador++);
                }
                System.Console.WriteLine();
            }
        }
    }
}
