using Expert.A_Tester;
using Expert.Excercice;
using System;
using System.Collections.Generic;
using static Expert.PI;

namespace Expert
{
    class Program
    {
        static void Main()
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

                    long result = change.coin2 * 2 + change.bill5 * 5 + change.bill10 * 10;
                    Console.WriteLine("\nChange given = " + result);

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
                    string target = Universe_Formula.Find(path, fName, null);

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

                case "Solde":
                    int[] prices = { 100, 400, 200 };
                    Console.WriteLine(Solde.CalculateTotalPrice(prices, 20));

                    break;

                case "Fizz":
                    Dictionary<int, string> map = new Dictionary<int, string>();

                    map[3] = "FIZZ";
                    map[4] = "BUZZ";

                    Console.WriteLine(FizzBuzz.fizzBuzz(5, map)); //5
                    Console.WriteLine(FizzBuzz.fizzBuzz(3, map)); //FIZZ
                    Console.WriteLine(FizzBuzz.fizzBuzz(8, map)); //BUZZ
                    Console.WriteLine(FizzBuzz.fizzBuzz(12, map)); //FIZZBUZZ

                    break;

                case "Encode":
                    string plainText = "aabaa";
                    Console.WriteLine(Occurence.Encode(plainText)); // 2a1b2a

                    plainText = "aaaabcccaaa";
                    Console.WriteLine(Occurence.Encode(plainText)); //4a1b3c3a

                    break;
                case "Carton":
                    int[] boxesA = { 90 };
                    int[] boxesB = { 130,160 };
                    int[] boxesC = { 160 };
                    string[] deplacement = Carton.Solve(boxesA, boxesB, boxesC);

                    foreach (string d in deplacement)
                        Console.WriteLine(d);

                    break;
            }
            Console.ReadKey();
        }
    }
}
