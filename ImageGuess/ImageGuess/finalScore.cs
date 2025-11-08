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
    public partial class finalScore : Form
    {
        private MainMenu mainMenuInstance;
        public finalScore(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenuInstance = mainMenu;
        }

        private void finalScore_Load(object sender, EventArgs e)
        {
            animalLabel.Text = "Animal Score: " + mainMenuInstance.AnimalTotalScore;
            treeLabel.Text = "Tree Score: " + mainMenuInstance.TreeTotalScore;
            fruitLabel.Text = "Fruit Score: " + mainMenuInstance.FruitTotalScore;

            int total = mainMenuInstance.AnimalTotalScore + mainMenuInstance.TreeTotalScore + mainMenuInstance.FruitTotalScore;

            totalLabel.Text = "TOTAL: " + total;
        }
    }
}
