using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	class DamageEffect : IEffect
	{
		// TODO: implement this :(
		public DamageEffect(int procEffectiveness, DamageType procDamageType, int procTriggerChance)
		{

		}
		public void Resolve()
		{
		}

		public string CombatMessage
		{
			get { return null; }
		}
	}
}
