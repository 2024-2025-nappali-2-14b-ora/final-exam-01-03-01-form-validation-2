namespace KretaProject.Validation.ValidationRules.Tests
{
    [TestClass()]
    public class NameValidationRulesTestsIsNameShort
    {
        [TestMethod()]
        public void NameValidationRulesTestNameEmpty()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void NameValidationRulesTestOneLetter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("F");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestValidShortName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Fa");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void NameValidationRulesTestValidLongName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkas");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsFalse(actual);
        }
    }
}