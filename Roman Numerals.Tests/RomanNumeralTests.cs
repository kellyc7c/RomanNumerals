using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Roman_Numerals.Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [Test]
        public void ConvertingZeroToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(0);

            Assert.AreEqual("nulla", result);
        }

        [Test]
        public void ConvertingOneToRomanNumerlasShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(1);

            Assert.AreEqual("I", result);
        }

    }
}
