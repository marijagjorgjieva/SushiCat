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
            this.black = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeCat = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.PictureBox();
            this.pink = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.catInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            this.SuspendLayout();
            // 
            // tbChangeName
            // 
            this.tbChangeName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChangeName.ForeColor = System.Drawing.Color.IndianRed;
            this.tbChangeName.Location = new System.Drawing.Point(74, 86);
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
            this.lblName.Location = new System.Drawing.Point(74, 58);
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
            this.btnChangeName.Location = new System.Drawing.Point(203, 60);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(100, 50);
            this.btnChangeName.TabIndex = 3;
            this.btnChangeName.Text = "Change";
            this.btnChangeName.UseVisualStyleBackColor = false;
            this.btnChangeName.Click += new System.EventHandler(this.ChangeName);
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
            // black
            // 
            this.black.BackColor = System.Drawing.Color.GreenYellow;
            this.black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.black.Image = global::SushiCat.Properties.Resources.Right;
            this.black.Location = new System.Drawing.Point(74, 192);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(40, 40);
            this.black.TabIndex = 4;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            this.black.MouseEnter += new System.EventHandler(this.black_MouseEnter);
            this.black.MouseLeave += new System.EventHandler(this.black_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(74, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose cat:";
            // 
            // btnChangeCat
            // 
            this.btnChangeCat.BackColor = System.Drawing.Color.LightPink;
            this.btnChangeCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeCat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangeCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnChangeCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangeCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCat.Font = new System.Drawing.Font("Bahnschrift", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCat.ForeColor = System.Drawing.Color.White;
            this.btnChangeCat.Location = new System.Drawing.Point(203, 156);
            this.btnChangeCat.Name = "btnChangeCat";
            this.btnChangeCat.Size = new System.Drawing.Size(100, 50);
            this.btnChangeCat.TabIndex = 3;
            this.btnChangeCat.Text = "Change";
            this.btnChangeCat.UseVisualStyleBackColor = false;
            this.btnChangeCat.Click += new System.EventHandler(this.btnChangeCat_Click);
            // 
            // gray
            // 
            this.gray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gray.Image = global::SushiCat.Properties.Resources.GrayRight;
            this.gray.Location = new System.Drawing.Point(129, 192);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(40, 40);
            this.gray.TabIndex = 4;
            this.gray.TabStop = false;
            this.gray.Click += new System.EventHandler(this.gray_Click);
            this.gray.MouseEnter += new System.EventHandler(this.gray_MouseEnter);
            this.gray.MouseLeave += new System.EventHandler(this.gray_MouseLeave);
            // 
            // pink
            // 
            this.pink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pink.Image = global::SushiCat.Properties.Resources.PinkRight;
            this.pink.Location = new System.Drawing.Point(74, 235);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(40, 40);
            this.pink.TabIndex = 4;
            this.pink.TabStop = false;
            this.pink.Click += new System.EventHandler(this.pink_Click);
            this.pink.MouseEnter += new System.EventHandler(this.pink_MouseEnter);
            this.pink.MouseLeave += new System.EventHandler(this.pink_MouseLeave);
            // 
            // yellow
            // 
            this.yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellow.Image = global::SushiCat.Properties.Resources.YellowRight;
            this.yellow.Location = new System.Drawing.Point(129, 235);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(40, 40);
            this.yellow.TabIndex = 4;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            this.yellow.MouseEnter += new System.EventHandler(this.yellow_MouseEnter);
            this.yellow.MouseLeave += new System.EventHandler(this.yellow_MouseLeave);
            // 
            // catInfo
            // 
            this.catInfo.AutoSize = true;
            this.catInfo.BackColor = System.Drawing.Color.MistyRose;
            this.catInfo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catInfo.ForeColor = System.Drawing.Color.YellowGreen;
            this.catInfo.Location = new System.Drawing.Point(203, 218);
            this.catInfo.Name = "catInfo";
            this.catInfo.Size = new System.Drawing.Size(227, 144);
            this.catInfo.TabIndex = 1;
            this.catInfo.Text = "Unlocked\r\nDefault Black\r\nCat\r\n";
            // 
            // Customize
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SushiCat.Properties.Resources.OtherScreen;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.gray);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.pink);
            this.Controls.Add(this.black);
            this.Controls.Add(this.btnChangeCat);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.catInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbChangeName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customize";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customize";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customize_FormClosed);
            this.Click += new System.EventHandler(this.Customize_Click);
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChangeName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeCat;
        private System.Windows.Forms.PictureBox gray;
        private System.Windows.Forms.PictureBox pink;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.Label catInfo;
    }
}