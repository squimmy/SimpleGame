using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public static class MonsterStats
	{
		public static string GetStat(int monsterid, string stat)
		{
			string result = StatParser.XMLStats(monsterid, stat, "monsters.xml");
			return result ?? getDefaultStat(stat);
		}

		private static string getDefaultStat(string stat)
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
				case "ability2":
				case "ability3":
					return "-1";
				default:
					return "0";
			}
		}

		public static bool MonsterExists(int monsterid)
		{
			return StatParser.IDExists(monsterid, "monsters.xml");
		}
	}
}
