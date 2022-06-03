using System;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var BirthDateCalculator = new BirthDateCalculator();
            var birthDate = BirthDateCalculator.BuildBirthDate();

            public static Int32 BuildBirthDate(this DateTime dateOfBirth)
            {
                var today = DateTime.Today;

                var a = (today.Year * 100 + today.Month) * 100 + today.Day;
                var b = (birthYear * 100 + birthYearMonth) * 100 + birthDay;

                return (a - b) / 10000;
            }
        }
    }
}
