using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;


    public class Voices
    {
    public string GetValue(string str,string Name)                //  словарь соответствия звуков и текста
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add($"{Name} скучает...", @"MyPets.Voice.skuchno.wav");
        dict.Add($"{Name} сейчас лопнет...", @"MyPets.Voice.lopnu.wav");
        dict.Add($"{Name} заболел..(", @"MyPets.Voice.golovabolit.wav");
        dict.Add("Жрать ДАВАЙ!", @"MyPets.Voice.zhrat.wav");
        dict.Add($"{Name} хочет кушать", @"MyPets.Voice.kushat.wav");
        dict.Add("Приветик!!!", @"MyPets.Voice.privetik.wav");
        dict.Add("Спасибо за пивко", @"MyPets.Voice.spasibozapivo.wav");
        dict.Add($"{Name} любит играть!!!", @"MyPets.Voice.igrat.wav");
        dict.Add("Спасибо за помощь, брат!!", @"MyPets.Voice.lechitsa.wav");
        dict.Add($"{Name} радуется:)", @"MyPets.Voice.horosho.wav");
        dict.Add($"Покойся с миром, {Name}!", @"MyPets.Voice.pohorons.wav");
        dict.Add($"{Name} заскучал. Он убежал от вас!", @"MyPets.Voice.ubezhal.wav");

        string value = dict[str];
        return value;
    }

}

