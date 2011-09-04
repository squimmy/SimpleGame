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
			string result = StatParser.XMLStats(monsterid, stat, SimpleGame.Properties.Resources.monsters);
			return result ?? GetDefaultStat(stat);
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

		public static string GetDefaultStat(string stat)
		{
			switch (stat)
			{
				case "name":
					return "unknown";
				case "speed":
					return "1";
				case "accuracy":
					return "70";
				case "strength":
				case "hp":
					return "1";
				default:
					return "0";
			}
		}

		public static bool MonsterExists(int monsterid)
		{
			return StatParser.IDExists(monsterid, SimpleGame.Properties.Resources.monsters);
		}
	}
}
