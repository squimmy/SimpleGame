using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame
{
	[Serializable]
	public class Armour : Item, ISerializable
	{
		private int protection;

		public Armour(int itemid): base(itemid)
		{
			this.protection = int.Parse(ItemStats.GetStat(itemid, "protection"));
			this.picture = SimpleGame.Properties.Resources.armour_image;
		}

		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			info.AddValue("id", this.id);
			info.AddValue("name", this.name);
			info.AddValue("value", this.value);
			info.AddValue("weight", this.weight);
			info.AddValue("type", this.type);
			info.AddValue("picture", this.picture);

			info.AddValue("protection", this.protection);
		}

		public int Protection
		{
			get { return protection; }
		}
	}
}