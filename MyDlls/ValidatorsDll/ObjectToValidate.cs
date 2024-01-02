using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators;

namespace ValidatorsDll
{
    enum ObjectType
    {
        Character ,Text, Number
    }

    class ObjectToValidate : IValidate
    {
        public string ObjectName { get; set; }
        public string ObjectValue { get; set; }

        public virtual bool Validation()
        { 
            return true; 
        }
        
    }
}
