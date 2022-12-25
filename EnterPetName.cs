using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPets
{
    public partial class EnterPetName : Form
    {
        readonly string petType;
        public EnterPetName(string petType)
        {
            InitializeComponent();
            this.petType = petType;
        }
       
        Point lastpoint;
        private void EnterPetName_MouseMove(object sender, MouseEventArgs e)   //  возможность перемещать окно мышью
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void EnterPetName_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);    
        }

        private void Apply_button(object sender, EventArgs e)
        {
            string petName = textBox1.Text;                  // получаем имя питомца
            if (petName == "")
            {
                MessageBox.Show("Отсутствует имя питомца");
            }
            else
            {
                if (petType == "Cat")
                {
                    Pet MyPet = new MyCat(70, 70, 70, petName);
                    Form1 gameform = new(MyPet, petName);
                    gameform.Show();                  // запуск игры c котом
                    this.Hide();
                }
                else
                {
                    Pet MyPet = new MyDog(70, 70, 70, petName);
                    Form1 gameform = new(MyPet, petName);
                    gameform.Show();                  // запуск игры c собак
                    this.Hide();
                }
            }
        }

        private void Exit_button(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainMenu_button(object sender, EventArgs e)
        {
            this.Hide();
            Start_form start_Form = new();
            start_Form.Show();
        }
    }
}
