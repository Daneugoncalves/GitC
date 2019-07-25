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

            Console.WriteLine("Digite a nota1");
            var nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota2");
            var nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota3");
            var nota3 = Convert.ToInt32(Console.ReadLine());

            var media = bol.CalculaMedia(nota1, nota2, nota3);
            var frequencia = bol.CalculaFrequencia(100, 10);

            bol.situacao(media, frequencia);
            Console.ReadKey();

        }
    }
}
