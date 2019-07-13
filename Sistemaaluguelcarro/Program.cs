using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemaaluguelcarro
{
    class Program
    {
        static string[,] matrizCarros;
        static void Main(string[] args)
        {
            CarregaBaseCarro();
            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if (opcaoMenu == 3)
                    MostrarListaDeCarros();
                    Console.Read();

                opcaoMenu = MenuPrincipal();

            }
            Console.ReadKey();
        }

        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um carro.");
            Console.WriteLine("2 - Devolver um carro.");
            Console.WriteLine("3 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("         Sistema de alocação de carros.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("    Desenvolvido pelas industrias katiau");
            Console.WriteLine("________________________________________________");
        }

        public static bool PesquisaCarroParaAlocacao(string nomecarro)

        {
            for (int i = 0; i < matrizCarros.GetLength(0); i++)
            {
                if (nomecarro == matrizCarros[i, 0])
                {
                    Console.WriteLine($"O Carro: {nomecarro}" +
                          $" ano: {matrizCarros[i, 1]}" +
                          $" pode ser alocado?: {matrizCarros[i, 2]}");

                    return matrizCarros[i, 2] == "sim";
                }
            }
            return false;
        }

        public static void CarregaBaseCarro()

        {
            matrizCarros = new string[2, 3]

                {
                    {"Celta","2019","não"},
                    {"Gol","2010", "sim"}
                };

        }

        public static void AlocarCarro(string nomecarro, bool alocar)

        {

            for (int i = 0; i < matrizCarros.GetLength(0); i++)
            {
                if (nomecarro == matrizCarros[i, 0])
                    matrizCarros[i, 2] = alocar ? "Nao" : "Sim";
            }
        }

        public static void AlocarUmCarro()
        {
            MostrarMenuInicialCarros("Alocar um CARRO:");

            var nomecarro = Console.ReadLine();
            if (PesquisaCarroParaAlocacao(nomecarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o carro? para sim(1) para não(0)");

                AlocarCarro(nomecarro, Console.ReadKey().KeyChar.ToString() == "1");
                MostrarListaDeCarros();
                Console.ReadKey();
            }
        } 

        public static void MostrarListaDeCarros()


        {
            Console.Clear();
            Console.WriteLine("Listagem de Carros:");

            for (int i = 0; i < matrizCarros.GetLength(0); i++)
            {
                Console.WriteLine($"{matrizCarros[i, 0]} Ano:{matrizCarros[i, 1]} Disponibilidade: {matrizCarros[i, 2]}");
            }
        }

        public static void DesalocarUmCarro()
        {
            MostrarMenuInicialCarros("Desalocar um carro: ");

            var nomedocarro = Console.ReadLine();
            if (!PesquisaCarroParaAlocacao(nomedocarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o carro? para sim(1) para não(0)");

                AlocarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "0");

               Console.WriteLine("Carros: ");
               for (int i = 0; i < matrizCarros.GetLength(0); i++)
               {
                   Console.WriteLine($"Carro: {matrizCarros[i, 0]} Ano: {matrizCarros[i, 1]} Disponibilidade: {matrizCarros[i, 2]}");
               }

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }

        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();
            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do carro para realizar a operação:");
        }

        

    }
}





