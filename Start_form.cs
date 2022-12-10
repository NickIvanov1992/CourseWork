using MyPets;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyPets
{
    public partial class Start_form : Form
    {
        public Start_form()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)    // кнопка загрузить сохранку
        {
            try
            {             
                using (FileStream fs = new FileStream("gamedata.json", FileMode.OpenOrCreate))
                {
                    this.Hide();
                    Pet? Cat = JsonSerializer.Deserialize<Pet>(fs);
                    Form1 gameform = new Form1(Cat);
                    gameform.Show();
                }                 
            }
            catch (FileNotFoundException)
            {
                this.Hide();
                MessageBox.Show("Отсутствует сохраненная игра", "Внимание!", MessageBoxButtons.OK);
                Start_form start_Form = new Start_form();
                start_Form.Show();
            }
        }

        private void Start_form_Load(object sender, EventArgs e)
        {

        }
        
        public void button1_Click_1(object sender, EventArgs e)
        {
            Pet Cat = new Pet(70, 70, 70);
            Form1 gameform = new Form1(Cat);
            gameform.Show();                  // запуск игры
            this.Hide();
 
        }
 
        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
