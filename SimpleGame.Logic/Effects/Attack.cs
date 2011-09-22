using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyExtensions;

namespace SimpleGame.Logic
{
	public class Attack : IEffect
	{
		bool hit;
		int damageDealt;
		int damageReceived;
		int accuracy;
		int strength;
		DamageType damageType;
		Warrior target;
		Warrior attacker;
		string combatMessage;
		Ability proc;

		public Attack(Warrior Attacker, Warrior Target, int Accuracy, int Strength, DamageType DamageType, Ability Proc)
		{
			this.damageType = DamageType;
			this.target = Target;
			this.attacker = Attacker;
			this.accuracy = Accuracy;
			this.strength = Strength;
			this.proc = Proc;
		}

		public void Resolve()
		{
			if (Combat.RollToHit(accuracy))
			{
				this.hit = true;
				this.damageDealt = Combat.RandomNumber(strength);
				this.damageReceived = target.TakeDamage(this.damageDealt, damageType);
			}
			else
			{
				this.damageDealt = this.damageReceived = 0;
				this.hit = false;
			}
			generateCombatMessage();
		}
		void generateCombatMessage()
		{
			string message;
			if (this.hit)
			{
				if (this.damageDealt > 0)
				{
					message = string.Format("{0} {1} {2} and deals {3} damage!", attacker.Name, Combat.AttackVerb(damageDealt, damageType).SFormOfVerb(), target.Name, damageDealt.ToString());
				}
				else
				{
					message = string.Format("{0} {1} {2}, but doesn't deal any damage.", attacker.Name, Combat.AttackVerb(damageDealt, damageType).SFormOfVerb(), target.Name);
				}
			}
			else
			{
				message = string.Format("{0} misses.", attacker.Name);
			}

			this.combatMessage = message.CapitaliseFirstLetter();
		}
		public string CombatMessage
		{
			get { return this.combatMessage; }
		}
	}
}
