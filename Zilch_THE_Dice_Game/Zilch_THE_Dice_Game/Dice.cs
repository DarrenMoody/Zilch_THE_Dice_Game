using System;
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
	public class Dice {

		// Global project variables
		public static int[] diceValues;
		public static Image[] dicePics;
		public static bool[] on;		// true = dice kept, false = dice not kept
		
		// class constant variables
		const int DICE_MAX = 6;         // Declare const int for dice number

		Timer[] timers = Form1.timers;
		Button[] keepBtns = Form1.keepBtns;
		Image[] diceOnPics;
		// public variables
		public Random random;         // Declare variable for a random number
		public Scoring score;
		


		// The Dice() Constructor
		// Purpose: Initialize data
		// Parameters: None
		// Returns: None
		public Dice() {
			on = new bool[6] { false, false, false, false, false, false };
			diceValues = new int[6] { 0, 0, 0, 0, 0, 0 };
			dicePics = new Image[6] { Properties.Resources.Dice1, Properties.Resources.Dice2,
										Properties.Resources.Dice3, Properties.Resources.Dice4,
										Properties.Resources.Dice5, Properties.Resources.Dice6 };
			diceOnPics = new Image[6] {Properties.Resources.Dice1On, Properties.Resources.Dice2On,
										Properties.Resources.Dice3On, Properties.Resources.Dice4On,
										Properties.Resources.Dice5On, Properties.Resources.Dice6On };
			score = new Scoring();
			random = new Random();
		}

		// The keep() method
		// Purpose: controls keep dice button functionality (highlight/remove highlight)
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

		}

		// The RollDice() method
		// Purpose: Gets Value of dice, counts number of each value, sets images on form1 picture boxes
		// Parameters: None
		// Returns: int[] dice values
		public int[] RollDice(PictureBox[] pb) { // SETS COUNTERS HERE
			
			for (int i = 0; i < DICE_MAX; i++) {
				if (on[i] == false) {
					Form1.timers[i].Stop();
					diceValues[i] = random.Next(0, DICE_MAX);
					Scoring.diceCounter[diceValues[i]]++;
					pb[i].Image = dicePics[diceValues[i]];
				}
            }
			enableKeepers();
			score.scoringTraverse();
			Form1.btnRoll.Enabled = true;
			return diceValues;
		}

		public void enableKeepers() {
			for(int i = 0; i < 6; i++) {
				if (on[i] == false)
					keepBtns[i].Enabled = true;
			}
		}

		public void timerTick(int idx) {
			int randomDieVal = random.Next(0, DICE_MAX);
			for (int i = 0; i < 6; i++) {
				if (randomDieVal == i) {
					Form1.diceBoxes[idx].Image = dicePics[i];
				}
			}
		}
	}
}
