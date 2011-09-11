using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public class Shop
	{
		private List<Item> stock = new List<Item>();
		Player customer;

		public Shop(Player shopper)
		{
			this.customer = shopper;
			this.stockshop();
		}

		private void stockshop()
		{
			for (int i = 1; i < 9; i++)
			{
				stock.Add(ItemGenerator.CreateItem(i));
			}
		}

		public void BuyItem(Item item)
		{
			customer.Gold -= item.Value * 15;
			if (item.Type == ItemType.Consumable && customer.PlayerHasItem(item.ID))
			{
				Consumable currentstash = (Consumable)customer.Inventory.Find(delegate(Item target){ return target.ID == item.ID; } );
				currentstash.Count ++;
			}
			else
			{
				customer.Inventory.Add(ItemGenerator.CreateItem(item.ID));
			}
		}
		

		public List<Item> Stock
		{
			get { return stock; }
		}

		public Player Customer
		{
			get { return customer; }
		}
	}
}
