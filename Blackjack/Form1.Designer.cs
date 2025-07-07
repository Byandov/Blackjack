namespace Blackjack
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
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(956, 775);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(49, 16);
            this.lblPlayerScore.TabIndex = 0;
            this.lblPlayerScore.Text = "Player:";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.Location = new System.Drawing.Point(841, 125);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(123, 31);
            this.lblDealerScore.TabIndex = 1;
            this.lblDealerScore.Text = "Dealer:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(890, 324);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(54, 51);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "\"\"";
            // 
            // btnHit
            // 
            this.btnHit.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_122804;
            this.btnHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHit.Location = new System.Drawing.Point(1070, 775);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(187, 81);
            this.btnHit.TabIndex = 3;
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_123053;
            this.btnStand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStand.Location = new System.Drawing.Point(689, 775);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(187, 81);
            this.btnStand.TabIndex = 4;
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_123315;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Location = new System.Drawing.Point(438, 775);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(196, 81);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Blackjack.Properties.Resources.Copilot_20250707_121644;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_122421;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1816, 967);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 66);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_100128;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

