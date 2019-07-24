using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe um valor Inicial");
            var primeiroValor = Console.ReadLine();

            Console.WriteLine("Informe um valor para comparação");
            var segundoValor = Console.ReadLine();


            if (primeiroValor == segundoValor)

                Console.WriteLine("o primeiro valor é igual o segundo");

            else

                Console.WriteLine("Nao existe nenhum valor igual no texto informado");

            if (segundoValor.Contains(primeiroValor))

                Console.WriteLine("o segundo valor contem em algum lugar do primeiro");

            if (segundoValor.IndexOf(primeiroValor) > -1)
                Console.WriteLine($"O primeiro existe dentro do segundo valor pos:{segundoValor.IndexOf(primeiroValor)}");
            else
                Console.WriteLine($"infelizmente ele nao retornou nad, pos: {segundoValor.IndexOf(primeiroValor)}");

            Console.ReadKey();
        }
    }
}
