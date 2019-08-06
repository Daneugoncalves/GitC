using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Carrega
{
    class CarregarLista
    {
        //Assinamos nossa lista no metodo construtor
        //com isso ja deixamos a lista pronta para uso nos demais metodos
        //sem precisar de um parametro para isso
        string[,] listaDeNome;


        public string[,] ListaNome { get { return listaDeNome; }}



        /// <summary>
        /// NOSSO METODO CONSTRUTOR QUE SEMPRE RECEBE O NOME DA CLASSE
        /// </summary>
        /// <param name="arrayBi"></param>
        public CarregarLista()
        {
            listaDeNome = new string[10, 2];
        }
        public void CarregaInformacoesEListaEmTela()


        {

            for (int i = 0; i < listaDeNome.GetLength(0); i++)

            {
                // CArregando oque podemos chamar de ID, identificador do nosso registro unico
                listaDeNome[i, 0] = i.ToString();
                // Aqui aprenas adicionamos uma informação extra
                listaDeNome[i, 1] = $"Daniel_{i}";
            }

            //Lembrando que o Getlength~´e um método e usamos "(parametro)" com parametro ou as vezes sem realizara chamada do mesmo
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam prestados
                Console.WriteLine($"ID: {listaDeNome[i, 0]} Nome:{listaDeNome[i, 1]}");

            }

        }
    }
}
