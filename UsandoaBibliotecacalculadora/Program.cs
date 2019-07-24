using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDaCalculadora;

namespace UsandoaBibliotecacalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            calc.PedeNumeros();

            Console.WriteLine(calc.CalculaAdicao(5, 5));
            Console.ReadKey();
        }
    }
}
