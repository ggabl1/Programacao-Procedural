using System;
public class Program
{
    static void Main(string[] args)
    {
        const int tamanho = 9;
        int[,] matriz = new int[tamanho, tamanho];
        int somatorio = 0;
        for (int contadorLinhas = 1; contadorLinhas <= 3; contadorLinhas++)
        {
            for (int contadorColunas = 1; contadorColunas <= 3; contadorColunas++)
            {
                System.Console.WriteLine("digite o numero");
                matriz[contadorColunas, contadorLinhas] = int.Parse(Console.ReadLine());
                if(contadorLinhas == contadorColunas)
                {
                somatorio = somatorio + matriz[contadorLinhas, contadorColunas];
                }
            }
        }
            System.Console.WriteLine("\n" + somatorio);
    }
}