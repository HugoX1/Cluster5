namespace Cluster5
{
    public partial class Menu : Form
    {
        List<Player> scores = new List<Player>();

        public Menu(List<Player> TempScore)
        {
            InitializeComponent();
            scores = TempScore;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            PlayScreen screen = new PlayScreen(scores);
            screen.Show();
            this.Hide();
        }

        private void alltimeButton_Click(object sender, EventArgs e)
        {
            allTimeHighScores screen = new allTimeHighScores(scores);
            screen.Show();
            this.Hide();
        }

        private void todayScoreButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?",
                "Exit Game", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (res == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
