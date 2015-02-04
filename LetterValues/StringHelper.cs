using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterValues
{
        public static class StringHelper
        {
            /// <summary>
            /// Sum the alphabetic index of each character in the string
            /// </summary>
            /// <param name="s">The string to sum</param>
            /// <returns>The sum of the alphabetic positions of each character</returns>
            public static int SumLetters(this string s)
            {
                int sum = 0;

                foreach (char c in s)
                {
                    sum += c.AlphabeticIndex();
                }

                return sum;
            }

            public static int AlphabeticIndex(this char c)
            {
                c = char.ToUpper(c);

                if (c < 'A' || c > 'Z')
                {
                    return 0;
                }

                return ((int)c - (int)'A') + 1;
            }

            /// <summary>
            /// For letters between A-Z return a numeric value corresponding to alphabetic position
            /// For anything outside of that range, return 0
            /// Case independent
            /// </summary>
            /// <param name="value">The character to get the index of</param>
            /// <returns>The alphabetic index of the character, or zero for non alphabetic characters</returns>
            public static int GetIndexInAlphabet(char value)
            {
                value = char.ToUpper(value);

                if (value < 'A' || value > 'Z')
                {
                    return 0;
                }

                return ((int)value - (int)'A') + 1;
            }
        }
}
