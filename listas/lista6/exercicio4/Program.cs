using System;
using System.Runtime.InteropServices;
public class Program
{
    static void Main(string[] args)
    {
        const int tamanho = 9;
        int[,] matriz = new int[tamanho, tamanho];
        for (int contadorLinhas = 1; contadorLinhas <= 3; contadorLinhas++)
        {
            for (int contadorColunas = 1; contadorColunas <= 3; contadorColunas++)
            {
                matriz[contadorLinhas, contadorColunas] = int.Parse(Console.ReadLine());
                if (matriz[contadorColunas, contadorLinhas] == matriz[2, 2] || matriz[contadorColunas, contadorLinhas] == matriz[3, 1] || matriz[contadorColunas, contadorLinhas] == matriz[1, 3])
                {
                    matriz[contadorLinhas, contadorColunas] = matriz[contadorLinhas, contadorColunas] * 2;
                }
            }
        }
        for (int linha = 1; linha <= 3; linha++)
        {
            for (int coluna = 1; coluna <= 3; coluna++)
            {
                System.Console.Write(matriz[linha, coluna] + "|");
                if (coluna == 3 || coluna == 6)
                {
                    System.Console.WriteLine();
                }
            }
        }
    }
}