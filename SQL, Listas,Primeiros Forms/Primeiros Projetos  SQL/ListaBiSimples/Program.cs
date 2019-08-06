using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSimples
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // criando lista com mais de uma dimensão


            //usando um laço simples para colocar valores mas no memso agora utilizando o
            // GetLength com o paramtro "0" para indicar que queremos o tamanho da primeira coluna
            string[,] listaDeNome = new string[5, 2];

            //Aqui como estamos usando apenas uma referencia da nossa lista colocamos ref ao passar ela no metodo
            CarregaInformacoesEListaEmTela(ref listaDeNome);

            // apos carregar informacoes e mostrar na tela espera um comando 
            Console.ReadKey();

            Console.WriteLine("informe i ID do registro a ser pesquisado.");
           

            PesquisandoInformacoesNaNOssaLsta(listaDeNome, Console.ReadLine());

            Console.ReadKey();

            //Aqui 

        }
        public static void CarregaInformacoesEListaEmTela(ref string[,] arrayBi)


        {

            for (int i = 0; i < arrayBi.GetLength(0); i++)

            {
                // CArregando oque podemos chamar de ID, identificador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                // Aqui aprenas adicionamos uma informação extra
                arrayBi[i, 1] = $"Daniel_{i}";
            }

            //Lembrando que o Getlength~´e um método e usamos "(parametro)" com parametro ou as vezes sem realizara chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam prestados
                Console.WriteLine($"ID: {arrayBi[i, 0]} Nome:{arrayBi[i, 1]}");

            }

        }

        public static void PesquisandoInformacoesNaNOssaLsta(string[,] arrayBi, string pId)

        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {

                //Realizando nossa comparação dos mesmos tipos
                if (arrayBi[i,0] == pId)

                {
                    //mostramos as infomcaoes formatadas da nossa pesquisa
                    Console.WriteLine($"Informações escolhida: Id: {arrayBi[i,0]} - Nome: {arrayBi[i,1]}");
                    //Aqui saimos da nossa lista mas retornameos vazio "return" pois estamos em um metodo vazio "void
                    //que nao esperamos retornar algo"

                    return;
                }
            }

            Console.WriteLine("Infelizmente a busca pelo id nao resultou em nenhuma informação");

        }

    }


}
