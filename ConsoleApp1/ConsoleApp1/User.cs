using ConsoleApp1.Objects;

namespace ConsoleApp1
{
    class User
    {
        public string Name;

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
        public bool CanDrink
        {
            get
            {
                return Age > 18;
            }

        }

        /// <summary>
        /// Возраст будет установлен в 18 лет.
        /// </summary>
        /// <param name="name">Имя нашего прекрасного пользователя</param>

        public User(string name)
        {
            Name = name;
            Age = 18;
        }


        /// <summary>
        /// Будет заполнено поля именя и возраста.
        /// </summary>
        /// <param name="name">Имя нашего прекрасного пользователя</param>
        /// <param name="age">Возраст без ограничений</param>
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }


        /// <summary>
        /// Он расскажет как его зовут и сколько ему лет
        /// </summary>
        /// <returns></returns>

        public string SayHi()
        {
            return $"Hi my name is {Name}. I'm {Age} old.";
        }

        public string FullName()
        {
            return $"Greate, {Name}"; //$"Greate, Boris"
        }
    }

}
