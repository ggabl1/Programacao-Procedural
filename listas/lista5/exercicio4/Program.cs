using System;
public class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;
        int numeroDigitado;
        do
        {
            numeroDigitado = int.Parse(Console.ReadLine());
            if (numeroDigitado % 2 == 1)
            {
                somatorio = somatorio + numeroDigitado;
            }
        }while(numeroDigitado >= 0);
        System.Console.WriteLine("o somatorio dos numeros impares eh: " + somatorio);
    }
}
