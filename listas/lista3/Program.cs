using System;
using System.Diagnostics.Contracts;

public class Program
{
    static void Main (string[] args)
    {
        const int numeroDeRepeticoes = 20;
         for (int contador = 0; contador < numeroDeRepeticoes; contador++)
        {
        System.Console.WriteLine("Digite o seu salario");
        double somaDeSalarios = double.Parse(Console.ReadLine());
         System.Console.WriteLine("Digite a quantidade de filhos");
        int somaDeFilhos= int.Parse(Console.ReadLine());
          double mediaDeSalario = somaDeSalarios / contador;
         System.Console.WriteLine("a media de salarios eh: " + mediaDeSalario);
          double mediaDeFilhos = somaDeFilhos / contador;
         System.Console.WriteLine("a media de filhos eh: " + mediaDeFilhos);
        }
        
    }
}