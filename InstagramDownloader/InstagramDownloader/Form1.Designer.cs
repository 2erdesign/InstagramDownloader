namespace InstagramDownloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUrlImage = new System.Windows.Forms.TextBox();
            this.lblUrlImage = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblUrlVideo = new System.Windows.Forms.Label();
            this.txtUrlVideo = new System.Windows.Forms.TextBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblComplete = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrlImage
            // 
            this.txtUrlImage.Location = new System.Drawing.Point(47, 49);
            this.txtUrlImage.Name = "txtUrlImage";
            this.txtUrlImage.Size = new System.Drawing.Size(238, 20);
            this.txtUrlImage.TabIndex = 0;
            // 
            // lblUrlImage
            // 
            this.lblUrlImage.AutoSize = true;
            this.lblUrlImage.Location = new System.Drawing.Point(18, 33);
            this.lblUrlImage.Name = "lblUrlImage";
            this.lblUrlImage.Size = new System.Drawing.Size(64, 13);
            this.lblUrlImage.TabIndex = 1;
            this.lblUrlImage.Text = "Image URL:";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(291, 46);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "Download";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // lblUrlVideo
            // 
            this.lblUrlVideo.AutoSize = true;
            this.lblUrlVideo.Location = new System.Drawing.Point(18, 83);
            this.lblUrlVideo.Name = "lblUrlVideo";
            this.lblUrlVideo.Size = new System.Drawing.Size(62, 13);
            this.lblUrlVideo.TabIndex = 3;
            this.lblUrlVideo.Text = "Video URL:";
            // 
            // txtUrlVideo
            // 
            this.txtUrlVideo.Location = new System.Drawing.Point(47, 99);
            this.txtUrlVideo.Name = "txtUrlVideo";
            this.txtUrlVideo.Size = new System.Drawing.Size(238, 20);
            this.txtUrlVideo.TabIndex = 4;
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(291, 96);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 23);
            this.btnVideo.TabIndex = 5;
            this.btnVideo.Text = "Download";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComplete);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblUrlImage);
            this.groupBox1.Controls.Add(this.btnVideo);
            this.groupBox1.Controls.Add(this.txtUrlImage);
            this.groupBox1.Controls.Add(this.txtUrlVideo);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.lblUrlVideo);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 414);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IG Downloader [2ER Design]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 204);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(44, 372);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(0, 13);
            this.lblComplete.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 455);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Instagram Downloader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrlImage;
        private System.Windows.Forms.Label lblUrlImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblUrlVideo;
        private System.Windows.Forms.TextBox txtUrlVideo;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblComplete;
    }
}

