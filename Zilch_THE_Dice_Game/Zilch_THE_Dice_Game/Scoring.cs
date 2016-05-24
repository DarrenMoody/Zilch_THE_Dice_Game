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

		// Global project variables
		public static int[] diceCounter;

		// Other Class objects
		Dice dice;

		// Other Arrays
		int[] numClicks;
		//Button[] btnPoints = Form1.btnPoints;
		//Button[] keepBtns = Form1.keepBtns;
		//int[] diceValues = Dice.diceValues;
		public int[] scorePos;
		public int[,] btnPointsCheck;
		bool[] clicksOdd;
		public int totalTurnScore;
		private int totalGameScore = 0;
		private int[] playerScore = new int[2];
		bool[] printed = new bool[16];
		// Boolean variables declared for testing the state of a set of dice
		bool sixKind = false, fiveKind = false, fourKind = false, threeKind = false,
			 second3Kind = false, straight = false, fullHouse = false, threePair = false,
			 sixOnes = false, fiveOnes = false, fourOnes = false, threeOnes = false,
			 twoOnes = false, oneOne = false, twoFives = false, oneFive = false, zilch = false;
		// Integer variables declared for scoring and displaying buttons for a set of dice
		int pointsStraight = 1500, pointsFHouse = 750, points3Pair = 1500,
			points23Kind = 0, points6Kind = 1500, points5Kind = 0, points4Kind = 0, points3Kind = 0,
			pointsSixOnes = 2000, points5Ones = 1200, points4Ones = 1100, points3Ones = 1000,
			points2Ones = 200, points1One = 100, points2Fives = 100, points1Five = 50;
		// Integer variables declared to hold the dices face values for a 3-of-a-kind etc.
		int value6Kind = 0, value5Kind = 0, value4Kind = 0, value3Kind = 0, value23Kind = 0,
			fhVal2 = 0, fhVal1 = 0;


		public Scoring() {
			diceCounter = new int[6] { 0, 0, 0, 0, 0, 0 };
			numClicks = new int[5] { 0, 0, 0, 0, 0 };
			scorePos = new int[6] { 0, 0, 0, 0, 0, 0 };
			clicksOdd = new bool[5] { false, false, false, false, false };
			totalTurnScore = 0;
			// Used to enable auto-click of keep buttons involving a points set.
			btnPointsCheck = new int[6, 5];
		}

		// Name: The scoringTraverse() Method
		// Purpose: Traverses the dice values to find score types
		//          and assign them to one of the btnPoints1-5
		// Parameters: none
		// Returns: none
		// Note: This will be chopped into several smaller methods in future versions
		public void scoringTraverse() { // DARREN - ***********************

			/*  ************** SCORING POSSIBILITIES **************
            1.	Straight (dice = 1, 2, 3, 4, 5, 6) = 1500 pts.
            2.	THREE Pairs = 1500 pts.
                a.	SIX OF A KIND  can also be used for three pair
                	i.  Unless SIX OF A KIND is 1s, 2 sets of three 1s = 2000 pts.
                    Because ((three 1s = 1000) * 2) ----see 4a
            3.	FULL HOUSE (a 3-of-a-kind, and a pair) = 750 pts.
                a.	FOUR OF A KIND AND A PAIR CAN ALSO BE TAKEN AS FULL HOUSE
            4.	THREE OF A KIND = (dice value * 100) (e.g. 3 * 2s = 200 pts.)
                a.	Exception = Three 1s = 1000 pts.
                b.	For FOUR OF A KIND, FIVE OF A KIND, pts. = (dice value * 100) + 100 for each additional dice past THREE OF A KIND. 
                c.	SIX OF A KIND would also be THREE PAIRS = 1500 pts. 
                    i.	Unless SIX OF A KIND is 1s, 2 sets of three 1s = 2000 pts.
                    Because ((three 1s = 1000) * 2) ----see 4a
            5.	Lone ONEs = 100 pts each
            6.	Lone FIVES = 50 pts each
            7.	If nothing = ZILCH
            */

			for (int i = 0; i < diceCounter.Length; i++) {
				if (diceCounter[0] == 1 &&
					diceCounter[1] == 1 &&
					diceCounter[2] == 1 &&
					diceCounter[3] == 1 &&
					diceCounter[4] == 1 &&
					diceCounter[5] == 1) // One of each value, STRAIGHT
				{
					straight = true;
				} else if (diceCounter[i] == 2) {
					for (int j = i + 1; j < diceCounter.Length; j++) {
						if (diceCounter[j] == 2) {
							for (int k = j + 1; k < diceCounter.Length; k++) {
								if (diceCounter[k] == 2) // If two more pairs, three pair
									threePair = true;
							}
						}
					}
				} else if (diceCounter[i] == 3) // Three of one value
				  {
					threeKind = true;
					value3Kind = i + 1;
					fhVal1 = i + 1;
					points3Kind = value3Kind * 100; // Calc score of threeKind
					if (value3Kind == 1) // If 1s then threeOnes
					{
						threeOnes = true;
						threeKind = false;
					}
					for (int j = 0; j < diceCounter.Length; j++) {
						if (j != i) {
							if (diceCounter[j] == 2) // If a triple and a pair, fullHouse (750 pts)
							{
								fullHouse = true;
								fhVal2 = j + 1;
							} else if (diceCounter[j] == 3) // Or if another triple, still fullHouse
							  {                             // and also second3Kind  
								fullHouse = true;
								fhVal2 = j + 1;
								second3Kind = true;
								value23Kind = j + 1;
								points23Kind = value23Kind * 100; // Calc score of second3Kind
								if (value3Kind == 1) // Or if 1s then threeOnes instead (1000 pts)
								{
									threeOnes = true;
									second3Kind = false;
								}
							}
						}
					}
				} else if (diceCounter[i] == 4) // 4 of one value
				  {
					fourKind = true;
					value4Kind = i + 1;
					fhVal1 = i + 1;
					points4Kind = (value4Kind * 100) + (100 * 1); // Calc score of fourKind
					if (value4Kind == 1) // Or if 4 ones, fourOnes instead (1100 pts)
					{
						fourKind = false;
						fourOnes = true;
					}
					for (int j = 0; j < diceCounter.Length; j++) {
						if (diceCounter[j] == 2) // Full House if a pair also
						{
							fullHouse = true;
							fhVal2 = j;
							threePair = true; // Set of 4 and set of 2 can also count as threePair (1500 pts)
						}
					}
				} else if (diceCounter[i] == 5) // 5 of one value
				  {
					fiveKind = true;
					value5Kind = i + 1;
					points5Kind = (value5Kind * 100) + (100 * 2); // Calc score of fiveKind
					fullHouse = true; // 5 of a kind can also count as fullHouse (750 pts)
					if (value4Kind == 1) // Or if 5 ones, then fiveOnes instead (1200 pts)
					{
						fiveOnes = true;
						fiveKind = false;
					}
				} else if (diceCounter[i] == 6) // 6 of one value
				  {
					threePair = true; // threePair is always preferable (1500 pts)
					value6Kind = i + 1;
					if (value6Kind == 1) // Unless it's 6 ones, sixOnes instead (2000 pts)
					{
						//sixKind = false;
						sixOnes = true;
					}
				} else if (diceCounter[0] == 0 &&
						   diceCounter[4] == 0 &&
						   sixKind == false && fiveKind == false && fourKind == false &&
						   straight == false && fullHouse == false && threeKind == false &&
						   threePair == false && second3Kind == false) {   // Zilch! if there's nothing worth any points on a roll
					zilch = true;
				}
			}

			if (diceCounter[0] == 2) // Two ones
			{
				twoOnes = true;
			}
			if (diceCounter[0] == 1) // One one
			{
				oneOne = true;
			}
			if (diceCounter[4] == 2) // Two fives
			{
				twoFives = true;
			}
			if (diceCounter[4] == 1) // One five
			{
				oneFive = true;
			}
			// 2 ints needed for assigning fullHouse dice positions
			int fhPairCounter = 0, fhTripleCounter = 0;
			// (prob don't need this) int[] scoreType = new int[5];
			
			for (int i = 0; i < 16; i++) {
				printed[i] = false;
			}

			for (int i = 0; i < 6; i++) {
				if (zilch) {
					/*Form1.btnPoints[i].Enabled = true;
                    Form1.btnPoints[i].Visible = true;
                    Form1.btnPoints[i].Text = "ZILCH!";*/
					MessageBox.Show("ZILCH!\nYOU LOST IT ALL SUCKA!!!",
						"ZILCH! ZILCH! ZILCH! ZILCH! ZILCH! ZILCH! ZILCH!",
						MessageBoxButtons.OK, MessageBoxIcon.Stop);
					totalTurnScore = 0;
					Zilch();
					goto functionEnd;
				}
				if (printed[0] == false) // If this is false...
				{
					if (sixKind) {
						printed[0] = true; // Then 
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Six of a kind (" + points6Kind + ")"; // points6Kind = same as points3Pair (1500). 
						scorePos[i] = points6Kind;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == value6Kind) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}// Keeping it seperate in case sixKind is six 1s
				if (printed[1] == false) {
					if (sixOnes) {
						printed[1] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Two sets of three 1s (" + pointsSixOnes + ")";
						scorePos[i] = pointsSixOnes;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == 1) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[2] == false) {
					if (fullHouse) {
						printed[2] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Full House (" + pointsFHouse + ")";
						scorePos[i] = pointsFHouse;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == fhVal1) {
								if (fhTripleCounter < 3) {
									btnPointsCheck[j, i] = j + 1;
								}
								fhTripleCounter++;
							} else if (Dice.diceValues[j] == fhVal2) {
								if (fhPairCounter < 2) {
									btnPointsCheck[j, i] = j + 1;
								}
								fhPairCounter++;
							}
						}
						goto printing;
					}
				}
				if (printed[3] == false) {
					if (fiveKind) {
						printed[3] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Five of a kind (" + points5Kind + ")";
						scorePos[i] = points5Kind;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == value5Kind) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;

					}
				}
				if (printed[4] == false) {
					if (fiveOnes) {
						printed[4] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Five of a kind (" + points5Ones + ")";
						scorePos[i] = points5Ones;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == 1) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[5] == false) {
					if (fourKind) {
						printed[5] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Four of a kind (" + points4Kind + ")";
						scorePos[i] = points4Kind;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == value4Kind) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[6] == false) {
					if (fourOnes) {
						printed[6] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Four ones (" + points4Ones + ")";
						scorePos[i] = points4Ones;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == 1) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[7] == false) {
					if (threeKind) {
						printed[7] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Three of a kind (" + points3Kind + ")";
						scorePos[i] = points3Kind;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == value3Kind) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[8] == false) {
					if (second3Kind) {
						printed[8] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Three of a kind (" + points23Kind + ")";
						scorePos[i] = points23Kind;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == value23Kind) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[9] == false) {
					if (threeOnes) {
						printed[9] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Three Ones (" + points3Ones + ")";
						scorePos[i] = points3Ones;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == 1) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[10] == false) {
					if (twoOnes) {
						printed[10] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Two Ones (" + points2Ones + ")";
						scorePos[i] = points2Ones;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == 1) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[11] == false) {
					if (twoFives) {
						printed[11] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Two Fives (" + points2Fives + ")";
						scorePos[i] = points2Fives;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == 5) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[12] == false) {
					if (straight) {
						printed[12] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Straight (" + pointsStraight + ")";
						scorePos[i] = pointsStraight;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							btnPointsCheck[j, i] = j + 1;
						}
						goto printing;
					}
				}
				if (printed[13] == false) {
					if (oneOne) {
						printed[13] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "One 1 (" + points1One + ")";
						scorePos[i] = points1One;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == 1) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[14] == false) {
					if (oneFive) {
						printed[14] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "One Five (" + points1Five + ")";
						scorePos[i] = points1Five;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							if (Dice.diceValues[j] == 5) {
								btnPointsCheck[j, i] = j + 1;
							}
						}
						goto printing;
					}
				}
				if (printed[15] == false) {
					if (threePair) {
						printed[15] = true;
						Form1.btnPoints[i].Enabled = true;
						Form1.btnPoints[i].Visible = true;
						Form1.btnPoints[i].Text = "Three Pairs (" + points3Pair + ")";
						scorePos[i] = points3Pair;
						for (int j = 0; j < 6; j++) // Loop to assign positions of dice for one of btnPoints1-5
						{
							btnPointsCheck[j, i] = j + 1;
						}
						goto printing;
					}
				}
				printing:
				continue;
				functionEnd:
				break;
			}
		}

		public void btnPtsClick(int i) {
			numClicks[i]++;

			if (btnPointsCheck[0, i] == 1) {
				dice.keep(0);
			}
			if (btnPointsCheck[1, i] == 2) {
				dice.keep(1);
			}
			if (btnPointsCheck[2, i] == 3) {
				dice.keep(2);
			}
			if (btnPointsCheck[3, i] == 4) {
				dice.keep(3);
			}
			if (btnPointsCheck[4, i] == 5) {
				dice.keep(4);
			}
			if (btnPointsCheck[5, i] == 6) {
				dice.keep(5);
			}

			if (numClicks[i] % 2 == 1) {
				totalTurnScore += scorePos[i];
				clicksOdd[i] = true;
			} else if (numClicks[i] % 2 == 0) {
				totalTurnScore -= scorePos[i];
			}
			string outStr = string.Format("{0}", totalTurnScore);
			Form1.turnPtsBox.Text = outStr;
		}

		

		// Name: The Zilch() Method
		// Purpose: // ENDS TURN, RESETS EVERYTHING EXCEPT TOTAL GAME SCORE
		// Parameters: none
		// Returns: none
		// A Note: resetting all the form1 variables upon the end of player's turn
		// instead of creating a new form each time seems logical...
		// I want the main form1 to last for the lifetime of a game.
		private void Zilch() {
			Form1.zilcher.Play();
			resetTurn();
			resetPoints();
			totalTurnScore = 0;
			string outStr2 = string.Format("{0}", totalTurnScore);
			Form1.turnPtsBox.Text = "0";
			Form1.btnRoll.Enabled = true;
		}

		public void bank() {

			if (totalTurnScore >= 350) {
				totalGameScore += totalTurnScore;

				// Just testing output
				string outStr = string.Format(("{0}"), totalGameScore);
				Form1.bankedPtsBox.Text = outStr;
				totalTurnScore = 0;
				string outStr2 = string.Format("{0}", totalTurnScore);
				Form1.turnPtsBox.Text = outStr2;
			} else if (totalTurnScore < 350) {
				MessageBox.Show("You must have 350 points to Bank!");

			}

			if (totalGameScore >= 10000) {
				// "You're not a loser!!!"
				MessageBox.Show("WINNER!!!", "YOU REACHED 10,000 POINTS!!!\nYOU'RE NOT A LOSER!!!!!!!!!");
			}
			resetPoints();
			resetTurn();
			Form1.btnRoll.Enabled = true;
			Zilch();
		}


		/*public static int[] diceCounter;

		// Other Class objects
		Dice dice;

		// Other Arrays
		int[] numClicks;
		//Button[] btnPoints = Form1.btnPoints;
		//Button[] keepBtns = Form1.keepBtns;
		//int[] diceValues = Dice.diceValues;
		public int[] scorePos;
		public int[,] btnPointsCheck;
		bool[] clicksOdd;
		public int totalTurnScore;
		private int totalGameScore = 0;
		private int[] playerScore = new int[2];
		bool[] printed = new bool[16];*/


		// Name: The resetPoints() Method
		// Purpose: // RESETS EVERYTHING RELATED TO POINTS EXCEPT TOTAL GAME SCORE
		// Parameters: none
		// Returns: none
		public void resetPoints() // DARREN - ***********************
		{
			for (int i = 0; i < diceCounter.Length; i++) // resets 2D array
			{

				diceCounter[i] = 0;
				Dice.diceValues[i] = 0;
				scorePos[i] = 0;
			}
			for (int i = 0; i < 5; i++) { 
				for (int j = 0; j < 5; j++) {
					btnPointsCheck[i, j] = 0; // btnPointsCheck[ 6, 5 ]
				}
			}

			Form1.btnPoints[0].Enabled = false;
			Form1.btnPoints[1].Enabled = false;
			Form1.btnPoints[2].Enabled = false;
			Form1.btnPoints[3].Enabled = false;
			Form1.btnPoints[4].Enabled = false;
			Form1.btnPoints[0].Visible = false;
			Form1.btnPoints[1].Visible = false;
			Form1.btnPoints[2].Visible = false;
			Form1.btnPoints[3].Visible = false;
			Form1.btnPoints[4].Visible = false;

			sixKind = false; fiveKind = false; fourKind = false; threeKind = false;
			second3Kind = false; straight = false; fullHouse = false; threePair = false; sixOnes = false;
			fiveOnes = false; fourOnes = false; threeOnes = false; twoOnes = false;
			oneOne = false; twoFives = false; oneFive = false; zilch = false;

			value6Kind = 0; value5Kind = 0; value4Kind = 0; value3Kind = 0;
			value23Kind = 0; fhVal2 = 0; fhVal1 = 0;

			numClicks[0] = 0;
			numClicks[1] = 0;
			numClicks[2] = 0;
			numClicks[3] = 0;
			numClicks[4] = 0;

			for (int i = 0; i < 16; i++) {
				printed[i] = false;
			}
		}
		 
		public void resetTurn() {
			Form1.keepBtns[0].Enabled = false;
			Form1.keepBtns[1].Enabled = false;
			Form1.keepBtns[2].Enabled = false;
			Form1.keepBtns[3].Enabled = false;
			Form1.keepBtns[4].Enabled = false;
			Form1.keepBtns[5].Enabled = false;
			
			Dice.on[0] = false;
			Dice.on[1] = false;
			Dice.on[2] = false;
			Dice.on[3] = false;
			Dice.on[4] = false;
			Dice.on[5] = false;
			Form1.diceBoxes[0].Image = Properties.Resources.Blank_Die;
			Form1.diceBoxes[1].Image = Properties.Resources.Blank_Die;
			Form1.diceBoxes[2].Image = Properties.Resources.Blank_Die;
			Form1.diceBoxes[3].Image = Properties.Resources.Blank_Die;
			Form1.diceBoxes[4].Image = Properties.Resources.Blank_Die;
			Form1.diceBoxes[5].Image = Properties.Resources.Blank_Die;
			Dice.diceValues[0] = 0;
			Dice.diceValues[1] = 0;
			Dice.diceValues[2] = 0;
			Dice.diceValues[3] = 0;
			Dice.diceValues[4] = 0;
			Dice.diceValues[5] = 0;

			clicksOdd[0] = false;
			clicksOdd[1] = false;
			clicksOdd[2] = false;
			clicksOdd[3] = false;
			clicksOdd[4] = false;

		}
	} // end class Scoring
} // end namespace
