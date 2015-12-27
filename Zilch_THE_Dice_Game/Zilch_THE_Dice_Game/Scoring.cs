using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zilch_Dice_Game {


	public class Scoring {
		Dice dice;
		bool[] on;
		Image[] diceOnPics;


		public Scoring() {
			on = new bool[6] { false, false, false, false, false, false };
			diceOnPics = new Image[6] {Properties.Resources.Dice1On, Properties.Resources.Dice2On,
										Properties.Resources.Dice3On, Properties.Resources.Dice4On,
										Properties.Resources.Dice5On, Properties.Resources.Dice6On };
		}

		public void keep(int btnNum, PictureBox[] diceBoxes) {

			for (int i = 0; i < 6; i++) {
				if (btnNum == i && on[i] == false) { // if not on get on pic
					diceBoxes[i].Image = diceOnPics[Dice.diceValues[i]];
					on[i] = true;
				} else if (btnNum == i && on[i] == true) { // if on, go back to off pic
					diceBoxes[i].Image = Dice.dicePics[Dice.diceValues[i]];
					on[i] = false;
				}
			}

			/*if (dieOne == 1 && first == true) {
				die1Pic.Image = Properties.Resources.Die_1;
				first = false;
			} else if (dieOne == 2 && first == true) {
				die1Pic.Image = Properties.Resources.Die_2;
				first = false;
			} else if (dieOne == 3 && first == true) {
				die1Pic.Image = Properties.Resources.Die_3;
				first = false;
			} else if (dieOne == 4 && first == true) {
				die1Pic.Image = Properties.Resources.Die_4;
				first = false;
			} else if (dieOne == 5 && first == true) {
				die1Pic.Image = Properties.Resources.Die_5;
				first = false;
			} else if (dieOne == 6 && first == true) {
				die1Pic.Image = Properties.Resources.Die_6;
				first = false;
			} else if (dieOne == 1 && first == false) {
				die1Pic.Image = Properties.Resources.Lit_Die_1;
				first = true;
			} else if (dieOne == 2 && first == false) {
				die1Pic.Image = Properties.Resources.Lit_Die_2;
				first = true;
			} else if (dieOne == 3 && first == false) {
				die1Pic.Image = Properties.Resources.Lit_Die_3;
				first = true;
			} else if (dieOne == 4 && first == false) {
				die1Pic.Image = Properties.Resources.Lit_Die_4;
				first = true;
			} else if (dieOne == 5 && first == false) {
				die1Pic.Image = Properties.Resources.Lit_Die_5;
				first = true;
			} else if (dieOne == 6 && first == false) {
				die1Pic.Image = Properties.Resources.Lit_Die_6;
				first = true;
			}*/
		}
	}
}
