using System;
class Program
{

    int age = birthDate.Age();

    public static class DateTimeExtensions
    {
        /// <summary>
        /// Calculates the age in years of the current System.DateTime object today.
        /// </summary>
        /// <param name="birthDate">The date of birth</param>
        /// <returns>Age in years today. 0 is returned for a future date of birth.</returns>
        public static int Age(this DateTime birthDate)
        {
            return Age(birthDate, DateTime.Today);
        }

        /// <summary>
        /// Calculates the age in years of the current System.DateTime object on a later date.
        /// </summary>
        /// <param name="birthDate">The date of birth</param>
        /// <param name="laterDate">The date on which to calculate the age.</param>
        /// <returns>Age in years on a later day. 0 is returned as minimum.</returns>
        public static int Age(this DateTime birthDate, DateTime laterDate)
        {
            int age;
            age = laterDate.Year - birthDate.Year;

            if (age > 0)
            {
                age -= Convert.ToInt32(laterDate.Date < birthDate.Date.AddYears(age));
            }
            else
            {
                age = 0;
            }

            return age;
        }
    }
    static void Main(string[] args)
    {
        RunTest();
    }

    private static void RunTest()
    {
        DateTime birthDate = new DateTime(2000, 2, 28);
        DateTime laterDate = new DateTime(2011, 2, 27);
        string iso = "yyyy-MM-dd";

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Birth date: " + birthDate.AddDays(i).ToString(iso) + "  Later date: " + laterDate.AddDays(j).ToString(iso) + "  Age: " + birthDate.AddDays(i).Age(laterDate.AddDays(j)).ToString());
            }
        }

        Console.ReadKey();
    }
}