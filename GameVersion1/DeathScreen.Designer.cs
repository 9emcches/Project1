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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRespawn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDead)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDead
            // 
            this.pbDead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDead.Image = ((System.Drawing.Image)(resources.GetObject("pbDead.Image")));
            this.pbDead.Location = new System.Drawing.Point(217, -26);
            this.pbDead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDead.Name = "pbDead";
            this.pbDead.Size = new System.Drawing.Size(360, 360);
            this.pbDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDead.TabIndex = 7;
            this.pbDead.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(190)))), ((int)(((byte)(193)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(275, 423);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(140, 37);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRespawn
            // 
            this.btnRespawn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(190)))), ((int)(((byte)(193)))));
            this.btnRespawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespawn.Location = new System.Drawing.Point(493, 423);
            this.btnRespawn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRespawn.Name = "btnRespawn";
            this.btnRespawn.Size = new System.Drawing.Size(140, 37);
            this.btnRespawn.TabIndex = 10;
            this.btnRespawn.Text = "&Respawn";
            this.btnRespawn.UseVisualStyleBackColor = false;
            this.btnRespawn.Click += new System.EventHandler(this.btnRespawn_Click);
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(941, 494);
            this.Controls.Add(this.btnRespawn);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pbDead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "DeathScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeathScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pbDead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDead;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRespawn;
    }
}