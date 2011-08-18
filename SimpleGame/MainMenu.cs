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
		}


		private void pictureBox1_Click(object sender, EventArgs e)
		{
			newgame();
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			newgame();
		}

		private void newgame()
		{
			NewGame window = new NewGame();
			if (window.ShowDialog(this) == DialogResult.OK)
			{
				GameMenu game = new GameMenu(window.CharacterNameTextBox());
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
