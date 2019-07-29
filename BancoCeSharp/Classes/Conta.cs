using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    public class Conta
    {
        double saldo = 0; //private

        //Propriedade  que contem o valor saldo 
        public double Saldo { get { return saldo; } }

        public Conta()
        {
            saldo = 1000;
        }
        /// <summary>
              /// Metodo para sacar dinheiro de acordo com o saldo disponivel
              /// </summary>
              /// <param name="valor">Parametro valor a ser sacado</param>
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {//desconta o valor em saldo da conta
                saldo -= valor;
                return true;
            }
            //rtorna false em caso de nao ter saldo disponivel
            return false;
         
        }

        public double MostrarSaldo()
        {
            return saldo;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
    }
}
