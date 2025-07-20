using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_game
{
    public partial class Form1: Form
    {
        int clickCount = 0;
        int timeLeft = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Random rand = new Random();

            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            int newX = rand.Next(0, maxX);
            int newY = rand.Next(0, maxY);

            button1.Location = new Point(newX, newY);

            clickCount++; // Increase by 1 on each click
            label1.Text = "Score: " + clickCount ;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            timeLeft--;

            this.Text = "Time Left: " + timeLeft + " seconds"; // Optional: show in title bar or use a Label

            if (timeLeft <= 0)
            {
                timer1.Stop(); // Stop timer
                button1.Enabled = false; // Disable the button
                MessageBox.Show("Time's up! Game over.");
            }
            label2.Text = "Time Left: " + timeLeft + " sec";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
