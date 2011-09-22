using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	class ItemStats
	{
		public static string GetStat(int itemid, string stat)
		{
			string result = StatParser.XMLStats(itemid, stat,  "items.xml");
			return result ?? getDefaultStat(stat);
		}

		private static string getDefaultStat(string stat)
		{
			switch (stat)
			{
				case "name":
					return "unknown";
				default:
					return "0";
			}
		}
	}
}