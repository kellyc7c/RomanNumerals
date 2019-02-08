﻿using System;
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
            else if (number == 9) return "IX";
            else if (number == 10) return "X";

            string romanNumeral = "";

            if (number >= 5)
            {
                romanNumeral += "V";
                number -= 5;
            }

            
            if (number == 1) romanNumeral += "I";
            else if (number == 2) romanNumeral += "II";
            else if (number == 3) romanNumeral += "III";
            else if (number == 4) return "IV";

            return romanNumeral;
        }
    }
}
