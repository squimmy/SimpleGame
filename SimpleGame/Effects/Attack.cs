using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyExtensions;

namespace SimpleGame
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
					message = string.Format("{0} hit {1} and dealt {2} damage!", attacker.Name, target.Name, damageDealt.ToString());
				}
				else
				{
					message = string.Format("{0} hit {1}, but didn't deal any damage.", attacker.Name, target.Name);
				}
			}
			else
			{
				message = string.Format("{0} missed.", attacker.Name);
			}

			this.combatMessage = message.CapitaliseFirstLetter();
		}
		public string CombatMessage()
		{
			return this.combatMessage;
		}
	}
}
