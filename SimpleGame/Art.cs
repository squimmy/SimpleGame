using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	public abstract class Art
	{
		static public System.Drawing.Image GetMonsterImage(int monsterid)
		{
			return SimpleGame.Properties.Resources.mystery_monster_image;
		}
		static public System.Drawing.Image GetItemImage(int itemid)
		{
			return SimpleGame.Properties.Resources.weapon_image;
		}

	}
}
