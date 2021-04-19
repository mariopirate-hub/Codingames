using System;
using System.Collections.Generic;
using System.Text;

namespace Expert.A_Tester
{
    class Robot
    {
        public static int[] Solve(string direction, int x, int y, int width, int height)
        {
            int[] deplacement = new int[2];
            switch (direction)
            {
                case "U": //au Dessus
                    deplacement[0] = x;
                    deplacement[1] = y - 1;
                    break;
                case "UR": //au Dessus a droite
                    deplacement[0] = x + 1;
                    deplacement[1] = y - 1;
                    break;
                case "R": // droite
                    deplacement[0] = x + 1;
                    deplacement[1] = y;
                    break;
                case "DR": // en dessous a droite
                    deplacement[0] = x + 1;
                    deplacement[1] = y + 1;
                    break;
                case "D": //en dessous
                    deplacement[0] = x;
                    deplacement[1] = y + 1;
                    break;
                case "DL": //en dessous a gauche
                    deplacement[0] = x - 1;
                    deplacement[1] = y + 1;
                    break;
                case "L": // a gauche
                    deplacement[0] = x - 1;
                    deplacement[1] = y;
                    break;
                case "UL": //au dessus a gauche
                    deplacement[0] = x - 1;
                    deplacement[1] = y - 1;
                    break;
            }

            return deplacement;
        }
    }
}
