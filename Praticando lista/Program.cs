using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticando_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeCarros = new string[3, 3];
            int IDLista = 0;

            InserirREgistro(ref listaDeCarros, ref IDLista);

            Console.ReadKey();

            Console.WriteLine("Registro adicionado com sucesso, lista das informações adicionadas: ");

            for (int i = 0; i < listaDeCarros.GetLength(0); i++)


            Console.WriteLine(string.Format("Registro ID {0} - Carro: {1} - Placa: {2} ", listaDeCarros[i, 0], listaDeCarros[i, 1], listaDeCarros[i, 2]));
            Console.ReadKey();

        }

        public static void AumentaALista(ref string[,] listaDeCarros)

        {
            var limiteDaLista = true;

            for (int i = 0; i < listaDeCarros.GetLength(0); i++)


            {

                if (listaDeCarros[i, 0] == null)
                    limiteDaLista = false;

            }

            if (limiteDaLista)
            {
                var listaCopia = listaDeCarros;

                listaDeCarros = new string[listaDeCarros.GetLength(0) + 5, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaDeCarros[i, 0] = listaCopia[i, 0];
                    listaDeCarros[i, 1] = listaCopia[i, 1];
                    listaDeCarros[i, 2] = listaCopia[i, 2];
                }

                Console.WriteLine("o tamanho da lista foi att");

            }


        }

        public static void InserirREgistro(ref string[,] listaDeCarros, ref int IDLista)

        {

            for (int i = 0; i < listaDeCarros.GetLength(0); i++)
            {

                if (listaDeCarros[i, 0] != null)
                    continue;

                Console.WriteLine("informe um carro para adicionar na lista");
                var nomeCarro = Console.ReadLine();


                listaDeCarros[i, 0] = (IDLista++).ToString();
                listaDeCarros[i, 1] = nomeCarro;

                Console.WriteLine("informe a placa do carro para adicionar na lista");
                var placa = Console.ReadLine();

                listaDeCarros[i, 2] = placa;

                Console.WriteLine("Deseja inserir um novo registro? sim(1) Não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();
                Console.Clear();


                if (continuar == "0")
                    break;



                AumentaALista(ref listaDeCarros);
            }


        }


    }
}
