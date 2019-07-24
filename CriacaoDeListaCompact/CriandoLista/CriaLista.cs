using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaCompact.CriandoLista
{
    class CriaLista
    {
        string[] lista = new string[10];

        public CriaLista()
        {
            crialista();
            Listar();
            LimpaLista();
            Listar();
        }

        public void crialista()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            }
        }

        public void Listar()
        {
            foreach (var item in lista)

                Console.WriteLine(item);
            Console.ReadKey();
        }

        public void LimpaLista()
        {
            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;

        }
    }

}
