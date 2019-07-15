using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add valores manualmente
namespace AddValoresNaLista
{
    class Program
    {


        static void Main(string[] args)
        {

            string[,] listaDeNome = new string[10, 2];
            //AQUI VAMOS CRAIR UMA FORMA EXTERNA DE IDENTIFICAR NOSSOS REGISTROS
            int IdParaLista = 0;

            insereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();

            insereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();
        }

        public static void insereRegistro(ref string[,] listaDeNome, ref int IdParaLista)

        {
            //AQUI ESTAREMOS EM UM LAÇO PARA INFORMAR NOSSOS REGISTROS
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {

                if (listaDeNome[i, 0] != null)
                    continue;
                // INDICAMOS QUE ELE DEVE APENAS INFORMAR O NOME DO REGISTRO
                Console.WriteLine("informe um nome para adicionar um registro");
                var nome = Console.ReadLine();

                //Criamos nosso identificador unico com um objeto eterno que mesmo
                //após sairmos do nosso laço ainda podera ser incrementado
                listaDeNome[i, 0] = (IdParaLista++).ToString();
                //Aqui colocamos o nosso nome na lista
                listaDeNome[i, 1] = nome;

                // identificamos se o memso ainda deseja inserir registros na lista
                Console.WriteLine("Deseja inserir um novo registro? sim(1) Não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;// Palavra reservada do c# que para, por isso brak, todo laço de repetição ou sequenciador logico

                AumentaTamanhoLista(ref listaDeNome);

            }

            Console.WriteLine("Registro adicionado com sucesso, lista das informações adicionadas: ");

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
                //Utilizamos o string format, basicamente ele faz da mesma forma que o $
                //a diferença entre eles é que este e um cara em grande quantidades
                //acaba sendo mais rápido

                Console.WriteLine(string.Format("Registro ID {0} - Nome: {1} ", listaDeNome[i, 0], listaDeNome[i, 1]));
        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {//FAZENDO UM AUMENTO DE LISTA

            //verifica se prescisa uma lista maior
            var limiteDaLista = true;
            //laço que verifica se tem registros dispovivel
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                {
                    //caso nao existir registro disponivel ela seta nossa variavel limitedalista para false
                    if (ListaDeNome[i, 0] == null)
                        limiteDaLista = false;
                }

            }
            // caso nao tenha mais registor disponivel fica true indicando que prescisamos aumentar a lista
                if (limiteDaLista)
                {
                    var listaCopia = ListaDeNome;

                    ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];
                // agora copiamos os registros da lista antiga para a nova
                    for (int i = 0; i < listaCopia.GetLength(0); i++)
                    {
                        ListaDeNome[i, 0] = listaCopia[i, 0];
                        ListaDeNome[i, 1] = listaCopia[i, 1];
                    }

                    Console.WriteLine("O tamanho da lista foi atualizado.");
                }
            

        }
    }
}
