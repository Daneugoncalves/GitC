using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJOinha
    {
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui iniciamos o joinha");
            Console.ReadKey();
            ; }

        public void MetodoDOisPontoZero(bool eQuinta)

        {
            if (eQuinta)

                Console.WriteLine("huehueehu");

            else
                Console.WriteLine("kakaka");

            Console.ReadKey();

        }

        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "t1", "t2" };
        }


    }
}
