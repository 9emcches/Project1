namespace GameVersion1
{
    partial class DeathScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeathScreen));
            this.pbDead = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDead)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDead
            // 
            this.pbDead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDead.Image = ((System.Drawing.Image)(resources.GetObject("pbDead.Image")));
            this.pbDead.Location = new System.Drawing.Point(274, 30);
            this.pbDead.Name = "pbDead";
            this.pbDead.Size = new System.Drawing.Size(360, 360);
            this.pbDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDead.TabIndex = 7;
            this.pbDead.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(254, 409);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(401, 75);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Press [SPACE] to Respawn..\r\nOr Press [Esc] to Return to Main Menu...\r\n\r\n";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(190)))), ((int)(((byte)(193)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(40, 37);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(80, 37);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbDead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeathScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeathScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeathScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbDead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDead;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnMenu;
    }
}