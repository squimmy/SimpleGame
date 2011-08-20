using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleGame
{
	static class Game
	{
		public static bool GameInProgress = false;

		public static Player StartGame(string name)
		{
			List<Item> inventory = new List<Item>();
			inventory.Add(ItemGenerator.CreateItem(7));
			Weapon weapon = (Weapon)ItemGenerator.CreateItem(-1);
			Armour armour = (Armour)ItemGenerator.CreateItem(-2);
			Player player = new Player(name, 10, 1, 100, 0, 80, 3, 7, 1001, inventory, weapon, armour);
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
