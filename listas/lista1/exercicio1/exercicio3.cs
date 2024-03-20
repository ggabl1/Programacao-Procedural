public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("digite a quantidade de moedas de um centavo: ");
        int centavos = (Console.ReadLine());
        double reais = centavos / 100;
        Console.WriteLine(" O total em dinheiro eh: "reais + "reais e" + centavos "centavos");

    }
}
