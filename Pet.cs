using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyPets

{
    [Serializable]
    public class Pet
    {
        int Health = 70;
        int Eat = 70;
        int Fun = 70;
        Random random = new Random();

        //повышаем значения
        public int Give_Pivo()
        {
            return Eat = Eat + 10;
        }
        public int To_Play()
        {
            return Fun = Fun + 10;
        }
        public int Treat()
        {
            return Health = Health + 10;
        }
       
        
        public string Condition_Kat()      // состояние кота
        {
            switch (random.Next(0, 5))
            {
                case (1):
                    Health = Health - 5;
                    break;
                case (2):
                    Eat = Eat - 5;
                    break;
                case (3):
                    Fun = Fun - 5;
                    break;
            }
            if (Eat == 0 || Health == 0)
            {
                return "Покойся с миром!!!";
            }
            if (Fun == 0)
            {
                return "Коту стало скучно. Он убежал от вас!";
            }

            if (Eat < 30)
            {
                if (Eat < 20)
                {
                    return "Жрать ДАВАЙ!";
                }
                return "Хочу кушать";

            }
            if (Eat > 80)
            {
                return "Я сейчас лопну...";
            }

            if (Health < 30)
            {
                return "Я заболел..(";
            }
            if (Fun < 30)
            {
                return "Мне скучно...";
            }

            return "У меня всё хорошо:)";
        }

        public int Current_Health()               // текущие параметры 
        {
            return Health;
        }
        public int Current_Eat()
        {
            return Eat;
        }
        public int Current_Fun()
        {
            return Fun;
        }
    }

}
