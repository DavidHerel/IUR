using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Controls;

namespace CV6
{
    public class ExtentValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int valueInt = 0;
            try
            {
                if (((string)value).Length > 0) valueInt = Int32.Parse((String)value);
            }
            catch (Exception e)
            { return new ValidationResult(false, "Illegal characters or " + e.Message); }
            if ((valueInt < 0) || (valueInt > 100))
            {
                return new ValidationResult(false,
               "Please enter value in the range: " + 0 + " - " + 100 + ".");
            }
            return ValidationResult.ValidResult;
        }
    }
}
