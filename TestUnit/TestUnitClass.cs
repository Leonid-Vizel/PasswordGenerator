using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (char.IsUpper(ch))
                {
                    actual = true;
                }
            }
            Assert.AreEqual(excepted, actual);
            
        }
    }
}
