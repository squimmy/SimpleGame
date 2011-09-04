using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	public class Monster : Warrior
	{
		private int xpreward;
		private int goldreward;
		private System.Drawing.Image picture;

		public Monster(int monsterid)
		{
			this.name = MonsterStats.GetStat(monsterid, "name");
			this.level = int.Parse(MonsterStats.GetStat(monsterid, "level"));
			this.hp = this.maxhp = int.Parse(MonsterStats.GetStat(monsterid, "hp"));
			this.xpreward = int.Parse(MonsterStats.GetStat(monsterid, "xp"));
			this.goldreward = int.Parse(MonsterStats.GetStat(monsterid, "gold"));
			this.accuracy = int.Parse(MonsterStats.GetStat(monsterid, "accuracy"));
			this.strength = int.Parse(MonsterStats.GetStat(monsterid, "strength"));
			this.speed = int.Parse(MonsterStats.GetStat(monsterid, "speed"));
			this.picture = SimpleGame.Properties.Resources.rabbit_image;
			this.unique = MonsterStats.GetStat(monsterid, "unique") == "1";
			this.primaryAbility = new UnarmedAttack(this, DamageType.Crush, null);
		}

		public int XPReward
		{
			get { return xpreward; }
		}

		public int GoldReward
		{
			get { return goldreward; }
		}

		public System.Drawing.Image Picture
		{
			get { return picture; }
		}

	}
}
