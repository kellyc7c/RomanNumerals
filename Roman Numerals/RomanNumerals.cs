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

            processRomanNumeral(1000, "M");
            processRomanNumeral(900, "CM");
            processRomanNumeral(500, "D");
            processRomanNumeral(400, "CD");
            processRomanNumeral(100, "C");
            processRomanNumeral(90, "XC");
            processRomanNumeral(50, "L");
            processRomanNumeral(40, "XL");
            processRomanNumeral(10, "X");
            processRomanNumeral(9, "IX");
            processRomanNumeral(5, "V");
            processRomanNumeral(4, "IV");
            processRomanNumeral(1, "I");

            return processedRomanNumeral;
        }

        private void processRomanNumeral(int romanNumeralInDecimal, string romanNumeral)
        {
            while (remainingValueToConvert >= romanNumeralInDecimal)
            {
                processedRomanNumeral += romanNumeral;
                remainingValueToConvert -= romanNumeralInDecimal;
            }
        }


    }
}
