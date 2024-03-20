using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;

public class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_DE_REPETICOES = 20;
        double somaDeSalarios = 0;
        int somaDeFilhos = 0;
        double maiorsalario = 0;

        for (int contador = 1; contador <= NUMERO_DE_REPETICOES; contador++)
        {
            System.Console.WriteLine("Digite o " + contador + "° salario");
            double Salario = double.Parse(Console.ReadLine());
            somaDeSalarios = somaDeSalarios + Salario;
            if (Salario > maiorsalario)
            {
                maiorsalario = Salario;
            }
            System.Console.WriteLine("Digite a quantidade de filhos");
            int Filho = int.Parse(Console.ReadLine());
            somaDeFilhos = somaDeFilhos + Filho;

            if (contador == NUMERO_DE_REPETICOES)
            {
                double mediaDeSalarios = somaDeSalarios / NUMERO_DE_REPETICOES;
                System.Console.WriteLine("a media de salario eh: " + Math.Round (mediaDeSalarios, 2));
                System.Console.WriteLine("o maior salario eh: " + maiorsalario);
                double mediaDeFilhos = somaDeFilhos / NUMERO_DE_REPETICOES;
                System.Console.WriteLine("a media de filhos eh: " + mediaDeFilhos);
            }
        }
    }
}