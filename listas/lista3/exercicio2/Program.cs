using System;
using System.Diagnostics.Contracts;
public class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("insira a quantidade de itens da compra: ");
        int quantidadeDeItens = int.Parse(Console.ReadLine());
        int valorNecessario = 150;
        int contador = 1;
        int valorDasCompras = 0;

        while (contador <= quantidadeDeItens)
        {
            System.Console.WriteLine("insira o valor do item " + contador);
            int valorAtual = int.Parse(Console.ReadLine());
            valorDasCompras = valorDasCompras + valorAtual;
            contador++;
            if (valorDasCompras >= valorNecessario && contador > quantidadeDeItens)
            {
                System.Console.WriteLine("Parabens! Voce ganhou fete gratis em sua copra de valor " + valorDasCompras);
            }
            else if (contador > quantidadeDeItens && valorDasCompras < valorNecessario)
            {
                System.Console.WriteLine("A compra nao possui fete gratis");
            }
        }
    }
}