using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleGame.Logic;

namespace SimpleGame
{
	public partial class CombatInventory : Form
	{
		Battle battle;

		private List<PictureBox> inventoryPicture = new List<PictureBox>();
		private List<Label> inventoryLabel = new List<Label>();
		private List<Consumable> inventoryConsumables = new List<Consumable>();


		public CombatInventory(Battle battle)
		{
			InitializeComponent();
			this.battle = battle;
			getpotionlist();
			showPlayerInventory();

		}

		private void showPlayerInventory()
		{
			getpotionlist();

			for (int i = 0; i < inventoryPicture.Count; i++)
			{
				this.InventoryPanel.Controls.Remove(inventoryPicture[i]);
				this.InventoryPanel.Controls.Remove(inventoryLabel[i]);
			}

			this.InventoryPanel.RowCount = inventoryConsumables.Count;

			if (inventoryConsumables.Count == 0)
			{
				this.InventoryPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
			}
			else
			{
				this.InventoryPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
			}



			inventoryPicture = new List<PictureBox>();
			inventoryLabel = new List<Label>();

			for (int i = 0; i < inventoryConsumables.Count; i++)
			{
				this.inventoryPicture.Add(new PictureBox());
				setupNewInventoryPicture(i);

				this.inventoryLabel.Add(new Label());
				setupNewInventoryLabel(i);
			}

		}

		private void setupNewInventoryPicture(int number)
		{
			inventoryPicture[number].Anchor = AnchorStyles.None;
			inventoryPicture[number].Size = new System.Drawing.Size(40, 40);
			inventoryPicture[number].Image = Art.GetItemImage(inventoryConsumables[number].ID);
			inventoryPicture[number].Tag = inventoryConsumables[number];

			inventoryPicture[number].Click += new EventHandler(useItem_Click);

			InventoryPanel.Controls.Add(inventoryPicture[number], 0, number);
		}

		private void setupNewInventoryLabel(int number)
		{
			inventoryLabel[number].Anchor = AnchorStyles.None;
			inventoryLabel[number].Text = inventoryConsumables[number].Name;
			InventoryPanel.Controls.Add(inventoryLabel[number], 1, number);
		}

		private void useItem_Click(object sender, EventArgs e)
		{
			PictureBox source = (PictureBox)sender;
			Consumable selection = (Consumable)source.Tag;

			battle.UseItem(selection);
			this.Close();
		}

		private void getpotionlist()
		{
			List<Item> templist = battle.player.Inventory.FindAll(delegate(Item target) { return target.Type == ItemType.Consumable; });
			inventoryConsumables = new List<Consumable>();

			foreach (Item item in templist)
			{
				inventoryConsumables.Add((Consumable)item);
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CombatInventory_Load(object sender, EventArgs e)
		{

		}

	}
}
