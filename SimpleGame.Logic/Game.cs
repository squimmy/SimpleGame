using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleGame.Logic
{
	public static class Game
	{
		public static bool GameInProgress = false;

		public static Player StartGame(string name)
		{
			List<Item> inventory = new List<Item>();
			inventory.Add(ItemGenerator.CreateItem(7));
			Weapon weapon = new Weapon();
			Armour headArmour = new Armour(ArmourLocation.Head);
			Armour torsoArmour = new Armour(ArmourLocation.Torso);
			Armour handArmour = new Armour(ArmourLocation.Hands);
			Armour legArmour = new Armour(ArmourLocation.Legs);
			Armour feetArmour = new Armour(ArmourLocation.Feet);

			Player player = new Player(name, 10, 1, 100, 0, 80, 3, 7, 1001, inventory, weapon, headArmour, torsoArmour, handArmour, legArmour, feetArmour);
			GameInProgress = true;
			return player;
		}

		public static string RandomName()
		{
			return "Bob";
		}

		public static void SaveGame(Player player, string path)
		{
			Stream stream = File.Open(path, FileMode.Create);
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(stream, player);
			stream.Close();
		}

		public static Player LoadGame(string path)
		{
			using(Stream stream = File.Open(path, FileMode.Open))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				Player player = (Player)formatter.Deserialize(stream);
				return player;
			}
		}
	}
}
