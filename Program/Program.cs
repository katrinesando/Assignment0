// See https://aka.ms/new-console-template for more information
using System;

// Console.WriteLine("Other branch");

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var leapYear = new Program(); //laver en ny instans af samme klasse
            
            Console.WriteLine("Please write a year and thereafter press Enter");
            string? input = Console.ReadLine(); //nullable string

            try
            {
                leapYear.IsLeapYear(leapYear.InputToInteger(input));
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

        public int InputToInteger(string? input)
        {
            if (int.TryParse(input, out var year))
            {
                return year;
            }
            throw new ArgumentException("Only integers allowed ");
        }
        public bool IsLeapYear(int year)
        {
            if (year < 1582)
            {
                throw new Exception("invalid input, must be integer and over 1582 ");
            }

            if (year % 100 == 0)
            {
                if (year % 4 != 0 || year % 400 != 0)
                {
                    Console.WriteLine("nay");
                    return false;
                }
            }
            Console.WriteLine("yay");
            return true;

        }

    }
}


