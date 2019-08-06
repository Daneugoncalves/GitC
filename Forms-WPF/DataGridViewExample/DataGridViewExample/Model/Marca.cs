﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewExample.Model
{
   public class Marca
    {
            public string Nome { get; set; }
            public bool Ativo { get; set; } = true;
            public int UsuInc { get; set; }
            public int UsuAlt { get; set; }
            public DateTime dateInc { get; set; } = DateTime.Now;
            public DateTime dateAlt { get; set; } = DateTime.Now;
    }
}
