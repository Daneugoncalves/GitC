using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivro;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            MostrarSejaBemVindo();

            if (OpcoesIniciais() == 1)

                MostrarMenuAlocacao();

            Console.ReadKey();
        }
        /// <summary>
        /// método que da boas vindas ao usuário, introduzindo-o no sistema.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Seja bem vindo ao sistema de alocação de livros!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("-----------  Desenvolvido por eu  --------------");
            Console.WriteLine("------------------------------------------------");
        }
        /// <summary>
        /// Metodo com opçoes menu inicial e opções para escolha.
        /// </summary>
        /// <returns></returns>
        public static int OpcoesIniciais()
        {
            Console.WriteLine("\r\n Menu inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("-- 1 - Alocar um livro -");
            Console.WriteLine("-- 2 - Sair do sistema -");
            Console.WriteLine("Digite o número desejado");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base d dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()

        {
            baseDeLivro = new string[2, 2]
            {
                { "O pequeno","sim"},
                { "O Grande","não"}
            };
        }
        /// <summary>
        /// metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomedolivro">Nome do livroa ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool PesquisaLivroParaAlocacao(string nomedolivro)

        {
            for (int i = 0; i < baseDeLivro.GetLength(0); i++)
            {
                if (nomedolivro == baseDeLivro[i, 0])
                {
                    Console.WriteLine($"O livro: {nomedolivro} " +
                        $"pode ser alocado?:{ baseDeLivro[i, 1]}");
                    return baseDeLivro[i, 1] == "sim";
                }

            }
            return false;
        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado
        /// </summary>
        /// <param name="nomedolivro">nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomedolivro)

        {
            for (int i = 0; i < baseDeLivro.GetLength(0); i++)
            {
                if (nomedolivro == baseDeLivro[i, 0])
                    baseDeLivro[i, 1] = "não";
            }
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação
        /// </summary>
        public static void MostrarMenuAlocacao()
        {
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Menu - Locação de livros");
                Console.WriteLine("Digite o nome do livro a ser alocado");

                var nomedolivro = Console.ReadLine();
                if (PesquisaLivroParaAlocacao(nomedolivro))

                {
                    Console.Clear();
                    Console.WriteLine("voce deseja alocar o livro? Para sim digite(1) para não(0)");

                    if (Console.ReadKey().KeyChar.ToString() == "1")

                    {
                        AlocarLivro(nomedolivro);
                        Console.WriteLine("Livro alocado com sucesso");
                    }

                    Console.WriteLine("Listagem de Livros");

                    for (int i = 0; i < baseDeLivro.GetLength(0); i++)
                    {
                        Console.WriteLine($"Nome:{baseDeLivro[i, 0]}Disponivel:{baseDeLivro[i, 1]}");
                    }
                }
            }
        }
    }
}
