using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaProject.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace KretaProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<Student> _students = new();
        [ObservableProperty]
        private Student _selectedStudent = new();

        [RelayCommand]
        private void AddStudent(Student student)
        {
            Students.Add(student);
            SelectedStudent=new Student();
        }

        [RelayCommand]
        private void UpdateStudent(Student student)
        {
            Students.Remove(student);
            Students.Add(student);    
            SelectedStudent=student;
        }

        [RelayCommand]
        private void DeleteStudent(Student student)
        {
            Students.Remove(student);
            SelectedStudent = new Student();
        }
    }
}
