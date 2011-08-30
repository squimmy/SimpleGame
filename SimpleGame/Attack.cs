using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	public class Attack
	{
		bool hit;
		int damageDealt;
		int damageReceived;
		Combat.DamageType damageType;
		Warrior target;
		Warrior attacker;
		string combatMessage;

		public Attack(Warrior Attacker, int Accuracy, int Strength, Combat.DamageType DamageType, Warrior Target)
		{
			this.damageType = DamageType;
			this.target = Target;
			this.attacker = Attacker;
			this.calculateAttackResult(Accuracy, Strength);
			this.combatMessage = generateCombatMessage();
		}

		void calculateAttackResult(int accuracy, int strength)
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
		}

		string generateCombatMessage()
		{
			if (this.hit)
			{
				if (this.damageDealt > 0)
				{
					return string.Format("{0} hit {1} and dealt {2} damage!", attacker.Name, target.Name, damageDealt.ToString());
				}
				else
				{
					return string.Format("{0} hit {1}, but didn't deal any damage.", attacker.Name, target.Name);
				}
			}
			else
			{
				return string.Format("{0} missed.", attacker.Name);
			}
		}

		public string CombatMessage
		{
			get { return this.combatMessage; }
		}
	}
}
