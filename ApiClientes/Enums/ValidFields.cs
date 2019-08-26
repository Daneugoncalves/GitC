using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClientes.Enums
{
    public enum ValidFields
    {
        ValidaNome,
        ValidaRG,
        ValidaCPFouCNPJ,
        ValidaNomeFantasia,
        ValidaCEP,
        ValidaTelefone,
        ValidaEndereço,
        ValidaCidade,
        ValidaEstado,
        ValidaCelular,
        ValidaEmail,
        ValidaEstadoCivil
    }

    public enum ValidEstadoCivil
    {
        Solteiro,
        Casado,
        Viuvo,
        Divorciado
    }
}