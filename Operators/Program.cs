using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new Teste(5,5); //novo bloco de memoria / nova instancia (NEW)


            elementoX.mostrarInformacoes();
            elementoX.AlteraInformacoes(5,5);
            elementoX.mostrarInformacoes();
            elementoX.AlteraInformacoes();
            elementoX.mostrarInformacoes();

            Console.ReadKey();
        }
    }

    public class Teste

    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0;
        public Teste(int pA, int pB)
        {
            A = pA;
            B = pB;
        }
        
        public void AlteraInformacoes()
        {
            A = B * 100;
        }
        public void AlteraInformacoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }
        public void mostrarInformacoes()
        {
            Console.WriteLine(A + B);
        }
    }
}
