using RevisaoWebApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisaoWebApi.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();


        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaLogin:
                        return ValidaLogin(value, validationContext.DisplayName);
                    case ValidFields.ValidaEmail:
                        return ValidarEmail(value, validationContext.DisplayName);
                    case ValidFields.ValidaSenha:
                        return ValidaSenha(value, validationContext.DisplayName);
                    case ValidFields.ValidaNome:
                        return ValidarNome(value, validationContext.DisplayName);
                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");

        }

        private ValidationResult ValidarEmail(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
            
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");

        }

        private ValidationResult ValidarNome(object value, string displayField)
        {

            bool result = Regex.IsMatch(value.ToString(), @"^((\b[A-zÀ-ú']{2,150}\b)\s*){2,}$");
            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayField} é inválido.");

        }


        private ValidationResult ValidaSenha(object value, string displayField)
        {

            bool result = Regex.IsMatch(value.ToString(), @"^.*(?=.{8,16})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@!#$%^&+=]).*$");
            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayField} é inválido.");

        }

        private ValidationResult ValidaLogin(object value, string displayField)
        {

            Usuario user = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString());

            if (user == null)
                return ValidationResult.Success;
            return new ValidationResult($"O usuário já existe.");



        }

    }
}