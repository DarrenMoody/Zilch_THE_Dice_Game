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

		// static Global Form1 components
		public static Button[] btnPoints;
		public static Button[] keepBtns;
		public static PictureBox[] diceBoxes;
		public static TextBox totalPtsBox;
		public static TextBox turnPtsBox;
		public static TextBox rollPtsBox;
		public static Button btnRoll;

		public Scoring score;
		public Dice dice;
		
		

		public Form1() {
			InitializeComponent();
			btnRoll = rollBtn;
			diceBoxes = new PictureBox[6] { picDice1, picDice2, picDice3,
											picDice4, picDice5, picDice6 };
			keepBtns = new Button[6] { keep1Btn, keep2Btn, keep3Btn,
										keep4Btn, keep5Btn, keep6Btn };
            keep1Btn.Enabled = false;
			keep2Btn.Enabled = false;
			keep3Btn.Enabled = false;
			keep4Btn.Enabled = false;
			keep5Btn.Enabled = false;
			keep6Btn.Enabled = false;
			btnPoints = new Button[5];
			btnPoints[0] = btnPoints1;
			btnPoints[1] = btnPoints2;
			btnPoints[2] = btnPoints3;
			btnPoints[3] = btnPoints4;
			btnPoints[4] = btnPoints5;
			totalPtsBox = txtBoxTotalPoints;
			turnPtsBox = txtBoxTurnPoints;
			rollPtsBox = txtBoxRollPoints;
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

		public Button[] getPtsBtns() {
			return btnPoints;
		}

		private void exitToolStripMenuItem1_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void bankBtn_Click(object sender, EventArgs e) {
			score.bank();
		}
	}
}
