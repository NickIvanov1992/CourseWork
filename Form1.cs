using System;
using System.Diagnostics;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using MyPets;


namespace MyPets
{
 
    public partial class Form1 : Form
    {
        //Pet_State pet_state = new();
        Pet pet;
        public Stopwatch sWatch = new();     // секундомер времени жизни питомца
        string name;
        public delegate void Handler();
        public static event Handler StopGame;    // событие смерти

        public Form1(Pet MyPet, string name)              // принимает состояние кота
        {
            InitializeComponent();
            pet = MyPet;
            this.name = name;
        }
        public Form1()
        {
            
        }
        
        public void timer1_Tick(object sender, EventArgs e)   // запуск таймера начало игры
        {
            string pet_picture;                       // картинка состояния кота
            StopGame += Stop_game;                     // подписка на событие смерти
            (label1.Text, pet_picture) = pet.Get_Condition_Pet();                                         // вывод информации о состоянии кота
            progressBar_health.Value = pet.Get_Current_Health();                           // текущие уровни жизни
            progressBar_fun.Value = pet.Get_Current_Fun();
            progressBar_eat.Value = pet.Get_Current_Eat();           
            pictureBox1.Image = imageList1.Images[pet_picture];      // картинка состояния кота
            if (pet_picture == "cat_grave.jpg"|| pet_picture == "dosvidos.jpg"|| pet_picture == "grave_dog.jpg")    // если умер или убежал то стоп игра
                StopGame.Invoke();

            return;
        }
        string picture_state;                                    /// картинка реакции питомца на нажатие кнопок
        public void Form1_Load(object sender, EventArgs e)      //Приветствие .Появление питомца, запуск времени
        {   
            timer1.Start();                                         // таймер событий наступления голода , настроения , здоровья
            pet.sWatch.Start();                                   // время жизни кота
            //pictureBox1.Image = imageList1.Images[10];             // начало
            //label1.Text = "Приветик!!!";
            //Zvook.Voice(label1.Text, Name);
            (label1.Text, picture_state) = pet.Say_Hello();
            pictureBox1.Image = imageList1.Images[picture_state];
        }
        
        private void button1_Click(object sender, EventArgs e)     //нажать кормить
        {
            if (pet.Get_Current_Eat() < 90)
            {                
                (label1.Text, picture_state) = pet.Give_Pivo();
                progressBar_eat.Value = pet.Get_Current_Eat();
                pictureBox1.Image = imageList1.Images[picture_state];
                
            }
        }
        private void button2_Click(object sender, EventArgs e)    //  нажать играть
        {
            if (pet.Get_Current_Fun() < 90)
            {   
                (label1.Text, picture_state) = pet.To_Play();
                progressBar_fun.Value = pet.Get_Current_Fun();
                pictureBox1.Image = imageList1.Images[picture_state];
            }
        }
        private void button3_Click_1(object sender, EventArgs e)    //нажать лечить
        {
            if (pet.Get_Current_Health() < 90)
            { 
                (label1.Text, picture_state) = pet.To_Treat();
                progressBar_health.Value = pet.Get_Current_Health();
                pictureBox1.Image = imageList1.Images[picture_state];
            }
        }
        private void button4_Click(object sender, EventArgs e)  // кнопка Завершить игру
        {
            this.Hide();
            Start_form start_Form = new Start_form();
            start_Form.Show();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)     // изменить скорость игры
        {
            timer1.Interval = trackBar1.Value;
            label2.Text = "Моя активность:" + trackBar1.Value.ToString() + "ms";
        }
        private void button5_Click_1(object sender, EventArgs e)    // нажать кнопку _ сохранить
        {
            using (FileStream fs = new FileStream("gamedata.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<Pet>(fs, pet);
                label2.Text = "Игра сохранена";
            }
        }
        public void Stop_game()             
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            pet.sWatch.Stop();
            timer1.Stop();
        }

        private void Live_time_Tick(object sender, EventArgs e)
        {
            label2.Text = "Время жизни:" + pet.sWatch.Elapsed.ToString().Substring(0, 8);
        }

        Point lastpoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}

