using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class Operacoes
    {
        public double CalculaAdicao(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
        public double CalculaSubtracao(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        public double CalculaMultiplicacao(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
        public double CalculaDivisao(double valor1, double valor2)
        {
            return valor1 / valor2;
        }
        public double CalculaAreaRetangulo(double valor1, double valor2, double area)
        {
            return area = valor2 * valor1;
        }
        public double CalculoTrianguloEquilatero(double valor1, double valor2)
        {
             return (valor1 * valor2) / 2;
        }
        public double RaioDeUmCirculo(double valor1)
        {
            return (valor1 * Math.PI);
        }

    }
}
