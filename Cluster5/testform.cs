using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cluster5
{
    public partial class testform : Form
    {

        List<Player> scores = new List<Player>();

        public testform(List<Player> TempScore)
        {
            InitializeComponent();

            scores = TempScore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionGenerator questionGenerator = new QuestionGenerator();
            double answer;
            string question;

            questionGenerator.question(out question, out answer);

            label1.Text = question;
            label2.Text = answer.ToString();

        }
    }
}
