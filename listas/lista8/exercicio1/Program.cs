using System;
using System.Data.Common;
public class Program
{
    struct pizza
    {
        public int id;
        public string sabor;
        public double preco;
    }
    static void Main(string[] args)
    {
        pizza pizza1;
        pizza1.id = int.Parse(Console.ReadLine());
        pizza1.sabor = Console.ReadLine();
        pizza1.preco = double.Parse(Console.ReadLine());

        System.Console.WriteLine(pizza1.id);
         System.Console.WriteLine(pizza1.sabor);
          System.Console.WriteLine(pizza1.preco);
    }
}