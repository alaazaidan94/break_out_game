using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Game
{
    public partial class Form1 : Form
    {

        bool goLeft;
        bool goRight;
        bool isGameOver;
        bool isGameWin;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random rnd = new Random();

        PictureBox[] blockArray;

        public Form1()
        {
            InitializeComponent();
            PlaceBlocks();
        }

        private void setupGame()
        {
            isGameOver = false;
            isGameWin = false;
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 15;
            txtScore.Text = "Score: " + score;

            ball.Left = 376;
            ball.Top = 328;

            player.Left = 347;


            gameTImer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    Image[] imgs =
                    {
                         Properties.Resources._1,
                         Properties.Resources._2,
                         Properties.Resources._3,
                         Properties.Resources._4,
                         Properties.Resources._5
                     };
                   
                    x.BackgroundImage = imgs[rnd.Next(4)];
                    
                }
            }
        }


        private void gameOver(string message)
        {
            isGameOver = true;
            gameTImer.Stop();

            txtScore.Text = "Score: " + score + " " + message;
            scorelable.ForeColor= Color.Red;
            scorelable.Text = "You Lose!! \nPress Try again\nOr\nExit";
            groupMessage.Visible = true;
            groupMessage.Enabled= true;
            nextbtn.Visible = false;
            startbtn.Visible = false;
            tryAginbtn.Visible = true;
        }
        private void gameWin(string message)
        {
            isGameWin = true;
            gameTImer.Stop();

            if (score == 20)
            {
                txtScore.Text = "Score: " + score + " " + message;
                scorelable.ForeColor = Color.Green;
                scorelable.Text = "You Win!! \nYou Complate All Level\nPress Start To \nrestart from the beginning";
                groupMessage.Visible = true;
                groupMessage.Enabled = true;
                startbtn.Visible = true;
                nextbtn.Visible = false;
                tryAginbtn.Visible = false;
            }
            else
            {
                txtScore.Text = "Score: " + score + " " + message;
                scorelable.ForeColor = Color.Blue;
                scorelable.Text = "You Win!! \nPress Next Level";
                groupMessage.Visible = true;
                groupMessage.Enabled = true;
                nextbtn.Visible = true;
                startbtn.Visible = false;
                tryAginbtn.Visible = false;
            }



        }
        int xxx = 5;
        int toppp;
        private void PlaceBlocks()
        
        {
            blockArray = new PictureBox[xxx];

            int a = 0;

            int top = 50;
            int left = 100;

            for(int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 50;
                blockArray[i].Width = 50;
                blockArray[i].Tag = "blocks";



                if (a == 5)
                {
                    top = top + 80;
                    left = 100;
                    a = 0;
                }

                if(a < 5)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left = left + 130;
                   
                   
                }

            }
            setupGame();
        }

        private void removeBlocks()
        {
            foreach(PictureBox x in blockArray)
            {
                this.Controls.Remove(x);
            }
        }



        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Left < 700)
            {
                player.Left += playerSpeed;
            }

            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 775)
            {
                ballx = -ballx;
            }
            if (ball.Top < 0)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {

                ball.Top = 463;

                bally = rnd.Next(5, 12) * -1;

                if (ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1;
                }
                else
                {
                    ballx = rnd.Next(5, 12);
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if(ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                        bally = -bally;

                        this.Controls.Remove(x);
                    }
                }

            }


            if(score == xxx)
            {
                gameWin("");
            }

            if(ball.Top > 580)
            {
                gameOver("");
            }



        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeBlocks();
                PlaceBlocks();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupMessage_Enter(object sender, EventArgs e)
        {

        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }
        int level = 1;
        private void nextbtn_Click(object sender, EventArgs e)
        {
            level++;
            level_lbl_num.Text = level.ToString();
            groupMessage.Visible = false;
            groupMessage.Enabled = false;
            xxx += 5;
            toppp = 30;
            PlaceBlocks();
            
            
            
        }

        private void tryAginbtn_Click(object sender, EventArgs e)
        {
            
            scorelable.Text = xxx.ToString();
            groupMessage.Visible = false;
            groupMessage.Enabled= false;
            removeBlocks();
            PlaceBlocks();
        }

        private void exitebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            xxx = 5;
            score = 0;
            level_lbl_num.Text = "1";
            groupMessage.Visible = false;
            groupMessage.Enabled= false;
            PlaceBlocks();
        }
    }
}
