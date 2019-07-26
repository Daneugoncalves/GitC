using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandobibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
            new AquiMostraJOinha().MetodoInicialDoJoinha();

            new AquiMostraJOinha().MetodoDOisPontoZero(true);
            new AquiMostraJOinha().MetodoDOisPontoZero(false);

            Console.WriteLine(new AquiMostraJOinha().TesteUmOperadorLegal());

            Console.ReadKey();
        }
    }
}
