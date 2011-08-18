using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	public static class Fighting
	{
		private static Random rnd = new Random();

		public static int ChooseMonster(int playerlevel)
		{
			return RandomNumber(playerlevel - 1, playerlevel + 1);
		}

		public static int RandomNumber(int minimum, int maximum)
		{
			return (int)rnd.Next(minimum, maximum + 1);
		}

		public static int RandomNumber(int maximum)
		{
			return RandomNumber(0, maximum);
		}

		public static bool MonsterHasInitiative(int monsterspeed, int playerspeed)
		{
			return RandomNumber(monsterspeed) > RandomNumber(playerspeed);
		}
	}
}
