using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
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
		

		public Attack AttackTarget()
		{
			return new Attack(this, this.accuracy, this.damage, Combat.DamageType.Crush, this.target);
		}
		public int TakeDamage(int damage, Combat.DamageType damageType)
		{
			int damageTaken = damage - Combat.RandomNumber(this.damageReduction);
			this.HP -= damageTaken;
			return damageTaken;
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
