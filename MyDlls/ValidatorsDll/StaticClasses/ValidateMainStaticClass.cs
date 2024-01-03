using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validators.StaticClasses
{
    static class ValidateMainStaticClass
    {
        public static bool ValidateIsSet(ObjectToValidate validatedObject)
        {
            if(validatedObject.ObjectName != string.Empty && validatedObject.ObjectValue != string.Empty)
            {  
                return true;
            }
            return false;
        }
    }
}
