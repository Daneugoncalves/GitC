using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoFuncoesClass
{
    public class ControlaEstacionamento
    {

        string[,] ArrayCarros = new string[2, 5];
        int IDcarro = 0;


        public void CadastrarCarro()
        {
            for (int i = 0; i < ArrayCarros.GetLength(0); i++)
            {

                Console.WriteLine("Informe a placa do veiculo");
                var Placa = Console.ReadLine();

                Console.WriteLine("Infome o modelo do veiculo");
                var Modelo = Console.ReadLine();

                var DataEntrada = Convert.ToString(DateTime.Now);

                ArrayCarros[i, 0] = (IDcarro++).ToString();
                ArrayCarros[i, 1] = Placa;
                ArrayCarros[i, 2] = Modelo;
                ArrayCarros[i, 3] = DataEntrada;
                ArrayCarros[i, 4] = null;

            }

            Console.ReadKey();
        }//INSERE OS REGISTROS NO CARRO

        public void listarCarros()

        {
            for (int i = 0; i < ArrayCarros.GetLength(0); i++)
            {

                {
                    Console.WriteLine($"Id..........: {ArrayCarros[i, 0]}");
                    Console.WriteLine($"Placa........: {ArrayCarros[i, 1]}");
                    Console.WriteLine($"Modelo.......: {ArrayCarros[i, 2]}");
                    Console.WriteLine($"Data de entrada: {ArrayCarros[i, 3]}");
                    Console.WriteLine($"Data de Saida: {ArrayCarros[i, 4]}\n");

                }
            }

            Console.ReadKey();

        }// LISTA TUDOS

        public void ListaTiketsNValidados()
        {
            for (int i = 0; i < ArrayCarros.GetLength(0); i++)
            {
                if (ArrayCarros[i, 4] == null)
                {
                    Console.WriteLine($"Id..........: {ArrayCarros[i, 0]}");
                    Console.WriteLine($"Placa........: {ArrayCarros[i, 1]}");
                    Console.WriteLine($"Modelo.......: {ArrayCarros[i, 2]}");
                    Console.WriteLine($"Data de entrada: {ArrayCarros[i, 3]}");
                    Console.WriteLine($"Data de Saida: {ArrayCarros[i, 4]}\n");

                }
            }

            Console.ReadKey();
        }// LISTA OS QUE NAO TEM DATA DE SAIDA

        public void ValidaEstacionamento()
        {
            var valida = Convert.ToString(DateTime.Now);

            for (int i = 0; i < ArrayCarros.GetLength(0); i++)
            {
                if (ArrayCarros[i, 4] != "null")

                    Console.WriteLine($"ID: {ArrayCarros[i, 0]}, Nome: {ArrayCarros[i, 1]} Modelo: {ArrayCarros[i, 2]}");
            }

            Console.WriteLine("Informe o ID a ser Validado: ");
            var id = Console.ReadLine();

            for (int i = 0; i < ArrayCarros.GetLength(0); i++)
            {
                if (ArrayCarros[i, 0] != null && ArrayCarros[i, 0] == id)
                {
                    ArrayCarros[i, 4] = valida;
                }
            }


        } //DEU CERTO

        public void PesquisaCarros1()
        {
            Console.WriteLine("Digite o ID a ser pesquisado");
            var IdPesquisado = Console.ReadLine();

            for (int i = 0; i < ArrayCarros.GetLength(0); i++)
            {
                if (IdPesquisado == ArrayCarros[i, 0])
                {
                    Console.WriteLine($"Resultados para o ID: {IdPesquisado}");
                    Console.WriteLine($"Placa: {ArrayCarros[i, 1]}");

                    return;
                }
            }

            Console.ReadKey();
        }

       


    }
}
