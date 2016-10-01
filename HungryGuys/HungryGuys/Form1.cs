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

        // Declare images
        Image initImage = Image.FromFile(@"..\..\Resources\plate-init.png");
        Image crumbsImage = Image.FromFile(@"..\..\Resources\plate-crumbs.png");
        Image sandwichImage = Image.FromFile(@"..\..\Resources\plate-sandwich.png");

        // Declare sounds
        System.Media.SoundPlayer eatingSound = new System.Media.SoundPlayer(@"..\..\Resources\eating.wav");
        System.Media.SoundPlayer dingSound = new System.Media.SoundPlayer(@"..\..\Resources\ding.wav");

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = initImage;
            menu = new MenuMaker();
            joe = new Guy() { Name = "Joe" };
            bob = new Guy() { Name = "Bob" };
            UpdateForm();
        }

        // Update labels and buttons
        public void UpdateForm()
        {
            joesPlateLabel.Text = joe.Name + " has " + joe.Plate + ".";
            bobsPlateLabel.Text = bob.Name + " has " + bob.Plate + ".";

            // Set buttons to enabled/disabled based on number of items on plate per Guy object
            makeJoeSandwich.Enabled = (joe.NumberOfPlateItems() < 2) ? true : false;
            makeBobSandwich.Enabled = (bob.NumberOfPlateItems() < 2) ? true : false;
            joeEatSandwich1.Enabled = (joe.NumberOfPlateItems() >= 1) ? true : false;
            joeEatSandwich2.Enabled = (joe.NumberOfPlateItems() == 2) ? true : false;
            bobEatSandwich1.Enabled = (bob.NumberOfPlateItems() >= 1) ? true : false;
            bobEatSandwich2.Enabled = (bob.NumberOfPlateItems() == 2) ? true : false;
        }

        // Action taken when a sandwich is made
        public void makeSandwichAction()
        {
            dingSound.Play();
            pictureBox1.Image = sandwichImage;
        }

        // Action taken when a sandwich is eaten
        public void eatSandwichAction()
        {
            eatingSound.Play();
            pictureBox1.Image = crumbsImage;
        }

        private void makeJoeSandwich_Click(object sender, EventArgs e)
        {
            joe.ReceiveSandwich(menu.GetMenuItem());
            makeSandwichAction();
            UpdateForm();
        }

        private void makeBobSandwich_Click(object sender, EventArgs e)
        {
            bob.ReceiveSandwich(menu.GetMenuItem());
            makeSandwichAction();
            UpdateForm();
        }

        private void bobEatSandwich1_Click(object sender, EventArgs e)
        {
            eatSandwichAction();
            bob.EatSandwich(0);
            UpdateForm();
        }

        private void bobEatSandwich2_Click(object sender, EventArgs e)
        {
            eatSandwichAction();
            bob.EatSandwich(1);
            UpdateForm();
        }

        private void joeEatSandwich1_Click(object sender, EventArgs e)
        {
            eatSandwichAction();
            joe.EatSandwich(0);
            UpdateForm();
        }

        private void joeEatSandwich2_Click(object sender, EventArgs e)
        {
            eatSandwichAction();
            joe.EatSandwich(1);
            UpdateForm();
        }
    }
}
