namespace Ben10DownloadAutomater
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.seasonNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EpisodeNumbersBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getLinks = new System.Windows.Forms.Button();
            this.episodeListLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(50, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(325, 20);
            this.urlBox.TabIndex = 1;
            this.urlBox.Text = "https://droplink.co/Omniverse-S&E#";
            // 
            // seasonNumberBox
            // 
            this.seasonNumberBox.Location = new System.Drawing.Point(107, 38);
            this.seasonNumberBox.Name = "seasonNumberBox";
            this.seasonNumberBox.Size = new System.Drawing.Size(41, 20);
            this.seasonNumberBox.TabIndex = 3;
            this.seasonNumberBox.Text = "1";
            this.seasonNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Season Number :";
            // 
            // EpisodeNumbersBox
            // 
            this.EpisodeNumbersBox.Location = new System.Drawing.Point(485, 15);
            this.EpisodeNumbersBox.Name = "EpisodeNumbersBox";
            this.EpisodeNumbersBox.Size = new System.Drawing.Size(34, 20);
            this.EpisodeNumbersBox.TabIndex = 5;
            this.EpisodeNumbersBox.Text = "4";
            this.EpisodeNumbersBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EpisodeNumbersBox.TextChanged += new System.EventHandler(this.EpisodeNumbersBox_TextChanged);
            this.EpisodeNumbersBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EpisodeNumbersBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Episode Numbers :";
            // 
            // getLinks
            // 
            this.getLinks.Location = new System.Drawing.Point(15, 78);
            this.getLinks.Name = "getLinks";
            this.getLinks.Size = new System.Drawing.Size(133, 53);
            this.getLinks.TabIndex = 6;
            this.getLinks.Text = "Get Links";
            this.getLinks.UseVisualStyleBackColor = true;
            this.getLinks.Click += new System.EventHandler(this.getLinks_Click);
            // 
            // episodeListLabel
            // 
            this.episodeListLabel.AutoSize = true;
            this.episodeListLabel.Location = new System.Drawing.Point(610, 19);
            this.episodeListLabel.Name = "episodeListLabel";
            this.episodeListLabel.Size = new System.Drawing.Size(13, 13);
            this.episodeListLabel.TabIndex = 7;
            this.episodeListLabel.Text = "1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.episodeListLabel);
            this.Controls.Add(this.getLinks);
            this.Controls.Add(this.EpisodeNumbersBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seasonNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox seasonNumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EpisodeNumbersBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getLinks;
        private System.Windows.Forms.Label episodeListLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

