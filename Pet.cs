using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MyPets

{
    [Serializable]
    public class Pet
    {
        public int Health { get; set; } 
        public int Eat { get; set; } 
        public int Fun { get; set; }

        public Stopwatch sWatch = new Stopwatch();     // покажет время жизни Кота

        public Pet(int health, int eat, int fun)
        {
            Health = health;
            Eat = eat;
            Fun = fun;
        }
        public Pet()
        {

        }

        Random random = new Random();       // хаотичное уменьшение прогресс-баров
        //повышаем значения
        public int Give_Pivo()
        {
            return Eat += 10;
        }
        public int To_Play()
        {
            return Fun += 10;
        }
        public int Treat()
        {
            return Health +=10;
        }
       
        
        public string Condition_Kat()      // состояние кота
        {
            switch (random.Next(0, 5))
            {
                case (1):
                    Health -= 5;
                    break;
                case (2):
                    Eat -= 5;
                    break;
                case (3):
                    Fun -= 5;
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
