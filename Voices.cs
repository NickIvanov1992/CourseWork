using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


    public class Voices
    {
    public string GetValue(string str)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("Мне скучно...", @"MyPets.Voice.skuchno.wav");
        dict.Add("Я сейчас лопну...", @"MyPets.Voice.lopnu.wav");
        dict.Add("Я заболел..(", @"MyPets.Voice.golovabolit.wav");
        dict.Add("Жрать ДАВАЙ!", @"MyPets.Voice.zhrat.wav");
        dict.Add("Хочу кушать", @"MyPets.Voice.kushat.wav");
        dict.Add("Приветик!!!", @"MyPets.Voice.privetik.wav");
        dict.Add("Спасибо за пивко", @"MyPets.Voice.spasibozapivo.wav");
        dict.Add("Я счастлив!!!", @"MyPets.Voice.igrat.wav");
        dict.Add("Спасибо за помощь, брат!!", @"MyPets.Voice.lechitsa.wav");
        dict.Add("У меня всё хорошо:)", @"MyPets.Voice.horosho.wav");
        
        string value = dict[str];
        return value;
    }
    
}

