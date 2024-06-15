using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorsPaper_Game
{
    public partial class Form1 : Form
    {
        private string[] choices = new string[] { "Rock", "Scissors", "Paper" };
        private Random r = new Random();
        private string GetComputerChoice()
        {
            string choice = choices[r.Next(choices.Length)];
            return choice;
        }
        private void GetResult(string userChoice)
        {
            string computerChoice = GetComputerChoice();
            computerChoiceTextBox.Text = computerChoice;
            userChoiceTextBox.Text = userChoice;
            if (userChoice == computerChoice)
            {
                resultTextBox.Text = "Draw";
            }
            else if (userChoice == "Rock" && computerChoice == "Scissors" ||
                userChoice == "Paper" && computerChoice == "Rock" ||
                userChoice == "Scissors" && computerChoice == "Paper")
            {
                resultTextBox.Text = "Victory";
            }
            else
            {
                resultTextBox.Text = "Defeat";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void rockButton_Click(object sender, EventArgs e)
        {

        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {

        }

        private void paperButton_Click(object sender, EventArgs e)
        {

        }
    }
}
