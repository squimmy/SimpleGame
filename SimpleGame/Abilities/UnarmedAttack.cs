using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleGame;
using SimpleGame.Abilities;

namespace SimpleGame
{
	class UnarmedAttack : Ability
	{
		protected Ability proc;
		protected DamageType damageType;

		public UnarmedAttack(Warrior Attacker, DamageType DamageType, Ability Proc)
		{
			this.effectType = SimpleGame.EffectType.Attack;
			this.attacker = Attacker;
			this.speed = this.attacker.Speed;
			this.accuracy = this.attacker.Accuracy;
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
