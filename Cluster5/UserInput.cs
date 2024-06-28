using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cluster5
{
    public partial class UserInput : Form
    {

        List<Player> scores = new List<Player>();
        int score;

        public UserInput(List<Player> TempScore, int Score)
        {
            InitializeComponent();

            scores = TempScore;
            score = Score;
            finalLabel.Text = "You complete the quiz. \r\nYour final score was " + score.ToString() + " / 10";
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(userName.Text, @"^[a-zA-Z]+$")) {
                Player player = new Player();
                player.pName = userName.Text;
                player.score = score.ToString();

                writeToFile();

                scores.Add(player);

                Menu screen = new Menu(scores);
                screen.Show();
                this.Hide();
            }
        }

        private void writeToFile()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "allTimeHighScores.txt";
            File.AppendAllText(filePath, Environment.NewLine + userName.Text + " = " + score);
        }

    }
}
