using System.Diagnostics;
using System.Media;




namespace MyPets

{
    public partial class Form1 : Form
    {
        public Stopwatch sWatch = new Stopwatch();    // покажет время жизни Кота
        public Form1()
        {
            InitializeComponent();
        }
        Pet Cat = new Pet();
        public void timer1_Tick(object sender, EventArgs e)   // запуск таймера начало игры
        {
            
            label2.Text = "Время жизни:" + sWatch.Elapsed.ToString().Substring(0, 8);
            label1.Text = Cat.Condition_Kat();
            progressBar_health.Value = Cat.Current_Health();
            progressBar_fun.Value = Cat.Current_Fun();
            progressBar_eat.Value = Cat.Current_Eat();

            if (label1.Text == "Хочу кушать")
            {
                pictureBox1.Image = imageList1.Images[11];
                return;
            }
            if (label1.Text == "Жрать ДАВАЙ!")
            {
                pictureBox1.Image = imageList1.Images[12];
                return;
            }
            if (label1.Text == "Я заболел..(")
            {
                pictureBox1.Image = imageList1.Images[8];
                return;
            }
            if (label1.Text == "Я сейчас лопну...")
            {
                pictureBox1.Image = imageList1.Images[6];
                return;
            }
            if (label1.Text == "Мне скучно...")
            {
                pictureBox1.Image = imageList1.Images[4];
                return;
            }
            if (label1.Text == "Коту стало скучно. Он убежал от вас!")
            {

                pictureBox1.Image = imageList1.Images[7];
                button1.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
                sWatch.Stop();
                timer1.Stop();
                Zvook.Play_puk();
                return;
            }

            if (label1.Text == "Покойся с миром!!!")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
                pictureBox1.Image = imageList1.Images[5];
                sWatch.Stop();
                timer1.Stop();
                Zvook.Play_puk();
                return;
            }
            else
                pictureBox1.Image = imageList1.Images[3];
            return;

        }
        public void Form1_Load(object sender, EventArgs e)      //Появление кота, запуск времени
        {
            timer1.Start();
            sWatch.Start();
            pictureBox1.Image = imageList1.Images[10];             // начало
            label1.Text = "Приветик!!!";
        }
        private void button1_Click(object sender, EventArgs e)     //нажать кормить
        {
            pictureBox1.Image = imageList1.Images[0];
            label1.Text = "Спасибо за пивко";
            if (Cat.Current_Eat() < 90)
            {
                Cat.Give_Pivo();
                progressBar_eat.Value = Cat.Current_Eat();
            }
        }
        private void button2_Click(object sender, EventArgs e)    //  нажать играть
        {
            pictureBox1.Image = imageList1.Images[9];
            label1.Text = "Я счастлив!!!";
            
            if (Cat.Current_Fun() < 90)
            {
                Cat.To_Play();
                progressBar_fun.Value = Cat.Current_Fun();
            }
        }
        private void button3_Click_1(object sender, EventArgs e)    //нажать лечить
        {
            pictureBox1.Image = imageList1.Images[2];
            label1.Text = "Спасибо за помощь, брат!!";
            if (Cat.Current_Health() < 90)
            {
                Cat.Treat();
                progressBar_health.Value = Cat.Current_Health();
            }
        }

        private void button4_Click(object sender, EventArgs e)  // кнопка Завершить игру
        {
            this.Hide();
            Start_form start_Form = new Start_form();
            start_Form.Show();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label2.Text = "Моя активность:" + trackBar1.Value.ToString() + "ms";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click_1(object sender, EventArgs e)    // нажать кнопку _ сохранить
        {
            int health = Cat.Current_Health();
            int eat = Cat.Current_Eat();
            int fun = Cat.Current_Fun();
            GameData data = new GameData(health, eat, fun);
            data.Save(@"C:\Users\Admin\source\repos\practic\MyPets\Save\gamedata.xml");
        }

        private void progressBar_eat_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar_fun_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_health_Click(object sender, EventArgs e)
        {

        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label2.Text = "Моя активность:" + trackBar1.Value.ToString() + "ms";
        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_form start_Form = new Start_form();
            start_Form.Show();
        }

    }

}

