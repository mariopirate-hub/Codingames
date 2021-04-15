using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expert.A_Tester
{
    class FizzBuzz
    {
        public static String fizzBuzz(int number, Dictionary<int, string> map)
        {
            foreach (KeyValuePair<int, string> entry in map)
            {
                if (entry.Key == number || entry.Key * 2 == number) return entry.Value;
               
            }
            for (int i = 0; i < map.Count - 1; i++)
            {
                if (map.ElementAt(i).Key * map.ElementAt(i+1).Key == number) return String.Join("", map.ElementAt(i).Value,map.ElementAt(i+1).Value);

            }
            return number.ToString();
        }
    }
}
