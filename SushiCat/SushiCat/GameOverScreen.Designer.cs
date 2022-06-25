namespace SushiCat
{
    partial class GameOverScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverScreen));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblNewH = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.MistyRose;
            this.lblScore.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.IndianRed;
            this.lblScore.Location = new System.Drawing.Point(57, 161);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(308, 88);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 191";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.MistyRose;
            this.lblGameOver.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGameOver.Location = new System.Drawing.Point(58, 78);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(632, 144);
            this.lblGameOver.TabIndex = 1;
            this.lblGameOver.Text = "GAME OVER!";
            // 
            // lblNewH
            // 
            this.lblNewH.AutoSize = true;
            this.lblNewH.BackColor = System.Drawing.Color.Transparent;
            this.lblNewH.Font = new System.Drawing.Font("Balthazar", 15.9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewH.ForeColor = System.Drawing.Color.Gold;
            this.lblNewH.Location = new System.Drawing.Point(192, 164);
            this.lblNewH.Name = "lblNewH";
            this.lblNewH.Size = new System.Drawing.Size(213, 63);
            this.lblNewH.TabIndex = 0;
            this.lblNewH.Text = "Good job !";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.LightPink;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Bahnschrift", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(58, 229);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 50);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.LightPink;
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Bahnschrift", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(164, 229);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(174, 50);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SushiCat.Properties.Resources.OtherScreen;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblNewH);
            this.Controls.Add(this.lblScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOverScreen";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME OVER!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblNewH;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}