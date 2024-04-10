using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
public class Program
{
    static void preencherVetor(int[] vagao)
    {
        for (int peso = 0; peso < 12; peso++)
        {
            vagao[peso] = int.Parse(Console.ReadLine());
        }
    }
    static string verificacao(int[]vagao)
    {
        for (int contador = 0; contador < 12; contador++)
        {
                int passoudopeso = vagao[contador];
            if (passoudopeso > 50)
            {
                System.Console.WriteLine("o " + (contador+1) + "vagão ultrapassou o limite de peso");
            }
        }
        return null;
    }
    static void Main(string[] args)
    {
        int[] vagao = new int[12];
        preencherVetor(vagao);
        System.Console.WriteLine(verificacao(vagao));
    }
}