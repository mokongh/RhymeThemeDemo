using System.Globalization;
using System.Windows.Controls;

namespace RhymeThemeDemo.Services
{
    internal class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
        {
            return string.IsNullOrEmpty((value ?? "").ToString())
                ? new ValidationResult(false, "此字段不能为空")
                : ValidationResult.ValidResult;
        }
    }
}
