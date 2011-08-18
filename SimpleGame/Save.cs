using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleGame
{
	public static class Save
	{
		public static void SaveGame(Player player, string path)
		{
			Stream stream = File.Open(path, FileMode.Create);
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(stream, player);
			stream.Close();
		}
	}
}
