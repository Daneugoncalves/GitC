using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraDoisPontoZero;

namespace UsandoBibliotecaCalcExterna
{
    class Program
    {
        static int valor1 = 0;
        static int valor2 = 0;

        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();

            mostraMenu();
            var escolha = Convert.ToInt32(Console.ReadLine());
            int caseSwitch = escolha;
            switch (caseSwitch)
            {
                case 1:

                    pede2numeros();
                    Console.WriteLine(cal.CalculadoraSomar(valor1, valor2));
                    Console.ReadLine();
                    break;

                case 2:
                    pede2numeros();
                    Console.WriteLine(cal.CalculadoraDiminuir(valor1, valor2));
                    Console.ReadLine();
                    break;

                case 3:
                    pede2numeros();
                    Console.WriteLine(cal.CalculadoraDuvidir(valor1, valor2));
                    Console.ReadLine();
                    break;

                case 4:
                    pede2numeros();
                    Console.WriteLine(cal.CalculadoraMultiplicar(valor1, valor2));
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Digite a area do Circulo");
                    var area = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(cal.CalcularCirculo(area));
                    Console.ReadLine();
                    break;

                case 6:

                    Console.WriteLine("Digite a base do retangulo (CM)");
                    var Base = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a altura do retangulo (cm)");
                    var Altura = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(cal.CalcularRetangulo(Base, Altura));
                    Console.ReadLine();
                    break;

                case 7:

                    Console.WriteLine("Digite a base do triangulo (CM)");
                    var BaseT = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a altura do triangulo (cm)");
                    var AlturaT = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(cal.CalcularRetangulo(BaseT, AlturaT));
                    Console.ReadLine();

                    break;
            }
        }

        public static void pede2numeros()
        {
            Console.WriteLine("Digite primeiro numero");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite segundo numero");
            valor2 = Convert.ToInt32(Console.ReadLine());

        }
        public static void mostraMenu()
        {
            Console.WriteLine("Digite:|| 1 - Soma || 2-Subtrai || 3-Dividir|| 4-Multiplicar");
            Console.WriteLine("Digite:|| 5 - Area Circulo || 6-Retangulo || 7-Triangulo ||");
        }
    }
}
