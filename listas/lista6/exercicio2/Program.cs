using System;
public class Program
{
    static void Main(string[] args)
    {
         string[] nomes = new string[11];
        for(int contador = 1; contador <= 10; contador++)
        {
            System.Console.WriteLine("escreva o " + contador + "° nome");
           nomes[contador] = Console.ReadLine();
        }
            System.Console.WriteLine();
        for(int contador = 10; contador >= 0; contador--)
        {
            if(contador % 2 == 0)
            {
                System.Console.WriteLine(nomes[contador]);
            }
        }
    }
}
