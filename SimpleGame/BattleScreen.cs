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
	public partial class BattleScreen : Form
	{
		private Battle battle;
		System.Timers.Timer autoattacktimer = new System.Timers.Timer();
		private bool _altF4Pressed = false;
		

		public BattleScreen(Player currentplayer)
		{
			InitializeComponent();
			battle = new Battle(currentplayer);
			this.PlayerName.Text = battle.player.Name;
			this.PlayerHP.Text = battle.player.HPText;
			this.MonsterName.Text = battle.monster.Name;
			this.MonsterHP.Text = battle.monster.HPText;
			this.PlayerPicture.Image = global::SimpleGame.Properties.Resources.player_image;
			this.MonsterPicture.Image = battle.monster.Picture;
		}



		private void SetHPTextColour()
		{
			if (battle.player.HP <= battle.player.MaxHP / 4)
			{
				this.PlayerHP.ForeColor = System.Drawing.Color.Red;
			}
			else if (battle.player.HP <= battle.player.MaxHP / 2)
			{
				this.PlayerHP.ForeColor = System.Drawing.Color.Yellow;
			}
			else
			{
				this.PlayerHP.ForeColor = System.Drawing.Color.Black;
			}
			if (battle.monster.HP <= battle.monster.MaxHP / 4)
			{
				this.MonsterHP.ForeColor = System.Drawing.Color.Red;
			}
			else if (battle.monster.HP <= battle.monster.MaxHP / 2)
			{
				this.MonsterHP.ForeColor = System.Drawing.Color.Yellow;
			}
			else
			{
				this.MonsterHP.ForeColor = System.Drawing.Color.Black;
			}

		}

		private void AttackPicture_Click(object sender, EventArgs e)
		{
			if (autoattacktimer.Enabled)
			{
				this.StopAutoAttack();
			}
			if (battle.StillFighting())
			{
				battle.InitiateAttack();
				UpdateTextAndPictures();
			}
		}

		private void UpdateTextAndPictures()
		{
			this.CombatLogTextBox.Text = battle.combatlog;
			this.MonsterHP.Text = battle.monster.HPText;
			this.PlayerHP.Text = battle.player.HPText;
			this.SetHPTextColour();
			if (!battle.StillFighting())
			{
				this.AttackPicture.Image = null;
				this.AutoPicture.Image = null;
				this.ItemPicture.Image = null;
				this.RunPicture.Image = SimpleGame.Properties.Resources.leave_image;
			}
		}

		private void RunPicture_Click(object sender, EventArgs e)
		{
			if (autoattacktimer.Enabled)
			{
				this.StopAutoAttack();
			}

			if (battle.TryToRun())
			{
				this.Close();
			}
			else
			{
				this.UpdateTextAndPictures();
			}
		}

		private void AutoPicture_Click(object sender, EventArgs e)
		{
			if (battle.StillFighting())
			{
				battle.InitiateAttack();
				this.UpdateTextAndPictures();

				if (battle.player.HP > battle.player.MaxHP / 5 && !autoattacktimer.Enabled)
				{
					autoattacktimer.Interval = 700;
					autoattacktimer.Start();
					autoattacktimer.Elapsed += new System.Timers.ElapsedEventHandler(this.AutoAttack);
					this.AutoPicture.Image = SimpleGame.Properties.Resources.stop_image;
				}
				else
				{
					this.StopAutoAttack();
				}
			}
		
		}

		private void AutoAttack(object sender, EventArgs e)
		{
			if (battle.StillFighting())
			{
				if (battle.player.HP > battle.player.MaxHP / 4)
				{
					battle.InitiateAttack();
					Action a = () => this.UpdateTextAndPictures();
					this.Invoke(a);
				}
				else
				{
					this.StopAutoAttack();
				}

				if (!battle.StillFighting())
				{
					this.StopAutoAttack();
				}
			}
		
				else
				{
					this.StopAutoAttack();
				}
			
		}

		private void StopAutoAttack()
		{
			autoattacktimer.Stop();
			if (battle.StillFighting())
			{
				this.AutoPicture.Image = SimpleGame.Properties.Resources.auto_image;	
			}
			else
			{
				this.AutoPicture.Image = null;
			}
			
		}

		private void EndOfBattle(object sender, FormClosedEventArgs e)
		{
			if (!battle.StillFighting())
			{
				if (battle.player.HP <= 0)
				{
					int doctorfee = battle.player.Level * 20;
					string message = "You have been killed!" + System.Environment.NewLine + "Don't worry. The magical medicine man has fixed you up good as new." + System.Environment.NewLine + "(and helped himself to a fee of " + doctorfee.ToString() + " gold.)";
					MessageBox.Show(message, "You died!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					battle.player.Resurrect(doctorfee);
				}

			}
			battle.player.TemporaryDamageBonus = 0;
			battle.player.HP = battle.player.MaxHP;
		}

		private void ItemPicture_Click(object sender, EventArgs e)
		{
			CombatInventory inventorywindow = new CombatInventory(battle.player);
			inventorywindow.ShowDialog();
			this.UpdateTextAndPictures();
		}

		private void CatchAltf4(object sender, FormClosingEventArgs e)
		{
			if (_altF4Pressed)
			{
				if (e.CloseReason == CloseReason.UserClosing)
				{
					e.Cancel = true;
					_altF4Pressed = false;
				}
			}
		}

		private void GetKeys(object sender, KeyEventArgs e)
		{
			if (e.Alt && e.KeyCode == Keys.F4)
			{
				_altF4Pressed = true;
			}
		}



		
	}
}
