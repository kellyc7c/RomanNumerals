using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    public class RomanNumerals
    {
        private int remainingValueToConvert;
        private string processedRomanNumeral;


        public string ToRomanNumeral(int number)
        {
            if (number == 0) return "nulla";

            remainingValueToConvert = number;
            
            processedRomanNumeral = "";

            processMultipleOfNumberIntoRomanNumeral(1000,    "M");
            processMultipleOfNumberIntoRomanNumeral(900,     "CM");
            processMultipleOfNumberIntoRomanNumeral(500,     "D");
            processMultipleOfNumberIntoRomanNumeral(400,     "CD");
            processMultipleOfNumberIntoRomanNumeral(100,     "C");
            processMultipleOfNumberIntoRomanNumeral(90,      "XC");
            processMultipleOfNumberIntoRomanNumeral(50,      "L");
            processMultipleOfNumberIntoRomanNumeral(40,      "XL");
            processMultipleOfNumberIntoRomanNumeral(10,      "X");
            processMultipleOfNumberIntoRomanNumeral(9,       "IX");
            processMultipleOfNumberIntoRomanNumeral(5,       "V");
            processMultipleOfNumberIntoRomanNumeral(4,       "IV");
            processMultipleOfNumberIntoRomanNumeral(1,       "I");

            return processedRomanNumeral;
        }

        private void processMultipleOfNumberIntoRomanNumeral(int romanNumeralInDecimal, string romanNumeral)
        {
            while (remainingValueToConvert >= romanNumeralInDecimal)
            {
                processedRomanNumeral += romanNumeral;
                remainingValueToConvert -= romanNumeralInDecimal;
            }
        }


    }
}
