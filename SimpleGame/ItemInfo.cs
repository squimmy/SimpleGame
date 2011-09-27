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
			this.detailsPanel.Controls.AddRange(getItemDetails(item).ToArray());
			

			Button moreInfo = new Button()
			{ Text = "More Info" };
			moreInfo.Click += new EventHandler(moreInfoClicked);
			this.buttonPanel.Controls.Add(moreInfo, 0, 0);

			if (item.Equippable && player != null)
			this.addEquippableButtons();
		}
		
		private List<Label> getItemDetails(Logic.Item item)
		{
			List<Logic.ItemDetail> details = item.ShortDescription;
			List<Label> labels = new List<Label>();

			foreach (Logic.ItemDetail detail in details)
			{
				Label detaillabel = new Label() { Text = detail.text, Dock = DockStyle.Fill };
				labels.Add(detaillabel);
			}

			return labels;
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
			if (item.Type == Logic.ItemType.Weapon)
			{
				Logic.Weapon weapon = item as Logic.Weapon;
				if (weapon.Size != Logic.WeaponSize.Small)
				{
					player.Equipment.EquipRightHandWeapon(weapon);
				}
			}
		}
		private void unequipButtonClicked(object sender, EventArgs e)
		{
			player.Equipment.UnequipItem(item);
			this.ShowItemInfo();
		}
		
	}
}
