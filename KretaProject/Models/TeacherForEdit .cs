using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace KretaProject.ViewModels
{
    public partial class TeacherForEdit : ObservableValidator
    {
        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required(ErrorMessage = "A név nem lehet üres!")]
        [MinLength(2, ErrorMessage = "A névnek legalább 2 karakter hosszúnak kell lennie!")]
        [RegularExpression("^[a-zA-Z -]+$", ErrorMessage = "A név csak betűket, szóközt és kötőjelet tartalmazhat!")]
        private string _name = string.Empty;

        [ObservableProperty]
        private DateTime _birthDate=DateTime.Now;

        [ObservableProperty]
        private bool _isWoman = true;

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required(ErrorMessage = "Az email cím megadása kötelező!")]
        [EmailAddress(ErrorMessage = "Érvénytelen email cím formátum!")]
        [CustomValidation(typeof(TeacherForEdit), nameof(ValidateEmailDomain))]
        private string _email = string.Empty;

        public static ValidationResult ValidateEmailDomain(string email, ValidationContext context)
        {
            if (!string.IsNullOrEmpty(email) && email.EndsWith("@vasvari.org"))
                return ValidationResult.Success;
            return new ValidationResult("Az email címnek @vasvari.org-ra kell végződnie!");
        }

        // Opcióként egy RelayCommand a kifejezett validációhoz
        [RelayCommand]
        public void ValidateTeacher()
        {
            ValidateAllProperties();
        }
    }
}