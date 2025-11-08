using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tanging ang Panginoon lamang ang may alam kung paano ko nagawa ang code na ito
// Dulnuan, Mark Hilton A.

namespace ImageGuess_Dulnuan
{
    public partial class MainMenu : Form
    {
        public int animalCounter { get; set; }
        public int fruitCounter { get; set; }
        public int treeCounter { get; set; }

        public int AnimalTotalScore { get; set; }
        public int FruitTotalScore { get; set; }
        public int TreeTotalScore { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            subPanel.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            subPanel.Visible = true;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnimalButton_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal(this);
            this.Hide();

            animal.minutes = 5;
            animal.baseScore_E = 1.5f;

            animalCounter = 1;

            animal.Show();
        }

        private void FruitButton_Click(object sender, EventArgs e)
        {
            Fruit fruit = new Fruit(this);
            this.Hide();

            fruit.minutes = 5;
            fruit.baseScore_F = 1.5f;

            fruitCounter = 1;

            fruit.Show();
        }

        private void TreeButton_Click(object sender, EventArgs e)
        {
            Tree tree = new Tree(this);
            this.Hide();

            tree.minutes = 5;
            tree.baseScore_T = 1.5f;

            treeCounter = 1;

            tree.Show();
        }
    }
}
