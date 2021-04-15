using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expert.A_Tester
{
    class StoneMagic
    {
        public static int Magic(List<int> stones)
        {
            //int old = stones.Count + 1;
            //while (old != stones.Count)
            //{
            //    old = stones.Count;
            //    for (int i = 1; i <= stones.Count - 1; i++)
            //    {
            //        if (stones[^i] == stones[^(i + 1)])
            //        {
            //            stones[^(i + 1)]++;
            //            stones.RemoveAt(stones.Count - i);
            //        }
            //    }
            //}
            ///
            /// OU
            /// 
            /// var stones = Console.ReadLine().Split().Select(int.Parse).ToList();
            //while (stones.GroupBy(i => i).Any(i => i.Count() > 1))
            //{
            //    var key = stones.GroupBy(i => i).OrderByDescending(i => i.Count()).First().Key;
            //    stones.Remove(key);
            //    stones.Remove(key);
            //    stones.Add(key + 1);
            //}

            //return stones.Count();


            int j = 0;
            int nbstones = stones.Count();
            var numQuery = new List<bool>();


            int p1 = stones[j];

            do
            {


                foreach (int t in stones)
                {
                    numQuery = (from st in stones
                                where st.Equals(t)
                                select stones.Count() >= 2).ToList();

                    if (numQuery.Count() > 1)
                    {
                        j = Array.IndexOf(stones.ToArray(), t);
                        p1 = stones[j];
                        break;
                    }
                }




                for (int i = j + 1; i < stones.Count(); i++)
                {
                    if (p1 == stones[i])
                    {
                        stones.RemoveAt(i);
                        stones.RemoveAt(j);
                        p1++;
                        stones.Add(p1);
                        break;

                    }
                }

                foreach (int t in stones)
                {
                    numQuery = (from st in stones
                                where st.Equals(t)
                                select stones.Count() >= 2).ToList();

                    if (numQuery.Count() > 1) break;
                }


            } while (stones.Count() >= 2 && numQuery.Count() > 1);




            return stones.Count();
        }
    }
}
