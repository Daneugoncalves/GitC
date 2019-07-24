using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDaCalculadora
{

    public class Calculadora
    {

        public void PedeNumeros()
        {
            int valor1, valor2;
            string NumeosD;

            Console.WriteLine("Digite um número: ");
            NumeosD = Console.ReadLine();
            valor1 = int.Parse(NumeosD);

            Console.WriteLine("Digite mais um número: ");
            Console.ReadLine();
            valor2 = int.Parse(NumeosD);



        }
            public int CalculaAdicao(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int CalculaSubtracao(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int CalculaMultiplicacao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int CalculaDivisao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        
    }  
}
