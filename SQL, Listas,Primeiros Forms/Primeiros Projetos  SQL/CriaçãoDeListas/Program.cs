using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaçãoDeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");


            //Iniciando uma lista de string com array linear
            string[] lista = new string[10]; // define posições na lista com 10 espaços de memoria para alocar info de texto


            // laço que usamos geralmente para andar sobre as posições de nossa lista
            for (int i = 0; i < lista.Length; i++)
            {
                //carregando os valores da nossa lista aqui
                // aonde i representa cada espaço que temos disponivel
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //DateTime e um tipo de .net c# que disponibiliza funçoes realacionadas a datas e horas .

            }

            // laço de repetiçao que usamos para varrer nossa lista de maneira mais simples

            foreach (var item in lista) // var item indica uma unidade da nossa lista "in lista" indoca a lista que queremos varrer
            {
                Console.WriteLine(item);// apresetamos na tela


            }
            Console.ReadKey();

            for (int i = 0; i < lista.Length; i++)

                lista[i] = string.Empty;// Aqui limpamos o valor dentro da coleção


            // laço de repetiçao que usamos para varrer nossa lista de maneira mais simples

            foreach (var item in lista) // var item indica uma unidade da nossa lista "in lista" indoca a lista que queremos varrer
            
                Console.WriteLine(item);// apresetamos na tela
                Console.ReadKey();
            


        }
    }
}
