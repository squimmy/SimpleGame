using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public class Battle
	{
		public Player player;
		public Monster monster;
		public string combatlog;

		public Battle(Player currentplayer)
		{
			player = currentplayer;
			monster = new Monster(Combat.ChooseMonster(player.Level));
			player.ResetTimers();
			monster.ResetTimers();
			player.Target = monster;
			monster.Target = player;
		}

		public void PlayerAttack()
		{
			prependToCombatLog(player.UseAllReadyAbilities());
		}
		public void MonsterAttack()
		{
			prependToCombatLog(monster.UseAllReadyAbilities());
		}

		public void Attack()
		{
			player.SelectNewAction(CombatAction.Attack, player.EquippedWeapon);
			this.Wait();
		}
		
		public void UseItem(Consumable item)
		{
			player.SelectNewAction(CombatAction.UseItem, item);
			this.Wait();
			player.SelectNewAction(CombatAction.Attack, player.EquippedWeapon);
		}
		
		public void InitiateAttack()
		{
			PlayerAttack();

			if (!monster.Alive)
			{
				string congratulations = string.Format("Congratulations! You defeated the {0}.", monster.Name) + System.Environment.NewLine + string.Format("You have gained {0} experience points", monster.XPReward.ToString());
				if (monster.GoldReward > 0)
				{
					congratulations += string.Format(", and looted {0} gold pieces.", monster.GoldReward.ToString());
				}
				else
				{
					congratulations += ".";
				}
				prependToCombatLog(congratulations + Environment.NewLine);
				player.XP += monster.XPReward;
				player.Gold += monster.GoldReward;
			}
		}

		public bool TryToRun()
		{
			if (StillFighting() && Combat.MonsterHasInitiative(monster.Speed, player.Speed))
			{
				prependToCombatLog(string.Format("The {0} chased you down!", monster.Name));
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
			return player.Alive && monster.Alive;
		}

		public void IncrementTime()
		{
			player.IncrementTimers();
			monster.IncrementTimers();
		}
		public void Wait()
		{
			bool breakflag = false;
			while (player.Alive && monster.Alive)
			{
				IncrementTime();
				if (player.PrimaryAbility.Ready)
					breakflag = true;
				resolveAbilities();
				if (breakflag)
					break;
			}
			return;
		}
		public void Wait(int time)
		{
			for (int i = 0; i < time; i++)
			{
				this.IncrementTime();
				resolveAbilities();
			}
			return;
		}

		private void resolveAbilities()
		{
			if (Combat.RandomNumber(player.Speed) >= Combat.RandomNumber(monster.Speed))
			{
				prependToCombatLog(player.UseAllReadyAbilities());
				prependToCombatLog(monster.UseAllReadyAbilities());

			}
			else
			{
				prependToCombatLog(monster.UseAllReadyAbilities());
				prependToCombatLog(player.UseAllReadyAbilities());
			}
		}

		private void prependToCombatLog(string text)
		{
			if (text != null)
				this.combatlog = text + System.Environment.NewLine + this.combatlog;
		}
	}
}
