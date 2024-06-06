using System.Security.Cryptography.X509Certificates;

namespace OverwatchCounters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] DVA = { "Zarya", "Doomfist", "Junker Queen", "Roadhog", "Sigma", "Reinhardt", "Mei", "Reaper", "Sombra", "Symmetra", "Moira", "Brigitte" };
            string[] Doomfist = { "Roadhog", "Orisa", "Sigma", "Bastion", "Symettra", "Sombra", "Mei", "Cassidy", "Junkrat", "Anna", "Moira", "Zenyatta" };
            string[] JunkerQueen = { };
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] DVA = { "Zarya", "Doomfist", "Junker Queen", "Roadhog", "Sigma", "Reinhardt", "Mei", "Reaper", "Sombra", "Symmetra", "Moira", "Brigitte" };
            string[] Doomfist = { "Roadhog", "Orisa", "Sigma", "Bastion", "Symettra", "Sombra", "Mei", "Cassidy", "Junkrat", "Anna", "Moira", "Zenyatta" };
            string[] JunkerQueen = { "Mei", "Kiriko", "Ana", "Widowmaker", "Hanzo", "Ashe" };
            string[] Mauga = { "Reaper", "DVA", "Ana", "Zenyatta", "Soldier: 76", "Sigma", "Sombra" };
            string[] Orisa = { "Reaper", "Soldier: 76", "Zenyatta", "DVA", "Winston", "Zarya", "Sombra", "Symmetra", "Mei", "Zenyatta" };
            string[] Ramattra = { "Sigma", "Orisa", "DVA", "Roadhog", "Sojourn", "Soldier: 76", "Reaper", "Bastion", "Tracer", "Junkrat", "Ana", "Baptiste", "Zenyatta", "Moira" };
            string[] Reinhardt = { "Ramattra", "Orisa", "DVA", "Mauga", "Winston", "Bastion", "Sombra", "Soldier: 76", "Sojourn", "Tracer", "Symmetra", "Reaper", "Cassidy", "Junkrat", "Mei", "Brigitte", "Ana" };
            string[] Roadhog = {"Zenyatta", "Ana", "Sombra", "Soldier: 76", "Sojourn" };
            label3.Text = comboBox1.Text;
            if (comboBox1.Text == "DVA")
            {
                foreach (string i in DVA)
                {
                    listView1.Items.Add(i);
                }
                await Task.Delay(TimeSpan.FromSeconds(10));
                listView1.Items.Clear();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
