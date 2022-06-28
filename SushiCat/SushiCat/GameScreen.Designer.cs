namespace SushiCat
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.goBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.AutoSize = true;
            this.goBack.BackColor = System.Drawing.Color.LightPink;
            this.goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goBack.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack.ForeColor = System.Drawing.Color.White;
            this.goBack.Location = new System.Drawing.Point(0, 770);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(105, 64);
            this.goBack.TabIndex = 0;
            this.goBack.Text = "Exit";
            this.goBack.Click += new System.EventHandler(this.GoBackClick);
            // 
            // GameScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SushiCat.Properties.Resources.game;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.ControlBox = false;
            this.Controls.Add(this.goBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SushiCat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goBack;
    }
}

