using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	class Battle
	{
		public Player player;
		public Monster monster;
		public string combatlog;

		public Battle(Player currentplayer)
		{
			player = currentplayer;
			monster = new Monster(Fighting.ChooseMonster(player.Level));
			if (Fighting.MonsterHasInitiative(monster.Speed, player.Speed))
			{
				this.MonsterAttack();
			}
		}

		public void PlayerAttack()
		{
			if (player.Hit)
			{
				int damage = Fighting.RandomNumber(player.Damage + player.EquippedWeapon.Damage + player.TemporaryDamageBonus);

				if (damage > 0)
				{
					monster.HP -= damage;
					this.combatlog = ("You hit the " + monster.Name + " and dealt " + damage.ToString() + " damage!" + System.Environment.NewLine + this.combatlog);
				}
				else
				{
					this.combatlog = ("You hit the " + monster.Name + ", but you didn't deal any damage." + System.Environment.NewLine + this.combatlog);
				}
			}
			else
			{
				this.combatlog = ("You missed the " + monster.Name + System.Environment.NewLine + this.combatlog);
			}
		}

		public void MonsterAttack()
		{
			if (monster.Hit)
			{
				int damage = Fighting.RandomNumber(monster.Damage);

				if (damage > 0)
				{
					player.HP -= damage;
					this.combatlog = ("The " + monster.Name + " hit you! you took " + damage.ToString() + " damage!" + System.Environment.NewLine + this.combatlog);
				}
				else
				{
					this.combatlog = ("The " + monster.Name + " hit you, but you didn't take any damage." + System.Environment.NewLine + this.combatlog);
				}
			}
			else
			{
				this.combatlog = ("The " + monster.Name + " missed you." + System.Environment.NewLine + this.combatlog);
			}
		}

		public void InitiateAttack()
		{
			PlayerAttack();

			if (monster.Alive)
			{
				MonsterAttack();
			}
			else
			{
				string congratulations = "Congratulations! You defeated the " + monster.Name + "." + System.Environment.NewLine + "You have gained " + monster.XPReward.ToString() + " experience points";
				if (monster.GoldReward > 0)
				{
					congratulations += ", and looted " + monster.GoldReward.ToString() + " gold pieces.";
				}
				combatlog = (congratulations + Environment.NewLine + Environment.NewLine + this.combatlog);
				player.XP += monster.XPReward;
				player.Gold += monster.GoldReward;
			}
		}

		public bool TryToRun()
		{
			if (StillFighting() && Fighting.MonsterHasInitiative(monster.Speed, player.Speed))
			{
				combatlog = ("The " + monster.Name + " chased you down!" + System.Environment.NewLine + this.combatlog);
				MonsterAttack();
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool StillFighting()
		{
			if (player.Alive && monster.Alive)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
