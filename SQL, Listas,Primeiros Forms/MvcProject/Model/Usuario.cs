using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.Model
{
    public class Usuario : Informacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DatInc { get; set; }
        public DateTime DatAlt { get; set; }
    }
}
