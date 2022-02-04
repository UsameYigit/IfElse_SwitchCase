using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse_SwitchCase
{
    public partial class IfElse : Form
    {
        public IfElse()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int score = 0, highScore = 0, life = 5;

        private void IfElse_Load(object sender, EventArgs e)
        {
            StartSettings();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (lblRandomNumber.Text == txtAnswer.Text)
            {
                lblRandomNumber.Text = ScoreDependentDifficulty().ToString();
                if (++score > highScore)
                {
                    highScore = score;
                    lblHighScore.Text = "Yüksek Skor: " + highScore;
                }
                    
                lblScore.Text = "Skor: " + score;
            }
            else
            {
                life--;
                lblLife.Text = "Hakkın: " + life;
                if (life > 0)
                {
                    lblRandomNumber.Text = ScoreDependentDifficulty().ToString();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Yeniden denemek ister misin?", "Yenildin!", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        life = 5;
                        score = 0;
                        StartSettings();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                
            }

        }

        void StartSettings()
        {
            lblRandomNumber.Text = ScoreDependentDifficulty().ToString();
            lblLife.Text = "Hakkın: " + life;
            lblHighScore.Text = "Yüksek Skor: " + highScore;
            lblScore.Text = "Skor: " + score;
        }

        int ScoreDependentDifficulty()
        {
            if(score > 15)
            {
                return rndNumber  = rnd.Next(100000000, 1000000000);
            }
            else if(score > 10)
            {
                return rndNumber = rnd.Next(10000000, 100000000);
            }
            else if (score > 5)
            {
                return rndNumber = rnd.Next(1000000, 10000000);
            }
            else
            {
                return rndNumber = rnd.Next(100000, 1000000);
            }
        }
    }
}
