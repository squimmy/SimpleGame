using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyExtensions;

namespace SimpleGame.Logic
{
	class HealEffect : IEffect
	{
		private string origin;
		private Warrior attacker;
		private Warrior target;
		private int triggerChance;
		private int effectiveness;
		private int amountHealed;
		private string combatMessage;

		public HealEffect(Warrior Attacker, int Effectiveness, int TriggerChance, string Origin)
		{
			this.attacker = Attacker;
			this.target = this.attacker;
			this.effectiveness = Effectiveness;
			this.triggerChance = TriggerChance;
			this.origin = Origin;
		}
		
		public void Resolve()
		{
			if (Combat.RollToHit(triggerChance))
			{
				this.amountHealed = Combat.RandomNumber(effectiveness);
			}
			else
			{
				this.amountHealed = 0;
			}

			if (this.amountHealed > 0)
			{
				target.HP += amountHealed;
				this.generateCombatMessage();
			}

		}

		void generateCombatMessage()
		{
			this.combatMessage = string.Format("{0} was healed for {1} hit-points", this.target.Name, this.amountHealed).CapitaliseFirstLetter();
			if (this.origin == null)
			{
				this.combatMessage += ".";
			}
			else
			{
				this.combatMessage += string.Format(" by the {0}.", this.origin);
			}
		}

		public string CombatMessage
		{
			get { return this.combatMessage; }
		}
	}
}
