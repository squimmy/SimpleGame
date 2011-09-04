using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleGame;
using SimpleGame.Abilities;

namespace SimpleGame
{
	class WeaponAttack : Ability
	{
		Weapon weapon;
		protected Ability proc;
		protected DamageType damageType;

		public WeaponAttack(Warrior Attacker, Weapon Weapon)
		{
			this.effectType = SimpleGame.EffectType.Attack;
			this.attacker = Attacker;
			this.weapon = Weapon;
			this.speed = this.attacker.Speed + this.weapon.Speed;
			this.effectiveness = this.attacker.Strength + this.weapon.Damage;
			this.damageType = this.weapon.DamageType;
			this.proc = this.weapon.Proc;
		}

		public override IEffect UseAbility()
		{
			this.timer -= (1000 / this.speed);
			return new Attack(attacker, attacker.Target, accuracy, effectiveness, weapon.DamageType, proc);
		}
	}
}
