using ApiClientes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ApiClientes.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaNome)]
        public string Nome { get; set; }
        public ValidEstadoCivil EstadoCivil { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaRG)]
        public int RG { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaCPFouCNPJ)]
        public string CPFCNPJ { get; set; }
        public string NomeFantasia  { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaCEP)]
        public string Cep { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaEndereço)]
        public string Endereço { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaCidade)]
        public string Cidade { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaEstado)]
        public string Estado { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaTelefone)]
        public string Telefone { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaCelular)]
        public string Celular { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

    }
}