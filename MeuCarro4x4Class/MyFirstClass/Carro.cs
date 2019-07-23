using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
    class Carro
    {

       public int rodas { } = 0;
       public int portas {} = 0;
       public int bancos {} = 0;
       public int janelas{} = 0;

        public int Rodas
        {
            get { return rodas; }
            set { rodas = value; }
        }

        public void MostrarCarro()
        {
            Console.WriteLine($"Nosso carro: \r\n" +
                    $"Quantidade de rodas[{rodas}]\r\n" +
                    $"Quantidade de portas[{portas}]\r\n" +
                    $"Quantidade de bancos[{bancos}]\r\n" +
                    $"Quantidade de janelas[{janelas}]");
                   
        }
    }
}
