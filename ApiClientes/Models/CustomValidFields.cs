using ApiClientes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ApiClientes.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();
        private ValidFields typeField;

        public CustomValidFields(ValidFields Type)
        {
            typeField = Type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)

        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaNome:
                        return ValidarNome(value, validationContext.DisplayName);
                    case ValidFields.ValidaCPFouCNPJ:
                        return ValidarCPFouCNPJ(value, validationContext.DisplayName);
                    case ValidFields.ValidaCEP:
                        return ValidarCEP(value, validationContext.DisplayName);
                    case ValidFields.ValidaEndereço:
                        return ValidarEnderecosGenerico(value, validationContext.DisplayName);
                    case ValidFields.ValidaEstado:
                        return ValidarEnderecosGenerico(value, validationContext.DisplayName);
                    case ValidFields.ValidaTelefone:
                        return ValidarTelefone(value, validationContext.DisplayName);
                    case ValidFields.ValidaCelular:
                        return ValidarCelular(value, validationContext.DisplayName);
                    case ValidFields.ValidaEmail:
                        return ValidarEmail(value, validationContext.DisplayName);
                    case ValidFields.ValidaRG:
                        return ValidarRG(value, validationContext.DisplayName);
                    case ValidFields.ValidaNomeFantasia:
                        return ValidarEnderecosGenerico(value, validationContext.DisplayName);
                    case ValidFields.ValidaCidade:
                        return ValidarEnderecosGenerico(value, validationContext.DisplayName);
                    case ValidFields.ValidaEstadoCivil:
                        return ValidarEstadoCivil(value, validationContext.DisplayName);
                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }
        private ValidationResult ValidarNome(object value, string displayField)
        {

            bool result = Regex.IsMatch(value.ToString(), @"^((\b[A-zÀ-ú']{2,150}\b)\s*){2,}$");
            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayField} é inválido.");

        }
        private ValidationResult ValidarCPFouCNPJ(object value, string displayField)
        {
            Usuario user = dB.usuarios.FirstOrDefault(x => x.CPFCNPJ == value.ToString());
            if (user == null)
            {
                bool result = Regex.IsMatch(value.ToString(), @"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)|(^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$)");
                if (result)
                    return ValidationResult.Success;
                else
                {
                    return new ValidationResult($"O campo {displayField} é inválido.");
                }


            }
            return new ValidationResult($"O CNPJ ou CPF já existe no sistema.");


        }
        private ValidationResult ValidarCEP(object value, string displayField)
        {

            bool result = Regex.IsMatch(value.ToString(), @"^[0-9]{5}[-]?[0-9]{3}$");
            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarEnderecosGenerico(object value, string displayField)
        {

            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");
            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarTelefone(object value, string displayField)
        {

            bool result = Regex.IsMatch(value.ToString(), @"^\([1-9]{2}\) (?:[2-8])[0-9]{3}\-[0-9]{4}$");
            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarCelular(object value, string displayField)
        {

            bool result = Regex.IsMatch(value.ToString(), @"^\([1-9]{2}\) (?:9[1-9])[0-9]{3}\-[0-9]{4}$");
            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarEmail(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)

                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");

        }
        private ValidationResult ValidarRG(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[0-9]{1,3}.?[0-9]{2,3}.?[0-9]{3}-?[A-Za-z0-9]{1}$");

            if (result)

                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");

        }
        private ValidationResult ValidarEstadoCivil(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"/^[A-Za-z]+$");

            if (result)

                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");

        }
    }
}