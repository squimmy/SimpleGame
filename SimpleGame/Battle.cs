using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame
{
	public class Battle
	{
		public Player player;
		public Monster monster;
		public string combatlog;
		private int playerTimer;
		private int monsterTimer;
		public enum CombatAction { Attack, UseItem };
		private CombatAction nextAction;
		private Item nextActionItem;

		public Battle(Player currentplayer)
		{
			player = currentplayer;
			playerTimer = monsterTimer = 0;
			monster = new Monster(Combat.ChooseMonster(player.Level));
			nextAction = CombatAction.Attack;
			nextActionItem = player.EquippedWeapon;
			player.Target = monster;
			monster.Target = player;
		}

		public void PlayerAttack()
		{
			Attack attack = player.AttackTarget();
			prependToCombatLog(attack.CombatMessage);
		}

		public void SelectNextAction(CombatAction action, Item itemToUse)
		{
			this.nextAction = action;
			this.nextActionItem = itemToUse;
		}

		public void Attack()
		{
			SelectNextAction(CombatAction.Attack, player.EquippedWeapon);
			this.Wait(1000 / playerActionSpeed());
		}
		
		public void performItemEffect(Consumable item)
		{

			switch (item.TypeOfConsumable)
			{
				case Consumable.ConsumableType.HealthPotion:
					player.HP += item.Effectiveness;
					break;
				case Consumable.ConsumableType.StrengthPotion:
					player.TemporaryDamageBonus = item.Effectiveness;
					break;
				case Consumable.ConsumableType.SpeedPotion:
					break;
				default:
					break;
			}
			item.Count -= 1;
			if (item.Count <= 0)
			{
				player.Inventory.Remove(item);
			}
		}

		public void UseItem(Consumable item)
		{
			this.nextAction = CombatAction.UseItem;
			this.nextActionItem = item;
			this.Wait(1000 / (player.Speed + item.Speed));
		}

		public void MonsterAttack()
		{
			Attack attack = monster.AttackTarget();
			prependToCombatLog(attack.CombatMessage);
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

		private void doPlayerAction()
		{
			switch (this.nextAction)
			{
				case CombatAction.Attack:
					this.InitiateAttack();
					break;
				case CombatAction.UseItem:
					this.performItemEffect((Consumable)nextActionItem);
					break;
				default:
					break;
			}
		}

		private void checkPlayerAction()
		{
			if (playerTimer >= (1000 / playerActionSpeed()))
			{
				playerTimer -= (1000 / playerActionSpeed());
				doPlayerAction();
			}
		}

		public int playerActionSpeed()
		{
			return player.Speed + nextActionItem.Speed;
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
			playerTimer += 1;
			monsterTimer += 1;
		}

		public void checkMonsterAttack()
		{
			if (monsterTimer >= (1000/monster.Speed))
			{
				monsterTimer -= (1000/monster.Speed);
				MonsterAttack();
			}
		}

		public void Wait(int units)
		{
			for (int i = 0; i < units; i++)
			{
				this.IncrementTime();
				if (Combat.RandomNumber(player.Speed) >= Combat.RandomNumber(monster.Speed))
				{
					checkPlayerAction();
					checkMonsterAttack();
				}
				else
				{
					checkMonsterAttack();
					checkPlayerAction();
				}
			}
			return;
		}

		private void prependToCombatLog(string text)
		{
			this.combatlog = text + System.Environment.NewLine + this.combatlog;
		}
	}
}
