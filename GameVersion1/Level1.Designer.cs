
namespace GameVersion1
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbPlat1 = new System.Windows.Forms.PictureBox();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.pbPortal = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblGuide1 = new System.Windows.Forms.Label();
            this.pbSpike = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpike)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(573, 454);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(45, 65);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbPlat1
            // 
            this.pbPlat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPlat1.BackgroundImage")));
            this.pbPlat1.Location = new System.Drawing.Point(-200, 566);
            this.pbPlat1.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlat1.Name = "pbPlat1";
            this.pbPlat1.Size = new System.Drawing.Size(2433, 49);
            this.pbPlat1.TabIndex = 1;
            this.pbPlat1.TabStop = false;
            this.pbPlat1.Tag = "platform";
            // 
            // Movement
            // 
            this.Movement.Enabled = true;
            this.Movement.Interval = 20;
            this.Movement.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // pbPortal
            // 
            this.pbPortal.Image = ((System.Drawing.Image)(resources.GetObject("pbPortal.Image")));
            this.pbPortal.Location = new System.Drawing.Point(1711, 491);
            this.pbPortal.Margin = new System.Windows.Forms.Padding(4);
            this.pbPortal.Name = "pbPortal";
            this.pbPortal.Size = new System.Drawing.Size(59, 68);
            this.pbPortal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortal.TabIndex = 5;
            this.pbPortal.TabStop = false;
            this.pbPortal.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 468);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1276, 488);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "movable";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(742, 281);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(500, 100);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // lblGuide1
            // 
            this.lblGuide1.AutoSize = true;
            this.lblGuide1.Location = new System.Drawing.Point(343, 454);
            this.lblGuide1.Name = "lblGuide1";
            this.lblGuide1.Size = new System.Drawing.Size(138, 17);
            this.lblGuide1.TabIndex = 9;
            this.lblGuide1.Tag = "label";
            this.lblGuide1.Text = "Arrow Keys To Move";
            // 
            // pbSpike
            // 
            this.pbSpike.Image = ((System.Drawing.Image)(resources.GetObject("pbSpike.Image")));
            this.pbSpike.Location = new System.Drawing.Point(1456, 538);
            this.pbSpike.Name = "pbSpike";
            this.pbSpike.Size = new System.Drawing.Size(90, 30);
            this.pbSpike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpike.TabIndex = 10;
            this.pbSpike.TabStop = false;
            this.pbSpike.Tag = "danger";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(190)))), ((int)(((byte)(193)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2220, 617);
            this.Controls.Add(this.pbSpike);
            this.Controls.Add(this.lblGuide1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPortal);
            this.Controls.Add(this.pbPlat1);
            this.Controls.Add(this.pbPlayer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbPlat1;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.PictureBox pbPortal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblGuide1;
        private System.Windows.Forms.PictureBox pbSpike;
    }
}