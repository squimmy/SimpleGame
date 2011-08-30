using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame
{
	[Serializable]
	public class Consumable : Item, ISerializable
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

		public Consumable(SerializationInfo info, StreamingContext ctxt): base(info, ctxt)
		{
			this.consumabletype = (ConsumableType)info.GetValue("consumabletype", typeof(ConsumableType));
			this.effectiveness = (int)info.GetValue("effectiveness", typeof(int));
			this.count = (int)info.GetValue("count", typeof(int));
		}



		public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			base.GetObjectData(info, ctxt);

			info.AddValue("consumabletype", this.consumabletype);
			info.AddValue("effectiveness", this.effectiveness);
			info.AddValue("count", this.count);
		}


		public int Count
		{
			get { return count; }
			set { count = value; }
		}

		public ConsumableType TypeOfConsumable
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
