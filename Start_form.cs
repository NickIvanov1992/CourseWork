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
                    using (FileStream fs = new("gamedata.json", FileMode.Open))
                    {
                        this.Hide();
                        Pet? selectPet = JsonSerializer.Deserialize<Pet>(fs);
                        Form1 gameform = new();
                        gameform.Show();
                    }
                }
                catch (FileNotFoundException)
                {
                    this.Hide();
                    MessageBox.Show("Отсутствует сохраненная игра", "Внимание!", MessageBoxButtons.OK);
                    Start_form start_Form = new();
                    start_Form.Show();
                } 
        }
        public void NewGame_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SelectPet selectPet = new();
            selectPet.Show();
        }
 
        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastpoint;
        private void Start_form_MouseMove(object sender, MouseEventArgs e)    //  возможность перемещать окно мышью
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void Start_form_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }

}
