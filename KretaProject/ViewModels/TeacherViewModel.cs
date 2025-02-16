using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaProject.Models;
using System.Collections.ObjectModel;

namespace KretaProject.ViewModels
{
    public partial class TeacherViewModel: ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<TeacherForEdit> _teachers = new();
        [ObservableProperty]
        private TeacherForEdit _selectedTeacher = new();

        [RelayCommand]
        private void AddTeacher(TeacherForEdit teacherForEdit)
        {
            Teachers.Add(teacherForEdit);
            SelectedTeacher = new TeacherForEdit();
        }

        [RelayCommand]
        private void UpdateTeacher(TeacherForEdit teacher)
        {
            Teachers.Remove(teacher);
            Teachers.Add(teacher);
            SelectedTeacher = teacher;
        }

        [RelayCommand]
        private void DeleteTeacher(TeacherForEdit teacher)
        {
            Teachers.Remove(teacher);
            SelectedTeacher = new TeacherForEdit();
        }
    }
}
