﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Classe
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Turma { get; set; }

        public DateTime DatInc { get; set; } = DateTime.Now;
    }
}
