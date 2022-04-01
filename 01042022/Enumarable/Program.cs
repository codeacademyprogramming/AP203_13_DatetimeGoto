using System;
using System.Collections.Generic;

namespace Enumarable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IEnumarable
            //MyList<int> myList = new MyList<int>();

            //myList[0] = 45;
            //myList[1] = 50;

            //Console.WriteLine(myList[0]);

            //MyList<string> stringList = new MyList<string>();
            //stringList[0] = "myList1";
            //stringList[3] = "myList2";
            //stringList[6] = "myList3";


            //List<string> stringList2 = new List<string>();
            //stringList2.Add("str1");
            //stringList2.Add("str2");
            //stringList2.Add("str3");

            //Console.WriteLine("Custom string list");
            //foreach (var item in stringList)
            //{
            //    Console.WriteLine(item);
            //}


            //stringList[0] = "A";
            //stringList[1] = "B";
            //stringList[2] = "C";

            //Console.WriteLine(stringList[1]);


            //int[] nums = { 1, 2, 3, };

            //foreach (var item in GetWeekdays())
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region goto

            Human human = new Human();
            human.Age = 45;
            human.Name = "Name1";
            human.Surname = "Surname1";

            //bool isExit = false;

            //do
            //{
            //    Console.WriteLine("1. Ad yazdir");
            //    Console.WriteLine("2. Soyad yazdir");
            //    Console.WriteLine("3. Yas yazdir");
            //    Console.WriteLine("0. Menudan cix");


            //    Console.WriteLine("Seciminiz edin:");
            //    string option = Console.ReadLine();
            //    switch (option)
            //    {
            //        case "1":
            //            Console.WriteLine(human.Name);
            //            break;
            //        case "2":
            //            Console.WriteLine(human.Surname);
            //            goto case "1";
            //        case "3":
            //            Console.WriteLine(human.Age);
            //            break;
            //        case "0":
            //            isExit = true;
            //            break;
            //        default:
            //            Console.WriteLine("Seciminiz yanlisdir, tekrar secin!");
            //            break;
            //    }

            //} while (!isExit);

            menu:
            Console.WriteLine("1. Ad yazdir");
            Console.WriteLine("2. Soyad yazdir");
            Console.WriteLine("3. Yas yazdir");
            Console.WriteLine("0. Menudan cix");

            chose:
            Console.WriteLine("Seciminiz edin:");
            string option = Console.ReadLine();

            bool isExit = false;

            switch (option)
            {
                case "1":
                    Console.WriteLine(human.Name);
                    goto menu;
                case "2":
                    Console.WriteLine(human.Surname);
                    goto menu;
                case "3":
                    Console.WriteLine(human.Age);
                    goto menu;
                case "0":
                    break;
                default:
                    Console.WriteLine("Seciminiz yanlisdir, tekrar secin!");
                    goto chose;
            }


            #endregion


        }


            static IEnumerable<string> GetWeekdays()
        {
            yield return "Bazarertesi";
            yield return "Cersenbe axsami";
            yield return "Cersenbe";
            yield return "Cume axsami";
            yield break;
            yield return "Cume";
            yield return "Senbe";
            yield return "Bazar";
        }
    }
}
