using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    class BirthDate
    {
        public int Year;
        public int Month;
        public int Day;

        /// <summary>
        /// Будет заполнено поля именя и возраста.
        /// </summary>
        /// <param name="name">Имя нашего прекрасного пользователя</param>
        /// <param name="age">Возраст без ограничений</param>
        public BirthDate(int birthYear, int birthMonth, int birthDay)
        {
            Year = birthYear;
            Month = birthMonth;
            Day = birthDay;
        }


        /// <summary>
        /// Он расскажет как его зовут и сколько ему лет
        /// </summary>
        /// <returns></returns>

        public string SayHi()
        {
            return $"Hi my birth date is {Day}.{Month}.{Year}";
        }

        //public string FullName()
        //{
        //    return $"Greate, {Name}";
        //}
    }
}
