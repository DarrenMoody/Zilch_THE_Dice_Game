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
		public static Player p1;
		public static Player p2;
		public static Button[] btnPoints;
		public static Button[] keepBtns;
		public static PictureBox[] diceBoxes;
		public static TextBox totalPtsBox;
		public static TextBox turnPtsBox;
		public static TextBox rollPtsBox;
		public static Button btnRoll;
		public static Timer[] timers;
		public Scoring score;
		public Dice dice;
		public static bool flag = false;
		

		public Form1() {
			InitializeComponent();
			btnRoll = rollBtn;
			diceBoxes = new PictureBox[6] { picDice1, picDice2, picDice3,
											picDice4, picDice5, picDice6 };
			keepBtns = new Button[6] { keep1Btn, keep2Btn, keep3Btn,
										keep4Btn, keep5Btn, keep6Btn };
            keep1Btn.Enabled = false; // initially not enabled
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
			btnPoints1.Enabled = false; // initially not enabled
			btnPoints2.Enabled = false;
			btnPoints3.Enabled = false;
			btnPoints4.Enabled = false;
			btnPoints5.Enabled = false;
			btnPoints1.Visible = false; // or visible
			btnPoints2.Visible = false;
			btnPoints3.Visible = false;
			btnPoints4.Visible = false;
			btnPoints5.Visible = false;
			totalPtsBox = txtBoxTotalPoints;
			turnPtsBox = txtBoxTurnPoints;
			rollPtsBox = txtBoxRollPoints;
			score = new Scoring();
			dice = new Dice();
			// Timers for dice roll effect
			Timer1.Interval = 100;
			Timer2.Interval = 100;
			Timer3.Interval = 100;
			Timer4.Interval = 100;
			Timer5.Interval = 100;
			Timer6.Interval = 100;
			timers = new Timer[6] { Timer1, Timer2, Timer3,
									Timer4, Timer5, Timer6};
		}

		private void btnDiceRoll_Click(object sender, EventArgs e) {
			flag = false;
			Timer1_Tick(sender, e);
			Timer2_Tick(sender, e);
			Timer3_Tick(sender, e);
			Timer4_Tick(sender, e);
			Timer5_Tick(sender, e);
			Timer6_Tick(sender, e);

			DiceTimer.Stop();
			DiceTimer.Tick += new EventHandler(letsRoll);
			DiceTimer.Interval = (1000) * (1);
			DiceTimer.Enabled = true;
			DiceTimer.Start();
			while (flag == false)
				Application.DoEvents();
			dice.RollDice(diceBoxes); // Rolls the dice and sets diceBoxes images
			//score.scoringTraverse();
		}

		public void letsRoll(object sender, EventArgs e) {
			Timer1.Stop();
			Timer2.Stop();
			Timer3.Stop();
			Timer4.Stop();
			Timer5.Stop();
			Timer6.Stop();
			flag = true;
		}

		private void keep1Btn_Click(object sender, EventArgs e) {
			dice.keep(0, diceBoxes);
		}

		private void keep2Btn_Click(object sender, EventArgs e) {
			dice.keep(1, diceBoxes);
		}

		private void keep3Btn_Click(object sender, EventArgs e) {
			dice.keep(2, diceBoxes);
		}

		private void keep4Btn_Click(object sender, EventArgs e) {
			dice.keep(3, diceBoxes);
		}

		private void keep5Btn_Click(object sender, EventArgs e) {
			dice.keep(4, diceBoxes);
		}

		private void keep6Btn_Click(object sender, EventArgs e) {
			dice.keep(5, diceBoxes);
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

		private void Timer1_Tick(object sender, EventArgs e) {
			if (Dice.on[0] == false) {
				Timer1.Stop();
				dice.timerTick(0);
				Timer1.Start();
			}
		}

		private void Timer2_Tick(object sender, EventArgs e) {
			if (Dice.on[1] == false) {
				Timer2.Stop();
				dice.timerTick(1);
				Timer2.Start();
			}
		}

		private void Timer3_Tick(object sender, EventArgs e) {
			if (Dice.on[2] == false) {
				Timer3.Stop();
				dice.timerTick(2);
				Timer3.Start();
			}
		}

		private void Timer4_Tick(object sender, EventArgs e) {
			if (Dice.on[3] == false) {
				Timer4.Stop();
				dice.timerTick(3);
				Timer4.Start();
			}
		}

		private void Timer5_Tick(object sender, EventArgs e) {
			if (Dice.on[4] == false) {
				Timer5.Stop();
				dice.timerTick(4);
				Timer5.Start();
			}
		}

		private void Timer6_Tick(object sender, EventArgs e) {
			if (Dice.on[5] == false) {
				Timer6.Stop();
				dice.timerTick(5);
				Timer6.Start();
			}
		}
	}
}
