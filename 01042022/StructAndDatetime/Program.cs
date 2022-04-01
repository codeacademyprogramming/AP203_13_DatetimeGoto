using System;

namespace StructAndDatetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            Console.WriteLine(human.Age);

            DateTime date = new DateTime(2022,10,25,20,45,0);
            date = DateTime.UtcNow.AddHours(4);
            date = date.AddMonths(-20);
            date = date.AddYears(-100);
            date = date.AddDays(-1);

            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.DayOfWeek);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Minute);


            Console.WriteLine(date);


            date = DateTime.Now;
            Console.WriteLine("Date");
            string dateStr = date.ToShortDateString();
            dateStr = date.ToString("dd-MM-yyyy");

            Console.WriteLine("Tarixi daxil edin:");
            string inputDateStr = Console.ReadLine();

            Console.WriteLine("Geri getmek istediyiniz ili daxil edin:");
            string yearStr = Console.ReadLine();

            DateTime inputDate = Convert.ToDateTime(inputDateStr);
            int year = Convert.ToInt32(yearStr)*-1;

            DateTime resultDate = inputDate.AddYears(year);

            Console.WriteLine(resultDate.ToString("dddd-MMMM-yyyy"));

            Console.WriteLine(resultDate<DateTime.Now);

            DateTime birthDate = new DateTime(1990, 12, 01);
            var val = birthDate.DayOfWeek;
            Console.WriteLine(birthDate.DayOfWeek);

            var diff = DateTime.Now.Subtract(birthDate);

            Console.WriteLine(GetDiffDateYears()); 
        }

        static int GetDiffDateYears() 
        {
            string dateStr1 = Console.ReadLine();
            string dateStr2 = Console.ReadLine();

            DateTime dateTime1 = Convert.ToDateTime(dateStr1);
            DateTime dateTime2 = Convert.ToDateTime(dateStr2);
            return dateTime2.Year - dateTime1.Year;
        }
    }
}
