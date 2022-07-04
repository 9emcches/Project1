namespace GameVersion1
{
    partial class Level4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level4));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbPlat1 = new System.Windows.Forms.PictureBox();
            this.pbPortal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortal)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(480, 431);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(45, 65);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // pbPlat1
            // 
            this.pbPlat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPlat1.BackgroundImage")));
            this.pbPlat1.Location = new System.Drawing.Point(-448, 578);
            this.pbPlat1.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlat1.Name = "pbPlat1";
            this.pbPlat1.Size = new System.Drawing.Size(3358, 49);
            this.pbPlat1.TabIndex = 4;
            this.pbPlat1.TabStop = false;
            this.pbPlat1.Tag = "platform";
            // 
            // pbPortal
            // 
            this.pbPortal.Image = ((System.Drawing.Image)(resources.GetObject("pbPortal.Image")));
            this.pbPortal.Location = new System.Drawing.Point(1058, 465);
            this.pbPortal.Margin = new System.Windows.Forms.Padding(4);
            this.pbPortal.Name = "pbPortal";
            this.pbPortal.Size = new System.Drawing.Size(59, 68);
            this.pbPortal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortal.TabIndex = 8;
            this.pbPortal.TabStop = false;
            this.pbPortal.Tag = "platform";
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(190)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(2564, 617);
            this.Controls.Add(this.pbPortal);
            this.Controls.Add(this.pbPlat1);
            this.Controls.Add(this.pbPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Level4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbPlat1;
        private System.Windows.Forms.PictureBox pbPortal;
    }
}