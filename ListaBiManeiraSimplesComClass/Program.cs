using ListaBiManeiraSimplesComClass.Carrega;
using ListaBiManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
    
            //Iniciando objetos em memoria
            var carregaLista = new CarregarLista();
            //aqui chamamos o metodo para carregar lista
            carregaLista.CarregaInformacoesEListaEmTela();

            var mostrarLista = new PesquisandoLista();

            mostrarLista.PesquisandoInformacoesNaNOssaLsta(carregaLista.ListaNome, "0");

            Console.ReadKey();
        }
    }
}
