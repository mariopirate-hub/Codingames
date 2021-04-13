using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class NouvelleDanse
    {
        public static int GetPositionAt(int n)
        {
            int[] deplacement = new int[3];
            int[] Possition = new int[3];

            List<int> valeur = new List<int>();

            //étape 0
            int danse = 0; //position
            valeur.Add(danse);

            //étape 1           
            danse += 1;
            deplacement[0] = danse;
            Possition[0] = danse;
            valeur.Add(danse);

            //étape 2           
            danse += -2;

            deplacement[1] = -2;
            Possition[1] = danse;
            valeur.Add(danse);

            n %= 6;

            for (int i = 0; i < 4; i++)
            {
                deplacement[2] = (deplacement[1] - deplacement[0]);

                danse = Possition[1] + deplacement[2];

                deplacement[0] = deplacement[1];
                deplacement[1] = deplacement[2];


                Possition[1] = danse;
                valeur.Add(danse);
            }

            return valeur[n];
        }
    }
}
