using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validators.StaticClasses
{
    static class ValidateString
    {
        public static bool ValidateValueEmpty(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                return true;
            }
            return false;
        }
    }
}
