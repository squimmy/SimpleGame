using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame.Logic
{
	public class Equipable: Item, ISerializable
	{
		protected Dictionary<DamageType, int> protection;
		protected Dictionary<Stat, int> bonus;

		public Equipable(int itemid) : base(itemid)
		{
			protection = new Dictionary<DamageType, int>();
			foreach (DamageType type in Enum.GetValues(typeof(DamageType)))
			{
				protection[type] = int.Parse(ItemStats.GetStat(itemid, type.ToString().ToLower()));
			}
			bonus = new Dictionary<Stat, int>();
			foreach (Stat stat in Enum.GetValues(typeof(Stat)))
			{
				bonus[stat] = int.Parse(ItemStats.GetStat(itemid, type.ToString().ToLower() + "bonus"));
			}

		}
		public Equipable(SerializationInfo info, StreamingContext ctxt)
			: base(info, ctxt)
		{
			this.protection = (Dictionary<DamageType, int>)info.GetValue("protection", typeof(Dictionary<DamageType, int>));
		}
		public Equipable()
		{
		}

		public Dictionary<DamageType, int> Protection
		{
			get { return protection; }
		}
		public Dictionary<Stat, int> Bonus
		{
			get { return bonus; }
		}
	}
}
