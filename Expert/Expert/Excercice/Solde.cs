using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expert.Excercice
{
    class Solde
    {
       public static int CalculateTotalPrice(int[] prices, int discount)
        {

            double produitReduc = prices.Max() - (prices.Max() * (double)discount / 100);

            double somme = prices.Sum() + produitReduc - prices.Max();

            return Convert.ToInt32(Math.Floor(somme));
        }
    }
}
