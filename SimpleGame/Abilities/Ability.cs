using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleGame.Abilities;

namespace SimpleGame
{
	public abstract class Ability
	{
		protected int timer;
		protected int speed;
		protected int effectiveness;
		protected int accuracy;
		protected Warrior attacker;
		protected EffectType effectType;
		
		public abstract IEffect UseAbility();

		public int Speed
		{
			get { return this.speed; }
		}
		public EffectType EffectType
		{
			get { return effectType; }
		}

		public void IncrementTimer()
		{
			this.timer++;
		}
		public void ResetTimer()
		{
			this.timer = 0;
		}
		public bool Ready
		{
			get { return timer >= (1000 / speed); }
		}
	}
}
