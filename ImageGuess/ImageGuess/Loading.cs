using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageGuess_Dulnuan
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Load_tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                progressNum.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer2.Start();
            }
        }

        private void Percent_tick(object sender, EventArgs e)
        {
            if (progressBar2.Value < 100)
            {
                progressBar2.Value += 5;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();

                MainMenu menu = new MainMenu();
                this.Hide();

                menu.Show();
            }
        }
    }
}
