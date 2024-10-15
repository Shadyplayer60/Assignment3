namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnDeal = new Button();
            btnSaveHand = new Button();
            btnLoadHand = new Button();
            picCard1 = new PictureBox();
            picCard2 = new PictureBox();
            picCard3 = new PictureBox();
            picCard4 = new PictureBox();
            picCard5 = new PictureBox();
            chkKeep1 = new CheckBox();
            chkKeep2 = new CheckBox();
            chkKeep3 = new CheckBox();
            chkKeep4 = new CheckBox();
            chkKeep5 = new CheckBox();
            imageCardsList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).BeginInit();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(12, 12);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(141, 67);
            btnDeal.TabIndex = 0;
            btnDeal.Text = "&Deal";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnSaveHand
            // 
            btnSaveHand.Location = new Point(500, 12);
            btnSaveHand.Name = "btnSaveHand";
            btnSaveHand.Size = new Size(141, 67);
            btnSaveHand.TabIndex = 1;
            btnSaveHand.Text = "&Save Hand";
            btnSaveHand.UseVisualStyleBackColor = true;
            btnSaveHand.Click += btnSaveHand_Click;
            // 
            // btnLoadHand
            // 
            btnLoadHand.Location = new Point(647, 12);
            btnLoadHand.Name = "btnLoadHand";
            btnLoadHand.Size = new Size(141, 67);
            btnLoadHand.TabIndex = 2;
            btnLoadHand.Text = "&Load Hand";
            btnLoadHand.UseVisualStyleBackColor = true;
            btnLoadHand.Click += btnLoadHand_Click;
            // 
            // picCard1
            // 
            picCard1.Location = new Point(12, 209);
            picCard1.Name = "picCard1";
            picCard1.Size = new Size(150, 229);
            picCard1.TabIndex = 3;
            picCard1.TabStop = false;
            // 
            // picCard2
            // 
            picCard2.Location = new Point(168, 209);
            picCard2.Name = "picCard2";
            picCard2.Size = new Size(150, 229);
            picCard2.TabIndex = 4;
            picCard2.TabStop = false;
            // 
            // picCard3
            // 
            picCard3.Location = new Point(324, 209);
            picCard3.Name = "picCard3";
            picCard3.Size = new Size(150, 229);
            picCard3.TabIndex = 5;
            picCard3.TabStop = false;
            // 
            // picCard4
            // 
            picCard4.Location = new Point(480, 209);
            picCard4.Name = "picCard4";
            picCard4.Size = new Size(150, 229);
            picCard4.TabIndex = 6;
            picCard4.TabStop = false;
            // 
            // picCard5
            // 
            picCard5.Location = new Point(636, 209);
            picCard5.Name = "picCard5";
            picCard5.Size = new Size(150, 229);
            picCard5.TabIndex = 7;
            picCard5.TabStop = false;
            // 
            // chkKeep1
            // 
            chkKeep1.AutoSize = true;
            chkKeep1.Location = new Point(12, 174);
            chkKeep1.Name = "chkKeep1";
            chkKeep1.Size = new Size(92, 29);
            chkKeep1.TabIndex = 8;
            chkKeep1.Text = "Keep &1";
            chkKeep1.UseVisualStyleBackColor = true;
            // 
            // chkKeep2
            // 
            chkKeep2.AutoSize = true;
            chkKeep2.Location = new Point(168, 176);
            chkKeep2.Name = "chkKeep2";
            chkKeep2.Size = new Size(92, 29);
            chkKeep2.TabIndex = 9;
            chkKeep2.Text = "Keep &2";
            chkKeep2.UseVisualStyleBackColor = true;
            // 
            // chkKeep3
            // 
            chkKeep3.AutoSize = true;
            chkKeep3.Location = new Point(324, 176);
            chkKeep3.Name = "chkKeep3";
            chkKeep3.Size = new Size(92, 29);
            chkKeep3.TabIndex = 10;
            chkKeep3.Text = "Keep &3";
            chkKeep3.UseVisualStyleBackColor = true;
            // 
            // chkKeep4
            // 
            chkKeep4.AutoSize = true;
            chkKeep4.Location = new Point(480, 174);
            chkKeep4.Name = "chkKeep4";
            chkKeep4.Size = new Size(92, 29);
            chkKeep4.TabIndex = 11;
            chkKeep4.Text = "Keep &4";
            chkKeep4.UseVisualStyleBackColor = true;
            // 
            // chkKeep5
            // 
            chkKeep5.AutoSize = true;
            chkKeep5.Location = new Point(636, 174);
            chkKeep5.Name = "chkKeep5";
            chkKeep5.Size = new Size(92, 29);
            chkKeep5.TabIndex = 12;
            chkKeep5.Text = "Keep &5";
            chkKeep5.UseVisualStyleBackColor = true;
            // 
            // imageCardsList
            // 
            imageCardsList.ColorDepth = ColorDepth.Depth32Bit;
            imageCardsList.ImageStream = (ImageListStreamer)resources.GetObject("imageCardsList.ImageStream");
            imageCardsList.TransparentColor = Color.Transparent;
            imageCardsList.Images.SetKeyName(0, "Card 0.png");
            imageCardsList.Images.SetKeyName(1, "Card 1.png");
            imageCardsList.Images.SetKeyName(2, "Card 2.png");
            imageCardsList.Images.SetKeyName(3, "Card 3.png");
            imageCardsList.Images.SetKeyName(4, "Card 4.png");
            imageCardsList.Images.SetKeyName(5, "Card 5.png");
            imageCardsList.Images.SetKeyName(6, "Card 6.png");
            imageCardsList.Images.SetKeyName(7, "Card 7.png");
            imageCardsList.Images.SetKeyName(8, "Card 8.png");
            imageCardsList.Images.SetKeyName(9, "Card 9.png");
            imageCardsList.Images.SetKeyName(10, "Card 10.png");
            imageCardsList.Images.SetKeyName(11, "Card 11.png");
            imageCardsList.Images.SetKeyName(12, "Card 12.png");
            imageCardsList.Images.SetKeyName(13, "Card 13.png");
            imageCardsList.Images.SetKeyName(14, "Card 14.png");
            imageCardsList.Images.SetKeyName(15, "Card 15.png");
            imageCardsList.Images.SetKeyName(16, "Card 16.png");
            imageCardsList.Images.SetKeyName(17, "Card 17.png");
            imageCardsList.Images.SetKeyName(18, "Card 18.png");
            imageCardsList.Images.SetKeyName(19, "Card 19.png");
            imageCardsList.Images.SetKeyName(20, "Card 20.png");
            imageCardsList.Images.SetKeyName(21, "Card 21.png");
            imageCardsList.Images.SetKeyName(22, "Card 22.png");
            imageCardsList.Images.SetKeyName(23, "Card 23.png");
            imageCardsList.Images.SetKeyName(24, "Card 24.png");
            imageCardsList.Images.SetKeyName(25, "Card 25.png");
            imageCardsList.Images.SetKeyName(26, "Card 26.png");
            imageCardsList.Images.SetKeyName(27, "Card 27.png");
            imageCardsList.Images.SetKeyName(28, "Card 28.png");
            imageCardsList.Images.SetKeyName(29, "Card 29.png");
            imageCardsList.Images.SetKeyName(30, "Card 30.png");
            imageCardsList.Images.SetKeyName(31, "Card 31.png");
            imageCardsList.Images.SetKeyName(32, "Card 32.png");
            imageCardsList.Images.SetKeyName(33, "Card 33.png");
            imageCardsList.Images.SetKeyName(34, "Card 34.png");
            imageCardsList.Images.SetKeyName(35, "Card 35.png");
            imageCardsList.Images.SetKeyName(36, "Card 36.png");
            imageCardsList.Images.SetKeyName(37, "Card 37.png");
            imageCardsList.Images.SetKeyName(38, "Card 38.png");
            imageCardsList.Images.SetKeyName(39, "Card 39.png");
            imageCardsList.Images.SetKeyName(40, "Card 40.png");
            imageCardsList.Images.SetKeyName(41, "Card 41.png");
            imageCardsList.Images.SetKeyName(42, "Card 42.png");
            imageCardsList.Images.SetKeyName(43, "Card 43.png");
            imageCardsList.Images.SetKeyName(44, "Card 44.png");
            imageCardsList.Images.SetKeyName(45, "Card 45.png");
            imageCardsList.Images.SetKeyName(46, "Card 46.png");
            imageCardsList.Images.SetKeyName(47, "Card 47.png");
            imageCardsList.Images.SetKeyName(48, "Card 48.png");
            imageCardsList.Images.SetKeyName(49, "Card 49.png");
            imageCardsList.Images.SetKeyName(50, "Card 50.png");
            imageCardsList.Images.SetKeyName(51, "Card 51.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(chkKeep5);
            Controls.Add(chkKeep4);
            Controls.Add(chkKeep3);
            Controls.Add(chkKeep2);
            Controls.Add(chkKeep1);
            Controls.Add(picCard5);
            Controls.Add(picCard4);
            Controls.Add(picCard3);
            Controls.Add(picCard2);
            Controls.Add(picCard1);
            Controls.Add(btnLoadHand);
            Controls.Add(btnSaveHand);
            Controls.Add(btnDeal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Poker Hand Simulator";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeal;
        private Button btnSaveHand;
        private Button btnLoadHand;
        private PictureBox picCard1;
        private PictureBox picCard2;
        private PictureBox picCard3;
        private PictureBox picCard4;
        private PictureBox picCard5;
        private CheckBox chkKeep1;
        private CheckBox chkKeep2;
        private CheckBox chkKeep3;
        private CheckBox chkKeep4;
        private CheckBox chkKeep5;
        private ImageList imageCardsList;
    }
}
