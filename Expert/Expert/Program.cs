using Expert.A_Tester;
using Expert.Excercice;
using System;
using System.Collections.Generic;
using static Expert.PI;

namespace Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "Billet":
                    long s = 1;

                    Change change = CaisseAutomatique.OptimalChange(s);

                    Console.WriteLine("monnaie " + s);

                    Console.WriteLine("Coin(s) 2€: " + change.coin2);
                    Console.WriteLine("Bill(s) 5€: " + change.bill5);
                    Console.WriteLine("Bill(s) 10€: " + change.bill10);

                    break;
                case "Danse":

                    Console.WriteLine(NouvelleDanse.GetPositionAt(3)); //-4
                    Console.WriteLine(NouvelleDanse.GetPositionAt(100000)); //-5
                    Console.WriteLine(NouvelleDanse.GetPositionAt(2147483647)); //1

                    break;
                case "PI":

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
                    break;

                case "Paire":

                    Console.WriteLine(NombrePaires.Count(4));
                    Console.WriteLine(NombrePaires.Count(10000));
                    break;

                case "formula":

                    string path = "/tmp/documents/";
                    string fName = "universe-formula";
                    string target = Universe_Formula.Find(path, fName, "");

                    target = target.Replace("\\", "/");

                    Console.Write(target);

                    break;

                case "IsTwin":

                    Console.WriteLine(IsTwin.isTwin("Hello", "world")); //Faux 372 392
                    Console.WriteLine(IsTwin.isTwin("acb", "bca")); // Vrai
                    Console.WriteLine(IsTwin.isTwin("Lookout", "Outloook")); //Vrai
                    break;

                case "Pierre":

                    List<int> stones = new List<int>(new int[] { 1, 1 });
                    Console.WriteLine(StoneMagic.Magic(stones));//1

                    stones = new List<int>(new int[] { 1, 1, 5 });
                    Console.WriteLine(StoneMagic.Magic(stones));//2

                    stones = new List<int>(new int[] { 1, 1, 2, 3, 3, 3, 5, 6, 6, 6, 6, 6, 6, 6, 6, 9 });
                    Console.WriteLine(StoneMagic.Magic(stones));//2
                    break;

                case "Message":

                    string[] parts = { "Ab", "bcZ" };
                    Console.WriteLine(RebuilMessage.RebuildMessage(parts));

                     parts = new string[]  { "*====#", "X-+-+-+-+-+-Z","#______X", "A........*====#______X-+-+-+-+-+-Z" };
                    Console.WriteLine(RebuilMessage.RebuildMessage(parts));
                    break;

                case "Filter":
                    var strings = new List<string>();
                    var filteredStrings = new Filtre().Filter(strings);

                    strings.Add("Gurt");
                    strings.Add("Lobster");
                    strings.Add("Litch");
                    strings.Add("Doe");

                    foreach(var str in filteredStrings)
                    {
                        Console.WriteLine(str);
                    }

                    break;
            }
            Console.ReadKey();
        }
    }
}
