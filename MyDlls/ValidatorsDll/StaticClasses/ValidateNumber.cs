using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validators.StaticClasses
{
    static class ValidateNumber
    {
        public static bool ValidateIsNumber(string value)
        {
            float outputValue;
            if (float.TryParse(value, out outputValue))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateIsInRange(float value, float min, float max)
        {
            if (value < min || value > max)
            {
                return false;
            }
            return true;
        }
    }
}
