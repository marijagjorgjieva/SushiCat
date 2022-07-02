namespace SushiCat.Forms
{
    partial class HelpScreen
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
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.catInfo = new System.Windows.Forms.Label();
            this.black = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gray = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.pink = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.LightPink;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(335, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(48, 57);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.MistyRose;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(71, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(531, 112);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "HOW TO PLAY";
            // 
            // catInfo
            // 
            this.catInfo.AutoSize = true;
            this.catInfo.BackColor = System.Drawing.Color.MistyRose;
            this.catInfo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catInfo.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.catInfo.Location = new System.Drawing.Point(56, 139);
            this.catInfo.Name = "catInfo";
            this.catInfo.Size = new System.Drawing.Size(425, 144);
            this.catInfo.TabIndex = 4;
            this.catInfo.Text = "Goal: With your cat collect\r\nevery sushi scattered \r\nacross the maze";
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Transparent;
            this.black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.black.Image = global::SushiCat.Properties.Resources.Right;
            this.black.Location = new System.Drawing.Point(238, 149);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(40, 40);
            this.black.TabIndex = 5;
            this.black.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SushiCat.Properties.Resources.Sushi;
            this.pictureBox1.Location = new System.Drawing.Point(291, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(56, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 144);
            this.label1.TabIndex = 4;
            this.label1.Text = "Controls:\r\nUse the arrow keys \r\nfrom your keyboard\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SushiCat.Properties.Resources.arrowsImage;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(202, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 52);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(56, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 240);
            this.label2.TabIndex = 4;
            this.label2.Text = "BUT BEWARE!\r\nFor every encounter with \r\nthe Evil Blob you lose one\r\nlife, and you" +
    " only have three\r\nlives to start with\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::SushiCat.Properties.Resources.EvilBlob;
            this.pictureBox3.Location = new System.Drawing.Point(253, 312);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(56, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 384);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customize:\r\nFrom customize you can\r\nchange your player \r\nname and cat avatar.\r\n\r\n" +
    "New cats are unlocked\r\nafter accomplishing \r\nsome achievements";
            // 
            // gray
            // 
            this.gray.BackColor = System.Drawing.Color.Transparent;
            this.gray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gray.Image = global::SushiCat.Properties.Resources.GrayRight;
            this.gray.Location = new System.Drawing.Point(286, 431);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(40, 40);
            this.gray.TabIndex = 6;
            this.gray.TabStop = false;
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Transparent;
            this.yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellow.Image = global::SushiCat.Properties.Resources.YellowRight;
            this.yellow.Location = new System.Drawing.Point(286, 474);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(40, 40);
            this.yellow.TabIndex = 7;
            this.yellow.TabStop = false;
            // 
            // pink
            // 
            this.pink.BackColor = System.Drawing.Color.Transparent;
            this.pink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pink.Image = global::SushiCat.Properties.Resources.PinkRight;
            this.pink.Location = new System.Drawing.Point(231, 474);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(40, 40);
            this.pink.TabIndex = 8;
            this.pink.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::SushiCat.Properties.Resources.Right;
            this.pictureBox4.Location = new System.Drawing.Point(231, 431);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // HelpScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SushiCat.Properties.Resources.OtherScreen;
            this.ClientSize = new System.Drawing.Size(368, 600);
            this.Controls.Add(this.gray);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.pink);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.black);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpScreen";
            this.Opacity = 0.97D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpScreen";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label catInfo;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox gray;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox pink;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}