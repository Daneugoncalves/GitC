using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento
{
    public class Carro
    {
        string[,] ArrayCarros = new string[1, 5];
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
        }

        public void listarCarros()

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
        }

       
    }
}
