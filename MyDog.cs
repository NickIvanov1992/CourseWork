using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPets
{
    [Serializable]
    internal class MyDog : Pet
    {
        public MyDog(int health, int eat, int fun, string name) : base(health, eat, fun, name) { }
        string picture_pet;                        // картинка эмоции
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

            picture_pet = Get_PictureCat(picture_text, Name);              //  получаем картинку-эмоцию в зависимости от коментария
            Zvook.Get_Voice(picture_text, Name);                          // получаем голос в зависимости от комментария
            return (picture_text, picture_pet);
        }

        public override (string, string) Give_Pivo()
        {
            Eat += 10;
            picture_text = "Спасибо за пивко";
            picture_pet = Get_PictureCat(picture_text, Name);
            Zvook.Get_Voice(picture_text, Name);
            return (picture_text, picture_pet);
        }
        public override (string, string) To_Play()
        {
            Fun += 10;
            picture_text = $"{Name} любит играть!!!";
            picture_pet = Get_PictureCat(picture_text, Name);
            Zvook.Get_Voice(picture_text, Name);
            return (picture_text, picture_pet);
        }
        public override (string, string) To_Treat()
        {
            Health += 10;
            picture_text = "Спасибо за помощь, брат!!";
            picture_pet = Get_PictureCat(picture_text, Name);
            Zvook.Get_Voice(picture_text, Name);
            return (picture_text, picture_pet);
        }
        public override (string, string) Say_Hello()
        {
            picture_text = "Приветик!!!";
            picture_pet = Get_PictureCat(picture_text, Name);
            Zvook.Get_Voice(picture_text, Name);
            return (picture_text, picture_pet);
        }

        public string Get_PictureCat(string text, string Name)                    // получить картинку в зависимости от текстового состояния
        {
            Dictionary<string, string> emotions = new Dictionary<string, string>()      // словарь состояний картинок и текста
            {
                [$"{Name} хочет кушать"] = "fail_dog.jpg",
                ["Жрать ДАВАЙ!"] = "scary_dog.jpg",
                [$"{Name} заболел..("] = "fail_dog.jpg",
                [$"{Name} сейчас лопнет..."] = "dog_overeat.jpg",
                [$"{Name} скучает..."] = "dog frowns.jpg",
                [$"{Name} радуется:)"] = "dog calm.png",
                [$"{Name} заскучал. Он убежал от вас!"] = "dosvidos.jpg",
                [$"Покойся с миром, {Name}!"] = "grave_dog.jpg",
                ["Спасибо за пивко"] = "beer dog.jpg",
                [$"{Name} любит играть!!!"] = "gaming dog.jpg",
                ["Спасибо за помощь, брат!!"] = "happy dog.jpg",
                ["Приветик!!!"] = "hello_dog.png"
            };
            string value = emotions[text];
            return value;
        }
    }
}
