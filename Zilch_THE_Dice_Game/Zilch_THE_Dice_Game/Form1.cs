﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zilch_Dice_Game
{
    public partial class Form1 : Form    // AKA: the View
    {
		Dice myDice;
		private PictureBox[] diceBoxes;
		Image[] dicePics;
		int[] diceVals;

        public Form1()
        {
            InitializeComponent();
			diceBoxes = new PictureBox[6];
			diceBoxes[0] = picDice1;
			diceBoxes[1] = picDice2;
			diceBoxes[2] = picDice3;
			diceBoxes[3] = picDice4;
			diceBoxes[4] = picDice5;
			diceBoxes[5] = picDice6;
            keep1Btn.Enabled = false;
            keep2Btn.Enabled = false;
            keep3Btn.Enabled = false;
            keep4Btn.Enabled = false;
            keep5Btn.Enabled = false;
            keep6Btn.Enabled = false;
            dicePics = new Image[6];
			diceVals = new int[6];
			myDice = new Dice();
        }

		private void btnDiceRoll_Click(object sender, EventArgs e) {
			messageLabel.Text = "";
			diceVals = myDice.RollDice();                   // Rolls the dice, returns array of dice results (ints)
			dicePics = myDice.GetDiceImg(diceVals);         // Gets the images for the imageboxes
			for (int i = 0; i < 6; i++) {
				diceBoxes[i].Image = dicePics[i];
			}    
		}

        private void keep1Btn_Click(object sender, EventArgs e)
        {

        }

        private void keep2Btn_Click(object sender, EventArgs e)
        {

        }

        private void keep3Btn_Click(object sender, EventArgs e)
        {

        }

        private void keep4Btn_Click(object sender, EventArgs e)
        {

        }

        private void keep5Btn_Click(object sender, EventArgs e)
        {

        }

        private void keep6Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
