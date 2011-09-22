using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public abstract class Ability
	{
		protected int id;
		protected string name;
		protected int timer;
		protected int speedBonus;
		protected int effectiveness;
		protected int accuracyBonus;
		protected Warrior attacker;
		protected EffectType effectType;
		
		public abstract IEffect UseAbility();

		public int ID
		{
			get { return id; }
		}
		public string Name
		{
			get { return name; }
		}
		protected int accuracy
		{
			get { return this.attacker.Accuracy + this.accuracyBonus; }
		}
		public int Accuracy
		{
			get
			{ return this.accuracy; }
		}
		protected int speed
		{
			get { return this.attacker.Speed + this.speedBonus; }
		}
		public int Speed
		{
			get { return this.speed; }
		}
		public int Effectiveness
		{
			get { return effectiveness; }
		}
		public EffectType EffectType
		{
			get { return effectType; }
		}

		public void IncrementTimer()
		{
			if (this.speed > 1 && this.timer <= 1000)
			{
				this.timer += this.speed;
			}
			
		}
		public void ResetTimer()
		{
			this.timer = 0;
		}
		public bool Ready
		{
			get { return timer >= 1000; }
		}
	}
}
