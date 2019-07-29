using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG.Classes
{
    class ContaM
    {
        double saldo = 20;

        public double Saldo
        {
            get { return saldo; }
           
        }

        public bool comprarLache(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

      

    


    }
}
