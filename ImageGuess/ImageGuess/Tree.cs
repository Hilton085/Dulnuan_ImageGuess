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
    public partial class Tree : Form
    {
        public int minutes;
        public int seconds = 0;
        public int totalPoints_T = 100;
        public float baseScore_T;


        private int timeTaken = 0;

        private string[] answers = { "birch", "cedar", "elm", "maple", "oak", "palm", "pine", "redwood", "sakura", "willow" };
        private int currentAnswerIndex = 0;

        private static List<int> t_scores = new List<int>();
        private Panel[] treePanels = new Panel[10];
        private int currentPanelIndex = 0;

        private int totalScore;

        private MainMenu mainMenuInstance;
        public Tree(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenuInstance = mainMenu;

            for (int i = 0; i < treePanels.Length; i++)
            {
                Panel panel = Controls.Find("tree" + (i + 1), true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    treePanels[i] = panel;
                }
            }

        }

        private void Tree_Load(object sender, EventArgs e)
        {
            game_Time.Start();
            time_Taken.Start();

            treePanels[0].Visible = true;
            finalPanel.Visible = false;

            for (int i = 1; i < treePanels.Length; i++)
            {
                treePanels[i].Visible = false;
            }
        }

        private void game_Time_Tick(object sender, EventArgs e)
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

        private void time_Taken_Tick(object sender, EventArgs e)
        {
            timeTaken += 1;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (currentAnswerIndex < answers.Length && currentAnswerIndex < answers.Length)
            {
                string userInput = t_answer.Text.ToLower();
                if (userInput == answers[currentAnswerIndex])
                {
                    t_answer.Text = "";
                    int score = CalculateScore(totalPoints_T, timeTaken, baseScore_T);
                    t_scores.Add(score);
                    ResetTimer();

                    treePanels[currentPanelIndex].Visible = false;

                    currentAnswerIndex++;
                    currentPanelIndex++;

                    if (currentPanelIndex < treePanels.Length && currentAnswerIndex < answers.Length)
                    {
                        treePanels[currentPanelIndex].Visible = true;
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
                    t_answer.Text = "Try Again!";
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
            int score = (int)((totalPoints / timeTaken) * baseScore);
            return score;
        }

        private void Total_Score()
        {
            int length = t_scores.Count;
            int overallScore = 0;
            for (int i = 0; i < length; i++)
            {
                overallScore = totalScore += t_scores[i];
            }
            mainMenuInstance.TreeTotalScore = overallScore;
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
                if (mainMenuInstance.treeCounter == 1 && mainMenuInstance.fruitCounter == 1)
                {
                    Animal animal = new Animal(mainMenuInstance);
                    animal.minutes = 1;
                    animal.baseScore_E = 2.5f;
                    mainMenuInstance.animalCounter = 1;
                    animal.Show();
                }
                else if (mainMenuInstance.animalCounter == 1 && mainMenuInstance.treeCounter == 1)
                {
                    Fruit fruit = new Fruit(mainMenuInstance);
                    fruit.minutes = 1;
                    fruit.baseScore_F = 2.5f;
                    mainMenuInstance.fruitCounter = 1;
                    fruit.Show();
                }
                else
                {
                        mainMenuInstance.treeCounter = 1;
                    if (number == 1)
                    {
                        Fruit fruit = new Fruit(mainMenuInstance);
                        fruit.minutes = 3;
                        fruit.baseScore_F = 2.0f;
                        mainMenuInstance.fruitCounter = 1;
                        fruit.Show();
                    }
                    else
                    {
                        Animal animal = new Animal(mainMenuInstance);
                        animal.minutes = 3;
                        animal.baseScore_E = 2.0f;
                        mainMenuInstance.animalCounter = 1;
                        animal.Show();
                    }
                }
            }
        }
    }
}
