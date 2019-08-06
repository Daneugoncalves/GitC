using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
    class Carro
    {

       public int rodas { get; set; } = 0;
       public int portas { get; set; } = 0;
       public int bancos { get; set; } = 0;
       public int janelas{ get; set; } = 0;

        public static Carro operator ++(Carro carro)
        {
            carro.rodas = carro.rodas + 5;
            return carro;
        }

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
