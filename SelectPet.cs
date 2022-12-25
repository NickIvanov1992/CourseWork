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
    public partial class SelectPet : Form
    {
        public SelectPet()
        {
            InitializeComponent();
        }
        Point lastpoint;                                                //  сделаем возможность перемещать форму мышью
        private void SelectPet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void SelectPet_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        string petType;
        private void button_Cat_Click(object sender, EventArgs e)   // cat                 
        {
            petType = "Cat";    //тип питомца
            EnterPetName enterPetName = new EnterPetName(petType);
            this.Hide();
            enterPetName.Show();
        }

        private void button_Dog_Click(object sender, EventArgs e)     // dog
        {
            petType = "Dog";  // тип питомца
            EnterPetName enterPetName = new EnterPetName(petType);
            this.Hide();
            enterPetName.Show();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_form start_Form = new Start_form();
            start_Form.Show();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
