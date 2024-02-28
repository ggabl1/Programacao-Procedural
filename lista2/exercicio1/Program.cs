public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("digite o nome de usuario: ");
        string nomedeusuario = (Console.ReadLine());
        Console.WriteLine("digite a senha: ");
        string senha = (Console.ReadLine());

        if (nomedeusuario == "admin" && senha == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas...");
        }
    }
}