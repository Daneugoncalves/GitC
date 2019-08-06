using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeArquivosDoWindows ;

namespace MyFirstBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {

            var teste = new GetFiles();

            var listaDocuments = teste.RetornaArquivosDoMeuDocumentos();

            for (int i = 0; i < listaDocuments.Length; i++)

            {
                Console.WriteLine(listaDocuments[i]);
                Console.ReadKey();
            }


            
            var ListaGit = teste.RetornaArquivosGit();
          
            for (int i = 0; i < ListaGit.Length; i++)
          
            {
                    Console.WriteLine(ListaGit[i]);
                    Console.ReadKey();
             
            }


            var listaDePictures = teste.RetornaArquivosImagesFiles();

            for (int i = 0; i < listaDePictures.Length; i++)

            {
                Console.WriteLine(listaDePictures[i]);
                Console.ReadKey();
            }
        }

 
    }
}
