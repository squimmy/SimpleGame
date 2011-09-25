using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleGame
{
	public partial class ItemInfo : UserControl
	{
		private Logic.Item item;
		private Logic.Player player;

		public ItemInfo()
		{
			InitializeComponent();
			this.ClearPanel();
		}
		/// <summary>
		/// Clears the panel completely, leaving a blank white panel
		/// </summary>
		public void ClearPanel()
		{
			this.ItemPicture.Image = null;
			this.ItemName.Text = null;
			this.ItemInfoLabel.Text = null;
			this.detailsPanel.Controls.Clear();
			this.buttonPanel.Controls.Clear();
		}

		public void ShowItemInfo()
		{
			if (this.item == null || this.player == null)
			{
				this.ClearPanel();
			}
			else
			{
				this.ClearPanel();
				this.ItemPicture.Image = Art.GetItemImage(item.ID);
				this.ItemName.Text = item.Name;
				this.ItemInfoLabel.Text = item.Info;
				this.generateItemDetails();
			}
		}
		public void ShowItemInfo(Logic.Item item, Logic.Player owner)
		{
			this.player = owner;
			this.item = item;
			this.ShowItemInfo();
		}
		public void ShowItemInfo(Logic.Item item, Logic.Item itemToCompareTo)
		{

		}


		private void generateItemDetails()
		{
			if (this.item.Type == Logic.ItemType.Weapon)
				addWeaponDetails();
			if (this.item.Type == Logic.ItemType.Weapon || this.item.Type == Logic.ItemType.Armour)
				addEquippableDetails();

			Button moreInfo = new Button()
			{ Text = "More Info" };
			moreInfo.Click += new EventHandler(moreInfoClicked);
			this.buttonPanel.Controls.Add(moreInfo, 0, 0);

			if (item.Equippable && player != null)
				this.addEquippableButtons();
		}
		private void addEquippableDetails()
		{
			Logic.IEquipable equipment = this.item as Logic.IEquipable;
			if (equipment == null)
				return;

			foreach (Logic.Stat stat in Enum.GetValues(typeof(Logic.Stat)))
			{
				if (equipment.Bonus[stat] != 0)
				{
					Label bonus = new Label() { Text = string.Format("{0} Bonus: {1}", stat.ToString(), equipment.Bonus[stat]) };
					bonus.Dock = DockStyle.Fill;
					this.detailsPanel.Controls.Add(bonus);
				}
			}

			foreach (Logic.DamageType type in Enum.GetValues(typeof(Logic.DamageType)))
			{
				if (equipment.Protection[type] != 0)
				{
					Label protection = new Label() { Text = string.Format("{0} Resistance: {1}", type.ToString(), equipment.Protection[type]) };
					protection.Dock = DockStyle.Fill;
					this.detailsPanel.Controls.Add(protection);
				}
			}
		}
		private void addWeaponDetails()
		{
			Logic.Weapon weapon = this.item as Logic.Weapon;
			if (weapon == null)
				return;

			Label damage = new Label() { Text = string.Format("Damage: {0} ({1})", weapon.Damage, weapon.DamageType) };
			damage.Dock = DockStyle.Fill;
			Label speed = new Label() { Text = string.Format("Speed: {0}", weapon.Speed) };
			speed.Dock = DockStyle.Fill;
			this.detailsPanel.Controls.Add(damage);
			this.detailsPanel.Controls.Add(speed);
		}
		private void addEquippableButtons()
		{
			if (player.Equipment.IsEquipped(item))
			{
				Button unequipButton = new Button() { Text = "Unequip" };
				unequipButton.Click += new EventHandler(unequipButtonClicked);
				this.buttonPanel.Controls.Add(unequipButton, 1, 0);
			}
			else
			{
				Button equipButton = new Button() { Text = "Equip" };
				equipButton.Click += new EventHandler(equipButtonClicked);
				this.buttonPanel.Controls.Add(equipButton, 1, 0);
			}
		}

		private void moreInfoClicked(object sender, EventArgs e)
		{
		}
		private void equipButtonClicked(object sender, EventArgs e)
		{
			if (item.Type == Logic.ItemType.Armour)
			{
				player.Equipment.EquipArmour(item as Logic.Armour);
				this.ShowItemInfo();
			}
		}
		private void unequipButtonClicked(object sender, EventArgs e)
		{
			player.Equipment.UnequipItem(item);
			this.ShowItemInfo();
		}
		
	}
}
