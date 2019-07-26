using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCalculadora;

namespace UsandoBibliotecaCalcExterna
{
    class Program
    {
        static void Main(string[] args)
        {

            Operacoes bl = new Operacoes();


            Console.WriteLine("Digite primeiro numero");
            var valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite segundo numero");
            var valor2 = Convert.ToDouble(Console.ReadLine());

            bl.CalculaAdicao(valor1, valor2);

            Console.WriteLine()
            Console.ReadLine();




        }
    }
}
