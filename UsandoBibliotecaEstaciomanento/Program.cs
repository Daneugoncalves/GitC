using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEstacionamento;

namespace UsandoBibliotecaEstaciomanento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro Auto = new Carro(); 
            Auto.CadastrarCarro();
            Auto.listarCarros();
           
        }
    }
}
