namespace Zilch_Dice_Game
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
            this.btnKeepScore = new System.Windows.Forms.Button();
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.keep4Btn = new System.Windows.Forms.Button();
            this.keep2Btn = new System.Windows.Forms.Button();
            this.keep6Btn = new System.Windows.Forms.Button();
            this.keep5Btn = new System.Windows.Forms.Button();
            this.keep3Btn = new System.Windows.Forms.Button();
            this.keep1Btn = new System.Windows.Forms.Button();
            this.picDice6 = new System.Windows.Forms.PictureBox();
            this.picDice5 = new System.Windows.Forms.PictureBox();
            this.picDice4 = new System.Windows.Forms.PictureBox();
            this.picDice3 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.picDice1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKeepScore
            // 
            this.btnKeepScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeepScore.Location = new System.Drawing.Point(331, 402);
            this.btnKeepScore.Name = "btnKeepScore";
            this.btnKeepScore.Size = new System.Drawing.Size(112, 40);
            this.btnKeepScore.TabIndex = 13;
            this.btnKeepScore.Text = "STOP: Bank Points";
            this.btnKeepScore.UseVisualStyleBackColor = true;
            // 
            // btnDiceRoll
            // 
            this.btnDiceRoll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiceRoll.Location = new System.Drawing.Point(288, 326);
            this.btnDiceRoll.Name = "btnDiceRoll";
            this.btnDiceRoll.Size = new System.Drawing.Size(206, 54);
            this.btnDiceRoll.TabIndex = 12;
            this.btnDiceRoll.Text = "Roll the Dice!";
            this.btnDiceRoll.UseVisualStyleBackColor = true;
            this.btnDiceRoll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(313, 29);
            this.messageLabel.MaximumSize = new System.Drawing.Size(150, 50);
            this.messageLabel.MinimumSize = new System.Drawing.Size(150, 50);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(150, 50);
            this.messageLabel.TabIndex = 15;
            this.messageLabel.Text = "Welcome to Zilch!";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keep4Btn
            // 
            this.keep4Btn.Location = new System.Drawing.Point(409, 212);
            this.keep4Btn.Name = "keep4Btn";
            this.keep4Btn.Size = new System.Drawing.Size(69, 23);
            this.keep4Btn.TabIndex = 55;
            this.keep4Btn.Text = "Keep Die 4";
            this.keep4Btn.UseVisualStyleBackColor = true;
            this.keep4Btn.Click += new System.EventHandler(this.keep4Btn_Click);
            // 
            // keep2Btn
            // 
            this.keep2Btn.Location = new System.Drawing.Point(196, 212);
            this.keep2Btn.Name = "keep2Btn";
            this.keep2Btn.Size = new System.Drawing.Size(69, 23);
            this.keep2Btn.TabIndex = 54;
            this.keep2Btn.Text = "Keep Die 2";
            this.keep2Btn.UseVisualStyleBackColor = true;
            this.keep2Btn.Click += new System.EventHandler(this.keep2Btn_Click);
            // 
            // keep6Btn
            // 
            this.keep6Btn.Location = new System.Drawing.Point(621, 212);
            this.keep6Btn.Name = "keep6Btn";
            this.keep6Btn.Size = new System.Drawing.Size(69, 23);
            this.keep6Btn.TabIndex = 53;
            this.keep6Btn.Text = "Keep Die 6";
            this.keep6Btn.UseVisualStyleBackColor = true;
            this.keep6Btn.Click += new System.EventHandler(this.keep6Btn_Click);
            // 
            // keep5Btn
            // 
            this.keep5Btn.Location = new System.Drawing.Point(515, 212);
            this.keep5Btn.Name = "keep5Btn";
            this.keep5Btn.Size = new System.Drawing.Size(69, 23);
            this.keep5Btn.TabIndex = 52;
            this.keep5Btn.Text = "Keep Die 5";
            this.keep5Btn.UseVisualStyleBackColor = true;
            this.keep5Btn.Click += new System.EventHandler(this.keep5Btn_Click);
            // 
            // keep3Btn
            // 
            this.keep3Btn.Location = new System.Drawing.Point(302, 212);
            this.keep3Btn.Name = "keep3Btn";
            this.keep3Btn.Size = new System.Drawing.Size(69, 23);
            this.keep3Btn.TabIndex = 51;
            this.keep3Btn.Text = "Keep Die 3";
            this.keep3Btn.UseVisualStyleBackColor = true;
            this.keep3Btn.Click += new System.EventHandler(this.keep3Btn_Click);
            // 
            // keep1Btn
            // 
            this.keep1Btn.Location = new System.Drawing.Point(90, 212);
            this.keep1Btn.Name = "keep1Btn";
            this.keep1Btn.Size = new System.Drawing.Size(69, 23);
            this.keep1Btn.TabIndex = 50;
            this.keep1Btn.Text = "Keep Die 1";
            this.keep1Btn.UseVisualStyleBackColor = true;
            this.keep1Btn.Click += new System.EventHandler(this.keep1Btn_Click);
            // 
            // picDice6
            // 
            this.picDice6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDice6.Image = global::Zilch_Dice_Game.Properties.Resources.Blank_Die;
            this.picDice6.Location = new System.Drawing.Point(606, 106);
            this.picDice6.MaximumSize = new System.Drawing.Size(100, 100);
            this.picDice6.MinimumSize = new System.Drawing.Size(100, 100);
            this.picDice6.Name = "picDice6";
            this.picDice6.Size = new System.Drawing.Size(100, 100);
            this.picDice6.TabIndex = 11;
            this.picDice6.TabStop = false;
            // 
            // picDice5
            // 
            this.picDice5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDice5.Image = global::Zilch_Dice_Game.Properties.Resources.Blank_Die;
            this.picDice5.Location = new System.Drawing.Point(500, 106);
            this.picDice5.MaximumSize = new System.Drawing.Size(100, 100);
            this.picDice5.MinimumSize = new System.Drawing.Size(100, 100);
            this.picDice5.Name = "picDice5";
            this.picDice5.Size = new System.Drawing.Size(100, 100);
            this.picDice5.TabIndex = 10;
            this.picDice5.TabStop = false;
            // 
            // picDice4
            // 
            this.picDice4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDice4.Image = global::Zilch_Dice_Game.Properties.Resources.Blank_Die;
            this.picDice4.Location = new System.Drawing.Point(394, 106);
            this.picDice4.MaximumSize = new System.Drawing.Size(100, 100);
            this.picDice4.MinimumSize = new System.Drawing.Size(100, 100);
            this.picDice4.Name = "picDice4";
            this.picDice4.Size = new System.Drawing.Size(100, 100);
            this.picDice4.TabIndex = 9;
            this.picDice4.TabStop = false;
            // 
            // picDice3
            // 
            this.picDice3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDice3.Image = global::Zilch_Dice_Game.Properties.Resources.Blank_Die;
            this.picDice3.Location = new System.Drawing.Point(288, 106);
            this.picDice3.MaximumSize = new System.Drawing.Size(100, 100);
            this.picDice3.MinimumSize = new System.Drawing.Size(100, 100);
            this.picDice3.Name = "picDice3";
            this.picDice3.Size = new System.Drawing.Size(100, 100);
            this.picDice3.TabIndex = 8;
            this.picDice3.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDice2.Image = global::Zilch_Dice_Game.Properties.Resources.Blank_Die;
            this.picDice2.Location = new System.Drawing.Point(182, 106);
            this.picDice2.MaximumSize = new System.Drawing.Size(100, 100);
            this.picDice2.MinimumSize = new System.Drawing.Size(100, 100);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(100, 100);
            this.picDice2.TabIndex = 7;
            this.picDice2.TabStop = false;
            // 
            // picDice1
            // 
            this.picDice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDice1.Image = global::Zilch_Dice_Game.Properties.Resources.Blank_Die;
            this.picDice1.Location = new System.Drawing.Point(76, 106);
            this.picDice1.MaximumSize = new System.Drawing.Size(100, 100);
            this.picDice1.MinimumSize = new System.Drawing.Size(100, 100);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(100, 100);
            this.picDice1.TabIndex = 6;
            this.picDice1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 556);
            this.Controls.Add(this.keep4Btn);
            this.Controls.Add(this.keep2Btn);
            this.Controls.Add(this.keep6Btn);
            this.Controls.Add(this.keep5Btn);
            this.Controls.Add(this.keep3Btn);
            this.Controls.Add(this.keep1Btn);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.btnKeepScore);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.picDice6);
            this.Controls.Add(this.picDice5);
            this.Controls.Add(this.picDice4);
            this.Controls.Add(this.picDice3);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Name = "Form1";
            this.Text = "Zilch - The Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.picDice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDice6;
        private System.Windows.Forms.PictureBox picDice5;
        private System.Windows.Forms.PictureBox picDice4;
        private System.Windows.Forms.PictureBox picDice3;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.Button btnKeepScore;
		private System.Windows.Forms.Button btnDiceRoll;
		private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button keep4Btn;
        private System.Windows.Forms.Button keep2Btn;
        private System.Windows.Forms.Button keep6Btn;
        private System.Windows.Forms.Button keep5Btn;
        private System.Windows.Forms.Button keep3Btn;
        private System.Windows.Forms.Button keep1Btn;
    }
}

