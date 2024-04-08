using System;
public class Program
{
static string classificarNadador(int idade)
{
    if(idade < 12)
    {
        return "Infantil";
    }
    else if(idade <= 14)
    {
        return "Juvenil A";
    }
    else if (idade <= 17)
    {
        return "Juvenil B";
    }
        return "Adulto";
}
static void Main(string [] args)
{
    int idade = int.Parse(Console.ReadLine());
    System.Console.WriteLine(classificarNadador(idade));
}
}