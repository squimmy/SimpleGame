using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleGame;
using SimpleGame.Abilities;

namespace SimpleGame.Abilities
{
	class ItemAbility : Ability
	{
		Item item;
		protected Warrior target;
		protected DamageType damageType;

		public ItemAbility(Warrior Attacker, Item Item)
		{
			this.attacker = Attacker;
			this.item = Item;
			this.target = this.attacker.Target;
			this.speed = this.attacker.Speed + item.Speed;
			this.effectType = item.UsageAbility.EffectType;
		}

		public override IEffect UseAbility()
		{
			this.timer -= (1000 / this.speed);
			if (item.Type == Item.ItemType.Consumable)
			{
				Player player = (Player)attacker;
				Consumable consumable = (Consumable)item;
				consumable.Count--;
				if (consumable.Count <= 0)
					player.Inventory.Remove(consumable);
			}
			switch (effectType)
			{
				case EffectType.Damage:
					return null;
				case EffectType.Heal:
					return new HealEffect(attacker, effectiveness, accuracy, null);
				default:
					return null;
			}
		}

	}
}
