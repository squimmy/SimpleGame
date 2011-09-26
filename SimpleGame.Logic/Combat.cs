using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public static class Combat
	{
		private static Random rnd = new Random();

		private static List<List<int>> monsterLevels = new List<List<int>>();

		
		public enum AttackType { Primary, Secondary, Tertiary };
		public enum EffectType { Heal, Damage, Buff, DeBuff, Stun };
		// TODO: add add poison/curse/bless to effects
		public enum Stat { Strength, Speed, Accuracy };

		public static void generateMonsterList()
		{
			for (int i = 0; i < 20; i++)
			{
				monsterLevels.Add(new List<int>());
			}
			for (int i = 0; MonsterStats.MonsterExists(i); i++)
			{
				int level = int.Parse(MonsterStats.GetStat(i, "level"));
				monsterLevels[level].Add(i);
			}
		}
		public static int ChooseMonster(int playerlevel)
		{
			int enemylevel = RandomNumber(playerlevel - 1, playerlevel + 1);
			return monsterLevels[enemylevel][RandomNumber(monsterLevels[enemylevel].Count-1)];
		}

		public static string AttackVerb(int damageDealt, DamageType damageType)
		{
			switch (damageType)
			{
				case DamageType.Cutting:
					if (damageDealt > 20)
						return "eviscerate";
					if (damageDealt > 10)
						return "slash";
					return "hit";
				case DamageType.Stabbing:
					if (damageDealt > 15)
						return "impale";
					return "hit";
				case DamageType.Crushing:
					if (damageDealt > 20)
						return "crush";
					if (damageDealt > 10)
						return "pummel";
					return "hit";
				case DamageType.Fire:
					if (damageDealt > 20)
						return "incinerate";
					if (damageDealt > 10)
						return "immolate";
					if (damageDealt > 5)
						return "burn";
					return "scorch";
				case DamageType.Ice:
					if (damageDealt > 10)
						return "freeze";
					return "chill";
				case DamageType.Electricity:
					if (damageDealt > 20)
						return "electrocute";
					return "zap";
				case DamageType.Magic:
					return "hit";
				case DamageType.Holy:
					return "hit";
				default:
					return "hit";
			}
		}

		public static int RandomNumber(int minimum, int maximum)
		{
			return (int)rnd.Next(minimum, maximum + 1);
		}
		public static int RandomNumber(int maximum)
		{
			return RandomNumber(0, maximum);
		}
		public static bool RollToHit(int accuracy)
		{
			return Combat.RandomNumber(100) <= accuracy;
		}
		public static int ApplyDamageReduction(int damage, int protectionValue)
		{
			double taken = damage * ProtectionMultiplierValue(protectionValue);
			int remainder = (int)((taken % 1) * 100);
			if (RollToHit(remainder))
				return (int)taken + 1;
			else
				return (int)taken;
		}
		public static double ProtectionMultiplierValue(int protectionValue)
		{
			return Math.Pow(0.96594, (double)protectionValue);
		}
		public static int ProtectionPercentage(int protectionValue)
		{
			return (int)Math.Round(ProtectionMultiplierValue(protectionValue) * 100, 0);
		}
		
		public static bool MonsterHasInitiative(int monsterspeed, int playerspeed)
		{
			return RandomNumber(monsterspeed) > RandomNumber(playerspeed);
		}
	}
}
