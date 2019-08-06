using ListarCarros.Carro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarCarros
{

    class Program
    {
    
        static void Main(string[] args)
        {

            List<Carros> minhaLista = new List<Carros>();

            MostrarMenu();

            switch (Console.ReadLine())
            {
                case "1":  AdicionaItens(minhaLista); break;
                case "2":  MostraLista(minhaLista); break;
                case "3":  RemoveValores(minhaLista);  break;
               
            }
            Console.ReadKey();  
        }

   
        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor do campo {nome}");
            return Console.ReadLine(); 
        }

        public static void RemoveValores(List<Carros> lista)
        {
            Console.WriteLine($"Informe o valor do campo para remover");
            var removeRegistro = Console.ReadLine();

            foreach (Carros item in lista)
            {
                if (item.Modelo == (removeRegistro))
                {
                    lista.Remove(item);
                    break;
                }
            }
        }

        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada" +
                "\r\n 1 - Adiciona Carros" +
                "\r\n 2 - Lista Carros" +
                "\r\n 3 - Remove Carro");  
        }

        public static void MostraLista(List<Carros> Mostralista)
        {
            Console.WriteLine("Carros cadastrados:\r\n");
            foreach (Carros item in Mostralista)
            {
                Console.WriteLine($"{item.Modelo}");
            }
            Console.ReadKey();
        }

        public static void AdicionaItens(List<Carros> ADDlista)
        {
            for (int i = 0; i < 1; i++)
            {
                ADDlista.Add(new Carros()
                {
                    Modelo = RetornaValores("Modelo"),
                    Ano = int.Parse(RetornaValores("Ano")),
                    Placa = RetornaValores("Placa"),
                    CV = int.Parse(RetornaValores("CV"))
                });
            }

            MostrarMenu();
        }

       


    }
}

       

