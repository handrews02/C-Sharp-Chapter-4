using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {


            Random ranNumberGenerator = new Random();
            int randomGuess;
            randomGuess = ranNumberGenerator.Next(1, 4);

            if (randomGuess == 1)
            {
                lblResult.Text = "It is a tie";
            }
            else if (randomGuess == 2)
            {
                lblResult.Text = "You lose!";
            }
            else if (randomGuess == 3)
            {
                lblResult.Text = "You win!";
            }

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            Random ranNumberGenerator = new Random();
            int randomGuess;
            randomGuess = ranNumberGenerator.Next(1, 4);

            if (randomGuess == 1)
            {
                lblResult.Text = "You win!";
            }
            else if (randomGuess == 2)
            {
                lblResult.Text = "It is a tie";
            }
            else if (randomGuess == 3)
            {
                lblResult.Text = "You lose!";
            }

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Random ranNumberGenerator = new Random();
            int randomGuess;
            randomGuess = ranNumberGenerator.Next(1, 4);

            if (randomGuess == 1)
            {
                lblResult.Text = "You lose!";
            }
            else if (randomGuess == 2)
            {
                lblResult.Text = "You win!";
            }
            else if (randomGuess == 3)
            {
                lblResult.Text = "It is a tie";
            }
        }
    }
}
