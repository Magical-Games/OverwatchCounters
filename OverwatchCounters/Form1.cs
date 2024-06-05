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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
