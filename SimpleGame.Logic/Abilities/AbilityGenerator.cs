using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	class AbilityGenerator
	{
		public static Ability CreateAbility(Warrior attacker, int abilityid)
		{
			if (abilityid == -1)
			{
				return null;
			}
		    switch (AbilityStats.GetStat(abilityid, "type"))
		    {
				case "unarmed":
					return CreateUnarmed(abilityid, attacker);
				default:
					return null;
		    }
		}

		private static Ability CreateUnarmed(int abilityid, Warrior attacker)
		{
			DamageType damageType = StatParser.ParseDamageType(AbilityStats.GetStat(abilityid, "damagetype"));
			int speedBonus = int.Parse(AbilityStats.GetStat(abilityid, "speed"));
			int accuracyBonus = int.Parse(AbilityStats.GetStat(abilityid, "accuracy"));
			Ability proc;
			int procid = int.Parse(AbilityStats.GetStat(abilityid, "proc"));
			if (procid != -1)
				proc = CreateAbility(attacker, procid);
			else
				proc = null;

			return new UnarmedAttack(attacker, damageType, speedBonus, accuracyBonus, proc);
		}


	}
}
