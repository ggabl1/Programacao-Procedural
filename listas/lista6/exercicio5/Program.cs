using System;
using System.Diagnostics.Contracts;
public class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        int[] vetor = new int[10];
        int contador = 0;
        do
        {
            numero = int.Parse(Console.ReadLine());
            if (numero >= 10 && numero <= 50)
            {
                vetor[contador] = numero;
                contador++;
            }
        } while(contador < 10);
        System.Console.WriteLine();
        for(int contadorVetor = 0; contadorVetor < 10; contadorVetor++)
        {
            System.Console.WriteLine(vetor[contadorVetor]);
        }
    }
}
