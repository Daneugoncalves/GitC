using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_BEBIDAS
{
    class Program
    {
        static void Main(string[] args)
        {

            MostrarSejaBemVindo();
            Console.WriteLine("Digite seu nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            string line = Console.ReadLine();

            int idade = Convert.ToInt32(line);

            

                if (idade > 17)
                {
                    Console.WriteLine($"Você pode beber, {nome}");
                    Console.ReadKey();
                }

                else

                {
                    Console.WriteLine($"Você nao pode beber, {nome}");
                    Console.ReadKey();
                }
        

        }

        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("         Sistema de Bebidas alcoólicas.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("");

        }
    }
}
