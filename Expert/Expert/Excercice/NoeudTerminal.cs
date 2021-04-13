using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expert.Excercice
{
    class NoeudTerminal
    {
        public static int FindNetworkEndpoint(int startNodeId, int[] fromIds, int[] toIds)
        {
            int i = Array.IndexOf(fromIds, startNodeId);
            List<int> tt = new List<int>();
            tt.Add(fromIds[i]);

            while (!(tt.Contains(toIds[i])) && (fromIds.Contains(toIds[i])))
            {


                i = Array.IndexOf(fromIds, toIds[i]);
                tt.Add(fromIds[i]);

            }
            return tt.Contains(toIds[i]) ? fromIds[i] : toIds[i];
        }

    }
}
