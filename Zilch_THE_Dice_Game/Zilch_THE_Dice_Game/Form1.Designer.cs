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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bankBtn = new System.Windows.Forms.Button();
			this.rollBtn = new System.Windows.Forms.Button();
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
			this.btnPoints5 = new System.Windows.Forms.Button();
			this.btnPoints4 = new System.Windows.Forms.Button();
			this.btnPoints3 = new System.Windows.Forms.Button();
			this.btnPoints2 = new System.Windows.Forms.Button();
			this.btnPoints1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rulesOfPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtBoxTurnPoints = new System.Windows.Forms.TextBox();
			this.txtBoxP1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBoxBankedPoints = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.Timer3 = new System.Windows.Forms.Timer(this.components);
			this.Timer4 = new System.Windows.Forms.Timer(this.components);
			this.Timer5 = new System.Windows.Forms.Timer(this.components);
			this.Timer6 = new System.Windows.Forms.Timer(this.components);
			this.DiceTimer = new System.Windows.Forms.Timer(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxP2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picDice6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bankBtn
			// 
			this.bankBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bankBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
			this.bankBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
			this.bankBtn.Font = new System.Drawing.Font("Magneto", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bankBtn.Location = new System.Drawing.Point(346, 578);
			this.bankBtn.Name = "bankBtn";
			this.bankBtn.Size = new System.Drawing.Size(222, 67);
			this.bankBtn.TabIndex = 13;
			this.bankBtn.Text = "Bank Points and\r\nEnd Turn";
			this.bankBtn.UseVisualStyleBackColor = true;
			this.bankBtn.Click += new System.EventHandler(this.bankBtn_Click);
			// 
			// rollBtn
			// 
			this.rollBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rollBtn.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rollBtn.Location = new System.Drawing.Point(356, 262);
			this.rollBtn.Name = "rollBtn";
			this.rollBtn.Size = new System.Drawing.Size(212, 54);
			this.rollBtn.TabIndex = 12;
			this.rollBtn.Text = "Roll the Dice!";
			this.rollBtn.UseVisualStyleBackColor = true;
			this.rollBtn.Click += new System.EventHandler(this.btnDiceRoll_Click);
			// 
			// messageLabel
			// 
			this.messageLabel.AutoSize = true;
			this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageLabel.Location = new System.Drawing.Point(846, 36);
			this.messageLabel.MaximumSize = new System.Drawing.Size(150, 50);
			this.messageLabel.MinimumSize = new System.Drawing.Size(150, 50);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(150, 50);
			this.messageLabel.TabIndex = 15;
			this.messageLabel.Text = "Zilch! THE Dice Game";
			this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// keep4Btn
			// 
			this.keep4Btn.AutoSize = true;
			this.keep4Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.keep4Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.keep4Btn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keep4Btn.Location = new System.Drawing.Point(406, 212);
			this.keep4Btn.Name = "keep4Btn";
			this.keep4Btn.Size = new System.Drawing.Size(79, 27);
			this.keep4Btn.TabIndex = 55;
			this.keep4Btn.Text = "Keep Die 4";
			this.keep4Btn.UseVisualStyleBackColor = true;
			this.keep4Btn.Click += new System.EventHandler(this.keep4Btn_Click);
			// 
			// keep2Btn
			// 
			this.keep2Btn.AutoSize = true;
			this.keep2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.keep2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.keep2Btn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keep2Btn.Location = new System.Drawing.Point(193, 212);
			this.keep2Btn.Name = "keep2Btn";
			this.keep2Btn.Size = new System.Drawing.Size(79, 27);
			this.keep2Btn.TabIndex = 54;
			this.keep2Btn.Text = "Keep Die 2";
			this.keep2Btn.UseVisualStyleBackColor = true;
			this.keep2Btn.Click += new System.EventHandler(this.keep2Btn_Click);
			// 
			// keep6Btn
			// 
			this.keep6Btn.AutoSize = true;
			this.keep6Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.keep6Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.keep6Btn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keep6Btn.Location = new System.Drawing.Point(618, 212);
			this.keep6Btn.Name = "keep6Btn";
			this.keep6Btn.Size = new System.Drawing.Size(79, 27);
			this.keep6Btn.TabIndex = 53;
			this.keep6Btn.Text = "Keep Die 6";
			this.keep6Btn.UseVisualStyleBackColor = true;
			this.keep6Btn.Click += new System.EventHandler(this.keep6Btn_Click);
			// 
			// keep5Btn
			// 
			this.keep5Btn.AutoSize = true;
			this.keep5Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.keep5Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.keep5Btn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keep5Btn.Location = new System.Drawing.Point(512, 212);
			this.keep5Btn.Name = "keep5Btn";
			this.keep5Btn.Size = new System.Drawing.Size(79, 27);
			this.keep5Btn.TabIndex = 52;
			this.keep5Btn.Text = "Keep Die 5";
			this.keep5Btn.UseVisualStyleBackColor = true;
			this.keep5Btn.Click += new System.EventHandler(this.keep5Btn_Click);
			// 
			// keep3Btn
			// 
			this.keep3Btn.AutoSize = true;
			this.keep3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.keep3Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.keep3Btn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keep3Btn.Location = new System.Drawing.Point(299, 212);
			this.keep3Btn.Name = "keep3Btn";
			this.keep3Btn.Size = new System.Drawing.Size(79, 27);
			this.keep3Btn.TabIndex = 51;
			this.keep3Btn.Text = "Keep Die 3";
			this.keep3Btn.UseVisualStyleBackColor = true;
			this.keep3Btn.Click += new System.EventHandler(this.keep3Btn_Click);
			// 
			// keep1Btn
			// 
			this.keep1Btn.AutoSize = true;
			this.keep1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.keep1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.keep1Btn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keep1Btn.Location = new System.Drawing.Point(87, 212);
			this.keep1Btn.Name = "keep1Btn";
			this.keep1Btn.Size = new System.Drawing.Size(79, 27);
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
			// btnPoints5
			// 
			this.btnPoints5.BackColor = System.Drawing.SystemColors.WindowText;
			this.btnPoints5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPoints5.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
			this.btnPoints5.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPoints5.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnPoints5.Location = new System.Drawing.Point(45, 460);
			this.btnPoints5.Name = "btnPoints5";
			this.btnPoints5.Size = new System.Drawing.Size(246, 40);
			this.btnPoints5.TabIndex = 60;
			this.btnPoints5.Text = "btnPoints5";
			this.btnPoints5.UseVisualStyleBackColor = false;
			this.btnPoints5.Click += new System.EventHandler(this.btnPoints5_Click);
			// 
			// btnPoints4
			// 
			this.btnPoints4.BackColor = System.Drawing.SystemColors.WindowText;
			this.btnPoints4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPoints4.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
			this.btnPoints4.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPoints4.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnPoints4.Location = new System.Drawing.Point(45, 414);
			this.btnPoints4.Name = "btnPoints4";
			this.btnPoints4.Size = new System.Drawing.Size(246, 40);
			this.btnPoints4.TabIndex = 59;
			this.btnPoints4.Text = "btnPoints4";
			this.btnPoints4.UseVisualStyleBackColor = false;
			this.btnPoints4.Click += new System.EventHandler(this.btnPoints4_Click);
			// 
			// btnPoints3
			// 
			this.btnPoints3.BackColor = System.Drawing.SystemColors.WindowText;
			this.btnPoints3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPoints3.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
			this.btnPoints3.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPoints3.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnPoints3.Location = new System.Drawing.Point(45, 368);
			this.btnPoints3.Name = "btnPoints3";
			this.btnPoints3.Size = new System.Drawing.Size(246, 40);
			this.btnPoints3.TabIndex = 58;
			this.btnPoints3.Text = "btnPoints3";
			this.btnPoints3.UseVisualStyleBackColor = false;
			this.btnPoints3.Click += new System.EventHandler(this.btnPoints3_Click);
			// 
			// btnPoints2
			// 
			this.btnPoints2.BackColor = System.Drawing.SystemColors.WindowText;
			this.btnPoints2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPoints2.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
			this.btnPoints2.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPoints2.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnPoints2.Location = new System.Drawing.Point(45, 322);
			this.btnPoints2.Name = "btnPoints2";
			this.btnPoints2.Size = new System.Drawing.Size(246, 40);
			this.btnPoints2.TabIndex = 57;
			this.btnPoints2.Text = "btnPoints2";
			this.btnPoints2.UseVisualStyleBackColor = false;
			this.btnPoints2.Click += new System.EventHandler(this.btnPoints2_Click);
			// 
			// btnPoints1
			// 
			this.btnPoints1.BackColor = System.Drawing.SystemColors.WindowText;
			this.btnPoints1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPoints1.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
			this.btnPoints1.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPoints1.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnPoints1.Location = new System.Drawing.Point(45, 276);
			this.btnPoints1.Name = "btnPoints1";
			this.btnPoints1.Size = new System.Drawing.Size(246, 40);
			this.btnPoints1.TabIndex = 56;
			this.btnPoints1.Text = "btnPoints1";
			this.btnPoints1.UseVisualStyleBackColor = false;
			this.btnPoints1.Click += new System.EventHandler(this.btnPoints1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip1.TabIndex = 61;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			// 
			// saveGameToolStripMenuItem
			// 
			this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
			this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.saveGameToolStripMenuItem.Text = "Open Game";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.exitToolStripMenuItem.Text = "Save Game";
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
			this.exitToolStripMenuItem1.Text = "Exit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesOfPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// rulesOfPlayToolStripMenuItem
			// 
			this.rulesOfPlayToolStripMenuItem.Name = "rulesOfPlayToolStripMenuItem";
			this.rulesOfPlayToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.rulesOfPlayToolStripMenuItem.Text = "Rules of Play";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// txtBoxTurnPoints
			// 
			this.txtBoxTurnPoints.BackColor = System.Drawing.SystemColors.WindowText;
			this.txtBoxTurnPoints.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtBoxTurnPoints.Font = new System.Drawing.Font("Magneto", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxTurnPoints.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtBoxTurnPoints.Location = new System.Drawing.Point(368, 377);
			this.txtBoxTurnPoints.Name = "txtBoxTurnPoints";
			this.txtBoxTurnPoints.Size = new System.Drawing.Size(190, 66);
			this.txtBoxTurnPoints.TabIndex = 62;
			this.txtBoxTurnPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtBoxP1
			// 
			this.txtBoxP1.BackColor = System.Drawing.SystemColors.WindowText;
			this.txtBoxP1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtBoxP1.Font = new System.Drawing.Font("Magneto", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxP1.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtBoxP1.Location = new System.Drawing.Point(780, 122);
			this.txtBoxP1.Name = "txtBoxP1";
			this.txtBoxP1.Size = new System.Drawing.Size(150, 30);
			this.txtBoxP1.TabIndex = 63;
			this.txtBoxP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.WindowText;
			this.label1.Font = new System.Drawing.Font("Magneto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(777, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 18);
			this.label1.TabIndex = 64;
			this.label1.Text = "Player 1 Total";
			// 
			// txtBoxBankedPoints
			// 
			this.txtBoxBankedPoints.BackColor = System.Drawing.SystemColors.WindowText;
			this.txtBoxBankedPoints.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtBoxBankedPoints.Font = new System.Drawing.Font("Magneto", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxBankedPoints.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtBoxBankedPoints.Location = new System.Drawing.Point(368, 506);
			this.txtBoxBankedPoints.MaximumSize = new System.Drawing.Size(190, 66);
			this.txtBoxBankedPoints.MinimumSize = new System.Drawing.Size(190, 66);
			this.txtBoxBankedPoints.Name = "txtBoxBankedPoints";
			this.txtBoxBankedPoints.Size = new System.Drawing.Size(190, 66);
			this.txtBoxBankedPoints.TabIndex = 65;
			this.txtBoxBankedPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Image = global::Zilch_Dice_Game.Properties.Resources.ThisRollsPoints;
			this.label2.Location = new System.Drawing.Point(297, 337);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(322, 37);
			this.label2.TabIndex = 66;
			// 
			// Timer1
			// 
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// Timer2
			// 
			this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// Timer3
			// 
			this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
			// 
			// Timer4
			// 
			this.Timer4.Tick += new System.EventHandler(this.Timer4_Tick);
			// 
			// Timer5
			// 
			this.Timer5.Tick += new System.EventHandler(this.Timer5_Tick);
			// 
			// Timer6
			// 
			this.Timer6.Tick += new System.EventHandler(this.Timer6_Tick);
			// 
			// DiceTimer
			// 
			this.DiceTimer.Interval = 1000;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.WindowText;
			this.label4.Font = new System.Drawing.Font("Magneto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(777, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 18);
			this.label4.TabIndex = 69;
			this.label4.Text = "Player 2 Total";
			// 
			// textBoxP2
			// 
			this.textBoxP2.BackColor = System.Drawing.SystemColors.WindowText;
			this.textBoxP2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBoxP2.Font = new System.Drawing.Font("Magneto", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxP2.ForeColor = System.Drawing.Color.OrangeRed;
			this.textBoxP2.Location = new System.Drawing.Point(780, 176);
			this.textBoxP2.Name = "textBoxP2";
			this.textBoxP2.Size = new System.Drawing.Size(150, 30);
			this.textBoxP2.TabIndex = 68;
			this.textBoxP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Image = global::Zilch_Dice_Game.Properties.Resources.YourBankedPoints;
			this.label3.Location = new System.Drawing.Point(297, 466);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(322, 37);
			this.label3.TabIndex = 70;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Image = global::Zilch_Dice_Game.Properties.Resources.die6;
			this.label6.Location = new System.Drawing.Point(607, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 43);
			this.label6.TabIndex = 76;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Image = global::Zilch_Dice_Game.Properties.Resources.die5;
			this.label5.Location = new System.Drawing.Point(501, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 43);
			this.label5.TabIndex = 75;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Image = global::Zilch_Dice_Game.Properties.Resources.die4;
			this.label7.Location = new System.Drawing.Point(393, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 43);
			this.label7.TabIndex = 74;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Image = global::Zilch_Dice_Game.Properties.Resources.die3;
			this.label8.Location = new System.Drawing.Point(286, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 43);
			this.label8.TabIndex = 73;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Image = global::Zilch_Dice_Game.Properties.Resources.die2;
			this.label9.Location = new System.Drawing.Point(178, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 43);
			this.label9.TabIndex = 72;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.Location = new System.Drawing.Point(73, 62);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 43);
			this.label10.TabIndex = 71;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Zilch_Dice_Game.Properties.Resources.diceBack;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxP2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBoxBankedPoints);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBoxP1);
			this.Controls.Add(this.txtBoxTurnPoints);
			this.Controls.Add(this.btnPoints5);
			this.Controls.Add(this.btnPoints4);
			this.Controls.Add(this.btnPoints3);
			this.Controls.Add(this.btnPoints2);
			this.Controls.Add(this.btnPoints1);
			this.Controls.Add(this.keep4Btn);
			this.Controls.Add(this.keep2Btn);
			this.Controls.Add(this.keep6Btn);
			this.Controls.Add(this.keep5Btn);
			this.Controls.Add(this.keep3Btn);
			this.Controls.Add(this.keep1Btn);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.bankBtn);
			this.Controls.Add(this.rollBtn);
			this.Controls.Add(this.picDice6);
			this.Controls.Add(this.picDice5);
			this.Controls.Add(this.picDice4);
			this.Controls.Add(this.picDice3);
			this.Controls.Add(this.picDice2);
			this.Controls.Add(this.picDice1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(1024, 768);
			this.MinimumSize = new System.Drawing.Size(1024, 580);
			this.Name = "Form1";
			this.Text = "Zilch - The Dice Game";
			((System.ComponentModel.ISupportInitialize)(this.picDice6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button bankBtn;
		private System.Windows.Forms.Button rollBtn;
		private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button keep4Btn;
        private System.Windows.Forms.Button keep2Btn;
        private System.Windows.Forms.Button keep6Btn;
        private System.Windows.Forms.Button keep5Btn;
        private System.Windows.Forms.Button keep3Btn;
        private System.Windows.Forms.Button keep1Btn;
		private System.Windows.Forms.Button btnPoints5;
		private System.Windows.Forms.Button btnPoints4;
		private System.Windows.Forms.Button btnPoints3;
		private System.Windows.Forms.Button btnPoints2;
		private System.Windows.Forms.Button btnPoints1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rulesOfPlayToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TextBox txtBoxTurnPoints;
		private System.Windows.Forms.TextBox txtBoxP1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBoxBankedPoints;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer Timer1;
		private System.Windows.Forms.Timer Timer2;
		private System.Windows.Forms.Timer Timer3;
		private System.Windows.Forms.Timer Timer4;
		private System.Windows.Forms.Timer Timer5;
		private System.Windows.Forms.Timer Timer6;
		private System.Windows.Forms.Timer DiceTimer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxP2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
	}
}

