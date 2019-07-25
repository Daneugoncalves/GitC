using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBoletinEscolar
{
    public class Listas
    {
        string[,] arrayAluno = new string[2, 6];
        Boletim boletim = new Boletim();

        int indiceBase = 0;


        public void inserir()
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                arrayAluno[i, 0] = (indiceBase++).ToString();
                Console.WriteLine("Informe o nome do aluno");
                var nome = Console.ReadLine();
                arrayAluno[i, 1] = nome;

                arrayAluno[i, 5] = "true";
                Console.WriteLine($"Informe a primeira nota de {nome}");
                int.TryParse(Console.ReadLine(), out int nota1);

                Console.WriteLine($"Informe a segunda nota de {nome}");
                int.TryParse(Console.ReadLine(), out int nota2);

                Console.WriteLine($"Informe a terceira nota de {nome} ");
                int.TryParse(Console.ReadLine(), out int nota3);

                //calculando a media
                var media = boletim.medias(nota1, nota2, nota3);
                arrayAluno[i, 2] = media.ToString();

                //informações e frequencia
                Console.WriteLine("Informe o numero de aulas");
                int.TryParse(Console.ReadLine(), out int totalAulas);

                Console.WriteLine("Informe o numero de faltas");
                int.TryParse(Console.ReadLine(), out int numeroFaltas);
                var frequencia = boletim.frequencia(totalAulas, numeroFaltas);
                //informa situação                
                arrayAluno[i, 4] = boletim.RetornaSituacao(media, frequencia);
                arrayAluno[i, 3] = frequencia.ToString();

            }
        }

        public void listar()
        {

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {

                if (arrayAluno[i, 5] == "true")
                {
                    Console.WriteLine($"Id..........: {arrayAluno[i, 0]}");
                    Console.WriteLine($"Nome........: {arrayAluno[i, 1]}");
                    Console.WriteLine($"Média.......: {arrayAluno[i, 2]}");
                    Console.WriteLine($"Frequência..: {arrayAluno[i, 3]}%");
                    Console.WriteLine($"Situação....: {arrayAluno[i, 4]}\n");
                
                }
            }
            Console.ReadKey();
        }

        public void RemoverInformacoes()
        {

            Console.WriteLine("Area de remoção de registro do sistema.");


            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                //Identifica que so deve remover os valores ativos dentro do sistema
                if (arrayAluno[i, 5] != "false")
                    Console.WriteLine($"ID:{arrayAluno[i, 0]} " +
                          $"- Nome:{arrayAluno[i, 1]} " +
                          $"- Média:{arrayAluno[i, 2]}");
            }


            Console.WriteLine("Informe o id do registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] != null && arrayAluno[i, 0] == id)
                {  //Agora trocamos este valor para um identificador string "false"
                    arrayAluno[i, 5] = "false";
                }
                //Finalizamos as operações desta tela
                Console.WriteLine("Operações finalizadas.");
                Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
                Console.ReadKey();
            }


        }

        public string ApresentaMenuInicial()
        {

            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inseir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");

            return Console.ReadLine();
        }

        public void  Menu()

        {
           string escolhaInicial = ApresentaMenuInicial();

            while (true)
            {

                switch (escolhaInicial)
                {

                    case "1": inserir(); break;

                    case "2": RemoverInformacoes(); break;

                    case "3": listar(); break;

                    case "5":
                        {
                            return;
                        }
                }

                escolhaInicial = ApresentaMenuInicial();
            }
        }
    }

    
}


