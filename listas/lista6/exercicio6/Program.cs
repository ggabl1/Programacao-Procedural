using System;
public class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;
        int[,] matriz = new int[4, 4];
        for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
                somatorio = somatorio + matriz[linha, coluna];
            }
        }
        System.Console.WriteLine("1 - imprimir os elementos da matriz");
        System.Console.WriteLine("2 - Somar todos os elementos e exibir o resultado");
        System.Console.WriteLine("3 - Somar todos os elementos da terceira linha e exibir o resultado");
        System.Console.WriteLine("4 - Somar os elementos da diagonal principal");
        System.Console.WriteLine("5 - Somar todos os elementos de índice par da segunda linha");
        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                    System.Console.WriteLine(matriz[linha, coluna]);
            }
        }
        else if (escolha == "2")
        {
            System.Console.WriteLine(somatorio);
        }
        else if (escolha == "3")
        {
            int somatorioLinha3 = 0;
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    if (matriz[linha, coluna] == matriz[2, coluna])
                    {
                        somatorioLinha3 = matriz[2, 0] + matriz[2, 1] + matriz[2, 2] + matriz[2, 3];
                    }
                }
            }
            System.Console.WriteLine(somatorioLinha3);
        }
        else if (escolha == "4")
        {
            int somatorioDiagonal = 0;
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    if (linha == coluna)
                    {
                        somatorioDiagonal = somatorioDiagonal + matriz[linha, coluna];
                    }
                }
            }
            System.Console.WriteLine(somatorioDiagonal);
        }
        else if (escolha == "5")
        {
            int somatorioLinha1 = 0;
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    if (matriz[linha, coluna] == matriz[1, coluna] && coluna % 2 == 0)
                    {
                             somatorioLinha1 = matriz[1,coluna] + matriz[1,0];
                    }
                }
            }
            System.Console.WriteLine(somatorioLinha1);
        }
    }
}
