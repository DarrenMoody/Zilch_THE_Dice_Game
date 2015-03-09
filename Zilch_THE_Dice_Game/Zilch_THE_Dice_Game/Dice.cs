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
        private Image[] dicePics;
        private int[] dice = { 1, 2, 3, 4, 5, 6 };    // Declare ints for dice 1 and dice 1 
        private Random randomNum;         // Declare variable for a random number
        const int DICE_MAX = 6;         // Declare const int for dice number

        // The Dice() Constructor
        // Purpose: Initialize data
        // Parameters: None
        // Returns: None
        public Dice()
        {
            randomNum = new Random();
        }

        // The RollDice() method
        // Purpose: Initialize data
        // Parameters: None
        // Returns: None
        public void RollDice()
        {
            for (int i = 0; i < DICE_MAX; i++)
            {
                dice[i] = randomNum.Next(1, DICE_MAX + 1);
            }
        }

        // The GetDice() method
        // Purpose: Gets the strings to make the dice in text boxes
        // Parameters: 2 strings passed by reference
        // Returns: None
        public void GetDice(ref string str1, ref string str2)
        {
            for (int i = 0; i < DICE_MAX; i++)
            {
                //str1 = MakeDice(dice[i]);
            }
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

        // The diceImage() method
        // Purpose: returns an image to match dice value
        // Parameters: die value
        // Returns: dice image
        public Image diceImage(int diceNum)
        {
            return dicePics[diceNum - 1];
        }
    }
}
