using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using SimpleGame;

namespace SimpleGame.Logic
{
	[Serializable]
	public class Player : Warrior, ISerializable
	{
		private int xp;
		private int nextlevel;
		private int gold;
		private int basemaxhp;
		private int basespeed;
		private int basestrength;
		private int baseDamageReduction;

		private Equipment equipment;
		private List<Item> inventory = new List<Item>();

		public Player(string name, int hp, int level, int nextlevel, int xp, int accuracy, int strength, int speed, int gold, List<Item> inventory, Weapon weapon, Armour headArmour, Armour torsoArmour, Armour handArmour, Armour legArmour, Armour feetArmour)
		{
			
			this.name = name;
			this.hp = this.basemaxhp = hp;
			this.level = level;
			this.nextlevel = nextlevel;
			this.xp = xp;
			this.accuracy = accuracy;
			this.basestrength = strength;
			this.basespeed = speed;
			this.gold = gold;

			this.inventory = inventory;
			this.equipment = new Equipment();

			this.baseDamageReduction = 0;

			this.unique = true;
			this.primaryAbility = new UnarmedAttack(this, DamageType.Crushing, 0, 0, null);

			//adding some items to debug inventory controls:
			for (int i = 1; i < 7; i++)
			{
				inventory.Add(ItemGenerator.CreateItem(i));
			}
		}
		public Player(SerializationInfo info, StreamingContext ctxt)
		{
			this.name = (string)info.GetValue("name", typeof(string));
			this.hp = this.basemaxhp = (int)info.GetValue("maxhp", typeof(int));
			this.level = (int)info.GetValue("level", typeof(int));
			this.nextlevel = (int)info.GetValue("nextlevel", typeof(int));
			this.xp = (int)info.GetValue("xp", typeof(int));
			this.accuracy = (int)info.GetValue("accuracy", typeof(int));
			this.basestrength = (int)info.GetValue("strength", typeof(int));
			this.basespeed = (int)info.GetValue("speed", typeof(int));
			this.gold = (int)info.GetValue("gold", typeof(int));

			this.inventory = (List<Item>)info.GetValue("inventory", typeof(List<Item>));
			this.equipment= (Equipment)info.GetValue("equipment", typeof(Equipment));
		}
		public Player()
		{
		}

		protected override int maxhp
		{
			//get { return this.basemaxhp + this.equippedweapon.HPBonus + this.equipmentHPBonus; }
			get { return this.basemaxhp + this.equipment.Bonus(Stat.HP); }
		}
		public int BaseMaxHP
		{
			get { return this.basemaxhp; }
		}

		protected override int speed
		{
			//get { return this.basespeed + this.equippedweapon.SpeedBonus + this.equipmentSpeedBonus; }
			get { return this.basespeed + this.equipment.Bonus(Stat.Speed); }
		}
		public int BaseSpeed
		{
			get { return this.basespeed; }
		}

		protected override int strength
		{
			//get { return this.basestrength + this.equippedweapon.StrengthBonus + this.equipmentStrengthBonus; }
			get { return this.basestrength + this.equipment.Bonus(Stat.Strength); }
		}
		public int BaseStrength
		{
			get { return this.basestrength; }
		}
		
		public List<Item> Inventory
		{
			get { return inventory; }
		}
		public Equipment Equipment
		{
			get { return equipment; }
		}

		public bool PlayerHasItem(int itemid)
		{
			foreach (Item item in inventory)
			{
				if (item.ID == itemid)
				{
					return true;
				}
			}
			return false;
		}

		public int Gold
		{
			get { return gold; }
			set { gold = value; }
		}

		protected override int damageReduction
		{
			get { return this.baseDamageReduction + this.equipment.Protection(DamageType.Crushing); }
			
		}

		protected override int damage
		{
			get { return this.strength + this.temporaryDamageBonus; }
		}

		public int Level
		{
			get { return level; }
		}
		public int XP
		{
			get { return xp; }
			set
			{
				if (value >= nextlevel)
				{
					xp = value;
				}
				else
				{
					xp = value;
				}
			}
		}
		public string XPText
		{
			get
			{
				return this.xp.ToString() + "/" + this.nextlevel.ToString();
			}
		}
		public bool CanLevelUp()
		{
			return this.xp >= this.nextlevel;
		}
		public void LevelUp()
		{
			nextlevel *= 2;
			level++;
			basemaxhp += level * 5;
		}

		public void SelectNewAction(CombatAction Action, Item Item)
		{
			switch (Action)
			{
				case CombatAction.Attack:
					this.primaryAbility = new WeaponAttack(this, Equipment.RightHandWeapon);
					break;
				case CombatAction.UseItem:
					this.primaryAbility = new ItemAbility(this, Item);
					break;
				default:
					break;
			}
		}

		public void Resurrect(int cost)
		{
			this.hp = this.maxhp;
			if (this.gold >= cost)
			{
				this.gold -= cost;
			}
			else
			{
				this.gold = 0;
			}
		}
		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			info.AddValue("name", this.name);
			info.AddValue("maxhp", this.maxhp);
			info.AddValue("level", this.level);
			info.AddValue("nextlevel", this.nextlevel);
			info.AddValue("xp", this.xp);
			info.AddValue("accuracy", this.accuracy);
			info.AddValue("strength", this.strength);
			info.AddValue("speed", this.speed);
			info.AddValue("gold", this.gold);

			info.AddValue("inventory", this.inventory);
			info.AddValue("equipment", this.equipment);
		}
	}
}
