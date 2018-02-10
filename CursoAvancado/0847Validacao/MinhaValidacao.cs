using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _0847Validacao
{
    class MinhaValidacao : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (((string)value).Length <= 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
