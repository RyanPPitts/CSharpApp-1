using System;
using System.Numerics;

namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //DATA TYPES

                    //(part 3)string randString = "This is a string";

                    //Console.WriteLine("String length : {0}", randString.Length);
                    //Console.WriteLine("String Contains is  : {0}", randString.Contains("is"));
                    //Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));
                    //Console.WriteLine("Remove String : {0}", randString.Remove(0, 6));
                    //Console.WriteLine("Insert String : {0}", randString.Insert(10, "short"));
                    //Console.WriteLine("Replace String : {0}", randString.Replace("a string","yarn"));

                    //Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
                    //Console.WriteLine("A = a: {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
                    //Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));
                    //Console.WriteLine("Pad Right : {0}", randString.PadRight(20, '.'));
                    //Console.WriteLine("Trim : {0}", randString.Trim());
                    //Console.WriteLine("Uppercase : {0}", randString.ToUpper());
                    //Console.WriteLine("Lowercase : {0}", randString.ToLower());

                    //string newString = String.Format("{0} saw a {1}  {2} in the {3}", "Paul", "rabbit", "eating", "snowing");



                    //BigInteger bigNum = BigInteger.Parse("123451234512345123451234512345");
                    //Console.WriteLine("Currency : {0:c}", 23.455);
                    //Console.WriteLine("Pad with 0s : {0:d4}", 23);
                    //Console.WriteLine("3 Decimals : {0:f4}", 23.455);
                    //Console.WriteLine("Commas : {0:n4}", 2300);
                    //(/part 3)Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);



            //(part 2)DateTime awesomeDate = new DateTime(1974, 12, 21);
            //Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);
            //awesomeDate = awesomeDate.AddDays(15);
            //awesomeDate = awesomeDate.AddMonths(2);
            //awesomeDate = awesomeDate.AddYears(1);
            //Console.WriteLine("New Date : {0}", awesomeDate.Date);
            //TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            //lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            //lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));

            //(part 2)Console.WriteLine("New Time : {0}", lunchTime.ToString());

            //(part 2) Convert from Strings to different data types
            //bool boolFromString = bool.Parse("true");
            //int intFromString = int.Parse("100");
            //(part 2)double dblFromString = double.Parse("1.234");

            //(part 2)decimal decPiVal = 3.141592M;
            //decimal decBigNum = 3.00000011M;
            //double dblPiVal = 3.14159265358979;
            //double dblBigNum = 3.0000000000002;
            //float fltPiVal = 3.141592F;
            //float fltBigNum = 3.00002F;
            //Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);
            //Console.WriteLine("Biggest Double : {0}", Double.MaxValue.ToString("#"));
            //Console.WriteLine("DBL : PI + bigNum = {0}", fltPiVal + fltBigNum);
            //Console.WriteLine("Biggest Float: {0}", float.MaxValue.ToString("#"));
            //Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);
            //Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            //Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);
            //Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            //Console.WriteLine("Smallest Integer : {0}", int.MinValue);
            //Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            //(part 2)Console.WriteLine("Smallest Long : {0}", long.MinValue);


            //(part1)Console.WriteLine("Hello, I'm Ryan Pitts!");
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Arg {0} : {1}", i, args[i]);
            //}
            //string[] myArgs = Environment.GetCommandLineArgs();
            //Console.WriteLine(string.Join(", ", myArgs));

            //(part 1)SayHello();

            Console.ReadLine();
        }

        //(part 1)private static void SayHello()
        //{
        //    string name = "";
        //    Console.Write("What is your name: ");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Hello {0}", name);
        //(part 1)}
    }
}
