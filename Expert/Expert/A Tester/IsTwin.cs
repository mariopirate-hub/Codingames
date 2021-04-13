using System;
using System.Collections.Generic;
using System.Text;

namespace Expert.A_Tester
{
    class IsTwin
    {
        public static bool isTwin(String a, String b)
        {
            int asciiA = 0;
            int asciiB = 0;
            for (int i = 0; i < a.Length; i++)
                for (char c = 'A'; c <= 'Z'; c++)
                    if (a.Substring(i, 1).ToUpper().Contains(c)) asciiA += c;

            for (int i = 0; i < b.Length; i++)
                for (char c = 'A'; c <= 'Z'; c++)
                    if (b.Substring(i, 1).ToUpper().Contains(c)) asciiB += c;

            return asciiA == asciiB ? true : false;
        }

    }
}
