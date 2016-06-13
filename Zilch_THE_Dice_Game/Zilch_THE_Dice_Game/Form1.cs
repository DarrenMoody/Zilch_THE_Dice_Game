using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
		public static TextBox turnPtsBox;
		public static TextBox bankedPtsBox;
		public static Button btnRoll;
		public static Timer[] timers;
		public Scoring score;
		public Dice dice;
		public static bool flag = false;
		const int MAX = 6;

		// Sounds for the fun of it 
		// Only took 10 minutes
		SoundPlayer bank = new SoundPlayer(Properties.Resources.ChaChing);
		SoundPlayer roll1b = new SoundPlayer(Properties.Resources.smb_fireball);
		SoundPlayer scoreBtns = new SoundPlayer(Properties.Resources.smb_jump);
		public static SoundPlayer zilcher = new SoundPlayer(Properties.Resources.mariodie);
		SoundPlayer winner = new SoundPlayer(Properties.Resources.smb_win);
		public static SoundPlayer rolled = new SoundPlayer(Properties.Resources.RollDiceHitTable);
		SoundPlayer rolling = new SoundPlayer(Properties.Resources.ShakingDiceInHand);
		SoundPlayer noBank = new SoundPlayer(Properties.Resources.smb_bump);

		public Form1() {
			InitializeComponent();
			btnRoll = rollBtn;
			diceBoxes = new PictureBox[MAX] { picDice1, picDice2, picDice3,
											picDice4, picDice5, picDice6 };
			keepBtns = new Button[MAX] { keep1Btn, keep2Btn, keep3Btn,
										keep4Btn, keep5Btn, keep6Btn };
            keepBtns[0].Enabled = false; // initially not enabled
			keepBtns[1].Enabled = false;
			keepBtns[2].Enabled = false;
			keepBtns[3].Enabled = false;
			keepBtns[4].Enabled = false;
			keepBtns[5].Enabled = false;
			btnPoints = new Button[5];
			btnPoints[0] = btnPoints1;
			btnPoints[1] = btnPoints2;
			btnPoints[2] = btnPoints3;
			btnPoints[3] = btnPoints4;
			btnPoints[4] = btnPoints5;
			btnPoints[0].Enabled = false; // initially not enabled
			btnPoints[1].Enabled = false;
			btnPoints[2].Enabled = false;
			btnPoints[3].Enabled = false;
			btnPoints[4].Enabled = false;
			btnPoints[0].Visible = false; // initially not enabled
			btnPoints[1].Visible = false;
			btnPoints[2].Visible = false;
			btnPoints[3].Visible = false;
			btnPoints[4].Visible = false;
			turnPtsBox = txtBoxTurnPoints;
			bankedPtsBox = txtBoxBankedPoints;
			score = new Scoring();
			dice = new Dice();
			// Timers for dice roll effect
			timers = new Timer[MAX] { Timer1, Timer2, Timer3,
									Timer4, Timer5, Timer6};
			timers[0].Interval = 100;
			timers[1].Interval = 100;
			timers[2].Interval = 100;
			timers[3].Interval = 100;
			timers[4].Interval = 100;
			timers[5].Interval = 100;
			
		}

		private void btnDiceRoll_Click(object sender, EventArgs e) {
			rolling.Play();
			//score.resetPoints();
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
			dice.RollDice(); // Rolls the dice and sets diceBoxes images
							 //score.scoringTraverse();
			if (!Scoring.zilch)
				rolled.Play();
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
			dice.keep(0);
		}

		private void keep2Btn_Click(object sender, EventArgs e) {
			dice.keep(1);
		}

		private void keep3Btn_Click(object sender, EventArgs e) {
			dice.keep(2);
		}

		private void keep4Btn_Click(object sender, EventArgs e) {
			dice.keep(3);
		}

		private void keep5Btn_Click(object sender, EventArgs e) {
			dice.keep(4);
		}

		private void keep6Btn_Click(object sender, EventArgs e) {
			dice.keep(5);
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

		private void btnPoints1_Click(object sender, EventArgs e) {
			scoreBtns.Play();
			btnPtsClick(sender, e, 0);
		}

		private void btnPoints2_Click(object sender, EventArgs e) {
			scoreBtns.Play();
			btnPtsClick(sender, e, 1);
		}

		private void btnPoints3_Click(object sender, EventArgs e) {
			scoreBtns.Play();
			btnPtsClick(sender, e, 2);
		}

		private void btnPoints4_Click(object sender, EventArgs e) {
			scoreBtns.Play();
			btnPtsClick(sender, e, 3);
		}

		private void btnPoints5_Click(object sender, EventArgs e) {
			scoreBtns.Play();
			btnPtsClick(sender, e, 4);
		}

		public void btnPtsClick(object sender, EventArgs e, int i) {
			Scoring.numClicks[i]++;

			if (Scoring.btnPointsCheck[0, i] == 1) {
				keep1Btn.PerformClick();//btnPoints1_Click(sender, e);
			}
			if (Scoring.btnPointsCheck[1, i] == 2) {
				keep2Btn.PerformClick();//btnPoints2_Click(sender, e);
			}
			if (Scoring.btnPointsCheck[2, i] == 3) {
				keep3Btn.PerformClick();//btnPoints3_Click(sender, e);
			}
			if (Scoring.btnPointsCheck[3, i] == 4) {
				keep4Btn.PerformClick();//btnPoints4_Click(sender, e);
			}
			if (Scoring.btnPointsCheck[4, i] == 5) {
				keep5Btn.PerformClick();//btnPoints5_Click(sender, e);
			}
			if (Scoring.btnPointsCheck[5, i] == 6) {
				keep6Btn.PerformClick();//  _Click(sender, e);
			}

			if (Scoring.numClicks[i] % 2 == 1) {
				Scoring.totalTurnScore += Scoring.scorePos[i];
				Scoring.clicksOdd[i] = true;
			} else if (Scoring.numClicks[i] % 2 == 0) {
				Scoring.totalTurnScore -= Scoring.scorePos[i];
			}
			string outStr = string.Format("{0}", Scoring.totalTurnScore);
			Form1.turnPtsBox.Text = outStr;
		}
	}
}
