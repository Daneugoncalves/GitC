using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Mostrar
{
    class PesquisandoLista
    {
        public void PesquisandoInformacoesNaNOssaLsta(string[,] arrayBi, string pId)

        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {

                //Realizando nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)

                {
                    //mostramos as infomcaoes formatadas da nossa pesquisa
                    Console.WriteLine($"Informações escolhida: Id: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
                    //Aqui saimos da nossa lista mas retornameos vazio "return" pois estamos em um metodo vazio "void
                    //que nao esperamos retornar algo"

                    return;
                }
            }

            Console.WriteLine("Infelizmente a busca pelo id nao resultou em nenhuma informação");

        }
    }
}
