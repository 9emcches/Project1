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
            this.lblRespawnInstruction = new System.Windows.Forms.Label();
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
            // lblRespawnInstruction
            // 
            this.lblRespawnInstruction.AutoSize = true;
            this.lblRespawnInstruction.Location = new System.Drawing.Point(369, 426);
            this.lblRespawnInstruction.Name = "lblRespawnInstruction";
            this.lblRespawnInstruction.Size = new System.Drawing.Size(187, 17);
            this.lblRespawnInstruction.TabIndex = 8;
            this.lblRespawnInstruction.Text = "Press [SPACE] to Respawn..";
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.lblRespawnInstruction);
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
        private System.Windows.Forms.Label lblRespawnInstruction;
    }
}