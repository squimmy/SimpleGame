using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame.Logic
{
	[Serializable]
	public class Weapon : Item, ISerializable
	{
		private int damage;
		private DamageType damageType;
		private ItemAbility proc;
		
		public Weapon(int itemid): base(itemid)
		{
			this.damage = int.Parse(ItemStats.GetStat(itemid, "damage"));
			this.damageType = StatParser.ParseDamageType(ItemStats.GetStat(itemid, "damagetype"));
			this.proc = null;
		}

		public Weapon(SerializationInfo info, StreamingContext ctxt): base(info, ctxt)
		{
			this.damage = (int)info.GetValue("damage", typeof(int));
			this.damageType = (DamageType)info.GetValue("damagetype", typeof(DamageType));
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			base.GetObjectData(info, ctxt);
			info.AddValue("damage", this.damage);
			info.AddValue("damagetype", this.damageType);
		}

		public int Damage
		{
			get { return damage; }
		}
		public DamageType DamageType
		{
			get { return damageType; }
		}
		public Ability Proc
		{
			get { return proc; }
		}
	}
}
