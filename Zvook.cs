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
        public static void Play_puk()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream =
            assembly.GetManifestResourceStream(@"MyPets.puk.wav");
            SoundPlayer player = new SoundPlayer(resourceStream);
            player.Play();
        }
    }
}
