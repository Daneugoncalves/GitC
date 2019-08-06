using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Lanche> minhaLista = new List<Lanche>();

            minhaLista.Add(new Lanche()
            {
                Nome = "Pão de queijo",
                Quantidade = 9,
                Valor = 1.75
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinho Carne",
                Quantidade = 3,
                Valor = 5.50
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Coxinha",
                Quantidade = 4,
                Valor = 4.50
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Bolo",
                Quantidade = 1,
                Valor = 17.50
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Quibe",
                Quantidade = 6,
                Valor = 2.50
            });

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            Console.WriteLine("Removendo Item");

            foreach (Lanche item in minhaLista)
            {

                if (item.Quantidade == 3)
                {
                    minhaLista.Remove(item);
                    break;
                }
            }

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            Console.ReadKey();



        }
    }
}
