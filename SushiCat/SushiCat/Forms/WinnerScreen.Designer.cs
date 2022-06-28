namespace SushiCat
{
    partial class WinnerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerScreen));
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblNewH = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnPlayAgain.Location = new System.Drawing.Point(156, 213);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(174, 50);
            this.btnPlayAgain.TabIndex = 6;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
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
            this.btnMenu.Location = new System.Drawing.Point(50, 213);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 50);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.MistyRose;
            this.lblGameOver.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGameOver.Location = new System.Drawing.Point(83, 62);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(477, 144);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "YOU WIN!";
            // 
            // lblNewH
            // 
            this.lblNewH.AutoSize = true;
            this.lblNewH.BackColor = System.Drawing.Color.White;
            this.lblNewH.Font = new System.Drawing.Font("Balthazar", 15.9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewH.ForeColor = System.Drawing.Color.Gold;
            this.lblNewH.Location = new System.Drawing.Point(184, 143);
            this.lblNewH.Name = "lblNewH";
            this.lblNewH.Size = new System.Drawing.Size(329, 63);
            this.lblNewH.TabIndex = 3;
            this.lblNewH.Text = "Congratulations!";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.MistyRose;
            this.lblScore.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.IndianRed;
            this.lblScore.Location = new System.Drawing.Point(49, 145);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(308, 88);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 191";
            // 
            // WinnerScreen
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
            this.Name = "WinnerScreen";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnerScreen";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblNewH;
        private System.Windows.Forms.Label lblScore;
    }
}