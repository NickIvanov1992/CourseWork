
using System.Xml.Serialization;


public class GameData          //  класс загрузки и сохранки
{
    // Сохраняемые параметры
    public int Health;
    public int Eat;
    public int Fun;
    public GameData(int health, int eat, int fun)  // передал в конструктор текущее состояние кота
    {
        Health = health;
        Eat = eat;
        Fun = fun;
    }
    public GameData()
    {

    }
    // метод сохранения в файл .xml :
    public void Save(string filename)
    {
        XmlSerializer xml = new XmlSerializer(typeof(GameData));
        Stream file = new FileStream(filename, FileMode.OpenOrCreate);
        xml.Serialize(file, this);
        file.Close();
    }
    // метод загрузки из файла .xml:
    public static GameData Load(string filename)
    {
        XmlSerializer xml = new XmlSerializer(typeof(GameData));
        Stream file = new FileStream(filename, FileMode.Open);
        object obj = xml.Deserialize(file);
        file.Close();
        return (GameData)obj;
    }
}
