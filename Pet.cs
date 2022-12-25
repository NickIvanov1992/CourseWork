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
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Eat { get; set; }
        public int Fun { get; set; }
        public Stopwatch sWatch = new();     // покажет время жизни 
        public Pet(int health, int eat, int fun, string name)
        {
            Health = health;
            Eat = eat;
            Fun = fun;
            Name = name;
            
        }
        public Pet()
        {

        }
        public Random random = new();       // переменная для хаотичного уменьшение прогресс-баров здоровья, голода, радости

        public abstract (string,string) Give_Pivo();    //покормить
        public abstract (string, string) To_Play();     // поиграть
        public abstract (string, string) To_Treat();    // лечить
        public abstract (string, string) Say_Hello();    // приветствие
        public abstract (string,string) Get_Condition_Pet();      // состояние кота
    
        public int Get_Current_Health() => Health;               // текущие параметры 
        public int Get_Current_Eat() => Eat;
        public int Get_Current_Fun() => Fun;   
    }
    
}
