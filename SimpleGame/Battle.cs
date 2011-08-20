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
			monster = new Monster(Fighting.ChooseMonster(player.Level));
			nextAction = CombatAction.Attack;
			nextActionItem = player.EquippedWeapon;
		}

		public void PlayerAttack()
		{
			if (player.Alive)
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
		}

		public void SelectNextAction(CombatAction action, Item itemToUse)
		{
			this.nextAction = action;
			this.nextActionItem = itemToUse;
		}

		public void Attack()
		{
			SelectNextAction(CombatAction.Attack, player.EquippedWeapon);
			this.Wait(1000 / player.AttackSpeed);
		}
		
		public void performItemEffect(Consumable item)
		{

			switch (item.Type)
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

			if (!monster.Alive)
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
				if (Fighting.RandomNumber(player.Speed) >= Fighting.RandomNumber(monster.Speed))
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

	}
}
