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
    public partial class Fruit : Form
    {
        public int minutes;
        public int seconds = 0;
        public int totalPoints_F = 100;
        public float baseScore_F;


        private int timeTaken = 0;

        private string[] answers = { "apple", "banana", "grapes", "kiwi", "mango", "orange", "peach", "pineapple", "strawberry", "watermelon" };
        private int currentAnswerIndex = 0;

        private static List<int> f_scores = new List<int>();
        private Panel[] fruitPanels = new Panel[10];
        private int currentPanelIndex = 0;

        private int totalScore;

        private MainMenu mainMenuInstance;

        public Fruit(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenuInstance = mainMenu;

            for (int i = 0; i < fruitPanels.Length; i++)
            {
                Panel panel = Controls.Find("fruit" + (i + 1), true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    fruitPanels[i] = panel;
                }
            }
        }

        private void Fruit_Load(object sender, EventArgs e)
        {
            game_Time.Start();
            time_Taken.Start();


            fruitPanels[0].Visible = true;
            finalPanel.Visible = false;

            for (int i = 1; i < fruitPanels.Length; i++)
            {
                fruitPanels[i].Visible = false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (currentAnswerIndex < answers.Length && currentAnswerIndex < answers.Length)
            {
                string userInput = f_answer.Text.ToLower();
                if (userInput == answers[currentAnswerIndex])
                {
                    f_answer.Text = "";
                    int score = CalculateScore(totalPoints_F, timeTaken, baseScore_F);
                    f_scores.Add(score);
                    ResetTimer();

                    fruitPanels[currentPanelIndex].Visible = false;

                    currentAnswerIndex++;
                    currentPanelIndex++;

                    if (currentPanelIndex < fruitPanels.Length && currentAnswerIndex < answers.Length)
                    {
                        fruitPanels[currentPanelIndex].Visible = true;
                    }

                    else
                    {
                        game_Time.Stop();
                        timeLimit.Visible = false;
                        finalPanel.Visible = true;
                        Total_Score();
                    }
                }
                else
                {
                    f_answer.Text = "Try Again!";
                }
            }
        }

        private void UpdateTimerDisplay()
        {
            timeLimit.Text = $"{minutes}:{seconds.ToString("00")}";
        }


        private void ResetTimer()
        {
            timeTaken = 0;
            time_Taken.Start();
        }

        private int CalculateScore(int totalPoints, int timeTaken, float baseScore)
        {
            if (timeTaken == 0)
            {
                return 0; 
            }
            else
            {
                int score = (int)((totalPoints / timeTaken) * baseScore);
                return score;
            }
        }

        private void Total_Score()
        {
            int length = f_scores.Count;
            int overallScore = 0;
            for (int i = 0; i < length; i++)
            {
                overallScore = totalScore += f_scores[i];
            }
            mainMenuInstance.FruitTotalScore = overallScore;
            scoreLabel.Text = "Score: " + overallScore.ToString();

        }

        static int GenerateRandomNumber()
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 3);

            return randomNumber;
        }

        private void nextLevel_Click(object sender, EventArgs e)
        {
            this.Hide();

            int number = GenerateRandomNumber();

            if (mainMenuInstance.fruitCounter == 1 && mainMenuInstance.treeCounter == 1 && mainMenuInstance.animalCounter == 1)
            {
                finalScore score = new finalScore(mainMenuInstance);
                score.Show();
            }
            else
            {
                if (mainMenuInstance.animalCounter == 1 && mainMenuInstance.fruitCounter == 1)
                {
                    Tree tree = new Tree(mainMenuInstance);
                    tree.minutes = 1;
                    tree.baseScore_T = 2.5f;
                    mainMenuInstance.treeCounter = 1;
                    tree.Show();
                }
                else if (   mainMenuInstance.fruitCounter == 1 && mainMenuInstance.treeCounter == 1)
                {
                    Animal animal = new Animal(mainMenuInstance);
                    animal.minutes = 1;
                    animal.baseScore_E = 2.5f;
                    mainMenuInstance.animalCounter = 1;
                    animal.Show();
                }
                else
                {
                    mainMenuInstance.fruitCounter = 1;
                    if (number == 1)
                    {
                        Animal animal = new Animal(mainMenuInstance);
                        animal.minutes = 3;
                        animal.baseScore_E = 2.0f;
                        mainMenuInstance.animalCounter = 1;
                        animal.Show();
                    }
                    else if (number == 2)
                    {
                        Tree tree = new Tree(mainMenuInstance);
                        tree.minutes = 3;
                        tree.baseScore_T = 2.0f;
                        mainMenuInstance.treeCounter = 1;
                        tree.Show();
                    }
                }
            }
        }

        private void game_Time_Tick_1(object sender, EventArgs e)
        {
            if (minutes == 0 && seconds == 0)
            {
                game_Time.Stop();
                MessageBox.Show("You have reached the time limit!");
                Close();

                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else
            {
                if (seconds == 0)
                {
                    minutes--;
                    seconds = 59;
                }
                else
                {
                    seconds--;
                }
                UpdateTimerDisplay();
            }
        }

        private void time_Taken_Tick_1(object sender, EventArgs e)
        {
            timeTaken += 1;
        }
    }
}
