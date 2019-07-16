using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserteREmoveInLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            //criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 5];

            //Indicador dor registro realizados em nosso sistema
            int IndiceBaseDados = 0;

            //apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de lista de nome e idade");
            //Criamos a variavel fora para nao ser criada novamente
            var escolhaInicial = ApresentaMenuInicial();

            while (true)
            {
                switch (escolhaInicial)

                {
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDados); } break;
                    case "2": { RemoverInformações(ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                        //menu que mostra somente registros desativados do sistema
                    case "4": { MostrarInformacoes(baseDeDados,"true"); } break;
                    case "5": { } return; //return dentro do nosso caso de escolha ele sai do nosso metotdo principal ou que estamos dentro de contexto

                }

                //alimento a escolha novamente
                escolhaInicial = ApresentaMenuInicial();
            }

        }
        /// <summary>
        /// Apresenta as informações do menu inicial
        /// </summary>
        /// <returns>Retorna o menu escolhido</returns>
        public static string ApresentaMenuInicial()

        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Insira um novo registro");
            Console.WriteLine("2 - Remover um novo registro");
            Console.WriteLine("3 - Listar informações");
            Console.WriteLine("4 - Listar informações desativadas");
            Console.WriteLine("5 - Sair do sistema");

            Console.WriteLine("Digite o numero da opção desejada");
            //retorna diretamente o menu escolhido
            return Console.ReadLine();
        }

        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int IndiceBaseDados)

        {
            Console.WriteLine("-------Inserindo Valores na Lista--------");
            Console.WriteLine("Informe um nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            var idade = Console.ReadLine();


            //aumenta o tamanho de nossa lista quando chega ao limite
            AumentaTamanhoLista(ref baseDeDados);


            //iniciamos o laço de repetição´para varrer nossa base de dados
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                // identificamos de maneira unica nosso registro "(" e ")" garante que ele incremente primeiro
                //antes de fazer a conversao para string
                baseDeDados[i, 0] = (IndiceBaseDados++).ToString();
                //carregamos na segunda coluna o valor do nome
                baseDeDados[i, 1] = nome;
                //terceira o valor da idade
                baseDeDados[i, 2] = idade;
                //carrega a coluna que identifica se o registro esta ativo
                baseDeDados[i, 3] = "true";
                //
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


                //finalizamos aqui apenas para inserir um registro por vez
                break;
            }

            Console.WriteLine("Registro cadastrado com sucesso");
            Console.WriteLine("Para voltar ao menu inicial basta apertar qualquer tecla. ");
            Console.ReadKey();




        }

        public static void MostrarInformacoes(string[,] baseDeDados, string mostrarregistrosNAtivos = "false")

        {
            Console.WriteLine("Apresentação das informações dentro da base de dados");

            if (mostrarregistrosNAtivos == "true")
            
                Console.WriteLine("Registros desativados dentro do sistema. ");
            

            //laço simples onde mostra de maneira formatada as informações
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Aqui deixamos mostrar as informaçoes que foram desabilitadas dentro do sistemas
                if (baseDeDados[i, 3] != mostrarregistrosNAtivos)

                    Console.WriteLine($"ID{baseDeDados[i, 0]} Nome: {baseDeDados[i, 1]} idade: {baseDeDados[i, 2]} Hora: {baseDeDados[i,4]}");
            }

            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla. ");

            Console.ReadKey();

        }

        public static void RemoverInformações(ref string[,] baseDeDados)
        {
            Console.WriteLine("Area de remoção de registro do sistema. ");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID:{baseDeDados[i, 0]} Nome:{baseDeDados[i, 1]} Idade:{baseDeDados[i, 2]} ");

            Console.WriteLine("Informe o id do registro a ser removido: ");
            var id = Console.ReadLine();

            //laço que remove o id caso exista
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {

                //Aqui comparamos o id colocamos um && pois a comparação de um valor 
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 3] = "false";
                    //indicamos a data que foi alterado esse registro
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                   
                }
            }

            Console.WriteLine("OPeraçoes finalizadas.");
            Console.WriteLine("Para retomar ao menu inicial precione qualquer tecla");
            Console.ReadKey();



        }
        /// <summary>
        /// metodo que aumenta a lista dinamicamente
        /// </summary>
        /// <param name="baseDeDados">retorna nossa base de dados</param>
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {//FAZENDO UM AUMENTO DE LISTA

            //verifica se prescisa uma lista maior
            var limiteDaLista = true;
            //laço que verifica se tem registros dispovivel
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                {
                    //caso nao existir registro disponivel ela seta nossa variavel limitedalista para false
                    if (baseDeDados[i, 0] == null)
                        limiteDaLista = false;
                }

            }
            // caso nao tenha mais registor disponivel fica true indicando que prescisamos aumentar a lista
            if (limiteDaLista)
            {
                var listaCopia = baseDeDados;

                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];
                // agora copiamos os registros da lista antiga para a nova
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    baseDeDados[i, 2] = listaCopia[i, 2];
                    baseDeDados[i, 3] = listaCopia[i, 3];
                    baseDeDados[i, 4] = listaCopia[i, 4];
                }

                Console.WriteLine("O tamanho da lista foi atualizado.");
            }


        }



    }
}
