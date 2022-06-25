namespace SushiCat
{
    partial class Customize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customize));
            this.tbChangeName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbChangeName
            // 
            this.tbChangeName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChangeName.ForeColor = System.Drawing.Color.IndianRed;
            this.tbChangeName.Location = new System.Drawing.Point(74, 128);
            this.tbChangeName.Name = "tbChangeName";
            this.tbChangeName.Size = new System.Drawing.Size(107, 56);
            this.tbChangeName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.MistyRose;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.IndianRed;
            this.lblName.Location = new System.Drawing.Point(74, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(263, 57);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Player name:";
            // 
            // btnChangeName
            // 
            this.btnChangeName.BackColor = System.Drawing.Color.LightPink;
            this.btnChangeName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangeName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnChangeName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeName.Font = new System.Drawing.Font("Bahnschrift", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeName.ForeColor = System.Drawing.Color.White;
            this.btnChangeName.Location = new System.Drawing.Point(203, 102);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(100, 50);
            this.btnChangeName.TabIndex = 3;
            this.btnChangeName.Text = "Change";
            this.btnChangeName.UseVisualStyleBackColor = false;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.LightPink;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(332, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(48, 57);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // Customize
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SushiCat.Properties.Resources.OtherScreen;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbChangeName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customize";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customize";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChangeName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Label lblClose;
    }
}