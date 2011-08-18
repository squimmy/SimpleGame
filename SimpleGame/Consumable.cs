using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame
{
	[Serializable]
	class Consumable : Item, ISerializable
	{
		private int count;
		public enum ConsumableType { HealthPotion, StrengthPotion, SpeedPotion, None };
		private ConsumableType consumabletype;
		private int effectiveness;

		public Consumable(int itemid): base(itemid)
		{
			this.picture = SimpleGame.Properties.Resources.potion_image;
			this.consumabletype = this.setConsumableType(itemid);
			this.effectiveness = int.Parse(ItemStats.GetStat(itemid, "effectiveness"));
			this.count = 1;
		}


		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			info.AddValue("id", this.id);
			info.AddValue("name", this.name);
			info.AddValue("value", this.value);
			info.AddValue("weight", this.weight);
			info.AddValue("type", this.type);
			info.AddValue("picture", this.picture);

			info.AddValue("consumabletype", this.consumabletype);
			info.AddValue("effectiveness", this.effectiveness);
		}


		public int Count
		{
			get { return count; }
			set { count = value; }
		}

		public ConsumableType Type
		{
			get { return consumabletype; }
		}

		public int Effectiveness
		{
			get { return effectiveness; }
		}


		private ConsumableType setConsumableType(int itemid)
		{
			switch (ItemStats.GetStat(itemid, "consumabletype"))
			{
				case "HealthPotion":
					return ConsumableType.HealthPotion;
				case "StrengthPotion":
					return ConsumableType.StrengthPotion;
				case "SpeedPotion":
					return ConsumableType.SpeedPotion;
				default:
					return ConsumableType.None;
			}
		}

		public override string Name
		{
			get
			{
				if (count == 1)
				{
					return name;
				}
				else
				{
					return name + " x" + count.ToString();
				}
			}
		}

	}
}
