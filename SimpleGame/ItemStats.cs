using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	class ItemStats
	{
		public static string GetStat(int itemid, string stat)
		{
			return StatParser.XMLStats(itemid, stat, SimpleGame.Properties.Resources.items);
		}

		public static System.Drawing.Image GetImage(int itemid)
		{
			switch (itemid)
			{
				case 0:
					return SimpleGame.Properties.Resources.rabbit_image;
				default:
					return SimpleGame.Properties.Resources.mystery_monster_image;
			}
		}

	}
}
