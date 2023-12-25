namespace EnginGL
{
    partial class splashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.splashCoprightLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.splashProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.SplashIcon = new Bunifu.Framework.UI.BunifuImageButton();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashCoprightLabel
            // 
            this.splashCoprightLabel.AutoSize = true;
            this.splashCoprightLabel.BackColor = System.Drawing.Color.Transparent;
            this.splashCoprightLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashCoprightLabel.ForeColor = System.Drawing.Color.White;
            this.splashCoprightLabel.Location = new System.Drawing.Point(144, 192);
            this.splashCoprightLabel.Name = "splashCoprightLabel";
            this.splashCoprightLabel.Size = new System.Drawing.Size(317, 17);
            this.splashCoprightLabel.TabIndex = 22;
            this.splashCoprightLabel.Text = "© 2018 All Right Reserved Developed by Asadullah.";
            this.splashCoprightLabel.UseWaitCursor = true;
            // 
            // splashProgressBar
            // 
            this.splashProgressBar.Location = new System.Drawing.Point(2, 147);
            this.splashProgressBar.Name = "splashProgressBar";
            this.splashProgressBar.Size = new System.Drawing.Size(597, 20);
            this.splashProgressBar.TabIndex = 21;
            this.splashProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.splashProgressBar.UseWaitCursor = true;
            // 
            // SplashIcon
            // 
            this.SplashIcon.BackColor = System.Drawing.Color.Transparent;
            this.SplashIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SplashIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplashIcon.Image = ((System.Drawing.Image)(resources.GetObject("SplashIcon.Image")));
            this.SplashIcon.ImageActive = null;
            this.SplashIcon.Location = new System.Drawing.Point(95, 26);
            this.SplashIcon.Name = "SplashIcon";
            this.SplashIcon.Size = new System.Drawing.Size(107, 99);
            this.SplashIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SplashIcon.TabIndex = 19;
            this.SplashIcon.TabStop = false;
            this.SplashIcon.UseWaitCursor = true;
            this.SplashIcon.Zoom = 0;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 99);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 238);
            this.Controls.Add(this.splashCoprightLabel);
            this.Controls.Add(this.splashProgressBar);
            this.Controls.Add(this.SplashIcon);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.SplashIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel splashCoprightLabel;
        private MetroFramework.Controls.MetroProgressBar splashProgressBar;
        private Bunifu.Framework.UI.BunifuImageButton SplashIcon;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}