using KretaProject.ViewModels;

namespace KretaProjectXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void NameValidation_ShouldFail_ForEmptyName()
        {
            var viewModel = new TeacherForEdit { Name = "" };
            viewModel.ValidateTeacher();
            Assert.True(viewModel.HasErrors);
        }

        [Fact]
        public void NameValidation_ShouldFail_ForShortName()
        {
            var viewModel = new TeacherForEdit { Name = "A" };
            viewModel.ValidateTeacher();
            Assert.True(viewModel.HasErrors);
        }

        [Fact]
        public void NameValidation_ShouldFail_ForInvalidCharacters()
        {
            var viewModel = new TeacherForEdit { Name = "John123" };
            viewModel.ValidateTeacher();
            Assert.True(viewModel.HasErrors);
        }

        [Fact]
        public void NameValidation_ShouldPass_ForValidName()
        {
            var viewModel = new TeacherForEdit { Name = "John Doe" };
            viewModel.ValidateTeacher();
            Assert.False(viewModel.HasErrors);
        }

        [Fact]
        public void EmailValidation_ShouldFail_ForInvalidEmail()
        {
            var viewModel = new TeacherForEdit { Email = "invalidemail" };
            viewModel.ValidateTeacher();
            Assert.True(viewModel.HasErrors);
        }

        [Fact]
        public void EmailValidation_ShouldFail_ForInvalidDomain()
        {
            var viewModel = new TeacherForEdit { Email = "test@gmail.com" };
            viewModel.ValidateTeacher();
            Assert.True(viewModel.HasErrors);
        }

        [Fact]
        public void EmailValidation_ShouldPass_ForValidDomain()
        {
            var viewModel = new TeacherForEdit { Email = "test@vasvari.org" };
            viewModel.ValidateTeacher();
            Assert.False(viewModel.HasErrors);
        }
    }
}