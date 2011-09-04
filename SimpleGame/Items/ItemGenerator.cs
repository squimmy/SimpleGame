using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	static class ItemGenerator
	{
		public static Item CreateItem(int itemid)
		{
			switch (ItemStats.GetStat(itemid, "type"))
			{
				case "weapon":
					return new Weapon(itemid);
				case "armour":
					return new Armour(itemid);
				case "consumable":
					return new Consumable(itemid);
				default:
					return new Item(itemid);
			}

		}

	}
}
