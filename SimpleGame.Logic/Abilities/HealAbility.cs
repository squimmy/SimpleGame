using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	class HealAbility : Ability
	{
		public HealAbility(Warrior Attacker, int Speed, int Effectiveness, int Accuracy)
		{
			this.attacker = Attacker;
			this.accuracyBonus = Accuracy;
			this.speedBonus = Speed;
			this.effectiveness = Effectiveness;
		}

		public override IEffect UseAbility()
		{
			return new HealEffect(attacker, effectiveness, accuracy, null);
		}

	}
}
