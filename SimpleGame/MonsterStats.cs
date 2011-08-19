using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	public static class MonsterStats
	{
		public static string GetStat(int monsterid, string stat)
		{
			return StatParser.XMLStats(monsterid, stat, SimpleGame.Properties.Resources.monsters);
		}

		public static System.Drawing.Image GetImage(int monsterid)
		{
			switch (monsterid)
			{
				case 0:
					return SimpleGame.Properties.Resources.rabbit_image;
				default:
					return SimpleGame.Properties.Resources.mystery_monster_image;
			}
		}

		public static bool MonsterExists(int monsterid)
		{
			return StatParser.IDExists(monsterid, SimpleGame.Properties.Resources.monsters);
		}
	}
}
