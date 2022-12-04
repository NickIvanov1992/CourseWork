using MyPets;
using System;
using System.IO;
using System.Windows.Forms;

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
                this.Hide();
                Form1 gameform = new Form1();
                GameData data = GameData.Load(@"C:\Users\Admin\source\repos\practic\MyPets\Save\gamedata.xml");
                gameform.Show();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 gameform = new Form1();
            gameform.Show();                  // запуск игры
            this.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
