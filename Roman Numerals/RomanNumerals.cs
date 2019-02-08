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
            else if (number == 1) return "I";
            else if (number == 2) return "II";
            else if (number == 3) return "III";

            return "";
        }
    }
}
