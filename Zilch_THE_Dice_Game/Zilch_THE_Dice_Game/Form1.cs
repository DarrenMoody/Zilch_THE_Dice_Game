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
	public partial class Form1 : Form {   // AKA: the View

		public Scoring score;
		public Dice dice;
		public PictureBox[] diceBoxes;
		public Image[] dicePics;
		public int[] diceVals;

		public Form1() {
			InitializeComponent();
			diceBoxes = new PictureBox[6] { picDice1, picDice2, picDice3,
											picDice4, picDice5, picDice6 };
			/*keep1Btn.Enabled = false;
			keep2Btn.Enabled = false;
			keep3Btn.Enabled = false;
			keep4Btn.Enabled = false;
			keep5Btn.Enabled = false;
			keep6Btn.Enabled = false;*/
			score = new Scoring();
			dice = new Dice();
		}

		private void btnDiceRoll_Click(object sender, EventArgs e) {
			dice.RollDice(diceBoxes); // Rolls the dice and sets diceBoxes images
		}

		private void keep1Btn_Click(object sender, EventArgs e) {
			score.keep(0, diceBoxes);
		}

		private void keep2Btn_Click(object sender, EventArgs e) {
			score.keep(1, diceBoxes);
		}

		private void keep3Btn_Click(object sender, EventArgs e) {
			score.keep(2, diceBoxes);
		}

		private void keep4Btn_Click(object sender, EventArgs e) {
			score.keep(3, diceBoxes);
		}

		private void keep5Btn_Click(object sender, EventArgs e) {
			score.keep(4, diceBoxes);
		}

		private void keep6Btn_Click(object sender, EventArgs e) {
			score.keep(5, diceBoxes);
		}
	}
}
