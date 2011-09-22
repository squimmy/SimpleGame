using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame.Logic
{
	[Serializable]
	public class Weapon : Item, ISerializable, IEquipable
	{
		private int damage;
		private DamageType damageType;
		private ItemAbility proc;
		private WeaponSize size;
		private Dictionary<DamageType, int> protection;
		private Dictionary<Stat, int> bonus;

		public Weapon(int itemid)
			: base(itemid)
		{
			this.damage = int.Parse(ItemStats.GetStat(itemid, "damage"));
			this.damageType = StatParser.ParseDamageType(ItemStats.GetStat(itemid, "damagetype"));
			this.proc = null;
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

		public Weapon()
		{
			this.id = -1;
			this.name = "Empty Handed";
			this.weight = 0;
			this.value = 0;
			this.speed = 0;
			this.speedbonus = 0;
			this.strengthbonus = 0;
			this.hpbonus = 0;
			this.damage = 0;
			this.type = ItemType.Weapon;
			this.damageType = DamageType.Crush;
			this.protection = new Dictionary<DamageType, int>();
			foreach (DamageType type in Enum.GetValues(typeof(DamageType)))
			{
				protection[type] = 0;
			}
			this.bonus = new Dictionary<Stat, int>();
			foreach (Stat stat in Enum.GetValues(typeof(Stat)))
			{
				bonus[stat] = 0;
			}

		}

		public Weapon(SerializationInfo info, StreamingContext ctxt)
			: base(info, ctxt)
		{
			this.damage = (int)info.GetValue("damage", typeof(int));
			this.damageType = (DamageType)info.GetValue("damagetype", typeof(DamageType));
			this.protection = (Dictionary<DamageType, int>)info.GetValue("protection", typeof(Dictionary<DamageType, int>));
			this.size = (WeaponSize)info.GetValue("size", typeof(WeaponSize));
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			base.GetObjectData(info, ctxt);
			info.AddValue("damage", this.damage);
			info.AddValue("damagetype", this.damageType);
			info.AddValue("protection", this.protection);
			info.AddValue("size", this.size);
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
		public WeaponSize Size
		{
			get { return size; }
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
