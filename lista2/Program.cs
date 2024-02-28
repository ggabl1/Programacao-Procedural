using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

public class Program
{
    public static void Main(string[] args)
 const double quantidadeDeNotas = 4;
    Console.WriteLine("digite a primeira nota");
   double nota1 = (Console.ReadLine());
    Console.WriteLine("digite a segunda nota");
   double nota2 = (Console.ReadLine());
    Console.WriteLine("digite a terceira nota");
   double nota3 = (Console.ReadLine());
    Console.WriteLine("digite a quarta nota");
   double nota4 = (Console.ReadLine());
    double media = (nota1 + nota2 + nota3 + nota4) / 4;

    if (media >= 5.0)
    {
       Console.WriteLine("Aluno aprovado"); 
    }
else if (media < 5.0 && media >= 3.0)
{
    Console.WriteLine("Aluno em recuperacao");
}
else if (media < 3.0)
{
    Console.WriteLine("Aluno reprovado");
}
}