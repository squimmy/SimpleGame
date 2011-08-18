using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	class Monster : Warrior
	{

		private int xpreward;
		private int goldreward;
		private System.Drawing.Image picture;

		public Monster(int monsterid)
		{
			this.alive = true;
			this.name = MonsterStats.GetStat(monsterid, "name");
			this.hp = this.maxhp = int.Parse(MonsterStats.GetStat(monsterid, "hp"));
			this.xpreward = int.Parse(MonsterStats.GetStat(monsterid, "xp"));
			this.goldreward = int.Parse(MonsterStats.GetStat(monsterid, "gold"));
			this.accuracy = int.Parse(MonsterStats.GetStat(monsterid, "accuracy"));
			this.damage = int.Parse(MonsterStats.GetStat(monsterid, "damage"));
			this.speed = int.Parse(MonsterStats.GetStat(monsterid, "speed"));
			this.picture = SimpleGame.Properties.Resources.rabbit_image;
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
