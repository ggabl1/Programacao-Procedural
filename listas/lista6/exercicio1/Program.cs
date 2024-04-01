using System;
public class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[11];
        bool existe = false;
        for (int contador = 1; contador <= 10; contador++)
        {
            System.Console.WriteLine("Digite o " + contador + "° nome");
            nomes[contador] = Console.ReadLine();
        }
        System.Console.WriteLine("escreva o nome que deseja buscar");
        string nomeBuscado = Console.ReadLine();
        for (int contador = 1; contador <= 10; contador++)
        {
            if (nomes[contador] == nomeBuscado)
            {
                existe = true;
            }
        }
        if (existe)
        {
            System.Console.WriteLine("ACHEI");
        }
        else
        {
            System.Console.WriteLine("NAO ACHEI");
        }
    }

}

