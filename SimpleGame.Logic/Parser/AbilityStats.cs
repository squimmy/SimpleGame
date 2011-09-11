using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	class AbilityStats
	{
		public static string GetStat(int abilityid, string stat)
		{
			string result = StatParser.XMLStats(abilityid, stat, "monster_abilities.xml");
			return result ?? getDefaultStat(stat);
		}

		private static string getDefaultStat(string stat)
		{
			switch (stat)
			{
				case "type":
					return "unarmed";
				case "damagetype":
					return "crush";
				case "proc":
					return "-1";
				case "damage":
					return "1";
				default:
					return "0";
			}
		}
	}
}