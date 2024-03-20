public class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine("escolha a rotina de uma das criancas:\n[1] - Filomena\n[2] - Joselito ");
        int rotinaEscolhida = int.Parse(Console.ReadLine());

        if (rotinaEscolhida == 1)
        {
            Console.WriteLine("Rotina de Filomena: 1. Escola das 7h ao 12h; 2. almoço das 12h a 13h; 3. futebol das 14h as 16h; 4. dever de casa das 14h as 18h.");
        }
        else if (rotinaEscolhida == 2)
        {
          Console.WriteLine("Rotina de Joselito: 1. Escola das 7h ao 12:30; 2. almoço das 13h as 14h; 3. nataçao das 14h as 16h; 4. reforço escolas das 16h as 19h");  
        }

    }
}