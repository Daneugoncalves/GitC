using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListDinamica.Lanche;

namespace ListDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanches> minhaLista = new List<Lanches>();//INICIALIZANDO A LISTA


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("CADASTRO DE PRODUTOS");
                Console.WriteLine("--------------------\r\n");

                Console.WriteLine("Digite o nome do Produto");
                var produto = Console.ReadLine();

                Console.WriteLine("Digite a Quantidade");
                var quantidade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o preço");
                var preco = Convert.ToDouble(Console.ReadLine());

                minhaLista.Add(new Lanches()
                {
                    Nome = produto,
                    Quantidade = quantidade,
                    Preco = preco
                }); ;

                Console.Clear();
            } // LOOP PARA CADASTRO DE 3 PRODUTOS

            foreach (Lanches item in minhaLista) //MOSTRA LANCHES DISPONIVEIS
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");
            Console.ReadKey();

            Console.WriteLine("Removendo Item");

            Console.WriteLine("Digite o item que deseja remover");
            var removeItem = Console.ReadLine(); // GRAVA NA VARIAVEL OQUE DESEJA REMOVER

            foreach (Lanches item in minhaLista)
            {
                if (item.Nome == removeItem)
                {
                    minhaLista.Remove(item);
                    break;
                }
            }// COMPARAÇÃO PARA REMOVER

            foreach (Lanches item in minhaLista)  //MOSTRA NOVAMENTE
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");
            Console.ReadKey();

        }
    }
}
