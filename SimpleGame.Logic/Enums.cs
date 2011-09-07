using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public enum DamageType { Cut, Stab, Crush, Fire, Ice, Electricity, Magic, Holy };
	public enum CombatAction { Attack, UseItem };
	public enum EffectType { Attack, Damage, Heal }
}
