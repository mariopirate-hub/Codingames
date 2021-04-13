using Expert.Excercice;
using System;
using static Expert.PI;

namespace Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args[0] == "Billet")
            {
                long s = 1;

                Change change = CaisseAutomatique.OptimalChange(s);

                Console.WriteLine("monnaie " + s);

                Console.WriteLine("Coin(s) 2€: " + change.coin2);
                Console.WriteLine("Bill(s) 5€: " + change.bill5);
                Console.WriteLine("Bill(s) 10€: " + change.bill10);

                
            }
            if(args[0] == "Danse")
            {
                Console.WriteLine(NouvelleDanse.GetPositionAt(3)); //-4
                Console.WriteLine(NouvelleDanse.GetPositionAt(100000)); //-5
                Console.WriteLine(NouvelleDanse.GetPositionAt(2147483647)); //1
              
            }
            if(args[0] == "PI")
            {
                var rands = new Point[100000];
                Random random = new Random();

                for (int i = 0; i < rands.Length; i++)
                {
                    Point p = new Point();
                    p.x = random.NextDouble(); //x
                    p.y = random.NextDouble(); //y
                    rands[i] = p;
                }

                double Test = PI.Approx(rands);

                Console.WriteLine(Test);
            }
            if(args[0] == "Paire")
            {
                Console.WriteLine(NombrePaires.Count(4));
                Console.WriteLine(NombrePaires.Count(10000));
            }
            Console.ReadKey();
        }
    }
}
