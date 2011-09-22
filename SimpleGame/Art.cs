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
			switch (itemid)
			{
				case -1:	return SimpleGame.Properties.Resources.hand;
				case -2:	return SimpleGame.Properties.Resources.hair;
				case -3:	return SimpleGame.Properties.Resources.tshirt;
				case -4:	return SimpleGame.Properties.Resources.hand;
				case -5:	return SimpleGame.Properties.Resources.jeans;
				case -6:	return SimpleGame.Properties.Resources.foot;
				case 4:		return SimpleGame.Properties.Resources.leather_armour;
				case 5:		return SimpleGame.Properties.Resources.chainmail;
				case 6:		return SimpleGame.Properties.Resources.chestplate;
				default:	return SimpleGame.Properties.Resources.weapon_image;
			}
			
		}
		static public System.Drawing.Image GetDamageIcon(SimpleGame.Logic.DamageType type)
		{
			switch (type)
			{
				case SimpleGame.Logic.DamageType.Cut: return SimpleGame.Properties.Resources.cut;
				case SimpleGame.Logic.DamageType.Stab: return SimpleGame.Properties.Resources.stab;
				case SimpleGame.Logic.DamageType.Crush: return SimpleGame.Properties.Resources.crush;
				case SimpleGame.Logic.DamageType.Fire: return SimpleGame.Properties.Resources.fire;
				case SimpleGame.Logic.DamageType.Ice: return SimpleGame.Properties.Resources.ice;
				case SimpleGame.Logic.DamageType.Electricity: return SimpleGame.Properties.Resources.electricity;
				case SimpleGame.Logic.DamageType.Poison: return SimpleGame.Properties.Resources.poison;
				case SimpleGame.Logic.DamageType.Magic: return SimpleGame.Properties.Resources.magic;
				case SimpleGame.Logic.DamageType.Holy: return SimpleGame.Properties.Resources.holy;
				default: return SimpleGame.Properties.Resources.none;
			}
		}
	}
}
