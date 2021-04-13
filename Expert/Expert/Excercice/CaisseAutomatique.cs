using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class Change
    {
        public long coin2 = 0;
        public long bill5 = 0;
        public long bill10 = 0;
    }
    class CaisseAutomatique
    {
        public static Change OptimalChange(long s)
        {
            Change change = new Change();



            do
            {
                if (s != 1 && s != 3)
                {
                    if (s % 10 == 1)
                    {
                        change.coin2 += 3;
                        change.bill5 += 1;
                        s -= 11;
                        change.bill10 = s / 10;
                    }
                    else if (s % 10 == 3)
                    {
                        change.coin2 += 4;
                        change.bill5 += 1;
                        s -= 13;
                        change.bill10 = s / 10;
                    }
                    else
                    {
                        if (s >= 10)
                        {
                            change.bill10 = s / 10;
                            s %= 10;
                        }
                        else if (s % 2 == 0)
                        {
                            change.coin2 = s / 2;
                            s %= 2;
                        }
                        else if ((s % 2 == 1) && (s >= 5))
                        {
                            change.bill5 = s / 5;
                            s %= 5;
                        }
                    }
                }
                else return null;
            } while (s != 0);

            return change;
        }
    }
}
