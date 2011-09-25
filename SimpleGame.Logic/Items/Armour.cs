using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame.Logic
{
	[Serializable]
	public class Armour : Item, ISerializable, IEquipable
	{
		private Dictionary<DamageType, int> protection;
		private Dictionary<Stat, int> bonus;
		private ArmourLocation location;

		public Armour(int itemid): base(itemid)
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
			location = StatParser.ParseArmourLocation(ItemStats.GetStat(itemid, "location"));
			this.Equippable = true;
		}
		public Armour(ArmourLocation location)
		{
			this.id = ((int)location * -1) - 2;
			this.weight = 0;
			this.value = 0;
			this.speed = 0;
			this.speedbonus = 0;
			this.strengthbonus = 0;
			this.hpbonus = 0;
			this.type = ItemType.Armour;
			protection = new Dictionary<DamageType, int>();
			foreach (DamageType type in Enum.GetValues(typeof(DamageType)))
			{
				protection[type] = 0;
			}
			bonus = new Dictionary<Stat,int>();
			foreach (Stat stat in Enum.GetValues(typeof(Stat)))
			{
				bonus[stat] = 0;
			}

			switch (location)
			{
				case ArmourLocation.Torso:
					this.name = "T-Shirt";
					this.info = "This simple t-shirt provides no protection against enemy attacks.";
					this.location = ArmourLocation.Torso;
					break;
				case ArmourLocation.Legs:
					this.name = "Jeans";
					this.info = "These plain, denim jeans don't prevent any damage, but at least they stop everyone from being able to see your junk.";
					this.location = ArmourLocation.Legs;
					break;
				case ArmourLocation.Head:
					this.name = "Head of Hair";
					this.info = "Your luscious, flowing locks provide no armour.";
					this.location = ArmourLocation.Head;
					break;
				case ArmourLocation.Hands:
					this.name = "Bare Hands";
					this.info = "Can be formed into 'rock', 'paper' and 'scissor' configurations.";
					this.location = ArmourLocation.Hands;
					break;
				case ArmourLocation.Feet:
					this.name = "Bare Feet";
					this.info = "You don't even have any socks. You will take double damage from any lego-based attacks.";
					this.location = ArmourLocation.Feet;
					break;
				default:
					break;
			}
		}

		public Armour(SerializationInfo info, StreamingContext ctxt): base(info, ctxt)
		{
			this.protection = (Dictionary<DamageType,int>)info.GetValue("protection", typeof(Dictionary<DamageType,int>));
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			base.GetObjectData(info, ctxt);
			info.AddValue("protection", this.protection);
		}

		public Dictionary<DamageType, int> Protection
		{
			get { return protection; }
		}
		public Dictionary<Stat, int> Bonus
		{
			get { return bonus; }
		}
		public ArmourLocation Location
		{
			get { return location; }
		}
	}
}