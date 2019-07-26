using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamentoFuncoesClass;

namespace UsandoBibliotecaEstaciomanento
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlaEstacionamento Auto = new ControlaEstacionamento(); 

            Auto.CadastrarCarro();
            Auto.listarCarros();
            Auto.ValidaEstacionamento();
            Auto.listarCarros();
            Auto.PesquisaCarros1(); //PASSANDO PARAMETRO PARA TESTE
            Auto.listarCarros();

        }
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Cadastrar Entrada");
            Console.WriteLine("2 - Listar Automóveis no estacionamento");
            Console.WriteLine("3 - Listar Automóveis.");
            Console.WriteLine("4 - Validar Ticket");
            Console.WriteLine("5 - Sair do sistema");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("         Sistema de Estacionamento              ");
            Console.WriteLine("________________________________________________");

        }
    }
}
