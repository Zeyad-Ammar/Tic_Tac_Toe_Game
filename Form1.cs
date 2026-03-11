using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {

        private bool Player1Turn = true;
        private byte RoundsPlayed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gbGame_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen pen = new Pen(color);
            pen.Width = 10;


            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, 200, 15, 200, 350);
            e.Graphics.DrawLine(pen, 400, 15, 400, 350);


            e.Graphics.DrawLine(pen, 15, 120, 580, 120);
            e.Graphics.DrawLine(pen, 15, 240, 580, 240);
        }

        private string PlayerName()
        {
            if (Player1Turn)
            {
                return "Player 1";
            }
            else
            {
                return "Player 2";
            }

        }
        private bool CheckEndGame()
        {



            if (pbLeftUp.Tag.ToString() != "?" && pbLeftUp.Tag.ToString() == pbMiddleUp.Tag.ToString() && pbMiddleUp.Tag.ToString() == pbRightUp.Tag.ToString())
            {
                pbLeftUp.BackColor = Color.Green;
                pbMiddleUp.BackColor = Color.Green;
                pbRightUp.BackColor = Color.Green;

                return true;
            }
            else if (pbLeftMiddle.Tag.ToString() != "?" && pbLeftMiddle.Tag.ToString() == pbMiddleMiddle.Tag.ToString() && pbMiddleMiddle.Tag.ToString() == pbRightMiddle.Tag.ToString())
            {

                pbLeftMiddle.BackColor = Color.Green;
                pbMiddleMiddle.BackColor = Color.Green;
                pbRightMiddle.BackColor = Color.Green;
                return true;
            }
            else if (pbLeftDown.Tag.ToString() != "?" && pbLeftDown.Tag.ToString() == pbMiddleDown.Tag.ToString() && pbMiddleDown.Tag.ToString() == pbRightDown.Tag.ToString())
            {

                pbLeftDown.BackColor = Color.Green;
                pbMiddleDown.BackColor = Color.Green;
                pbRightDown.BackColor = Color.Green;
                return true;
            }
            else if (pbLeftUp.Tag.ToString() != "?" && pbLeftUp.Tag.ToString() == pbLeftMiddle.Tag.ToString() && pbLeftMiddle.Tag.ToString() == pbLeftDown.Tag.ToString())
            {
                pbLeftUp.BackColor = Color.Green;
                pbLeftMiddle.BackColor = Color.Green;
                pbLeftDown.BackColor = Color.Green;
                return true;
            }
            else if (pbMiddleUp.Tag.ToString() != "?" && pbMiddleUp.Tag.ToString() == pbMiddleMiddle.Tag.ToString() && pbMiddleMiddle.Tag.ToString() == pbMiddleDown.Tag.ToString())
            {
                pbMiddleUp.BackColor = Color.Green;
                pbMiddleMiddle.BackColor = Color.Green;
                pbMiddleDown.BackColor = Color.Green;
                return true;
            }
            else if (pbRightUp.Tag.ToString() != "?" && pbRightUp.Tag.ToString() == pbRightMiddle.Tag.ToString() && pbRightMiddle.Tag.ToString() == pbRightDown.Tag.ToString())
            {
                pbRightUp.BackColor = Color.Green;
                pbRightMiddle.BackColor = Color.Green;
                pbRightDown.BackColor = Color.Green;
                return true;
            }
            else if (pbLeftUp.Tag.ToString() != "?" && pbLeftUp.Tag.ToString() == pbMiddleMiddle.Tag.ToString() && pbMiddleMiddle.Tag.ToString() == pbRightDown.Tag.ToString())
            {

                pbLeftUp.BackColor = Color.Green;
                pbMiddleMiddle.BackColor = Color.Green;
                pbRightDown.BackColor = Color.Green;
                return true;

            }
            else if (pbRightUp.Tag.ToString() != "?" && pbRightUp.Tag.ToString() == pbMiddleMiddle.Tag.ToString() && pbMiddleMiddle.Tag.ToString() == pbLeftDown.Tag.ToString())
            {
                pbRightUp.BackColor = Color.Green;
                pbMiddleMiddle.BackColor = Color.Green;
                pbLeftDown.BackColor = Color.Green;
                return true;
            }





            return false;

        }

        private void stopGame()
        {

            gbGame.Enabled = false;
        }
       
  
        private void RestartPictureBox(PictureBox pictureBox)
        {
            pictureBox.Image = Resources.q;
            pictureBox.Tag = "?";
            pictureBox.BackColor = Color.Black;
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {

            RestartPictureBox(pbLeftUp);
            RestartPictureBox(pbLeftMiddle);
            RestartPictureBox(pbLeftDown);
            RestartPictureBox(pbMiddleUp);
            RestartPictureBox(pbMiddleMiddle);
            RestartPictureBox(pbMiddleDown);
            RestartPictureBox(pbRightUp);
            RestartPictureBox(pbRightMiddle);
            RestartPictureBox(pbRightDown);

            lbTurnValue.Text = "Player 1";
            lbWinnerValue.Text = "In Progress";
            Player1Turn = true;
            gbGame.Enabled = true;
            RoundsPlayed = 0;

        }

        private void btnRestartGame_MouseDown(object sender, MouseEventArgs e)
        {
            btnRestartGame.BackColor = Color.Blue;
        }

        private void btnRestartGame_MouseUp(object sender, MouseEventArgs e)
        {
            btnRestartGame.BackColor = Color.Black;

        }

        private void PlayTurn(object sender, EventArgs e)
        {

            if (((PictureBox)sender).Tag.ToString() != "?")
            {
                MessageBox.Show("Wrong Choice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (Player1Turn)
            {

                ((PictureBox)sender).Image = Resources.xpng;
                ((PictureBox)sender).Tag = Player1Turn;

            }
            else
            {
                ((PictureBox)sender).Tag = Player1Turn;
                ((PictureBox)sender).Image = Resources.o;
            }

            RoundsPlayed++;

            if (CheckEndGame())
            {
                lbWinnerValue.Text = PlayerName();
                lbTurnValue.Text = "Game Over";
                stopGame();
                MessageBox.Show("Game Over", "End The Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (RoundsPlayed == 9)
            {
                lbWinnerValue.Text = "Draw";
                lbTurnValue.Text = "Game Over";

                stopGame();
                MessageBox.Show("Game Over", "End The Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            Player1Turn = !Player1Turn;
            lbTurnValue.Text = PlayerName();
        }
    }
}
