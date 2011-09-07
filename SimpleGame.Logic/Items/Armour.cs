using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame.Logic
{
	[Serializable]
	public class Armour : Item, ISerializable
	{
		private int protection;

		public Armour(int itemid): base(itemid)
		{
			this.protection = int.Parse(ItemStats.GetStat(itemid, "protection"));
		}

		public Armour(SerializationInfo info, StreamingContext ctxt): base(info, ctxt)
		{
			this.protection = (int)info.GetValue("protection", typeof(int));
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			base.GetObjectData(info, ctxt);
			info.AddValue("protection", this.protection);
		}

		public int Protection
		{
			get { return protection; }
		}
	}
}