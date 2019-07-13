using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEITA_BOLO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COMO FAZER UM BOLO: ");
            Console.WriteLine("");

            Console.WriteLine("INGREDIENTES NESCESSARIOS");
            Console.WriteLine("");

            ListaDeIngredientes();

           

            Console.WriteLine();
            Console.WriteLine("VOCÊ TEM TODOS INGREDIENTES?");
            Console.WriteLine("DIGITE (1) PARA SIM E (2) PARA NÃO");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
               {
                   Console.WriteLine();
                   Console.WriteLine("PASSO A PASSO || COMO FAZER");
                   Console.WriteLine("");
               }
              
               if (opcao == 2)
              
               {
                   Console.WriteLine();
                   Console.WriteLine("Não sera possivel fazer essa receita por falta de ingredientes");
                   Console.WriteLine("");

                return;
              
               }
            

            List<string> Listabolo = new List<string>();
            Listabolo.Add("Adicione 3 xícaras de chá de farinha de trigo(Sem fermento)");
            Listabolo.Add("Adicione 2 xícaras de chá de açúcar)");
            Listabolo.Add("Adicione 3 ovos)");
            Listabolo.Add("Adicione 200 ml de leite)");
            Listabolo.Add("Adicione 4 colheres sopa de manteiga)");
            Listabolo.Add("Adicione 1 colher de sopa de fermento químico em pó)");
            Listabolo.Add("Numa tigela, junte os ovos, o açúcar e a manteiga.)");
            Listabolo.Add("Misture tudo muito bem e adicione o leite. ");
            Listabolo.Add("Leve para assar em forno preaquecido, 180ºC, por cerca de 40 minutinhos ou até dourar.");


            foreach (var item in Listabolo)
            {
                Console.ReadKey();
                Console.WriteLine(item);

            }

        }
        public static void ListaDeIngredientes()

        {
            List<string> ingredientes = new List<string>();
            ingredientes.Add("3 Ovos");
            ingredientes.Add("200g farinha");
            ingredientes.Add("200ml leite");
            ingredientes.Add("2 colher de manteiga");

            foreach (var item in ingredientes)
            {
                Console.ReadKey();
                Console.WriteLine(item);
            }
        }
    }
}
