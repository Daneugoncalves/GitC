using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_1
{
    class Program
    {

        static void Main(string[] args)


        {

            #region Sistema de bebidas
            /*

                         Console.WriteLine("OLÁ BEM VINDO AO SISTEMA!");


                         Console.WriteLine("DIGITE SEU NOME");

                         var nome = Console.ReadLine();



                         Console.WriteLine("DIGITE SUA IDADE!");

                         string line = Console.ReadLine();
                         int idade = Convert.ToInt32(line);

                         if (idade > 17)
                         {
                             Console.WriteLine($"pode beber{nome}");
                             Console.ReadKey();
                         }

                         else

                         {
                             Console.WriteLine($"Nao pode ein{nome}");
                             Console.ReadKey();
                         }

                 */
            #endregion

            #region Fazer bolo

            /*
            Console.WriteLine("COMO FAZER UM BOLO: ");
            Console.WriteLine("");

            Console.WriteLine("INGREDIENTES NESCESSARIOS");
            Console.WriteLine("");


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

            Console.WriteLine("PASSO A PASSO || COMO FAZER");
            Console.WriteLine("");

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
            */

            #endregion




            string[,] alunos = new string[20, 3] { { "Aluno1", "19", "M" }, { "Aluno11", "45", "F" },
                                                   { "Aluno2", "22", "F" }, { "Aluno12", "11", "M" },
                                                   { "Aluno3", "31", "M" }, { "Aluno13", "33", "M" },
                                                   { "Aluno4", "44", "F" }, { "Aluno14", "23", "F" },
                                                   { "Aluno5", "12", "F" }, { "Aluno15", "23", "M" },
                                                   { "Aluno6", "13", "M" }, { "Aluno16", "32", "F" },
                                                   { "Aluno7", "34", "M" }, { "Aluno17", "32", "M" },
                                                   { "Aluno8", "12", "F" }, { "Aluno18", "13", "M" },
                                                   { "Aluno9", "55", "M" }, { "Aluno19", "17", "F" },
                                                   { "Aluno10", "12", "M"}, { "Aluno20", "23", "M" } };

            for (int i = 0; i < alunos.GetLength(0); i++)
            
                
                    Console.WriteLine($"O Aluno: {alunos[i,0]}" +
                          $" tem a idade: {alunos[i, 1]}" +
                          $" é do sexo: {alunos[i, 2]}");

            Console.ReadKey();

        }

    
    }
}
