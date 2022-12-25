using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MyPets
{
    public static class Zvook
    {
        public static void Get_Play (string voice)             //   проиграть голос
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream =
            assembly.GetManifestResourceStream(voice);
            SoundPlayer player = new SoundPlayer(resourceStream);
            player.Play();
        }

        public static string str = "";                          //переменная чтобы вызвать звук 1 раз
        public static string Get_Voice(string voice,string Name)         //  получить нужный голос в зависимости от текста
        {
            if (voice != str)
            {
            Voices voices = new Voices();
            string sound = voices.GetValue(voice,Name);
            Get_Play(sound); 
            str = voice;
            }
            return str;
        }
    }
}
