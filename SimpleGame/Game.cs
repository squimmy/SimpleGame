using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	static class Game
	{
		public static bool GameInProgress = false;

		public static void StartGame(string name)
	{
		Player player = new Player(name);
		GameInProgress = true;
	}

	public static string RandomName()
	{
		return "Bob";
	}




	}
}
