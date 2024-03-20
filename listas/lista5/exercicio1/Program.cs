using System;
public class Program
{
    public static void Main (string[] args)
    {
        int contadorDecrescente = 200;
       for(int contadorCrescente = 0; contadorCrescente <= 100 && contadorDecrescente >= 0; contadorCrescente+=2, contadorDecrescente-=4)
       {
        System.Console.WriteLine(contadorCrescente + " - " + contadorDecrescente);
       }
    }
}