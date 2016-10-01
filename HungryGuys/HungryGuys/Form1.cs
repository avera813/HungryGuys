using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungryGuys
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        MenuMaker menu;

        System.Media.SoundPlayer eatingSound = new System.Media.SoundPlayer(@"..\..\Resources\eating.wav");
        System.Media.SoundPlayer dingSound = new System.Media.SoundPlayer(@"..\..\Resources\ding.wav");

        public Form1()
        {
            InitializeComponent();
            menu = new MenuMaker();
            joe = new Guy() { Name = "Joe" };
            bob = new Guy() { Name = "Bob" };
            UpdateForm();
        }

        public void UpdateForm()
        {
            joesPlateLabel.Text = joe.Name + " has " + joe.Plate;
            bobsPlateLabel.Text = bob.Name + " has " + bob.Plate;
            makeJoeSandwich.Enabled = (joe.NumberOfPlateItems() < 2) ? true : false;
            makeBobSandwich.Enabled = (bob.NumberOfPlateItems() < 2) ? true : false;
            joeEatSandwich1.Enabled = (joe.NumberOfPlateItems() >= 1) ? true : false;
            joeEatSandwich2.Enabled = (joe.NumberOfPlateItems() == 2) ? true : false;
            bobEatSandwich1.Enabled = (bob.NumberOfPlateItems() >= 1) ? true : false;
            bobEatSandwich2.Enabled = (bob.NumberOfPlateItems() == 2) ? true : false;
        }

        private void makeJoeSandwich_Click(object sender, EventArgs e)
        {
            joe.ReceiveSandwich(menu.GetMenuItem());
            dingSound.Play();
            UpdateForm();
        }

        private void makeBobSandwich_Click(object sender, EventArgs e)
        {
            bob.ReceiveSandwich(menu.GetMenuItem());
            dingSound.Play();
            UpdateForm();
        }

        private void bobEatSandwich1_Click(object sender, EventArgs e)
        {
            eatingSound.Play();
            bob.EatSandwich(0);
            UpdateForm();
        }

        private void bobEatSandwich2_Click(object sender, EventArgs e)
        {
            eatingSound.Play();
            bob.EatSandwich(1);
            UpdateForm();
        }

        private void joeEatSandwich1_Click(object sender, EventArgs e)
        {
            eatingSound.Play();
            joe.EatSandwich(0);
            UpdateForm();
        }

        private void joeEatSandwich2_Click(object sender, EventArgs e)
        {
            eatingSound.Play();
            joe.EatSandwich(1);
            UpdateForm();
        }
    }
}
