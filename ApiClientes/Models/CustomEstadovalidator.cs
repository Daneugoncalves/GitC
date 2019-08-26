using ApiClientes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiClientes.Models
{
    public class CustomEstadovalidator : ValidationAttribute
    {

        private ValidEstadoCivil TypeEstadoCivil;


        public CustomEstadovalidator(ValidEstadoCivil TypeE)
        {
            TypeEstadoCivil = TypeE;
        }


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (TypeEstadoCivil)
                {
                    case ValidEstadoCivil.Solteiro:
                        return ValidarSolteiro(value, validationContext.DisplayName);
                    case ValidEstadoCivil.Casado:
                        return ValidarSolteiro(value, validationContext.DisplayName);
                    case ValidEstadoCivil.Viuvo:
                        return ValidarSolteiro(value, validationContext.DisplayName);
                    case ValidEstadoCivil.Divorciado:
                        return ValidarSolteiro(value, validationContext.DisplayName);
                    default:
                        break;
                }
            }
            return new ValidationResult("O campo" + validationContext.DisplayName + "é um campo obrigatório");


        }

        private ValidationResult ValidarSolteiro(object value, string displayField)
        {
            if (value != null)
            {
                if (value.ToString() == "Solteiro")
                {
                    return ValidationResult.Success;
                }

                if (value.ToString() == "Casado")
                {
                    return ValidationResult.Success;
                }

                if (value.ToString() == "Viuvo")
                {
                    return ValidationResult.Success;
                }

                if (value.ToString() == "Divorciado")
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult($"O campo {displayField} é inválido.");

        }
    }
}
