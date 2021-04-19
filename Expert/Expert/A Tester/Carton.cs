using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expert.A_Tester
{
    class Carton
    {
        public static string[] Solve(int[] boxesA, int[] boxesB, int[] boxesC)
        {

            List<int> nbCartons = new List<int>();
            List<string> deplacement = new List<string>();

            foreach (int bA in boxesA)
                nbCartons.Add(bA);

            foreach (int bB in boxesB)
                nbCartons.Add(bB);

            foreach (int bC in boxesC)
                nbCartons.Add(bC);

            var num = nbCartons.OrderByDescending(c => c);

            List<int> LstBoxA = boxesA.ToList();
            List<int> LstBoxB = boxesB.ToList();
            List<int> LstBoxC = boxesC.ToList();

            foreach (var carton in num)
            {
                //On mets tout les carton dans la colonne B
                while (LstBoxA.Count() > 0 && LstBoxA[0] != num.First())
                {
                    deplacement.Add("A B");
                    LstBoxB.Add(LstBoxA[^1]);
                    LstBoxA.RemoveAt(LstBoxA.Count()-1);
                }

                while (LstBoxC.Count() > 0 )
                {
                    deplacement.Add("C B");
                    LstBoxB.Add(LstBoxC[^1]);
                    LstBoxC.RemoveAt(LstBoxC.Count()-1);
                }

                while (LstBoxB.Count() > 0)
                {
                    //On mets le carton dans la colonne C si c'est pas le plus lourd
                    if (LstBoxB[^1] != carton)
                    {
                        deplacement.Add("B C");
                        LstBoxC.Add(LstBoxB[^1]);
                        LstBoxB.RemoveAt(LstBoxB.Count()-1);
                    }
                    //On mets le carton dans la colonne A si il est le plus lourd
                    else
                    {
                        deplacement.Add("B A");
                        LstBoxA.Add(LstBoxB[^1]);
                        LstBoxB.RemoveAt(LstBoxB.Count()-1);
                        break;
                    }

                }

            }

            return deplacement.ToArray();
        }
    }
}
