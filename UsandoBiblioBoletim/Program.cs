using BibliotecaBoletinEscolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBiblioBoletim
{
    class Program
    {
        static void Main(string[] args)
        {
            Boletim bol = new Boletim();
            Listas lis = new Listas();

            lis.Menu();

            Console.ReadKey();

        }
      

    }

  
}
