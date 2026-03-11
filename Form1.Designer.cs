namespace Tic_Tac_Toe_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbGameName = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbTurnValue = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.lbWinnerValue = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.pbRightDown = new System.Windows.Forms.PictureBox();
            this.pbMiddleDown = new System.Windows.Forms.PictureBox();
            this.pbLeftDown = new System.Windows.Forms.PictureBox();
            this.pbRightMiddle = new System.Windows.Forms.PictureBox();
            this.pbMiddleMiddle = new System.Windows.Forms.PictureBox();
            this.pbLeftMiddle = new System.Windows.Forms.PictureBox();
            this.pbRightUp = new System.Windows.Forms.PictureBox();
            this.pbMiddleUp = new System.Windows.Forms.PictureBox();
            this.pbLeftUp = new System.Windows.Forms.PictureBox();
            this.gbInformation.SuspendLayout();
            this.gbGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddleDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddleMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddleUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbGameName.Location = new System.Drawing.Point(479, 5);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(593, 74);
            this.lbGameName.TabIndex = 0;
            this.lbGameName.Text = "Tic_Tac_Toe Game";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lbTurn.Location = new System.Drawing.Point(6, 18);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(257, 98);
            this.lbTurn.TabIndex = 1;
            this.lbTurn.Text = "Turn";
            // 
            // lbTurnValue
            // 
            this.lbTurnValue.AutoSize = true;
            this.lbTurnValue.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurnValue.ForeColor = System.Drawing.Color.Honeydew;
            this.lbTurnValue.Location = new System.Drawing.Point(15, 134);
            this.lbTurnValue.Name = "lbTurnValue";
            this.lbTurnValue.Size = new System.Drawing.Size(238, 59);
            this.lbTurnValue.TabIndex = 2;
            this.lbTurnValue.Text = "Player 1";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Showcard Gothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lbWinner.Location = new System.Drawing.Point(2, 211);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(265, 74);
            this.lbWinner.TabIndex = 3;
            this.lbWinner.Text = "Winner";
            // 
            // lbWinnerValue
            // 
            this.lbWinnerValue.AutoSize = true;
            this.lbWinnerValue.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinnerValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbWinnerValue.Location = new System.Drawing.Point(13, 303);
            this.lbWinnerValue.Name = "lbWinnerValue";
            this.lbWinnerValue.Size = new System.Drawing.Size(235, 42);
            this.lbWinnerValue.TabIndex = 4;
            this.lbWinnerValue.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestartGame.Location = new System.Drawing.Point(58, 364);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(153, 53);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            this.btnRestartGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRestartGame_MouseDown);
            this.btnRestartGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRestartGame_MouseUp);
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.btnRestartGame);
            this.gbInformation.Controls.Add(this.lbWinnerValue);
            this.gbInformation.Controls.Add(this.lbWinner);
            this.gbInformation.Controls.Add(this.lbTurnValue);
            this.gbInformation.Controls.Add(this.lbTurn);
            this.gbInformation.Location = new System.Drawing.Point(12, 94);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(337, 454);
            this.gbInformation.TabIndex = 6;
            this.gbInformation.TabStop = false;
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.pbRightDown);
            this.gbGame.Controls.Add(this.pbMiddleDown);
            this.gbGame.Controls.Add(this.pbLeftDown);
            this.gbGame.Controls.Add(this.pbRightMiddle);
            this.gbGame.Controls.Add(this.pbMiddleMiddle);
            this.gbGame.Controls.Add(this.pbLeftMiddle);
            this.gbGame.Controls.Add(this.pbRightUp);
            this.gbGame.Controls.Add(this.pbMiddleUp);
            this.gbGame.Controls.Add(this.pbLeftUp);
            this.gbGame.Location = new System.Drawing.Point(374, 94);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(802, 454);
            this.gbGame.TabIndex = 7;
            this.gbGame.TabStop = false;
            this.gbGame.Paint += new System.Windows.Forms.PaintEventHandler(this.gbGame_Paint);
            // 
            // pbRightDown
            // 
            this.pbRightDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRightDown.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbRightDown.Location = new System.Drawing.Point(564, 321);
            this.pbRightDown.Name = "pbRightDown";
            this.pbRightDown.Size = new System.Drawing.Size(225, 115);
            this.pbRightDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRightDown.TabIndex = 8;
            this.pbRightDown.TabStop = false;
            this.pbRightDown.Tag = "?";
            this.pbRightDown.Click += new System.EventHandler(this.PlayTurn);
            // 
            // pbMiddleDown
            // 
            this.pbMiddleDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMiddleDown.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbMiddleDown.Location = new System.Drawing.Point(293, 321);
            this.pbMiddleDown.Name = "pbMiddleDown";
            this.pbMiddleDown.Size = new System.Drawing.Size(225, 115);
            this.pbMiddleDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMiddleDown.TabIndex = 7;
            this.pbMiddleDown.TabStop = false;
            this.pbMiddleDown.Tag = "?";
            this.pbMiddleDown.Click += new System.EventHandler(this.PlayTurn);
            // 
            // pbLeftDown
            // 
            this.pbLeftDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLeftDown.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbLeftDown.Location = new System.Drawing.Point(22, 321);
            this.pbLeftDown.Name = "pbLeftDown";
            this.pbLeftDown.Size = new System.Drawing.Size(225, 115);
            this.pbLeftDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeftDown.TabIndex = 6;
            this.pbLeftDown.TabStop = false;
            this.pbLeftDown.Tag = "?";
            this.pbLeftDown.Click += new System.EventHandler(this.PlayTurn);
            // 
            // pbRightMiddle
            // 
            this.pbRightMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRightMiddle.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbRightMiddle.Location = new System.Drawing.Point(564, 171);
            this.pbRightMiddle.Name = "pbRightMiddle";
            this.pbRightMiddle.Size = new System.Drawing.Size(225, 115);
            this.pbRightMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRightMiddle.TabIndex = 5;
            this.pbRightMiddle.TabStop = false;
            this.pbRightMiddle.Tag = "?";
            this.pbRightMiddle.Click += new System.EventHandler(this.PlayTurn);
            // 
            // pbMiddleMiddle
            // 
            this.pbMiddleMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMiddleMiddle.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbMiddleMiddle.Location = new System.Drawing.Point(293, 171);
            this.pbMiddleMiddle.Name = "pbMiddleMiddle";
            this.pbMiddleMiddle.Size = new System.Drawing.Size(225, 115);
            this.pbMiddleMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMiddleMiddle.TabIndex = 4;
            this.pbMiddleMiddle.TabStop = false;
            this.pbMiddleMiddle.Tag = "?";
            this.pbMiddleMiddle.Click += new System.EventHandler(this.PlayTurn);
            // 
            // pbLeftMiddle
            // 
            this.pbLeftMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLeftMiddle.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbLeftMiddle.Location = new System.Drawing.Point(22, 171);
            this.pbLeftMiddle.Name = "pbLeftMiddle";
            this.pbLeftMiddle.Size = new System.Drawing.Size(225, 115);
            this.pbLeftMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeftMiddle.TabIndex = 3;
            this.pbLeftMiddle.TabStop = false;
            this.pbLeftMiddle.Tag = "?";
            this.pbLeftMiddle.Click += new System.EventHandler(this.PlayTurn);
            // 
            // pbRightUp
            // 
            this.pbRightUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRightUp.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbRightUp.Location = new System.Drawing.Point(564, 21);
            this.pbRightUp.Name = "pbRightUp";
            this.pbRightUp.Size = new System.Drawing.Size(225, 115);
            this.pbRightUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRightUp.TabIndex = 2;
            this.pbRightUp.TabStop = false;
            this.pbRightUp.Tag = "?";
            this.pbRightUp.Click += new System.EventHandler(this.PlayTurn);
            // 
            // pbMiddleUp
            // 
            this.pbMiddleUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMiddleUp.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbMiddleUp.Location = new System.Drawing.Point(293, 21);
            this.pbMiddleUp.Name = "pbMiddleUp";
            this.pbMiddleUp.Size = new System.Drawing.Size(225, 115);
            this.pbMiddleUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMiddleUp.TabIndex = 1;
            this.pbMiddleUp.TabStop = false;
            this.pbMiddleUp.Tag = "?";
            this.pbMiddleUp.Click += new System.EventHandler(this.PlayTurn);
            // 
            // pbLeftUp
            // 
            this.pbLeftUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLeftUp.Image = global::Tic_Tac_Toe_Game.Properties.Resources.q;
            this.pbLeftUp.Location = new System.Drawing.Point(22, 21);
            this.pbLeftUp.Name = "pbLeftUp";
            this.pbLeftUp.Size = new System.Drawing.Size(225, 115);
            this.pbLeftUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeftUp.TabIndex = 0;
            this.pbLeftUp.TabStop = false;
            this.pbLeftUp.Tag = "?";
            this.pbLeftUp.Click += new System.EventHandler(this.PlayTurn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1213, 585);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.gbInformation);
            this.Controls.Add(this.lbGameName);
            this.Name = "Form1";
            this.Text = "Game over";
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.gbGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddleDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddleMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddleUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbTurnValue;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Label lbWinnerValue;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.PictureBox pbRightDown;
        private System.Windows.Forms.PictureBox pbMiddleDown;
        private System.Windows.Forms.PictureBox pbLeftDown;
        private System.Windows.Forms.PictureBox pbRightMiddle;
        private System.Windows.Forms.PictureBox pbMiddleMiddle;
        private System.Windows.Forms.PictureBox pbLeftMiddle;
        private System.Windows.Forms.PictureBox pbRightUp;
        private System.Windows.Forms.PictureBox pbMiddleUp;
        private System.Windows.Forms.PictureBox pbLeftUp;
    }
}

