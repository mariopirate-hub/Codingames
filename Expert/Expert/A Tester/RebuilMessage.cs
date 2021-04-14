using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expert.A_Tester
{
    class RebuilMessage
    {
        public static string RebuildMessage(string[] parts)
        {
            var query =  parts.Where(p => p.StartsWith("A") ).Concat(parts.Where(z => z.EndsWith("Z")));

            

            return string.Join("",query);
        }
    }
}
