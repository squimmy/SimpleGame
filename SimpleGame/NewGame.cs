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
	public partial class NewGame : Form
	{
		public NewGame()
		{
			InitializeComponent();
			CharacterNameInput.Text = SimpleGame.Logic.Game.RandomName();
		}

		public string CharacterNameTextBox()
		{
			return CharacterNameInput.Text;
		}

		private void StartGameButton_Click(object sender, EventArgs e)
		{
			if (CharacterNameInput.Text != "")
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				CharacterNameInput.Text = SimpleGame.Logic.Game.RandomName();
			}
		}

		private void CancelStartGameButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
