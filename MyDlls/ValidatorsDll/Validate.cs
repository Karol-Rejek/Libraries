using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validators
{
    class Validate
    {
        public bool Validation(List<IValidate> toValidate)
        {
            foreach (var item in toValidate)  
            { 
                if(!item.Validation())
                    return false;
            }

            return true;
        }
    }
}
