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
    public partial class allTimeHighScores : Form
    {

        List<Player> players = new List<Player>();

        public allTimeHighScores(List<Player> players)
        {
            InitializeComponent();

            populateScreen();
            this.players = players;
        }

        private void populateScreen()
        {
            string[] data = ReadScoresFromFile();

            Application.DoEvents();

            List<Player> Historicplayers = new List<Player>();

            //int cnt = data.Length;
            //int key;

            //for (int i = 0; i < cnt; i++)
            //{
            //    string[] values = data[i].Split('=');

            //    int.TryParse(values[1], out key);

            //    int j = i - 1;

            //    int previous;
            //    if (j >= 1)
            //    {
            //        int.TryParse(data[j].Split('=')[1], out previous);
            //    }
            //    else
            //    {
            //        previous = 0;
            //    }

            //    while (j >= 0 && previous > key)
            //    {
            //        data[j] = data[j + 1];
            //        j = j - 1;
            //    }
            //}

            foreach (string i in data)
            {
                Console.WriteLine(i);
                string[] values = i.Split('=');

                Player player = new Player();
                player.pName = values[0];
                player.score = values[1];

                Historicplayers.Add(player);
            }

            var arrayLength = Historicplayers.Count();
            for (int i = 0; i < arrayLength; i++)
            {
                var SmallestVal = 1;

            }

        }

        private string[] ReadScoresFromFile()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "allTimeHighScores.txt";
            string[] data = File.ReadAllLines(filePath);

            return data;
        }
    }
}
