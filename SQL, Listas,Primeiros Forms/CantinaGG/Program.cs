using CantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaM ContaAluno = new ContaM();
            string escolha = "1";
            while (escolha == "1")
            {
                Console.WriteLine("Escolha uma opção do cardápio: ");
                Console.WriteLine("1-XSALADA || 2-BATATA FRITA|| 3-PASTEL ");
                Console.WriteLine("4-SAIR");

                var precolanche = 0.00;

                switch (Console.ReadLine())
                {
                    case "1": { precolanche = 3.45; } break;
                    case "2": { precolanche = 5.50; } break;
                    case "3": { precolanche = 8.45; } break;
                    case "4": break;
                }

                if (precolanche > 0 && ContaAluno.comprarLache(precolanche))
                {
                    Console.WriteLine("Aproveite seu lanche");
                    Console.WriteLine($"Saldo atual disponivel:{ContaAluno.Saldo}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Saldo nao é sufuciente");
                    Console.WriteLine($"Saldo atual disponivel: R$ {ContaAluno.Saldo}");

                    Console.ReadKey();
                }

                Console.WriteLine("Voce deseja outro lanche? 1- Sim || Precione qualquer tecla para sair.");
                escolha = Convert.ToString(Console.ReadLine());
            }
       
        }
    }
}
