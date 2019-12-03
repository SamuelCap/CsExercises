using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    [TestFixture]
    class NumberTest
    {
        [Test]
        public void isCorrectTest()
        {
            Number num = new Number();
            num.guessedNumber = 2;
            num.randomNumber = 2;
            bool expectedValue = true;
            bool actualValue = num.iscorrect();
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void isCorrectPrintTest()
        {
            Number num = new Number();
            num.guessedNumber = 2;
            num.randomNumber = 2;
            string expectedValue = "Correct";
            string actualValue = num.print();
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void overHundo()
        {
            Number num = new Number();
            int actualValue = num.generateNumber();
            Assert.LessOrEqual(actualValue, 100);
        }
    }
}
