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
            this.playerCardBox3 = new System.Windows.Forms.PictureBox();
            this.playerCardBox4 = new System.Windows.Forms.PictureBox();
            this.playerCardBox2 = new System.Windows.Forms.PictureBox();
            this.playerCardBox1 = new System.Windows.Forms.PictureBox();
            this.playerCardBox5 = new System.Windows.Forms.PictureBox();
            this.dealerCardBox2 = new System.Windows.Forms.PictureBox();
            this.dealerCardBox3 = new System.Windows.Forms.PictureBox();
            this.dealerCardBox4 = new System.Windows.Forms.PictureBox();
            this.dealerCardBox1 = new System.Windows.Forms.PictureBox();
            this.dealerCardBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayerScore.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(676, 746);
            this.lblPlayerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(194, 43);
            this.lblPlayerScore.TabIndex = 0;
            this.lblPlayerScore.Text = "\"\"";
            this.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerScore.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDealerScore.ForeColor = System.Drawing.Color.White;
            this.lblDealerScore.Location = new System.Drawing.Point(797, 9);
            this.lblDealerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(366, 72);
            this.lblDealerScore.TabIndex = 1;
            this.lblDealerScore.Text = "\"\"";
            this.lblDealerScore.Click += new System.EventHandler(this.lblDealerScore_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(765, 317);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(512, 113);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "\"\"";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_122804;
            this.btnHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHit.Location = new System.Drawing.Point(1516, 296);
            this.btnHit.Margin = new System.Windows.Forms.Padding(2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(204, 66);
            this.btnHit.TabIndex = 3;
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_123053;
            this.btnStand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStand.Location = new System.Drawing.Point(1516, 379);
            this.btnStand.Margin = new System.Windows.Forms.Padding(2);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(204, 66);
            this.btnStand.TabIndex = 4;
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_123315;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Location = new System.Drawing.Point(1516, 459);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(204, 66);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Blackjack.Properties.Resources.Copilot_20250707_121644;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_122421;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1737, 963);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 77);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerCardBox3
            // 
            this.playerCardBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCardBox3.Location = new System.Drawing.Point(851, 555);
            this.playerCardBox3.Name = "playerCardBox3";
            this.playerCardBox3.Size = new System.Drawing.Size(100, 143);
            this.playerCardBox3.TabIndex = 8;
            this.playerCardBox3.TabStop = false;
            // 
            // playerCardBox4
            // 
            this.playerCardBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCardBox4.Location = new System.Drawing.Point(957, 555);
            this.playerCardBox4.Name = "playerCardBox4";
            this.playerCardBox4.Size = new System.Drawing.Size(100, 143);
            this.playerCardBox4.TabIndex = 9;
            this.playerCardBox4.TabStop = false;
            // 
            // playerCardBox2
            // 
            this.playerCardBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCardBox2.Location = new System.Drawing.Point(745, 555);
            this.playerCardBox2.Name = "playerCardBox2";
            this.playerCardBox2.Size = new System.Drawing.Size(100, 143);
            this.playerCardBox2.TabIndex = 10;
            this.playerCardBox2.TabStop = false;
            // 
            // playerCardBox1
            // 
            this.playerCardBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCardBox1.Location = new System.Drawing.Point(639, 555);
            this.playerCardBox1.Name = "playerCardBox1";
            this.playerCardBox1.Size = new System.Drawing.Size(100, 143);
            this.playerCardBox1.TabIndex = 11;
            this.playerCardBox1.TabStop = false;
            // 
            // playerCardBox5
            // 
            this.playerCardBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCardBox5.Location = new System.Drawing.Point(1063, 555);
            this.playerCardBox5.Name = "playerCardBox5";
            this.playerCardBox5.Size = new System.Drawing.Size(100, 143);
            this.playerCardBox5.TabIndex = 12;
            this.playerCardBox5.TabStop = false;
            // 
            // dealerCardBox2
            // 
            this.dealerCardBox2.Location = new System.Drawing.Point(639, 92);
            this.dealerCardBox2.Name = "dealerCardBox2";
            this.dealerCardBox2.Size = new System.Drawing.Size(100, 124);
            this.dealerCardBox2.TabIndex = 13;
            this.dealerCardBox2.TabStop = false;
            // 
            // dealerCardBox3
            // 
            this.dealerCardBox3.Location = new System.Drawing.Point(851, 92);
            this.dealerCardBox3.Name = "dealerCardBox3";
            this.dealerCardBox3.Size = new System.Drawing.Size(100, 124);
            this.dealerCardBox3.TabIndex = 14;
            this.dealerCardBox3.TabStop = false;
            // 
            // dealerCardBox4
            // 
            this.dealerCardBox4.Location = new System.Drawing.Point(957, 92);
            this.dealerCardBox4.Name = "dealerCardBox4";
            this.dealerCardBox4.Size = new System.Drawing.Size(100, 124);
            this.dealerCardBox4.TabIndex = 15;
            this.dealerCardBox4.TabStop = false;
            // 
            // dealerCardBox1
            // 
            this.dealerCardBox1.Location = new System.Drawing.Point(745, 92);
            this.dealerCardBox1.Name = "dealerCardBox1";
            this.dealerCardBox1.Size = new System.Drawing.Size(100, 124);
            this.dealerCardBox1.TabIndex = 16;
            this.dealerCardBox1.TabStop = false;
            // 
            // dealerCardBox5
            // 
            this.dealerCardBox5.Location = new System.Drawing.Point(1063, 92);
            this.dealerCardBox5.Name = "dealerCardBox5";
            this.dealerCardBox5.Size = new System.Drawing.Size(100, 124);
            this.dealerCardBox5.TabIndex = 17;
            this.dealerCardBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack.Properties.Resources.Copilot_20250707_100128;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dealerCardBox5);
            this.Controls.Add(this.dealerCardBox1);
            this.Controls.Add(this.dealerCardBox4);
            this.Controls.Add(this.dealerCardBox3);
            this.Controls.Add(this.dealerCardBox2);
            this.Controls.Add(this.playerCardBox5);
            this.Controls.Add(this.playerCardBox1);
            this.Controls.Add(this.playerCardBox2);
            this.Controls.Add(this.playerCardBox4);
            this.Controls.Add(this.playerCardBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardBox5)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox playerCardBox3;
        private System.Windows.Forms.PictureBox playerCardBox4;
        private System.Windows.Forms.PictureBox playerCardBox2;
        private System.Windows.Forms.PictureBox playerCardBox1;
        private System.Windows.Forms.PictureBox playerCardBox5;
        private System.Windows.Forms.PictureBox dealerCardBox2;
        private System.Windows.Forms.PictureBox dealerCardBox3;
        private System.Windows.Forms.PictureBox dealerCardBox4;
        private System.Windows.Forms.PictureBox dealerCardBox1;
        private System.Windows.Forms.PictureBox dealerCardBox5;
    }
}

