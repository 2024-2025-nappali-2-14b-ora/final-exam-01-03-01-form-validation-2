using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KretaProject.Models
{
    public class Teacher
    {
        public string Nname { get; set; } = string.Empty;
        public bool IsWoman { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;

        public bool HasEmail => !string.IsNullOrEmpty(Email);
        public int Age => DateTime.Now.Year - BirthDate.Year - (DateTime.Now < BirthDate.AddYears(DateTime.Now.Year - BirthDate.Year) ? 1 : 0);
        public bool IsBirthdayToday => BirthDate.Month == DateTime.Now.Month && BirthDate.Day == DateTime.Now.Day;

    }
}
