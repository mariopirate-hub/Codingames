using System;
using System.Collections.Generic;
using System.Text;

namespace Expert.A_Tester
{
    class Tennis
    {
        static string ComputeGameState(string nameP1, string nameP2, string[] wins)
        {

            int scoreP2 = 0;
            int scoreP1 = 0;

            foreach (string w in wins)
            {
                if (w == "P1") scoreP1++;
                else scoreP2++;
            }



            switch (scoreP1)
            {
                case 1:
                    scoreP1 = 15;
                    break;
                case 2:
                    scoreP1 = 30;
                    break;
                case 3:
                    scoreP1 = 40;
                    break;
            }

            switch (scoreP2)
            {
                case 1:
                    scoreP2 = 15;
                    break;
                case 2:
                    scoreP2 = 30;
                    break;
                case 3:
                    scoreP2 = 40;
                    break;
            }

            string scoreFinale = string.Format("{0} {1} - {2} {3}", nameP1, scoreP1, nameP2, scoreP2);
            if ((scoreP1 >= 4) && (scoreP1 - scoreP2 == 2)) scoreFinale = string.Format("{0} WIN", nameP1);
            else if ((scoreP2 >= 4) && (scoreP2 - scoreP1 == 2)) scoreFinale = string.Format("{0} WIN", nameP2);
            else if (scoreP1 == scoreP2) scoreFinale = "DEUCE";
            else if (scoreP1 >= 3 && scoreP1 - scoreP2 == 1) scoreFinale = nameP1 + " ADVANTAGE";
            else if (scoreP2 >= 3 && scoreP2 - scoreP1 == 1) scoreFinale = nameP2 + " ADVANTAGE";

            return scoreFinale;
        }
    }
}
