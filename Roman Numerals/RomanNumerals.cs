using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    public class RomanNumerals
    {
        public static string ToRomanNumeral(int number)
        {
            if (number == 0) return "nulla";

            string romanNumeral = "";

            if (number >= 50)
            {
                romanNumeral += "L";
                number -= 50;
            }

            if (number >= 40)
            {
                romanNumeral += "XL";
                number -= 40;
            }

            while (number >= 10)
            {
                romanNumeral += "X";
                number -= 10;
            }

            if (number >= 9)
            {
                romanNumeral += "IX";
                number -= 9;
            }



            if (number >= 5)
            {
                romanNumeral += "V";
                number -= 5;
            }

            
            if (number == 1) romanNumeral += "I";
            else if (number == 2) romanNumeral += "II";
            else if (number == 3) romanNumeral += "III";
            else if (number == 4) romanNumeral += "IV";

            return romanNumeral;
        }
    }
}
