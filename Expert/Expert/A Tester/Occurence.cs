using System;
using System.Collections.Generic;
using System.Text;

namespace Expert.A_Tester
{
    class Occurence
    {
        public static string Encode(string plainText)
        {
            int cpt = 1;
            string lettre = plainText.Substring(0, 1);
            string finale = "";

            for (int i = 1; i < plainText.Length; i++)
            {
                while (i < plainText.Length && lettre == plainText.Substring(i, 1))
                {
                    cpt++;
                    i++;
                }
                finale = String.Concat(finale, cpt, lettre);
                if (i < plainText.Length) lettre = plainText.Substring(i, 1);

                cpt = 1;

            }
            return finale;
        }
    }
}
