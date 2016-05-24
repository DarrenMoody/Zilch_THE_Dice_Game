using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilch_Dice_Game {
	
	public class Player {
		public Scoring p1score;
		public Scoring p2score;
		public int p1total, p2total;

		private Player() {
			p1score = new Scoring();
			p2score = new Scoring();
			p1total = 0;
			p2total = 0;
		}

		public int getTotalScore( ) {
			return p1total;
		}

		public int getP2Score() {
			return p2total;
		}

	}
}
