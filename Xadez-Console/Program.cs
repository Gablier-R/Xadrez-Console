using System;
using tabuleiro;

namespace XadrezConsole
{
    class Program 
    {
        static void Main() 
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Posicao p = new Posicao(3, 4);

            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
