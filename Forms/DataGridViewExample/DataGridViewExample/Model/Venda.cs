using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewExample.Model
{
   public class Venda
    {
        public int Carro { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; } = true;
        public int UsuAlt { get; set; }
        public DateTime dateInc { get; set; } = DateTime.Now;
        public DateTime dateAlt { get; set; } = DateTime.Now;

    }
}
