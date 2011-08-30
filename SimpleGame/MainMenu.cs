using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleGame
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
			Combat.generateMonsterList();
		}


		private void NewGamePicture_Click(object sender, EventArgs e)
		{
			this.newgame();
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.newgame();
		}

		private void newgame()
		{
			NewGame window = new NewGame();
			if (window.ShowDialog(this) == DialogResult.OK)
			{
				GameMenu game = new GameMenu(Game.StartGame(window.CharacterNameTextBox()));
				this.Hide();
				game.Show();
			}
		}

		private void LoadGamePicture_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				GameMenu game = new GameMenu(Game.LoadGame(openFileDialog.FileName));
				this.Hide();
				game.Show();
			}
		}
		
		private void QuitButton_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

	}
}
