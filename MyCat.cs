using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyPets
{
    [Serializable]
    internal class MyCat:Pet
    {
        public MyCat(int health, int eat, int fun, string name) : base(health, eat, fun, name) { }
        string picture_cat;                        // картинка эмоции
        string picture_text;                       // комментарий эмоции
        public override (string, string) Get_Condition_Pet()             /// кортеж возвращает текстовое состояние
        {                                                            /// и картинку             
            switch (random.Next(0, 3))                 //  случайно с помощью switch / case уменьшаем значение здоровья, голода и счастья 
            {
                case 0:
                    Health -= 2;
                    break;
                case 1:
                    Eat -= 2;
                    break;
                case 2:
                    Fun -= 2;
                    break;
            }
            if (Eat == 0 || Health == 0)              
                picture_text = $"Покойся с миром, {Name}!";              
                      
            else if (Fun <= 0)
                picture_text = $"{Name} заскучал. Он убежал от вас!";


            else if (Eat < 30)
            {
                picture_text = $"{Name} хочет кушать";

                if (Eat < 20)
                picture_text = "Жрать ДАВАЙ!";
            }

           else if (Eat > 80)
               picture_text = $"{Name} сейчас лопнет...";

           else if (Health < 30)
                picture_text = $"{Name} заболел..(";
            
           else if (Fun < 30)
                picture_text = $"{Name} скучает...";
            
            else
                picture_text = $"{Name} радуется:)";

            picture_cat = Get_PictureCat(picture_text,Name);              //  получаем картинку-эмоцию в зависимости от коментария
            Zvook.Get_Voice(picture_text,Name);                          // получаем голос в зависимости от комментария
            return (picture_text,picture_cat);                                   
        }

        public override (string,string) Give_Pivo()
        {
                Eat += 10;
                picture_text = "Спасибо за пивко";
                picture_cat = Get_PictureCat(picture_text, Name);
                Zvook.Get_Voice(picture_text, Name);
                return (picture_text, picture_cat);            
        }
        public override (string, string) To_Play()
        {
                Fun += 10;
                picture_text = $"{Name} любит играть!!!";
                picture_cat = Get_PictureCat(picture_text, Name);
                Zvook.Get_Voice(picture_text, Name);
                return (picture_text, picture_cat);
        }
        public override (string, string) To_Treat()
        {
                Health += 10;
                picture_text = "Спасибо за помощь, брат!!";
                picture_cat = Get_PictureCat(picture_text, Name);
                Zvook.Get_Voice(picture_text, Name);
                return (picture_text, picture_cat);
        }
        public override (string, string) Say_Hello()
        {
            picture_text = "Приветик!!!";
            picture_cat = Get_PictureCat(picture_text, Name);
            Zvook.Get_Voice(picture_text, Name);
            return (picture_text, picture_cat);
        }

        public string Get_PictureCat(string text, string Name)                    // получить картинку в зависимости от текстового состояния
        {
            Dictionary<string, string> emotions = new Dictionary<string, string>()      // словарь состояний картинок и текста
            {
                [$"{Name} хочет кушать"] = "hungry cat 1.png",
                ["Жрать ДАВАЙ!"] = "scary cat1.jpg",
                [$"{Name} заболел..("] = "fail cat1.jpg",
                [$"{Name} сейчас лопнет..."] = "cat_overeat2.png",
                [$"{Name} скучает..."] = "cat_frowns.png",
                [$"{Name} радуется:)"] = "cat_calm.png",
                [$"{Name} заскучал. Он убежал от вас!"] = "dosvidos.jpg",
                [$"Покойся с миром, {Name}!"] = "cat_grave.jpg",
                ["Спасибо за пивко"] = "beer cat.jpg",
                [$"{Name} любит играть!!!"] = "gaming cat.jpg",
                ["Спасибо за помощь, брат!!"] = "cat smoke.jpg",
                ["Приветик!!!"] = "happy cat1.jpg"
            };
            string value = emotions[text];
            return value;
        }
    }
}
