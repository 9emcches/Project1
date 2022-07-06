
namespace GameVersion1
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblFact = new System.Windows.Forms.Label();
            this.lblDidYouKnow = new System.Windows.Forms.Label();
            this.pbLoadingAnim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(230, 10);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(500, 200);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // lblFact
            // 
            this.lblFact.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFact.Location = new System.Drawing.Point(220, 285);
            this.lblFact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(525, 76);
            this.lblFact.TabIndex = 7;
            this.lblFact.Text = "*fact";
            this.lblFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDidYouKnow
            // 
            this.lblDidYouKnow.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDidYouKnow.Location = new System.Drawing.Point(220, 260);
            this.lblDidYouKnow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDidYouKnow.Name = "lblDidYouKnow";
            this.lblDidYouKnow.Size = new System.Drawing.Size(525, 31);
            this.lblDidYouKnow.TabIndex = 8;
            this.lblDidYouKnow.Text = "Did you know?";
            this.lblDidYouKnow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLoadingAnim
            // 
            this.pbLoadingAnim.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingAnim.Image")));
            this.pbLoadingAnim.Location = new System.Drawing.Point(445, 365);
            this.pbLoadingAnim.Margin = new System.Windows.Forms.Padding(2);
            this.pbLoadingAnim.Name = "pbLoadingAnim";
            this.pbLoadingAnim.Size = new System.Drawing.Size(74, 76);
            this.pbLoadingAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoadingAnim.TabIndex = 9;
            this.pbLoadingAnim.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 450);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Loading...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLoadingAnim);
            this.Controls.Add(this.lblDidYouKnow);
            this.Controls.Add(this.lblFact);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Shown += new System.EventHandler(this.SplashScreen_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAnim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Label lblDidYouKnow;
        private System.Windows.Forms.PictureBox pbLoadingAnim;
        private System.Windows.Forms.Label label1;
    }
}