using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expert.A_Tester
{
    class Filtre
    {
        public  IEnumerable<string> Filter(List<string> String)
        {

            return String.Where(r => r.StartsWith("L")).OrderBy(c => c);

          
            
        }
    }
}
