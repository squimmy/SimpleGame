using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public interface IEquipable
	{
		Dictionary<DamageType, int> Protection { get; }
		Dictionary<Stat, int> Bonus { get; }
	}
}
