namespace ImageGuess_Dulnuan
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.quitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.subPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TreeButton = new System.Windows.Forms.Button();
            this.FruitButton = new System.Windows.Forms.Button();
            this.AnimalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.subPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.quitButton);
            this.mainPanel.Controls.Add(this.startButton);
            this.mainPanel.Controls.Add(this.title);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 426);
            this.mainPanel.TabIndex = 0;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.quitButton.Location = new System.Drawing.Point(336, 253);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(98, 52);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.RosyBrown;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Control;
            this.startButton.Location = new System.Drawing.Point(336, 177);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(98, 52);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(150, 69);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(498, 57);
            this.title.TabIndex = 0;
            this.title.Text = "Guess That Image";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subPanel
            // 
            this.subPanel.BackColor = System.Drawing.Color.Transparent;
            this.subPanel.Controls.Add(this.pictureBox3);
            this.subPanel.Controls.Add(this.pictureBox2);
            this.subPanel.Controls.Add(this.pictureBox1);
            this.subPanel.Controls.Add(this.TreeButton);
            this.subPanel.Controls.Add(this.FruitButton);
            this.subPanel.Controls.Add(this.AnimalButton);
            this.subPanel.Controls.Add(this.label1);
            this.subPanel.Location = new System.Drawing.Point(12, 12);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(776, 426);
            this.subPanel.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ImageGuess.Properties.Resources.trees;
            this.pictureBox3.Location = new System.Drawing.Point(294, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ImageGuess.Properties.Resources.fruits;
            this.pictureBox2.Location = new System.Drawing.Point(294, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ImageGuess.Properties.Resources.animals;
            this.pictureBox1.Location = new System.Drawing.Point(294, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TreeButton
            // 
            this.TreeButton.BackColor = System.Drawing.Color.RosyBrown;
            this.TreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TreeButton.Location = new System.Drawing.Point(366, 311);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(98, 52);
            this.TreeButton.TabIndex = 3;
            this.TreeButton.Text = "TREES";
            this.TreeButton.UseVisualStyleBackColor = false;
            this.TreeButton.Click += new System.EventHandler(this.TreeButton_Click);
            // 
            // FruitButton
            // 
            this.FruitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.FruitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FruitButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FruitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FruitButton.Location = new System.Drawing.Point(366, 235);
            this.FruitButton.Name = "FruitButton";
            this.FruitButton.Size = new System.Drawing.Size(98, 52);
            this.FruitButton.TabIndex = 2;
            this.FruitButton.Text = "FRUIT";
            this.FruitButton.UseVisualStyleBackColor = false;
            this.FruitButton.Click += new System.EventHandler(this.FruitButton_Click);
            // 
            // AnimalButton
            // 
            this.AnimalButton.BackColor = System.Drawing.Color.RosyBrown;
            this.AnimalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimalButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AnimalButton.Location = new System.Drawing.Point(366, 162);
            this.AnimalButton.Name = "AnimalButton";
            this.AnimalButton.Size = new System.Drawing.Size(98, 52);
            this.AnimalButton.TabIndex = 1;
            this.AnimalButton.Text = "ANIMAL";
            this.AnimalButton.UseVisualStyleBackColor = false;
            this.AnimalButton.Click += new System.EventHandler(this.AnimalButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(150, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Preferred Topic:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ImageGuess.Properties.Resources.loading;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess That Image";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.mainPanel.ResumeLayout(false);
            this.subPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel subPanel;
        private System.Windows.Forms.Button FruitButton;
        private System.Windows.Forms.Button AnimalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TreeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}