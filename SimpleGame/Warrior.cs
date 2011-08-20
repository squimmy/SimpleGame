using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	public abstract class Warrior
	{
		protected int hp;
		protected int maxhp;
		protected int level;
		protected int accuracy;
		protected int strength;
		protected string name;
		protected int speed;
		protected int temporarydamagebonus;

		public string Name
		{
			get { return name; }
		}

		public int Speed
		{
			get { return speed; }
		}

		public int MaxHP
		{
			get { return maxhp; }
		}

		public int HP
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

		public bool Hit
		{
			get
			{
				return Fighting.RandomNumber(100) <= this.accuracy;
			}
		}
		
		virtual public int Damage
		{
			get
			{ return strength; }
		}

		public string HPText
		{
			get
			{
				return this.hp.ToString() + "/" + this.maxhp.ToString();
			}
		}

		public bool Alive
		{
			get { return this.hp > 0; }
		}

		public int TemporaryDamageBonus
		{
			get { return temporarydamagebonus; }
			set { temporarydamagebonus = value; }
		}

	}
}
