using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame
{
	[Serializable]
	public class Item : ISerializable
	{
		public enum ItemType { None, Weapon, Armour, Consumable }

		protected string name;
		protected int weight;
		protected int value;
		protected int id;
		protected int speed;
		protected int speedbonus;
		protected int strengthbonus;
		protected int hpbonus;
		protected System.Drawing.Image picture;
		protected ItemType type;
		protected Ability usageAbility;

		public Item(int itemid)
		{
			this.id = itemid;
			this.name = ItemStats.GetStat(itemid, "name");
			this.weight = int.Parse(ItemStats.GetStat(itemid, "weight"));
			this.value = int.Parse(ItemStats.GetStat(itemid, "value"));
			this.speed = int.Parse(ItemStats.GetStat(itemid, "speed"));
			this.speedbonus = int.Parse(ItemStats.GetStat(itemid, "speedbonus"));
			this.strengthbonus = int.Parse(ItemStats.GetStat(itemid, "strengthbonus"));
			this.hpbonus = int.Parse(ItemStats.GetStat(itemid, "hpbonus"));
			this.type = this.setItemType(itemid);
		}
		public Item(SerializationInfo info, StreamingContext ctxt)
		{
			this.id = (int)info.GetValue("id", typeof(int));
			this.name = (string)info.GetValue("name", typeof(string));
			this.value = (int)info.GetValue("value", typeof(int));
			this.weight = (int)info.GetValue("weight", typeof(int));
			this.type = (ItemType)info.GetValue("type", typeof(ItemType));
			this.picture = (System.Drawing.Image)info.GetValue("picture", typeof(System.Drawing.Image));
		}
		protected ItemType setItemType(int itemid)
		{
			switch (ItemStats.GetStat(itemid, "type"))
			{
				case "weapon":
					return ItemType.Weapon;
				case "armour":
					return ItemType.Armour;
				case "consumable":
					return ItemType.Consumable;
				default:
					return ItemType.None;
			}
		}
		public virtual void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			info.AddValue("id", this.id);
			info.AddValue("name", this.name);
			info.AddValue("value", this.value);
			info.AddValue("weight", this.weight);
			info.AddValue("type", this.type);
			info.AddValue("picture", this.picture);
		}
		public Item()
		{
		}

		public int ID
		{
			get { return id; }
		}
		public string UsageVerb
		{
			get
			{
				switch (this.type)
				{
					case Item.ItemType.Weapon:
						return "wield";
					case Item.ItemType.Armour:
						return "wear";
					default:
						return "use";
				}
			}
		}
		public Ability UsageAbility
		{
			get { return this.usageAbility; }
		}

		public virtual string Name
		{
			get { return name; }
		}
		public int Weight
		{
			get { return weight; }
		}
		public int Value
		{
			get { return value; }
		}

		public int Speed
		{
			get { return this.speed; }
		}

		public int SpeedBonus
		{
			get { return this.speedbonus; }
		}
		public int StrengthBonus
		{
			get { return this.speedbonus; }
		}
		public int HPBonus
		{
			get { return this.speedbonus; }
		}

		public ItemType Type
		{
			get { return type; }
		}
		public System.Drawing.Image Picture
		{
			get { return picture; }
		}
	}
}
