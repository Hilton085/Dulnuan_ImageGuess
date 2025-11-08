namespace ImageGuess_Dulnuan
{
    partial class finalScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finalScore));
            this.label1 = new System.Windows.Forms.Label();
            this.animalLabel = new System.Windows.Forms.Label();
            this.treeLabel = new System.Windows.Forms.Label();
            this.fruitLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONGRATULATIONS!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animalLabel
            // 
            this.animalLabel.BackColor = System.Drawing.Color.Transparent;
            this.animalLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalLabel.ForeColor = System.Drawing.Color.White;
            this.animalLabel.Location = new System.Drawing.Point(217, 116);
            this.animalLabel.Name = "animalLabel";
            this.animalLabel.Size = new System.Drawing.Size(390, 52);
            this.animalLabel.TabIndex = 1;
            this.animalLabel.Text = "Animal Score:";
            this.animalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeLabel
            // 
            this.treeLabel.BackColor = System.Drawing.Color.Transparent;
            this.treeLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeLabel.ForeColor = System.Drawing.Color.White;
            this.treeLabel.Location = new System.Drawing.Point(217, 198);
            this.treeLabel.Name = "treeLabel";
            this.treeLabel.Size = new System.Drawing.Size(390, 52);
            this.treeLabel.TabIndex = 2;
            this.treeLabel.Text = "Tree Score:";
            this.treeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fruitLabel
            // 
            this.fruitLabel.BackColor = System.Drawing.Color.Transparent;
            this.fruitLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruitLabel.ForeColor = System.Drawing.Color.White;
            this.fruitLabel.Location = new System.Drawing.Point(217, 283);
            this.fruitLabel.Name = "fruitLabel";
            this.fruitLabel.Size = new System.Drawing.Size(390, 52);
            this.fruitLabel.TabIndex = 3;
            this.fruitLabel.Text = "Fruit Score:";
            this.fruitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(258, 360);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(305, 52);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "TOTAL:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // finalScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ImageGuess.Properties.Resources.loading;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.fruitLabel);
            this.Controls.Add(this.treeLabel);
            this.Controls.Add(this.animalLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "finalScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess That Image";
            this.Load += new System.EventHandler(this.finalScore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label animalLabel;
        private System.Windows.Forms.Label treeLabel;
        private System.Windows.Forms.Label fruitLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}