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
		public static int[] diceValues;
		public int[] diceCounter;
		// DEPRECATED - static string newLine = System.Environment.NewLine;
		public static Image[] dicePics;
		public Random random;         // Declare variable for a random number
		const int DICE_MAX = 6;         // Declare const int for dice number
										/*DEPRECATED-private string[] TEXT_DICE = {newLine + " l ",                    // If rolls one
																	   "l  " + newLine + newLine + "  l",    // Two
																	   "l  " + newLine + " l " + newLine + "  l", // Three
																	   "l l" + newLine + newLine + "l l",  // Four
																	   "l l" + newLine + " l " + newLine + "l l",  // Five
																	   "l l" + newLine + "l l" + newLine + "l l"  // Six
																	 };*/



		// The Dice() Constructor
		// Purpose: Initialize data
		// Parameters: None
		// Returns: None
		public Dice() {
			
			diceValues = new int[6] { 0, 0, 0, 0, 0, 0 };
			diceCounter = new int[6] { 0, 0, 0, 0, 0, 0 };
			dicePics = new Image[6] { Properties.Resources.Dice1, Properties.Resources.Dice2,
										Properties.Resources.Dice3, Properties.Resources.Dice4,
										Properties.Resources.Dice5, Properties.Resources.Dice6 };
			random = new Random();
		}

		private void setCounters(int[] diceValues) {

			for (int i = 0; i < DICE_MAX; i++) {
				
				/*
				switch () {
					case 1:
						diceCounter[0]++; // If randy = 1 adds one to ones
						break;
					case 2:
						diceCounter[1]++; // If randy = 2 adds one to twos
						break;
					case 3:
						diceCounter[2]++; // If randy = 3 adds one to threes
						break;
					case 4:
						diceCounter[3]++; // If randy = 4 adds one to fours
						break;
					case 5:
						diceCounter[4]++; // If randy = 5 adds one to fives
						break;
					case 6:
						diceCounter[5]++; // If randy = 6 adds one to sixes
						break;
				}
				*/
			}
		}
		// The RollDice() method
		// Purpose: Gets Value of dice, counts number of each value, sets images on form1 picture boxes
		// Parameters: None
		// Returns: int[] dice values
		public int[] RollDice(PictureBox[] pb) {
			for (int i = 0; i < DICE_MAX; i++) {
				diceValues[i] = random.Next(0, DICE_MAX);
				diceCounter[diceValues[i]]++;
				pb[i].Image = dicePics[diceValues[i]];
            }
			return diceValues;
		}
	}
}
