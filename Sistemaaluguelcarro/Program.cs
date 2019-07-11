using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemaaluguelcarro
{
    class Program
    //CRIANDO A MATRIZ
    {
        static string[,] matrizCarros;

        //DELARANDO PARAMENTROS
        static void Main(string[] args)
        {
            matrizCarros = new string[2, 3]
            {
           {"Gol","2001","sim"},
           {"Celta","2004","não"}
            };
            // BOAS VINDAS
            {
                Console.WriteLine("________________________________________________");
                Console.WriteLine("        Sistema de alocação de Carros");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("    Desenvolvido pelas industrias Ktiau");
                Console.WriteLine("________________________________________________");

                Console.ReadKey();

                //MOSTRAR MATRIZ
                //  {
                //      for (int i = 0; i < matrizCarros.GetLength(0); i++)
                //          Console.WriteLine(matrizCarros[i,0]);
                //  }
                Console.ReadKey();


                //MENU INICIO
                {
                    Console.WriteLine("\r\nMenu - Inicial");
                    Console.WriteLine("O que você deseja realizar?");
                    Console.WriteLine("1 - Alocar um carro.");
                    Console.WriteLine("2 - Sair do sistema.");
                    Console.WriteLine("Digite o número desejado:");

                    int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);


                    //if inicial alocar ou n
                    if (opcao == 1)

                    {
                        Console.Clear();

                        Console.WriteLine("Menu - Alocação de Carros");
                        Console.WriteLine("Digite o nome do Carro a ser alocado:");

                        var nomeCarro = Console.ReadLine();


                        if (PesquisaCarroParaAlocacao(nomeCarro))

                        {

                            Console.WriteLine("Você deseja alocar o carro? para sim(1) para não(0)");
                        }
                        if (Console.ReadKey().KeyChar.ToString() == "1")

                        {
                            AlocarCarro(nomeCarro);
                            Console.Clear();
                            Console.WriteLine("Carro Alocado com sucesso!");

                            {
                                for (int i = 0; i < matrizCarros.GetLength(0); i++)
                                    Console.WriteLine($"Modelos de carros: {matrizCarros[i, 0]}" +
                              $" Ano dos carros: {matrizCarros[i, 1]}" +
                              $" Disponibilidade: {matrizCarros[i, 2]}");

                            }
                            Console.ReadKey();
                        }
                    }
                }
            }
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

        public static void AlocarCarro(string nomecarro)

        {
            for (int i = 0; i < matrizCarros.GetLength(0); i++)
            {
                if (nomecarro == matrizCarros[i, 0])
                    matrizCarros[i, 2] = "não";
            }
        }


    }
}





