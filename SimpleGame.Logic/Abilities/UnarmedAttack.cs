using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleGame;

namespace SimpleGame.Logic
{
	class UnarmedAttack : Ability
	{
		protected Ability proc;
		protected DamageType damageType;

		public UnarmedAttack(Warrior Attacker, DamageType DamageType, int SpeedBonus, int AccuracyBonus, Ability Proc)
		{
			this.effectType = EffectType.Attack;
			this.attacker = Attacker;
			this.speedBonus = SpeedBonus;
			this.accuracyBonus = AccuracyBonus;
			this.effectiveness = this.attacker.Strength;
			this.damageType = DamageType;
			this.proc = Proc;
		}

		public override IEffect UseAbility()
		{
			this.timer -= (1000 / this.speed);
			return new Attack(attacker, attacker.Target, accuracy, effectiveness, damageType, proc);
		}

	}
}
