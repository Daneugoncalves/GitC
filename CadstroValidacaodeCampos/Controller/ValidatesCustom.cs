using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CadstroValidacaodeCampos.Controller
{
   public class ValidatesCustom
    {
        public static bool ValidEmail(string email)
        {
            var stringRegEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regexEmail = new Regex(stringRegEmail);
            return regexEmail.IsMatch(email);
        }
    }
}
