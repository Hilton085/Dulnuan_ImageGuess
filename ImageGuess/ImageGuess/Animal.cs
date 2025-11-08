using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tanging ang Panginoon lamang ang may alam kung paano ko nagawa ang code na ito
// Dulnuan, Mark Hilton A.

namespace ImageGuess_Dulnuan
{
    public partial class Animal : Form
    {
        public int minutes;
        public int seconds = 0;
        public int totalPoints_E = 100;
        public float baseScore_E;


        private int timeTaken = 0;

        private string[] answers = {"bear", "beaver", "capybara", "dog", "elephant", "giraffe", "horse", "lion", "monkey", "rabbit"};
        private int currentAnswerIndex = 0;

        private static List<int> a_scores = new List<int>();
        private Panel[] animalPanels = new Panel[10];
        private int currentPanelIndex = 0;

        public int totalScore;

        private MainMenu mainMenuInstance;

        public Animal(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenuInstance = mainMenu;

            for (int i = 0; i < animalPanels.Length; i++)
            {
                Panel panel = Controls.Find("animal" + (i + 1), true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    animalPanels[i] = panel;
                }
            }
        }

        private void Animal_Load(object sender, EventArgs e)
        {
            game_Time.Start();
            time_Taken.Start();


            animalPanels[0].Visible = true;
            finalPanel.Visible = false;

            for (int i = 1; i < animalPanels.Length; i++)
            {
                animalPanels[i].Visible = false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (currentAnswerIndex < answers.Length && currentAnswerIndex < answers.Length)
            {
                string userInput = a_answer.Text.ToLower();
                if (userInput == answers[currentAnswerIndex])
                {
                    a_answer.Text = "";
                    int score = CalculateScore(totalPoints_E, timeTaken, baseScore_E);
                    a_scores.Add(score);
                    ResetTimer();

                    animalPanels[currentPanelIndex].Visible = false;

                    currentAnswerIndex++;
                    currentPanelIndex++;

                    if (currentPanelIndex < animalPanels.Length && currentAnswerIndex < answers.Length)
                    {
                        animalPanels[currentPanelIndex].Visible = true;
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
                    a_answer.Text = "Try Again!";
                }
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
                mainMenuInstance.Show();
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
        private void UpdateTimerDisplay()
        {
            timeLimit.Text = $"{minutes}:{seconds.ToString("00")}";
        }

        private void Time_Taken_Tick(object sender, EventArgs e)
        {
            timeTaken += 1;
        }

        private void ResetTimer()
        {
            timeTaken = 0;
            time_Taken.Start();
        }

        private int CalculateScore(int totalPoints, int timeTaken, float baseScore)
        {
            int score = (int)((totalPoints/timeTaken) * baseScore);
            return score;
        }

        private void Total_Score()
        {
            int length = a_scores.Count;
            int overallScore = 0;
            for (int i = 0; i < length; i++)
            {
                overallScore = totalScore += a_scores[i];
            }
            this.totalScore = overallScore;
            mainMenuInstance.AnimalTotalScore = overallScore;
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
                    mainMenuInstance.animalCounter = 1;
                    if (number == 1)
                    {
                        Fruit fruit = new Fruit(mainMenuInstance);
                        fruit.minutes = 3;
                        fruit.baseScore_F = 2.0f;
                        mainMenuInstance.fruitCounter = 1;
                        fruit.Show();
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
    }

    
}
