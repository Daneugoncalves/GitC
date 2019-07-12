using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_20_NOMES
{
    class Program
    {
        static string[,] alunos;
        static void Main(string[] args)
        {
            CarregaBaseDeAlunos();

            Console.WriteLine("LISTA DE ALUNOS");
            Console.WriteLine("");
            Console.WriteLine("DIGITE (1) PARA LISTAR ALUNOS E (2) PARA SAIR DO SISTEMA");
            Console.WriteLine("");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
            {
                MostarLIsta(); 
            }

            if (opcao == 2)

            {
                return;
            }
        }

        public static void CarregaBaseDeAlunos()

        {
             alunos = new string[20, 3] { { "Aluno01", "19", "M" },{ "Aluno02", "45", "F" },
                                                   { "Aluno03", "22", "F" },{ "Aluno04", "11", "M" },
                                                   { "Aluno05", "31", "M" },{ "Aluno06", "33", "M" },
                                                   { "Aluno07", "44", "F" },{ "Aluno08", "23", "F" },
                                                   { "Aluno09", "12", "F" },{ "Aluno10", "23", "M" },
                                                   { "Aluno11", "13", "M" },{ "Aluno12", "32", "F" },
                                                   { "Aluno13", "34", "M" },{ "Aluno14", "32", "M" },
                                                   { "Aluno15", "12", "F" },{ "Aluno16", "13", "M" },
                                                   { "Aluno17", "55", "M" },{ "Aluno18", "17", "F" },
                                                   { "Aluno19", "12", "M"},{ "Aluno20", "23", "M" } };

        }

        public static void MostarLIsta()

        {

           for (int i = 0; i < alunos.GetLength(0); i++)
         
         
               Console.WriteLine($"O Aluno: {alunos[i, 0]}" +
                     $" tem a idade: {alunos[i, 1]}" +
                     $" é do sexo: {alunos[i, 2]}");
         
           Console.ReadKey();

        }

    }
}

