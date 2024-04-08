using System;
using System.Reflection.PortableExecutable;
public class Program
{
    static void preencherVetor(int[] vagao)
    {
        for(int peso = 0; peso < 4; peso++)
        {
            vagao[peso] = int.Parse(Console.ReadLine());
        }
    }
    static string verificacao(int peso)
    {
        if(peso > 50)
        {
        System.Console.WriteLine("o vagão ultrapassou o limite de peso");
        }
        return "";
    }
    static void Main(string[] args)
    { 
        int[] vagao = new int [12];
        preencherVetor(vagao);
        for(int contador = 0; contador < 4; contador++)
        {
        System.Console.WriteLine(verificacao(vagao[contador]));
        }
    }
}
