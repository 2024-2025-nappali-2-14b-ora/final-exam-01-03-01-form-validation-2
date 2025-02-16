using KretaProject.Validation.ValidationRules;
using System.Globalization;
using System.Windows.Controls;

namespace KretaProject.Validation
{
    public class NameValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is not string nameToValidate || string.IsNullOrWhiteSpace(nameToValidate))
            {
                return new ValidationResult(false, "A név nem lehet üres!");
            }
            var nvr = new NameValidationRules(nameToValidate);
            if (nvr.IsNameShort)
                return new ValidationResult(false, "A név túl rövid!");

            if (!nvr.IsValidCharacters)
                return new ValidationResult(false, "A név csak betűket, kötőjelet és szóközt tartalmazhat!");

            return ValidationResult.ValidResult;
        }
    }
}
