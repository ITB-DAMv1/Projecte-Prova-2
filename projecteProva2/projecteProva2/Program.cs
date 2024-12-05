//PRE: rep 3 números
using System;

namespace Ex3
{
    public class validateNum
    {
        const string AskDay = "Introdueix el dia";
        const string AskMonth = "Introdueix el mes";
        const string AskYear = "Introdueix l'any";
        const int MaxMonth = 12;
        const int Min = 0;
        const int MaxOddDay = 30;
        const int MaxEvenDay = 31;
        const int MaxFebNorDay = 28;
        const int MaxFeb4Day = 29;
        const int Jan = 1;
        const int Feb = 2;
        const int Mar = 3;
        const int Apr = 4;
        const int May = 5;
        const int Jun = 6;
        const int Jul = 7;
        const int Aug = 8;
        const int Sep = 9;
        const int Oct = 10;
        const int Nov = 11;
        const int Dec = 12;
        const string Date = "La data posada es {0}/{1}/{2}";
        public static void Main()
        {
            int year = GetYear();
            int month = GetMonth();
            int day = GetDayOnMonth(month, year);
            Console.WriteLine(Date,day,month,year);
        }
        public static int GetYear()
        {
            int year = 0;
            do
            {
                Console.WriteLine(AskYear);
            } while (!int.TryParse(Console.ReadLine(), out year) && year > 0);
            return year;
        }
        public static int GetMonth()
        {
            int month = 0;
            do
            {
                Console.WriteLine(AskMonth);
            } while (!int.TryParse(Console.ReadLine(), out month) && month > 0 && month > 12);
            return month;
        }
        public static int GetDayOnMonth(int month, int year)
        {
            if (month == 2)
            {
                if ((year % 4 == 0) && !(year % 400 == 0))
                {
                    return GetDay(MaxFeb4Day);
                }
                else
                {
                    return GetDay(MaxFebNorDay);
                }
            }
            else
            {
                if (month == Jan || month == Mar || month == May || month == Jul || month == Sep || month == Nov) 
                {
                    return GetDay(MaxOddDay);
                }
                else
                {
                    return GetDay(MaxEvenDay);
                }
            }
        }
        public static int GetDay(int max)
        {
            int day = 0;
            do
            {
                Console.WriteLine(AskDay);
            } while (!int.TryParse(Console.ReadLine(), out day) && day > Min && day <= max);
            return day;
        }
    }
}
