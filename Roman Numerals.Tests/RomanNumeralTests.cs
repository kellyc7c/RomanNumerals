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

        [Test]
        public void ConvertingSixToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(6);

            Assert.AreEqual("VI", result);
        }

        [TestCase(7,"VII")]
        [TestCase(8, "VIII")]
        public void ConvertingSevenAndEightToRomanNumeralsShouldReturnExpectedValues(int number, string romanNumeral)
        {
            string result = RomanNumerals.ToRomanNumeral(number);

            Assert.AreEqual(romanNumeral, result);
        }

        [Test]
        public void ConvertingNineToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(9);

            Assert.AreEqual("IX", result);
        }

        [Test]
        public void ConvertingTenToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(10);

            Assert.AreEqual("X", result);
        }

        [TestCase(11, "XI")]
        [TestCase(14, "XIV")]
        [TestCase(16, "XVI")]
        [TestCase(19, "XIX")]
        public void ConvertingElevenToNineteenToRomanNumeralsShouldReturnExpectedValues(int number, string romanNumeral)
        {
            string result = RomanNumerals.ToRomanNumeral(number);

            Assert.AreEqual(romanNumeral, result);
        }

        [TestCase(20, "XX")]
        [TestCase(25, "XXV")]
        [TestCase(30, "XXX")]
        [TestCase(39, "XXXIX")]
        public void ConvertingTwentyToThirtyNineToRomanNumeralsShouldReturnExpectedValues(int number, string romanNumeral)
        {
            string result = RomanNumerals.ToRomanNumeral(number);

            Assert.AreEqual(romanNumeral, result);
        }

        [Test]
        public void Converting40ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(40);

            Assert.AreEqual("XL", result);
        }

        [Test]
        public void Converting50ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(50);

            Assert.AreEqual("L", result);
        }

        [Test]
        public void Converting90ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(90);

            Assert.AreEqual("XC", result);
        }

        [Test]
        public void Converting100ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(100);

            Assert.AreEqual("C", result);
        }

        [TestCase(200, "CC")]
        [TestCase(300, "CCC")]
        [TestCase(399, "CCCXCIX")]
        public void Converting200To399ToRomanNumeralsShouldReturnExpectedValues(int number, string romanNumeral)
        {
            string result = RomanNumerals.ToRomanNumeral(number);

            Assert.AreEqual(romanNumeral, result);
        }

        [Test]
        public void Converting400ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(400);

            Assert.AreEqual("CD", result);
        }

        [Test]
        public void Converting500ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(500);

            Assert.AreEqual("D", result);
        }

        [Test]
        public void Converting900ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(900);

            Assert.AreEqual("CM", result);
        }

        [Test]
        public void Converting950ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(950);

            Assert.AreEqual("CML", result);
        }

        [Test]
        public void Converting987ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(987);

            Assert.AreEqual("CMLXXXVII", result);
        }

        [Test]
        public void Converting1000ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(1000);

            Assert.AreEqual("M", result);
        }

        [Test]
        public void Converting2000ToRomanNumeralsShouldReturnExpectedValue()
        {
            string result = RomanNumerals.ToRomanNumeral(2000);

            Assert.AreEqual("MM", result);
        }


    }
}
