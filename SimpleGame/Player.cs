using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpleGame
{
	[Serializable]
	public class Player : Warrior, ISerializable
	{
		private int xp;
		private int nextlevel;
		private int gold;
		private Weapon equippedweapon;
		private Armour equippedarmour;

		private List<Item> inventory = new List<Item>();

		public Player(string name, int hp, int level, int nextlevel, int xp, int accuracy, int strength, int speed, int gold, List<Item> inventory, Weapon weapon, Armour armour)
		{
			this.name = name;
			this.hp = this.maxhp = hp;
			this.level = level;
			this.nextlevel = nextlevel;
			this.xp = xp;
			this.accuracy = accuracy;
			this.strength = strength;
			this.speed = speed;
			this.gold = gold;

			this.inventory = inventory;
			this.equippedweapon = weapon;
			this.equippedarmour = armour;
		}

		public Player(SerializationInfo info, StreamingContext ctxt)
		{
			this.name = (string)info.GetValue("name", typeof(string));
			this.hp = this.maxhp = (int)info.GetValue("maxhp", typeof(int));
			this.level = (int)info.GetValue("level", typeof(int));
			this.nextlevel = (int)info.GetValue("nextlevel", typeof(int));
			this.xp = (int)info.GetValue("xp", typeof(int));
			this.accuracy = (int)info.GetValue("accuracy", typeof(int));
			this.strength = (int)info.GetValue("strength", typeof(int));
			this.speed = (int)info.GetValue("speed", typeof(int));
			this.gold = (int)info.GetValue("gold", typeof(int));

			this.inventory = (List<Item>)info.GetValue("inventory", typeof(List<Item>));
			this.equippedweapon= (Weapon)info.GetValue("weapon", typeof(Weapon));
			this.equippedarmour= (Armour)info.GetValue("armour", typeof(Armour));
		}

		public Player()
		{
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

		public void EquipWeapon(Weapon weapon)
		{
			equippedweapon = weapon;
		}

		public void EquipArmour(Armour armour)
		{
			equippedarmour = armour;
		}

		public Weapon EquippedWeapon
		{
			get { return equippedweapon; }
		}

		public Armour EquippedArmour
		{
			get { return equippedarmour; }
		}

		public int Damage
		{
			get { return strength; }
		}

		public int ArmourProtection
		{
			get { return Fighting.RandomNumber(this.equippedarmour.Protection); }
		}

		public List<Item> Inventory
		{
			get { return inventory; }
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

		public int Gold
		{
			get { return gold; }
			set { gold = value; }
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
			if (this.xp >= this.nextlevel)
			{
				return true;
			}
			return false;
		}

		public void LevelUp()
		{
			nextlevel *= 2;
			level++;
			maxhp += level * 5;
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

		public int AttackSpeed
		{
			get { return this.speed + this.equippedweapon.Speed; }
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
			info.AddValue("weapon", this.equippedweapon);
			info.AddValue("armour", this.equippedarmour);
		}
	}
}
