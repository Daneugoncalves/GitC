﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayBi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivros = new string[2, 2]
                { { "O pequeno", "sim" },{ "O grande","não"} };

            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                var Nomelivro = listaDeLivros[i,0];
                var disponivel = listaDeLivros[i,1];

                Console.WriteLine($"Nome do livro:{Nomelivro} disponivel:{disponivel}.");

            }

            Console.WriteLine("Bem vindo!");
            

            Console.ReadKey();

            Console.WriteLine("O que você quer fazer? Digite o numero da opção desejada");
            Console.WriteLine("(1)Locar livro || (2) Devolver livro");

            Console.ReadLine();

            var livroEscolido == Console.ReadLine();

            Console.ReadKey();


        }
    }
}
