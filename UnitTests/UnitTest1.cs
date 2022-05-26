using NUnit.Framework;
using System.Drawing;

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
            passwordGenerator.PasswordLength = 5;

            bool excepted = false;
            bool actual = false;
            var result = passwordGenerator.Generate();
            result=result.Replace("0", "");
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
            passwordGenerator.PasswordLength = 100;

            var excepted = string.Empty;
            var result = passwordGenerator.Generate();
            var actual = result;
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        public void EncryptAndDecrypt()
        {
            var excepted = "Леня";
            var actual = Algorythms.EncryptString(excepted, excepted);
            actual=Algorythms.DecryptString(actual, excepted);
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        public void DecryptAndEncypt()
        {
            var excepted = "Леня";
            excepted = Algorythms.EncryptString(excepted, "123");
            var actual = Algorythms.DecryptString(excepted, "123");
            actual = Algorythms.EncryptString(actual, excepted);
            Assert.AreEqual(excepted.Length, actual.Length);
        }
        [Test]
        public void NotContainsStrangeSymbols()
        {
            var passwordGenerator = new PasswordGenerator();
            passwordGenerator.UseNumbers = true;
            passwordGenerator.UseNonAlphanumeric = true;
            passwordGenerator.ExcludeSimilar = true;
            passwordGenerator.ExcludeAmbiguous = false;
            passwordGenerator.PasswordLength = 500;
             string ambiguousChars = "{}[]()/\\'\"`~,;:.<>";
            var excepted = false;
            var actual = false;
            var result = passwordGenerator.Generate();
            for (int i = 0; i < ambiguousChars.Length; i++)
            {
                if (!result.Contains(ambiguousChars[i]))
                {
                    actual = true;
                }
            }
            
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        public void NotContainsSimilarSymbols()
        {
            var passwordGenerator = new PasswordGenerator();
            passwordGenerator.UseNumbers = true;
            passwordGenerator.UseNonAlphanumeric = true;
            passwordGenerator.ExcludeSimilar = false;
            passwordGenerator.ExcludeAmbiguous = true;
            passwordGenerator.PasswordLength = 500;
            string similarChars = "iIl1Lo0O";
            var excepted = false;
            var actual = true;
            var result = passwordGenerator.Generate();
            for (int i = 0; i < similarChars.Length; i++)
            {
                if (result.Contains(similarChars[i]))
                {
                    actual = false;
                }
            }

            Assert.AreEqual(excepted, actual);
        }
        [Test]
        public void NotContainsSymbols()
        {
            var passwordGenerator = new PasswordGenerator();
            passwordGenerator.UseNumbers = true;
            passwordGenerator.UseNonAlphanumeric = false ;
            passwordGenerator.ExcludeSimilar = true; ;
            passwordGenerator.ExcludeAmbiguous = true;
            passwordGenerator.PasswordLength = 500;
            string similarChars = "~`'!@#$%^&*()_-+={}[]|\\:\";<,>.?/";
            var excepted = false;
            var actual = false;
            var result = passwordGenerator.Generate();
            for (int i = 0; i < similarChars.Length; i++)
            {
                if (result.Contains(similarChars[i]))
                {
                    actual = true;
                }
            }

            Assert.AreEqual(excepted, actual);
        }
        [Test]
        public void CheckColorChange()
        {
            Color excepted = Color.White;
            Color actual = Algorythms.ChangeColorBrightness(Color.Green, 1);
            Assert.AreEqual(excepted.ToArgb(), actual.ToArgb());

        }
        [Test]
        public void CheckColorChangeWuthNegativeBright()
        {
            Color excepted = Color.FromArgb(255,0,0,0);//Red           
            Color actual = Algorythms.ChangeColorBrightness(Color.Green, -1);
            Assert.AreEqual(excepted.ToArgb(), actual.ToArgb());

        }
        [Test]
        public void CheckLenLoginPassword()
        {
            var excepted = "difidufjifugjiufgj";
            excepted = Algorythms.EncryptString(excepted,"123");
            LoginPassword password = new LoginPassword(1, "Леня", excepted);
            Assert.AreEqual(excepted.Length, password.Password.Length);

        }
        [Test]
        public void CheckLenLoginIdPassword()
        {
            var excepted = 1;
            LoginPassword password = new LoginPassword(excepted, "Леня", "djfidhfiufdjg");
            Assert.AreEqual(excepted, password.Id);

        }
        [Test]
        public void CheckLoginIdPassword()
        {
            var excepted = "Леня";
            LoginPassword password = new LoginPassword(1, excepted, "djfidhfiufdjg");
            Assert.AreEqual(excepted, password.Login);

        }


    }
    
}