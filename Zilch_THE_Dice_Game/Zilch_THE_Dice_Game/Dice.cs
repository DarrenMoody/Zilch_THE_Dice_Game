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

		// class constant variables
		const int DICE_MAX = 6;         // Declare const int for dice number

		// public variables
		public Random random;         // Declare variable for a random number

		


		// The Dice() Constructor
		// Purpose: Initialize data
		// Parameters: None
		// Returns: None
		public Dice() {
			
			diceValues = new int[6] { 0, 0, 0, 0, 0, 0 };
			dicePics = new Image[6] { Properties.Resources.Dice1, Properties.Resources.Dice2,
										Properties.Resources.Dice3, Properties.Resources.Dice4,
										Properties.Resources.Dice5, Properties.Resources.Dice6 };
			random = new Random();
		}

		// The RollDice() method
		// Purpose: Gets Value of dice, counts number of each value, sets images on form1 picture boxes
		// Parameters: None
		// Returns: int[] dice values
		public int[] RollDice(PictureBox[] pb) {
			for (int i = 0; i < DICE_MAX; i++) {
				diceValues[i] = random.Next(0, DICE_MAX);
				Scoring.diceCounter[diceValues[i]]++;
				pb[i].Image = dicePics[diceValues[i]];
            }
			return diceValues;
		}
	}
}
