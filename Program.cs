﻿using System;
using tabuleiro;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 4);
            Console.WriteLine("Posição: " + p);

            
            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.ReadLine();
        }
    }
}
