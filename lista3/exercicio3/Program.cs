using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("escreva o nome de usuario: ");
        string nomeDeUsuario = (Console.ReadLine());
        System.Console.WriteLine("escreva a senha: ");
        string senha = (Console.ReadLine());
        int contador = 2;
        const int tentativasLimite = 3;
        const string usuarioCorreto = "admin";
        const string senhaCorreta = "123senha";
        if (nomeDeUsuario == usuarioCorreto && senha == senhaCorreta)
        {
            System.Console.WriteLine("Loguin realizado com sucesso");
        }
        do
        {
            System.Console.WriteLine("escreva o nome de usuario novamente: ");
            string nomeDeUsuarioDigitado = (Console.ReadLine());
            System.Console.WriteLine("escreva a senha novamente: ");
            string senhaDigitada = (Console.ReadLine());
            if (nomeDeUsuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
            {
                System.Console.WriteLine("Loguin realizado com sucesso");
            }
            else if (contador > tentativasLimite)
            {
                System.Console.WriteLine("sua conta foi bloqueada");
            }
            contador++;
        }
        while (contador <= tentativasLimite);
    }
}
