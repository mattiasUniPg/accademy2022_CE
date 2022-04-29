using Academy.Common.Constants;
using Academy.Common.Enums;
using System;
using System.Globalization;

namespace Academy.TestConsole
{
    internal class Program
    {
        public const string ConsoleName = "Test Console";

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(CommonConstants.AcademyName);

            var season = Season.Spring;
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine(season);
                    break;
                case Season.Summer:
                    break;
                case Season.Autumn:
                    break;
                case Season.Winter:
                    break;
                default:
                    Console.WriteLine("stagione non trovata");
                    break;
            }

            string winter = "Winter";
            //Season season1 = winter;
            var season1 = Enum.Parse(typeof(Season), winter);

            Type typeSeasonType = typeof(Season);
            Type typeSeason = season1.GetType();
            Type typeWinter = winter.GetType();


            object season2 = Enum.Parse(typeof(Season), "winter", true);
            Season realSeason = (Season)season2;


            Season aaa = Season.Autumn;
            Console.WriteLine($"Integral value of {aaa} is {(int)aaa}");  // output: Integral value of Autumn is 2

            var bbb = (Season)1;
            Console.WriteLine(bbb);  // output: Summer

            var ccc = (Season)4;
            Console.WriteLine(ccc);  // output: 4

            Convert(season2);
            Convert(winter);


            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
            //equivalente
            for (int h = 0; h < args.Length; h++)
            {
                Console.WriteLine(args[h]);
            }



            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j); //0,1,2,3,4
            }

            int k = 10;
            do
            {
                Console.WriteLine(k); //10,11
                k++;
            } while (k < 12);


            int l = 7;
            while (l < 10)
            {
                Console.WriteLine(l); //7,8,9
                l++;
            }

            int m = 5;
            while (true)
            {
                if (m == 10)
                {
                    break;
                }

                m++;
                if (m < 8)
                {
                    continue;
                }

                Console.WriteLine(m);
            }



            //123 12/08/2020 true

            int argument0Parsed = int.Parse(args[0]); //123
            int result; //default 0
            bool isParsed = int.TryParse(args[0], out result);

            if (isParsed == true)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Attenzione: non sono riuscito a fare il parse");
            }

            string bu = "a";
            //var ciccio = 34D;
            switch (bu)
            {
                case "a":
                    Console.WriteLine(ConsoleName);
                    break;
                case "b":
                case "c":
                    Console.WriteLine("b o c");
                    break;
                case "d":
                    Console.WriteLine("d");
                    break;
                default:
                    //qualcosa da eseguire
                    break;
            }
            //equivale
            if (bu.Equals("a")) //equivale a bu =="a"
            {
                Console.WriteLine(ConsoleName);
            }
            else if (bu == "b" || bu == "c")
            {
                Console.WriteLine("123 ok");
            }
            else if (bu == "d")
            {
                Console.WriteLine("d");
            }
            else
            {
                //qualcosa da eseguire
            }

            int i = 34;
            if (i > 100)
            {

            }
            else if (i > 50)
            {

            }
            else if (i > 10)
            {

            }
            else
            {

            }


            DateTime dateTime;
            DateTime.TryParse(args[1], out dateTime); //12/08/2020
            //equivale a 
            //DateTime.TryParse(args[1], out DateTime dateTime1);

            DateTime.TryParse("05-12-56 12:34", out dateTime);

            bool bArg;
            bool.TryParse(args[2], out bArg); //true
            bArg = bool.Parse("TRUE"); //true

            double dParsed = double.Parse("123123123");

            /*
            var dTemp = 12D;
            double dTemp2 = (double)argument0Parsed;
            */


            DoWork();

            string concatArgs2 = string.Join(", ", args);
            string concatArgs2NoSeparatore = string.Concat(args);
            Console.WriteLine(concatArgs2);

            ArrayOperations();

            StringOperations();

            int a = 12;
            int b = 8;
            var c = (a + b) * a;
            var d = c / a;
            double e = Math.Pow(a, 2);

            var cultureUS = CultureInfo.GetCultureInfo("en-US");

            IntToStringOperations(a, cultureUS);

            DateTimeOperations(cultureUS);

            Console.ReadKey();
        }

        private static void IntToStringOperations(int a, CultureInfo cultureUS)
        {
            string aS = a.ToString(); // 12 => "12"
            // 12 =>  € 12.00
            aS = a.ToString("C"); //culture corrente (it-IT) => 12,00 €
            aS = a.ToString("C", cultureUS); // culture (en-US) => $12.00
            aS = a.ToString("C4");
            // 12 => 12.0
            aS = a.ToString("##.0");            // "12,0"
            aS = a.ToString("##.0", cultureUS); // "12.0"

            //percentuale
            aS = a.ToString("P");
        }

        private static void StringOperations()
        {
            string myString3 = null;
            string nullString = null;
            string myString2 = ConsoleName;
            myString3 = "stringa 3";

            var result = myString2 + myString3;
            result = string.Concat("ss", "www");

            //string.IsNullOrEmpty() metodo associato al tipo
            bool isNull = string.IsNullOrEmpty(nullString);

            // isNull.ToString() metodo associato all'istanza
            var boolToString = isNull.ToString();

            //bool hasC = myString3.Contains(nullString);
            int indexA = myString3.IndexOf("a");


            //formattazione e composite string

            string format = "Posizione X {1}, test test Xamarin";
            string resultFormat = format.Replace("X", "NewString");

            format = "Posizione {0} {1:C}, test test {0}{0} {2}";
            resultFormat = string.Format(format, "zero", 12, "X");

            resultFormat = $"Posizione {isNull} {myString3}, test test {234324:C}";

            Console.WriteLine("nullString is null? " + isNull);
            Console.WriteLine(result);
            Console.WriteLine("a is on position " + indexA);

            myString3 = "";
        }

        private static void DateTimeOperations(CultureInfo cultureUS)
        {
            DateTime dateTime = DateTime.Now;
            DateTime dateTime1 = new DateTime(2020, 12, 15);


            string dateTimeString = dateTime.ToString();        // 20/04/2022 12:52:38      it
            dateTimeString = dateTime.ToString(cultureUS);      // 4/20/2022 12:52:38 PM    us
            dateTimeString = dateTime.ToString("d.M.y");        // 20.4.22                  custom

            var dateTime2 = dateTime1.AddDays(25.5);
            TimeSpan interval = dateTime - dateTime1;
            TimeSpan interval1 = new TimeSpan(15, 4, 40, 0);
        }

        private static void ArrayOperations()
        {
            var MyStringList2 = new string[] { "wer", "ert" };
            var MyStringList3 = new string[3] { "wer", "ert", "asd" };

            int length = MyStringList3.Length; //3
            string pos0 = MyStringList3[0]; //"wer"
            string pos1 = MyStringList3[1]; //"ert"
            string pos2 = MyStringList3[2]; //"asd"

            MyStringList3.SetValue("ertertert", 0);
            //MyStringList3.SetValue("ertertert", 5); non si può fare l'indice (5) è maggiore della capienza (3) della array
        }

        static void DoWork()
        {
            Console.WriteLine("DoWork");
            Console.WriteLine("Ciao a tutti");

        }

        string DoString()
        {
            return "";
        }

        static void Convert(object obj)
        {
            switch (obj.GetType().Name)
            {
                case "String":

                    break;
                case "DateTime":

                    break;
                case "Int":

                    break;
                default:
                    break;
            }



        }
    }

    public class Ciccio
    {
        public int Pluto { get; set; }
    }

}