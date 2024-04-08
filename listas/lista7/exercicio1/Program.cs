using System;
using System.ComponentModel;
public class Program
{
 static bool ehPar(int numero)
 {
    if(numero % 2 == 0)
    {
        return true;
    }
    return false;
 }
 static void Main(string[] args)
 {
    int numero = int.Parse(Console.ReadLine());
    System.Console.WriteLine(ehPar(numero));
 }
}