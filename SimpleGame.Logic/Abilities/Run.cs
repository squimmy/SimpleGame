using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	class Run : Ability
	{
		bool runSucceeds;
		public Run(Warrior Attacker)
		{
			this.attacker = Attacker;
			this.accuracyBonus = 100;
			this.speedBonus = 0;

			this.runSucceeds = true;
		}

		public override IEffect UseAbility()
		{
			return null;
		}

	}
}
