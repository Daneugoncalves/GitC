﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.Model
{
   public class Informacao 
    {
        public bool Ativo { get; set; }
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public DateTime DataInc { get; set; }
        public DateTime DataAlt { get; set; }


    }
}
