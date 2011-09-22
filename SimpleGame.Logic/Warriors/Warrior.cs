using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public abstract class Warrior
	{
		protected int hp;
		protected virtual int maxhp { get; set; }
		protected int level;
		protected int accuracy;
		protected virtual int strength { get; set; }
		protected string name;
		protected virtual int speed { get; set; }
		protected Warrior target;
		protected int temporaryDamageBonus;
		protected virtual int damageReduction { get; set; }
		protected bool unique;
		protected Ability primaryAbility;
		protected Ability secondaryAbility;
		protected Ability tertiaryAbility;

		public string Name
		{
			get
			{
				if (unique)
				{
					return name;
				}
				else
				{
					return "the " + name;
				}
			}
		}
		public int Speed
		{
			get { return speed; }
		}
		public int Strength
		{
			get { return strength; }
		}
		public int Accuracy
		{
			get { return accuracy; }
		}
		

		public virtual IEffect AttackTarget()
		{
			return primaryAbility.UseAbility();
		}
		public int TakeDamage(int damage, DamageType damageType)
		{
			int damageTaken = damage - Combat.RandomNumber(this.damageReduction);
			this.HP -= damageTaken;
			return damageTaken;
		}

		public void IncrementTimers()
		{
			if (primaryAbility != null)
				primaryAbility.IncrementTimer();
			if (secondaryAbility != null)
				secondaryAbility.IncrementTimer();
			if (tertiaryAbility != null)
				tertiaryAbility.IncrementTimer();
		}
		public void ResetTimers()
		{
			if (primaryAbility != null)
				primaryAbility.ResetTimer();
			if (secondaryAbility != null)
				secondaryAbility.ResetTimer();
			if (tertiaryAbility != null)
				tertiaryAbility.ResetTimer();
		}
		public bool AbiltiesReady()
		{
			if (primaryAbility != null)
			{
				if (primaryAbility.Ready)
					return true;
			}
			if (secondaryAbility != null)
			{
				if (secondaryAbility.Ready)
					return true;
			}
			if (tertiaryAbility != null)
			{
				if (tertiaryAbility.Ready)
					return true;
			}
			return false;
		}
		public string UseAllReadyAbilities()
		{
			if (AbiltiesReady())
			{
				return UsePrimaryAbility() + UseSecondaryAbility() + UseTertiaryAbility();
			}
			return null;
		}

		public string UsePrimaryAbility()
		{
			if (primaryAbility == null || !primaryAbility.Ready)
			{
				return null;
			}
			IEffect effect = primaryAbility.UseAbility();
			effect.Resolve();
			return effect.CombatMessage;
		}
		public string UseSecondaryAbility()
		{
			if (secondaryAbility == null || !secondaryAbility.Ready)
			{
				return null;
			}
			IEffect effect = secondaryAbility.UseAbility();
			effect.Resolve();
			return effect.CombatMessage;
		}
		public string UseTertiaryAbility()
		{
			if (tertiaryAbility == null || !tertiaryAbility.Ready)
			{
				return null;
			}
			IEffect effect = tertiaryAbility.UseAbility();
			effect.Resolve();
			return effect.CombatMessage;
		}
		public Ability PrimaryAbility
		{
			get { return primaryAbility; }
		}
		public Ability SecondaryAbility
		{
			get { return secondaryAbility; }
		}
		public Ability TertiaryAbility
		{
			get { return tertiaryAbility; }
		}



		public virtual int MaxHP
		{
			get { return maxhp; }
		}
		public virtual int HP
		{
			get { return hp; }

			set
			{
				if (value > maxhp)
				{
					hp = maxhp;
				}
				else
				{
					hp = value;
				}
			}
		}
		public virtual string HPText
		{
			get
			{
				return string.Format("{0}/{1}", this.hp.ToString(), this.maxhp.ToString());
			}
		}
		public bool Alive
		{
			get { return this.hp > 0; }
		}
		
		public int TemporaryDamageBonus
		{
			get { return temporaryDamageBonus; }
			set { temporaryDamageBonus = value; }
		}
		virtual protected int damage
		{
			get { return this.strength + this.temporaryDamageBonus; }
		}
		virtual public int Damage
		{
			get
			{ return this.damage; }
		}

		public int DamageReduction
		{
			get { return damageReduction; }
		}

		public Warrior Target
		{
			get { return target; }
			set { target = value; }
		}

	}
}
