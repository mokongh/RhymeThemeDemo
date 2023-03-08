using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RhymeThemeDemo.Services
{

    internal class CheckValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
        {
            if (bool.TryParse((value ?? "").ToString(), out var boolResult))
            {
                return boolResult ? 
                    ValidationResult.ValidResult : 
                    new ValidationResult(false, "此项必选");
            }

            return new ValidationResult(false, "无法判断类型");
        }
    }
}
