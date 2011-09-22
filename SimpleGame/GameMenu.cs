using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleGame.Logic;

namespace SimpleGame
{
	public partial class GameMenu : Form
	{

		

		Player player;	

		public GameMenu(Player player)
		{
			InitializeComponent();
			this.player = player;
			this.UpdateText();
		}


		private void FightMonstersPicture_Click(object sender, EventArgs e)
		{
			BattleScreen fight = new BattleScreen(player);
			fight.ShowDialog();
			this.UpdateText();
		}
		private void ShopPicture_Click(object sender, EventArgs e)
		{
			//ShopMenu goshopping = new ShopMenu(player);
			//goshopping.ShowDialog();
			//this.UpdateText();
			Inventory inventory = new Inventory(player);
			inventory.ShowDialog();

		}
		private void SavePicture_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Game.SaveGame(player, saveFileDialog.FileName);
			}
		}
		private void QuitPicture_Click(object sender, EventArgs e)
		{
			quitgame(sender, e);
		}


		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewGame window = new NewGame();
			if (window.ShowDialog(this) == DialogResult.OK)
			{
				this.player = Game.StartGame(window.CharacterNameTextBox());
				this.UpdateText();
			}
		}
		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			quitgame(sender, e);
		}

		private void quitgame(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to quit the game?", "Really Quit?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
			Environment.Exit(0);
			}
		}

		private void UpdateText()
		{

			this.NameLabel.Text = player.Name;
			this.XPLabel.Text = player.XPText;
			this.HPLabel.Text = player.HPText;
			this.LevelLabel.Text = player.Level.ToString();
			this.GoldLabel.Text = player.Gold.ToString();
		}

	}
}
