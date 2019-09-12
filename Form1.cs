using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssaignmentCSharp
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int comChoice;
        int chr;
        static int round = 0;
        static int PlayarWin= 0;
        static int ComputerWin = 0;
        static int t = 0;
        int duration = 15;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrock_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PlayarPB.Image= Resource1.rock;
            int iRandomNum = random.Next(1, 4);

           
            comChoice = iRandomNum;
            chr = iRandomNum;

            switch (iRandomNum)
            {
                case 1:

                   ComputerPB.Image = Resource1.rock;
                   txtWinner.Text = "Tie";
                   t++;
                   TxtTie.Text = t.ToString();
                   
                    break;

                case 2:

                    ComputerPB.Image = Resource1.paper;
                   txtWinner.Text = " Computer wins";
                   ComputerWin++;
                 txtCpmputer.Text = ComputerWin.ToString();
                    break;

                case 3:

                    ComputerPB.Image = Resource1.scissors;
                    txtWinner.Text = "Playar wins";
                    PlayarWin++;
                    txtPlayar.Text = PlayarWin.ToString();
                    break;
            }

            round++;
            TxtCount.Text = Convert.ToString(round);
          
            if (round % 5 == 0)
            {
                this.duration = 15;
                timer1.Stop();
              // duration = 0;
                if (PlayarWin > ComputerWin)
                {
                    DialogResult r = MessageBox.Show("Player Win !!", "Congratulation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }
                }
                if (PlayarWin < ComputerWin)
                {
                    DialogResult r = MessageBox.Show("Computer Win !!", "Congratulation ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }

                }
                else if (t > PlayarWin && t > ComputerWin)
                {
                    DialogResult r = MessageBox.Show("Nobody Wins !!", "Congratulation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }
                }

            }
            else {
                this.Show(); 
            } 

        }

        private void btnpaper_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PlayarPB.Image = Resource1.paper;
            int iRandomNum = random.Next(1,4);


            comChoice = iRandomNum;
            chr = iRandomNum;

            switch (comChoice)
            {
                case 1:

                    ComputerPB.Image = Resource1.rock;
                    txtWinner.Text = "Playar wins";
                    PlayarWin++;
                    txtPlayar.Text = PlayarWin.ToString();

                    break;

                case 2:

                    ComputerPB.Image = Resource1.paper;
                    txtWinner.Text = "Tie";
                    t++;
                    TxtTie.Text = t.ToString();
                    break;

                case 3:

                    ComputerPB.Image = Resource1.scissors;
                    txtWinner.Text = "Computer Wins";
                    ComputerWin++;
                        txtCpmputer.Text = ComputerWin.ToString();
                    break;
            }
            round++;
            TxtCount.Text = Convert.ToString(round);
            if (round % 5 == 0)
            {
                this.duration = 15;
                timer1.Stop();
              //  duration = 0;
                if (PlayarWin > ComputerWin)
                {
                    DialogResult r = MessageBox.Show("Player Win !!", "congratulation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }
                }
                if (PlayarWin < ComputerWin)
                {
                    DialogResult r = MessageBox.Show("Computer Win !!", "Congratulation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }
                }
                else if (t > ComputerWin && t > PlayarWin)
                {
                    DialogResult r = MessageBox.Show("Nobody Wins !!", "Congratulation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }
                }
            }
            else
            {
                this.Show();
            }
        }

        private void btnscissor_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PlayarPB.Image = Resource1.scissors;
            int iRandomNum = random.Next(1, 4);


           comChoice = iRandomNum;
           chr = iRandomNum;

            switch (iRandomNum)
            {
                case 1:

                    ComputerPB.Image = Resource1.rock;
                    txtWinner.Text = "Computer wins";
                    ComputerWin++;
                    txtCpmputer.Text = ComputerWin.ToString();

                    break;

                case 2:

                    ComputerPB.Image = Resource1.paper;
                    txtWinner.Text = "Playar wins ";
                    PlayarWin++;
                    txtPlayar.Text = PlayarWin.ToString();
                    break;

                case 3:
                    ComputerPB.Image = Resource1.scissors;
                    txtWinner.Text = "Tie";
                    t++;
                    TxtTie.Text = t.ToString();
                    break;
            }
            round++;
            TxtCount.Text = Convert.ToString(round);
           
            if (round % 5 == 0)
            {
                this.duration = 15;
                timer1.Stop();
               // duration = 0;
                if (PlayarWin > ComputerWin)
                {
                    DialogResult r = MessageBox.Show("Player Wins !!", "Congratulation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }

                }
                if (PlayarWin < ComputerWin)
                {
                    DialogResult r = MessageBox.Show("Computer Wins !!", "Congratulation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }
                }

                else if (t > PlayarWin && t > ComputerWin)
                {
                    DialogResult r = MessageBox.Show("Nobody Wins: Tied !!", "Congratulation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.Retry)
                    {
                        reset();
                    }
                    else if (r == DialogResult.Cancel) { Application.Exit(); }
                }
            }
            else
            {
                this.Show(); 
            }
        }

        private void tbroud_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }
        public void reset()
        {
            PlayarWin = 0;
            ComputerWin = 0;
            t = 0;
            round = 0;
            duration = 15;
            PlayarPB.Image = null;
            ComputerPB.Image = null;
            txtCpmputer.Text = Convert.ToString(0);
            txtPlayar.Text = Convert.ToString(0);
            txtWinner.Text = Convert.ToString(0);
            TxtCount.Text = Convert.ToString(0);
            TxtTie.Text = Convert.ToString(0);
            txtTImer.Text = Convert.ToString(0);
        }

        private void PlayarPB_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////MessageBox.Show("Times up");
            //duration--;
            //if (duration == 0)
            //{
            //    timer1.Stop();
            //    // MessageBox.Show("TimeS up");
            //    txtTImer.Text = duration.ToString();
            //}


            txtTImer.Text = Convert.ToString(duration);
            duration--;
            if (duration == -1)
            {
                reset();
                timer1.Stop();
                DialogResult r = MessageBox.Show("Times Up ", "Play again?" +
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    reset();
                    timer1.Start();
                    
                }
                else if (r == DialogResult.No)
                {
                    Application.Exit();
                }
         
            } 


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
