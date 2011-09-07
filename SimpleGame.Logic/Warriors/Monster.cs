using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public class Monster : Warrior
	{
		private int id;
		private int xpreward;
		private int goldreward;

		public Monster(int monsterid)
		{
			this.id = monsterid;
			this.name = MonsterStats.GetStat(monsterid, "name");
			this.level = int.Parse(MonsterStats.GetStat(monsterid, "level"));
			this.hp = this.maxhp = int.Parse(MonsterStats.GetStat(monsterid, "hp"));
			this.xpreward = int.Parse(MonsterStats.GetStat(monsterid, "xp"));
			this.goldreward = int.Parse(MonsterStats.GetStat(monsterid, "gold"));
			this.accuracy = int.Parse(MonsterStats.GetStat(monsterid, "accuracy"));
			this.strength = int.Parse(MonsterStats.GetStat(monsterid, "strength"));
			this.speed = int.Parse(MonsterStats.GetStat(monsterid, "speed"));
			this.unique = MonsterStats.GetStat(monsterid, "unique") == "1";
			this.primaryAbility = AbilityGenerator.CreateAbility(this, int.Parse(MonsterStats.GetStat(monsterid, "ability1")));
			this.secondaryAbility = AbilityGenerator.CreateAbility(this, int.Parse(MonsterStats.GetStat(monsterid, "ability2")));
			this.tertiaryAbility = AbilityGenerator.CreateAbility(this, int.Parse(MonsterStats.GetStat(monsterid, "ability3")));
		}

		public int ID
		{
			get { return id; }
		}
		public int XPReward
		{
			get { return xpreward; }
		}
		public int GoldReward
		{
			get { return goldreward; }
		}
	}
}
