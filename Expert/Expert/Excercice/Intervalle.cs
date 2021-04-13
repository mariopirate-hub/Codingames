using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expert.Excercice
{
    class Intervalle
    {
        static public int Calc(int[] array, int n1, int n2)
        {
            List<int> intervalle = new List<int>();

            for (int i = n1; i <= n2; i++)

                intervalle.Add(array[i]);



            return intervalle.Sum();
        }

    }
}
