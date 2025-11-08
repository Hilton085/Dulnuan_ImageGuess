namespace ImageGuess_Dulnuan
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.label_description1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(256, 121);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(310, 85);
            this.title.TabIndex = 0;
            this.title.Text = "LOADING...";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_description1
            // 
            this.label_description1.AutoSize = true;
            this.label_description1.BackColor = System.Drawing.Color.Transparent;
            this.label_description1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_description1.Location = new System.Drawing.Point(302, 230);
            this.label_description1.Name = "label_description1";
            this.label_description1.Size = new System.Drawing.Size(198, 25);
            this.label_description1.TabIndex = 1;
            this.label_description1.Text = "Preparing Images...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 438);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(801, 15);
            this.progressBar1.TabIndex = 2;
            // 
            // progressNum
            // 
            this.progressNum.AutoSize = true;
            this.progressNum.BackColor = System.Drawing.Color.Transparent;
            this.progressNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressNum.Location = new System.Drawing.Point(721, 396);
            this.progressNum.Name = "progressNum";
            this.progressNum.Size = new System.Drawing.Size(67, 25);
            this.progressNum.TabIndex = 3;
            this.progressNum.Text = "100%";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Load_tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Percent_tick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(1, 438);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(48, 15);
            this.progressBar2.TabIndex = 4;
            this.progressBar2.Visible = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ImageGuess.Properties.Resources.loading;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressNum);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_description1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label_description1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

