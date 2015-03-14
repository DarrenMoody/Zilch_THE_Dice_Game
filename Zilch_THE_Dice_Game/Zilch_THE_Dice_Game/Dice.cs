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
    class Dice
    {
		static string newLine = System.Environment.NewLine;
        private Image[] dicePics;
        private int[] dice; 
        private Random randomNum;         // Declare variable for a random number
        const int DICE_MAX = 6;         // Declare const int for dice number
		private string[] TEXT_DICE = {newLine + " l ",                    // If rolls one
                                       "l  " + newLine + newLine + "  l",    // Two
                                       "l  " + newLine + " l " + newLine + "  l", // Three
                                       "l l" + newLine + newLine + "l l",  // Four
                                       "l l" + newLine + " l " + newLine + "l l",  // Five
                                       "l l" + newLine + "l l" + newLine + "l l"  // Six
                                     };
        // The Dice() Constructor
        // Purpose: Initialize data
        // Parameters: None
        // Returns: None
        public Dice()
        {
			dice = new int[6];
			dicePics = new Image[6];
			dicePics[0] = Properties.Resources.Dice1;
			dicePics[1] = Properties.Resources.Dice2;
			dicePics[2] = Properties.Resources.Dice3;
			dicePics[3] = Properties.Resources.Dice4;
			dicePics[4] = Properties.Resources.Dice5;
			dicePics[5] = Properties.Resources.Dice6;
            randomNum = new Random();
        }

        // The RollDice() method
        // Purpose: Initialize data
        // Parameters: None
        // Returns: None
        public int[] RollDice()
        {
            for (int i = 0; i < DICE_MAX; i++)
            {
                dice[i] = randomNum.Next(1, DICE_MAX + 1);
            }
			return dice;
        }

        // The GetDice() method
        // Purpose: Returns the diceImages for the image boxes
        // Parameters: integer array
        // Returns: None
        public Image[] GetDiceImg(int[] dice)
        {
			Image[] temp = new Image[6];
            for (int i = 0; i < 6; i++)
            {
				temp[i] = dicePics[dice[i] - 1]; 
            }
			return temp;
        }

        // The triple() method
        // Purpose: Test to see if there are three of same dice value
        // Parameters: None
        // Returns: True if there is a triple, else false
        public bool triple()
        {
            return true;
        }

        // The ones() method
        // Purpose: Test to see if dice are 1s
        // Defines how to treat 1s in scoring
        // Parameters: None
        // Returns: True if dice is 1, else false
        public bool ones()
        {
            return true;
        }

        // The fives() method
        // Purpose: Test to see if dice are 5s
        //          Defines how to treat 5s in scoring
        // Parameters: None
        // Returns: True if dice is 5, else false
        public bool fives()
        {
            return true;
        }
    }
}
