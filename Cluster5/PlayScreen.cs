using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cluster5
{
    public partial class PlayScreen : Form
    {
        List<Player> scores = new List<Player>();

        QuestionGenerator questionGenerator = new QuestionGenerator();
        double answer;
        string question;
        int score = 0;
        int currentQuestion = 0;

        public PlayScreen(List<Player> TempScore)
        {
            InitializeComponent();

            scores = TempScore;
        }

        public void updateQuestion()
        {
            currentQuestion++;

            questionGenerator.question(out question, out answer);

            questionLabel.Text = question;

        }

        private void PlayScreen_Load(object sender, EventArgs e)
        {
            updateQuestion();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(answerInput.Text, out number)) {
                if (number == answer)
                {
                    score++;
                }

                answerInput.Text = "";
                updateQuestion();
                userScore.Text = "Current Score: " + score.ToString();
            }

            if (currentQuestion == 10)
            {
                UserInput screen = new UserInput(scores, score);
                screen.Show();
                this.Hide();
            }

        }
    }
}
