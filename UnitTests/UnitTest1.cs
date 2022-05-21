using NUnit.Framework;

namespace PasswordGenerator
{

        [TestFixture]
        public class TestUnitClass
        {
            [Test]
            public void ExceptedOnlyLowerCharsInPassword()
            {
                var passwordGenerator = new PasswordGenerator();
                passwordGenerator.UseLowerCase = true;
                passwordGenerator.PasswordLength = 1000;

                bool excepted = false;
                bool actual = false;
                var result = passwordGenerator.Generate();
                foreach (var ch in result)
                {
                    if (char.IsUpper(ch) || result.Length <= 0)
                    {
                        actual = true;
                    }
                }
                Assert.AreEqual(excepted, actual);

            }
        [Test]
        public void ExceptedOnlyUpperCharsInPassword()
        {
            var passwordGenerator = new PasswordGenerator();
            passwordGenerator.UseUpperCase = true;
            passwordGenerator.PasswordLength = 1000;

            bool excepted = false;
            bool actual = false;
            var result = passwordGenerator.Generate();
            foreach (var ch in result)
            {
                if (char.IsLower(ch)||result.Length<=0)
                {
                    actual = true;
                }
            }
            Assert.AreEqual(excepted, actual);

        }
        [Test]
        public void ExceptedOnlyNumberInPassword()
        {
            var passwordGenerator = new PasswordGenerator();
            passwordGenerator.UseNumbers = true;
            passwordGenerator.PasswordLength = 1000;

            bool excepted = false;
            bool actual = false;
            var result = passwordGenerator.Generate();
            result.Replace("0", "");
            if(!int.TryParse(result, out int value) || result.Length <= 0)
            {
                actual = true;
            }
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        public void ExceptedEmptyWithNegativePasswordLength()
        {
            var passwordGenerator = new PasswordGenerator();
            passwordGenerator.UseNumbers = true;
            passwordGenerator.PasswordLength = -10;

            var excepted = string.Empty;
            var result = passwordGenerator.Generate();
            var actual = result;
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        public void ExceptedEmptyWithoutParams()
        {
            var passwordGenerator = new PasswordGenerator();
            passwordGenerator.PasswordLength = 1000;

            var excepted = string.Empty;
            var result = passwordGenerator.Generate();
            var actual = result;
            Assert.AreEqual(excepted, actual);
        }

    }
    
}