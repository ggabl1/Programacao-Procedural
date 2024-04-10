using System;
public class Program
{
    static void preencheMatriz(int[,] numero)
    {
        for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                numero[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
    }
    static bool percorreMatriz(int[,] verificacao)
    {
        for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                if (verificacao[linha, coluna] == 0)
                {
                    System.Console.WriteLine("Fique atento! Existem balistas no tabuleiro");
                    return true;
                }
                else
                {
                    System.Console.WriteLine("Nao ha balistas no tabuleiro");
                    return false;
                }
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];
        preencheMatriz(matriz);
        percorreMatriz(matriz);
    }
}