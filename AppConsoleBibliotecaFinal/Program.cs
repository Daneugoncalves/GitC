using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleBibliotecaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivros = new string[5, 5]; // Criando a arrayLista
            int IndiceBaseDados = 0;

            var escolhaInicial = ApresentaMenuInicial();

            while (true)
            {
                switch (escolhaInicial)

                {
                    case "1": { InserirRegistro(ref listaDeLivros, ref IndiceBaseDados); } break;
                    case "2": { RemoverInformações(ref listaDeLivros); } break;
                    case "3": { MostrarInformacoes(listaDeLivros); } break;
                    case "4": { MostrarInformacoes(listaDeLivros, "true"); } break;
                    case "5": { } return;

                }
                escolhaInicial = ApresentaMenuInicial();
            }
        }

        public static string ApresentaMenuInicial()

        {
            Console.Clear();
            Console.WriteLine("---------- BEM VINDO AO SISTEMA DA BIBLIOTECA --------");
            Console.WriteLine("---------- selecione a opção desejada no menu --------");
            Console.WriteLine("");
            Console.WriteLine("1 - Insira um novo registro");
            Console.WriteLine("2 - Remover um registro");
            Console.WriteLine("3 - Listar informações");
            Console.WriteLine("4 - Listar informações desativadas");
            Console.WriteLine("5 - Sair do sistema");

            Console.WriteLine("");
            
            Console.WriteLine("Digite o numero da opção desejada");
            //retorna diretamente o menu escolhido
            return Console.ReadLine();
            
        }

        public static void InserirRegistro(ref string[,] listaDelivros, ref int IDLista)

        {
            Console.Clear();
            Console.WriteLine("---------Inserindo valores na lista---------");

            Console.WriteLine("Informe um nome para o livro:");

            var nomeLivro = Console.ReadLine();

            Console.WriteLine("Informe o Autor do livro");
            //Aqui pegamos a idade da pessoa digitada pelo usuario do sistema
            var Autor = Console.ReadLine();

            //Aumenta o tamanho da nossa lista quando chegou no limite.
            AumentaALista(ref listaDelivros);

            for (int i = 0; i < listaDelivros.GetLength(0); i++)
            {

                if (listaDelivros[i, 0] != null)
                    continue;

                listaDelivros[i, 0] = (IDLista++).ToString();
                listaDelivros[i, 1] = nomeLivro;
                listaDelivros[i, 2] = Autor;
                listaDelivros[i, 3] = "true";
                listaDelivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }

            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();


        }

        public static void AumentaALista(ref string[,] listaDeLivros)

        {
            var limiteDaLista = true;

            for (int i = 0; i < listaDeLivros.GetLength(0); i++)


            {

                if (listaDeLivros[i, 0] == null)
                    limiteDaLista = false;

            }

            if (limiteDaLista)
            {
                var listaCopia = listaDeLivros;

                listaDeLivros = new string[listaDeLivros.GetLength(0) + 5, 5];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaDeLivros[i, 0] = listaCopia[i, 0];
                    listaDeLivros[i, 1] = listaCopia[i, 1];
                    listaDeLivros[i, 2] = listaCopia[i, 2];
                    listaDeLivros[i, 3] = listaCopia[i, 3];
                    listaDeLivros[i, 4] = listaCopia[i, 4];
                }

                Console.WriteLine("o tamanho da lista foi att");

            }


        }

        public static void MostrarInformacoes(string[,] listaDeLivros, string mostrarregistrosNAtivos = "false")

        {
            Console.Clear();
            Console.WriteLine("Apresentação das informações dentro da lista de livros");

            if (mostrarregistrosNAtivos == "true")

                Console.WriteLine("Registros desativados dentro do sistema. ");


            //laço simples onde mostra de maneira formatada as informações
            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                //Aqui deixamos mostrar as informaçoes que foram desabilitadas dentro do sistemas
                if (listaDeLivros[i, 3] != mostrarregistrosNAtivos)

                    Console.WriteLine($"ID{listaDeLivros[i, 0]} Livro: {listaDeLivros[i, 1]} Autor: {listaDeLivros[i, 2]} Hora: {listaDeLivros[i, 4]}");
            }

            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla. ");

            Console.ReadKey();

        }

        public static void RemoverInformações(ref string[,] listaDeLivros)
        {
            Console.Clear();
            Console.WriteLine("Area de remoção de registro dos livros do sistema. ");



            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                //Identifica que so deve remover os valores ativos dentro do sistema
                if (listaDeLivros[i, 3] != "false")
                    Console.WriteLine($"ID:{listaDeLivros[i, 0]} " +
                          $"- livro:{listaDeLivros[i, 1]} " +
                          $"- autor:{listaDeLivros[i, 2]}");
            }




            Console.WriteLine("Informe o id do registro a ser removido: ");
            var id = Console.ReadLine();


            for (int i = 0; i < listaDeLivros.GetLength(0); i++)


                if (listaDeLivros[i, 0] != null && listaDeLivros[i, 0] == id)
                {  //Agora trocamos este valor para um identificador string "false"
                    listaDeLivros[i, 3] = "false";
                    //Aqui indicamos a data que foi alterado esse registro.
                    listaDeLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();

        }
    }
}
