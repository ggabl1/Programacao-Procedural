using System;
public class Program
{
    static void Main(string[] args)
    {
        int linhas = int.Parse(Console.ReadLine());
        int colunas = int.Parse(Console.ReadLine());
        int linhasImpressas = 0;
        int colunasImpressas = 0;
        do
        {
            colunasImpressas = 0;
            do
            {
                System.Console.Write("*");
                colunasImpressas++;
            } while(colunasImpressas < colunas);
                System.Console.WriteLine();
            linhasImpressas++;
        }while(linhasImpressas < linhas);
    }
}
