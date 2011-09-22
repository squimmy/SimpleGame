using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic.InventoryExtensions
{
	public static class InventoryExtensions
	{
		public static List<Weapon> Weapons(this List<Item> inventory)
		{
			return inventory.FindAll(delegate(Item x) { return x.Type == ItemType.Weapon; }).Cast<Weapon>().ToList();
		}
		public static List<Weapon> Weapons(this List<Item> inventory, WeaponSize size)
		{
			return inventory.Weapons().FindAll(delegate(Weapon x) { return x.Size == size; });
		}
		public static List<Armour> Armour(this List<Item> inventory)
		{
			return inventory.FindAll(delegate(Item x) { return x.Type == ItemType.Armour; }).Cast<Armour>().ToList();
		}
		public static List<Armour> Armour(this List<Item> inventory, ArmourLocation location)
		{
			return inventory.Armour().FindAll(delegate(Armour x) { return x.Location == location; });
		}
		public static List<Consumable> Consumables(this List<Item> inventory)
		{
			return inventory.FindAll(delegate(Item x) { return x.Type == ItemType.Consumable; }).Cast<Consumable>().ToList();
		}

		public static List<Item> WeaponsAsItems(this List<Item> inventory)
		{
			return inventory.FindAll(delegate(Item x) { return x.Type == ItemType.Weapon; });
		}
		public static List<Item> WeaponsAsItems(this List<Item> inventory, WeaponSize size)
		{
			return inventory.Weapons(size).Cast<Item>().ToList();
		}
		public static List<Item> ArmourAsItems(this List<Item> inventory)
		{
			return inventory.FindAll(delegate(Item x) { return x.Type == ItemType.Armour; });
		}
		public static List<Item> ArmourAsItems(this List<Item> inventory, ArmourLocation location)
		{
			return inventory.Armour(location).Cast<Item>().ToList();
		}
		public static List<Item> ConsumablesAsItems(this List<Item> inventory)
		{
			return inventory.FindAll(delegate(Item x) { return x.Type == ItemType.Consumable; });
		}

		public static List<Armour> Location(this List<Armour> inventory, ArmourLocation location)
		{
			return inventory.FindAll(delegate(Armour x) { return x.Location == location; });
		}
	}
}
