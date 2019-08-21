﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPIRESTFULL.Models;
using WEBAPIRESTFULL.Utils;

namespace WEBAPIRESTFULL.Controllers
{
    public class MathFile : Single<MathFile>
    {
        BibliotecaContextDB bibliotecaContectDB = new BibliotecaContextDB();

        public int QuantidadedeUsuarios()
        {
            return bibliotecaContectDB
                .Usuarios.Count();
        }
    }
}