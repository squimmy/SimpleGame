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
	public partial class ShopMenu : Form
	{
		private Shop shop;
		private List<Label> shopInventoryPriceLabel = new List<Label>();
		private List<PictureBox> shopInventoryPicture = new List<PictureBox>();
		private List<Label> shopInventoryLabel = new List<Label>();
		
		private List<Label> playerInventoryPriceLabel= new List<Label>();
		private List<PictureBox> playerInventoryPicture = new List<PictureBox>();
		private List<Label> playerInventoryLabel = new List<Label>();

		private enum Action {Buy, Equip};

		private delegate void actionClickedEventHandler(Item item);
		
		public ShopMenu(Player player)
		{
			InitializeComponent();
			shop = new Shop(player);

			this.ShopInventoryPanel.RowCount = shop.Stock.Count;

			for (int i = 0; i < shop.Stock.Count; i++)
			{
				shopInventoryPriceLabel.Add(new Label());
				setupNewInventoryPriceLabel(i, this.shopInventoryPriceLabel, this.ShopInventoryPanel, shop.Stock);

				shopInventoryPicture.Add(new PictureBox());
				setupNewInventoryPicture(i, this.shopInventoryPicture, this.ShopInventoryPanel, shop.Stock, Action.Buy);

				shopInventoryLabel.Add(new Label());
				setupNewInventoryLabel(i, this.shopInventoryLabel, this.ShopInventoryPanel, shop.Stock);
			}

			this.showPlayerInventory();
		}
		


		private void showPlayerInventory()
		{

			this.PlayerInventoryPanel.RowCount = shop.Customer.Inventory.Count;
			this.CurrentWeaponStats.Text = this.equippedWeaponStats();
			this.CurrentArmourStats.Text = this.equippedArmourStats();

			if (shop.Customer.Inventory.Count == 0)
			{
				this.PlayerInventoryPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
			}
			else
			{
				this.PlayerInventoryPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
			}

			for (int i = 0; i < shop.Customer.Inventory.Count; i++)
			{
				this.playerInventoryPriceLabel.Add(new Label());
				setupNewInventoryPriceLabel(i, this.playerInventoryPriceLabel, this.PlayerInventoryPanel, shop.Customer.Inventory);

				this.playerInventoryPicture.Add(new PictureBox());
				setupNewInventoryPicture(i, this.playerInventoryPicture, this.PlayerInventoryPanel, shop.Customer.Inventory, Action.Equip);

				this.playerInventoryLabel.Add(new Label());
				setupNewInventoryLabel(i, this.playerInventoryLabel, this.PlayerInventoryPanel, shop.Customer.Inventory);
			}

			this.goldlabel.Text = "Current Gold: " + this.shop.Customer.Gold.ToString() + "g";
		}

		private string equippedWeaponStats()
		{
			if (shop.Customer.EquippedWeapon.ID == 0)
			{
				 return "none";
			}
			else if (shop.Customer.EquippedWeapon.Type == Item.ItemType.Weapon)
			{
				Weapon current = (Weapon)shop.Customer.EquippedWeapon;
				return current.Name + " (" + current.Damage + " damage)";
		 	}
			else
			{
				return shop.Customer.EquippedWeapon.Name;
			}
		}

		private string equippedArmourStats()
		{
			if (shop.Customer.EquippedArmour.ID == 0)
			{
				return "none";
			}
			else if (shop.Customer.EquippedArmour.Type == Item.ItemType.Armour)
			{
				Armour current = (Armour)shop.Customer.EquippedArmour;
				return current.Name + " (" + current.Protection + " protection)";
			}
			else
			{
				return shop.Customer.EquippedArmour.Name;
			}
		}

		private void setupNewInventoryPriceLabel(int number, List<Label> inventoryPriceLabel, TableLayoutPanel inventoryPanel, List<Item> inventory)
		{
			inventoryPriceLabel[number].Anchor = AnchorStyles.None;
			inventoryPriceLabel[number].AutoSize = true;
			inventoryPriceLabel[number].Text = (inventory[number].Value * 15).ToString() + "g";
			inventoryPanel.Controls.Add(inventoryPriceLabel[number], 0, number);
		}
		
		private void setupNewInventoryPicture(int number, List<PictureBox> inventoryPicture, TableLayoutPanel inventoryPanel, List<Item> inventory, Action action)
		{
			inventoryPicture[number].Anchor = AnchorStyles.None;
			inventoryPicture[number].Size = new System.Drawing.Size(40, 40);
			inventoryPicture[number].Image = inventory[number].Picture;
			inventoryPicture[number].Tag = inventory[number];
						
			if (action == Action.Buy)
			{
				inventoryPicture[number].Click += new EventHandler(BuyPicture_Click);
			}
			else if (action == Action.Equip)
			{
				inventoryPicture[number].Click += new EventHandler(EquipPicture_Click);
			}
			inventoryPanel.Controls.Add(inventoryPicture[number], 1, number);
		}

		private void setupNewInventoryLabel(int number, List<Label> inventoryLabel, TableLayoutPanel inventoryPanel, List<Item> inventory)
		{
			inventoryLabel[number].Anchor = AnchorStyles.None;
			inventoryLabel[number].Text = inventory[number].Name;
			inventoryPanel.Controls.Add(inventoryLabel[number], 2, number);
		}



		private void BuyPicture_Click(object sender, EventArgs e)
		{
			PictureBox source = (PictureBox)sender;
			Item item = (Item)source.Tag;
			string info = item.Name + Environment.NewLine + Environment.NewLine + "Price: " + (item.Value * 15).ToString() + "g" + Environment.NewLine;
			MessageBoxButtons boxtype;
			string boxtitle = item.Name + " info";

			switch (item.Type)
			{
				case Item.ItemType.Weapon:
					Weapon weapon = (Weapon)item;
					info += "Damage: " + weapon.Damage.ToString() + Environment.NewLine;
					break;
				case Item.ItemType.Armour:
					Armour armour = (Armour)item;
					info += "Protection: " + armour.Protection.ToString() + Environment.NewLine;
					break;
				default:
					break;
			}
			info += Environment.NewLine;


			if (shop.Customer.PlayerHasItem(item.ID) && item.Type != Item.ItemType.Consumable)
			{
				info += "(You already own one of these)";
				boxtype = MessageBoxButtons.OK;
			}
			else if (item.Value * 15 > shop.Customer.Gold)
			{
				info += "(You can't afford this item)";
				boxtype = MessageBoxButtons.OK;
			}
			else
			{
				info += Environment.NewLine + "Would you like to buy this item?";
				boxtitle = "Buy " + item.Name;
				boxtype = MessageBoxButtons.YesNo;
			}
			
			var result = MessageBox.Show(info, "Buy " + item.Name, boxtype);

			if (result == DialogResult.Yes)
			{
				shop.BuyItem(item);
				showPlayerInventory();
			}
		}

		private void EquipPicture_Click(object sender, EventArgs e)
		{
			PictureBox source = (PictureBox)sender;
			Item item = (Item)source.Tag;
			string info = item.Name + Environment.NewLine + Environment.NewLine + "Price: " + (item.Value * 15).ToString() + "g" + Environment.NewLine;
			MessageBoxButtons boxtype;
			string boxtitle = item.Name + " info";

			switch (item.Type)
			{
				case Item.ItemType.Weapon:
					Weapon weapon = (Weapon)item;
					info += "Damage: " + weapon.Damage.ToString() + Environment.NewLine;
					break;
				case Item.ItemType.Armour:
					Armour armour = (Armour)item;
					info += "Protection: " + armour.Protection.ToString() + Environment.NewLine;
					break;
				default:
					break;
			}
			info += Environment.NewLine;


			if ((item.Type == Item.ItemType.Weapon && shop.Customer.EquippedWeapon.ID == item.ID) || (item.Type == Item.ItemType.Armour && shop.Customer.EquippedArmour.ID == item.ID))
			{
				info += "(already equipped)";
				boxtype = MessageBoxButtons.OK;
			}
			else if (item.Type == Item.ItemType.Consumable)
			{
				boxtype = MessageBoxButtons.OK;
			}
			else
			{
				info += Environment.NewLine + "Equip this item?";
				boxtitle = "Equip " + item.Name;
				boxtype = MessageBoxButtons.YesNo;
			}

			var result = MessageBox.Show(info, "Buy " + item.Name, boxtype);

			if (result == DialogResult.Yes)
			{
				if (item.Type == Item.ItemType.Weapon)
				{
					shop.Customer.EquipWeapon((Weapon)item);
					showPlayerInventory();
				}
				else if (item.Type == Item.ItemType.Armour)
				{
					shop.Customer.EquipArmour((Armour)item);
					showPlayerInventory();
				}
			}
		}

		private void LeavePicture_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
