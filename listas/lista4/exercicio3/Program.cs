using System;
using System.ComponentModel.DataAnnotations.Schema;
public class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        for (int Linha = 0; Linha < 8; Linha++)
        {
            for (int Coluna = 0; Coluna < 8; Coluna++)
            {
                if (Linha == 0 || Coluna == 0 || Coluna == 7 || Linha == 7)
                {
                     Tabuleiro.Adicionar(Linha, Coluna, "s");
                }
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}