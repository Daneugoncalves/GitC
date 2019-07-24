using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] ListaBI;

        

        public ListaBi()
        {
            ListaBI = new string[5, 2];
            carregaListaBi();
        }
        public void carregaListaBi()

        {
            for (int i = 0; i <ListaBI.GetLength(0); i++)
            {
                ListaBI[i, 0] = i.ToString();
                ListaBI[i, 1] = $"Daniel_{i}";

                Console.WriteLine($"Id:{i} Nome:Daniel_{i}");
            }
        }

        public void Pesquislista(string idPesquisa)
        {
            for (int i = 0; i < ListaBI.GetLength(0); i++)
            {
                if (ListaBI[i,0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso!");
                    Console.WriteLine($"Você pesquisou pelo registro{ListaBI[i,1]}");

                    return;
                }
            }
            Console.WriteLine("Nenhum registro encontrado com esse ID!");
        }
    }
}
