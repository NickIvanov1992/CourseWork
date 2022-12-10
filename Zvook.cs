using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MyPets
{
    public class Zvook
    {
        
        public static void Play (string voice)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream =
            assembly.GetManifestResourceStream(voice);
            SoundPlayer player = new SoundPlayer(resourceStream);
            player.Play();
        }

        public static string str = "";
        public static string Voice(string voice)
        {
            if (voice != str)
            {
            Voices voices = new Voices();
            string sound = voices.GetValue(voice);
            Play(sound); 
            str = voice;
            }
            return str;
        }
    }
}
