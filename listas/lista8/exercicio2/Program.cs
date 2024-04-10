using System;
public class Program
{
    struct Produto
    {
        public int id;
        public string nome;
        public double preco;
        public bool disponivelEmEstoque;
    }
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[4];
            for (int iCaracteristicas = 0; iCaracteristicas < 4; iCaracteristicas++)
            {
                produtos[iCaracteristicas].id = int.Parse(Console.ReadLine());
                 produtos[iCaracteristicas].nome = Console.ReadLine();
                  produtos[iCaracteristicas].preco = double.Parse(Console.ReadLine());
                   produtos[iCaracteristicas].disponivelEmEstoque = bool.Parse(Console.ReadLine());
                   System.Console.WriteLine();
            }
            for(int i = 0;  i < produtos.Length; i++)
            {
                System.Console.WriteLine();
            if (produtos[i].disponivelEmEstoque)
            {
                System.Console.WriteLine(produtos[i].nome);
                System.Console.WriteLine(produtos[i].preco);
            }
            }
        }
    }