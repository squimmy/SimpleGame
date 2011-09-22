using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleGame.Logic;
using SimpleGame.Logic.InventoryExtensions;

namespace SimpleGame
{
	public partial class CombatInventory : Form
	{
		Battle battle;

		private List<PictureBox> inventoryPicture;
		private List<Label> inventoryLabel;
		
		public CombatInventory(Battle battle)
		{
			
			InitializeComponent();
			inventoryPicture = new List<PictureBox>();
			inventoryLabel = new List<Label>();

			this.battle = battle;
			showPlayerInventory();

		}

		private void showPlayerInventory()
		{
			for (int i = 0; i < inventoryPicture.Count; i++)
			{
				this.InventoryPanel.Controls.Remove(inventoryPicture[i]);
				this.InventoryPanel.Controls.Remove(inventoryLabel[i]);
			}

			this.InventoryPanel.RowCount = battle.player.Inventory.Consumables().Count;

			if (battle.player.Inventory.Consumables().Count == 0)
			{
				this.InventoryPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
			}
			else
			{
				this.InventoryPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
			}



			inventoryPicture = new List<PictureBox>();
			inventoryLabel = new List<Label>();

			for (int i = 0; i < battle.player.Inventory.Consumables().Count; i++)
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
			inventoryPicture[number].Image = Art.GetItemImage(battle.player.Inventory.Consumables()[number].ID);
			inventoryPicture[number].Tag = battle.player.Inventory.Consumables()[number];

			inventoryPicture[number].Click += new EventHandler(useItem_Click);

			InventoryPanel.Controls.Add(inventoryPicture[number], 0, number);
		}

		private void setupNewInventoryLabel(int number)
		{
			inventoryLabel[number].Anchor = AnchorStyles.None;
			inventoryLabel[number].Text = battle.player.Inventory.Consumables()[number].Name;
			InventoryPanel.Controls.Add(inventoryLabel[number], 1, number);
		}

		private void useItem_Click(object sender, EventArgs e)
		{
			PictureBox source = (PictureBox)sender;
			Consumable selection = (Consumable)source.Tag;

			battle.UseItem(selection);
			this.Close();
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
