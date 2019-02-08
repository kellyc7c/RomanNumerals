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
        public void ConvertingOneToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(1);

            Assert.AreEqual("I", result);
        }

        [Test]
        public void ConvertingTwoToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(2);

            Assert.AreEqual("II", result);
        }

        [Test]
        public void ConvertingThreeToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(3);

            Assert.AreEqual("III", result);
        }

        [Test]
        public void ConvertingFourToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(4);

            Assert.AreEqual("IV", result);
        }

        [Test]
        public void ConvertingFiveToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(5);

            Assert.AreEqual("V", result);
        }

    }
}
