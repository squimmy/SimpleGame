using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame
{
	[Serializable]
	public class Weapon : Item, ISerializable
	{
		private int damage;

		public Weapon(int itemid): base(itemid)
		{
			this.damage = int.Parse(ItemStats.GetStat(itemid, "damage"));
			this.picture = SimpleGame.Properties.Resources.weapon_image;
		}

		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			info.AddValue("id", this.id);
			info.AddValue("name", this.name);
			info.AddValue("value", this.value);
			info.AddValue("weight", this.weight);
			info.AddValue("type", this.type);
			info.AddValue("picture", this.picture);

			info.AddValue("damage", this.damage);
		}

		public int Damage
		{
			get { return damage; }
		}
	}
}
