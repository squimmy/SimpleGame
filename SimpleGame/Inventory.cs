using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleGame.Logic.InventoryExtensions;

namespace SimpleGame
{
	public partial class Inventory : Form
	{
		private enum EquipmentSlot { Head, Torso, Hands, Legs, Feet, RightHand, LeftHand }
		private EquipmentSlot? selection;
		private List<Logic.Item> inventoryToDisplay;
		private List<InventoryEntry> inventoryEntries;
		private Dictionary<EquipmentSlot, InventoryEntry> equippedItems;
		private Logic.Player player;
		private Logic.Item selectedEquipment;
		private Logic.Item selectedItem;
		private Rectangle headLocation;
		private Rectangle torsoLocation1;
		private Rectangle torsoLocation2;
		private Rectangle torsoLocation3;
		private Rectangle torsoLocation4;
		private Rectangle torsoLocation5;
		private Rectangle legsLocation1;
		private Rectangle legsLocation2;
		private Rectangle handsLocation;
		private Rectangle feetLocation;
		private Logic.ItemType subFilterMode;

		public Inventory(Logic.Player player)
		{
			InitializeComponent();

			this.player = player;
			this.attackDefenseInfo.Player = player;
			this.equippedItems = new Dictionary<EquipmentSlot, InventoryEntry>()
			{
				{ EquipmentSlot.RightHand, mainHandEquipment },
				{ EquipmentSlot.LeftHand, offHandEquipment },
				{ EquipmentSlot.Head, headEquipment },
				{ EquipmentSlot.Torso, torsoEquipment },
				{ EquipmentSlot.Hands, handEquipment },
				{ EquipmentSlot.Legs, legEquipment },
				{ EquipmentSlot.Feet, feetEquipment },
			};
			this.offHandEquipment.ImageFlipped = true;
			this.inventoryToDisplay = new List<Logic.Item>();

			this.inventoryEntries = new List<InventoryEntry>();



			this.characterImage.Image = SimpleGame.Properties.Resources.none_selected;
			headLocation = new Rectangle(26, 0, 28, 32);
			torsoLocation1 = new Rectangle(0, 32, 80, 65);
			torsoLocation2 = new Rectangle(24, 97, 32, 2);
			torsoLocation3 = new Rectangle(34, 99, 12, 2);
			torsoLocation4 = new Rectangle(2, 97, 12, 2);
			torsoLocation5 = new Rectangle(66, 97, 12, 2);
			legsLocation1 = new Rectangle(16, 97, 48, 53);
			legsLocation2 = new Rectangle(14, 150, 52, 37);
			handsLocation = new Rectangle(0, 99, 80, 17);
			feetLocation = new Rectangle(4, 187, 72, 23);

			this.deselectAllEquipment();
			this.attackDefenseInfo.UpdateLabels();
			this.updateEquipmentIcons();

			this.inventoryFilterBox.SelectedValueChanged += new EventHandler(displayInventory);
			this.inventorySubFilter.SelectedValueChanged += new EventHandler(displayInventory);
			this.inventoryFilterBox.SelectedIndex = 0;
			this.inventorySubFilter.SelectedIndex = 0;
		}

		private void updateEquipmentIcons()
		{
			this.mainHandEquipment.Item = player.Equipment.RightHandWeapon;

			if (player.Equipment.LeftHandWeapon != null)
			{
				this.offHandEquipment.Item = player.Equipment.LeftHandWeapon;
			}
			else
			{
				this.offHandEquipment.Item = null;
			}
			this.headEquipment.Item = player.Equipment.EquippedArmour[Logic.ArmourLocation.Head];
			this.torsoEquipment.Item = player.Equipment.EquippedArmour[Logic.ArmourLocation.Torso];
			this.handEquipment.Item = player.Equipment.EquippedArmour[Logic.ArmourLocation.Hands];
			this.legEquipment.Item = player.Equipment.EquippedArmour[Logic.ArmourLocation.Legs];
			this.feetEquipment.Item = player.Equipment.EquippedArmour[Logic.ArmourLocation.Feet];
		}
		private void updateSelectedEquipmentInfo()
		{
			if (this.selectedEquipment != null)
				this.selectedEquipmentInfo.ShowItemInfo(selectedEquipment);
			else
				this.selectedEquipmentInfo.ClearPanel();
		}
		private void updateSelectedItemInfo()
		{
			if (this.selectedItem != null)
				this.selectedItemInfo.ShowItemInfo(selectedItem);
			else
				this.selectedItemInfo.ClearPanel();
		}

		private void characterImage_Click(object sender, EventArgs e)
		{
			MouseEventArgs mouse = (MouseEventArgs)e;
			if (headLocation.Contains(mouse.Location))
			{
				headClicked(sender, e);
			}
			else if (torsoLocation1.Contains(mouse.Location) || torsoLocation2.Contains(mouse.Location) || torsoLocation3.Contains(mouse.Location) || torsoLocation4.Contains(mouse.Location) || torsoLocation5.Contains(mouse.Location))
			{
				torsoClicked(sender, e);
			}
			else if (legsLocation1.Contains(mouse.Location) || legsLocation2.Contains(mouse.Location))
			{
				legClicked(sender, e);
			}
			else if (handsLocation.Contains(mouse.Location))
			{
				handClicked(sender, e);
			}
			else if (feetLocation.Contains(mouse.Location))
			{
				feetClicked(sender, e);
			}
			else
			{
				deselectAllEquipment();
			}
		}
		private void headClicked(object sender, EventArgs e)
		{
			if (selection == EquipmentSlot.Head)
			{
				deselectAllEquipment();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Head);
			}
		}
		private void torsoClicked(object sender, EventArgs e)
		{
			if (selection == EquipmentSlot.Torso)
			{
				deselectAllEquipment();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Torso);
			}
		}
		private void legClicked(object sender, EventArgs e)
		{
			if (selection == EquipmentSlot.Legs)
			{
				deselectAllEquipment();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Legs);
			}
		}
		private void handClicked(object sender, EventArgs e)
		{
			if (selection == EquipmentSlot.Hands)
			{
				deselectAllEquipment();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Hands);
			}
		}
		private void feetClicked(object sender, EventArgs e)
		{
			if (selection == EquipmentSlot.Feet)
			{
				deselectAllEquipment();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Feet);
			}
		}
		private void mainHandClicked(object sender, EventArgs e)
		{
			if (selection == EquipmentSlot.RightHand)
			{
				deselectAllEquipment();
			}
			else
			{
				this.selectLocation(EquipmentSlot.RightHand);
			}
		}
		private void offHandClicked(object sender, EventArgs e)
		{
			if (selection == EquipmentSlot.LeftHand)
			{
				deselectAllEquipment();
			}
			else
			{
				this.selectLocation(EquipmentSlot.LeftHand);
			}
		}
		private void highlightSelection(EquipmentSlot location)
		{
			this.equippedItems[location].Highlight();
			switch (location)
			{
				case EquipmentSlot.Head:
					this.characterImage.Image = SimpleGame.Properties.Resources.head_selected;
					break;
				case EquipmentSlot.Torso:
					this.characterImage.Image = SimpleGame.Properties.Resources.torso_selected;
					break;
				case EquipmentSlot.Hands:
					this.characterImage.Image = SimpleGame.Properties.Resources.hands_selected;
					break;
				case EquipmentSlot.Legs:
					this.characterImage.Image = SimpleGame.Properties.Resources.legs_selected;
					break;
				case EquipmentSlot.Feet:
					this.characterImage.Image = SimpleGame.Properties.Resources.feet_selected;
					break;
				case EquipmentSlot.RightHand:
					this.rightHandLabel.ForeColor = Color.Red;
					break;
				case EquipmentSlot.LeftHand:
					this.leftHandLabel.ForeColor = Color.Red;
					break;
				default:
					break;
			}
		}

		private void selectLocation(EquipmentSlot location)
		{
			this.selection = location;
			this.selectedEquipment = getLocationItem(location);

			this.clearEquipmentHighlighting();
			this.highlightSelection(location);
			this.matchInventoryFilterToEquipmentSelection(location);

			this.updateSelectedEquipmentInfo();
		}
		private Logic.Item getLocationItem(EquipmentSlot location)
		{
			switch (location)
			{
				case EquipmentSlot.Head: return player.Equipment.EquippedArmour[Logic.ArmourLocation.Head];
				case EquipmentSlot.Torso: return player.Equipment.EquippedArmour[Logic.ArmourLocation.Torso];
				case EquipmentSlot.Hands: return player.Equipment.EquippedArmour[Logic.ArmourLocation.Hands];
				case EquipmentSlot.Legs: return player.Equipment.EquippedArmour[Logic.ArmourLocation.Legs];
				case EquipmentSlot.Feet: return player.Equipment.EquippedArmour[Logic.ArmourLocation.Feet];
				case EquipmentSlot.RightHand: return player.Equipment.RightHandWeapon;
				case EquipmentSlot.LeftHand: return player.Equipment.LeftHandWeapon;
				default: return null;
			}
		}

		private void deselectAllEquipment()
		{
			this.clearEquipmentHighlighting();
			this.selectedEquipment = null;
			this.updateSelectedEquipmentInfo();
		}
		private void clearEquipmentHighlighting()
		{
			this.characterImage.Image = SimpleGame.Properties.Resources.none_selected;
			this.rightHandLabel.ForeColor = SystemColors.ControlText;
			this.leftHandLabel.ForeColor = SystemColors.ControlText;
			foreach (var item in equippedItems.Values)
			{
				item.UnHighlight();
			}
		}


		private void displayInventory()
		{
			applyInventoryFilter();
			inventoryPanel.Controls.Clear();
			this.inventoryPanel.RowCount = 0;
			createInventoryEntries();

			for (int i = 0; i < inventoryEntries.Count; i++)
			{
				this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
				inventoryPanel.Controls.Add(inventoryEntries[i], 0, i);
			}
			this.inventoryPanel.VerticalScroll.Value = inventoryPanel.VerticalScroll.Minimum;
			ActiveControl = inventoryPanel;

			foreach (InventoryEntry entry in inventoryEntries)
			{
				entry.Click += new EventHandler(itemClicked);
				entry.MouseDown += new MouseEventHandler(item_MouseDown);
			}
		}
		private void displayInventory(object sender, EventArgs e)
		{
			displayInventory();
		}
		private void createInventoryEntries()
		{
			this.inventoryEntries.Clear();
			foreach (Logic.Item item in inventoryToDisplay)
			{
				InventoryEntry entry = new InventoryEntry();
				entry.Item = item;
				inventoryEntries.Add(entry);
			}
		}


		private void itemClicked(object sender, EventArgs e)
		{
			InventoryEntry entry = sender as InventoryEntry;

			if (selectedItem == entry.Item)
			{
				deselectAllItems();
			}
			else
			{
				this.clearItemHighlighting();
				entry.Highlight();
				this.selectItem(entry.Item);
			}
		}
		private void selectItem(Logic.Item item)
		{
			this.selectedItem = item;
			this.updateSelectedItemInfo();
		}

		private void deselectAllItems()
		{
			this.selectedItem = null;
			this.clearItemHighlighting();
			this.updateSelectedItemInfo();
		}
		private void clearItemHighlighting()
		{
			foreach (var entry in this.inventoryEntries)
			{
				entry.UnHighlight();
			}
		}
		
		private void item_MouseDown(object sender, EventArgs e)
		{
			DoDragDrop((sender as Control).Tag, DragDropEffects.Move);
		}
		
		private void setSubFilter(Logic.ItemType type)
		{
			switch (type)
			{
				case SimpleGame.Logic.ItemType.None:
					this.subFilterMode = Logic.ItemType.None;
					if (inventorySubFilter.Visible)
						this.inventorySubFilter.Hide();
					this.inventorySubFilter.SelectedIndex = 0;
					break;
				case SimpleGame.Logic.ItemType.Weapon:
					this.subFilterMode = Logic.ItemType.Weapon;
					if (!inventorySubFilter.Visible)
						this.inventorySubFilter.Show();
					this.inventorySubFilter.Items.Clear();
					this.inventorySubFilter.Items.AddRange(new object[]
					{
						"All",
						"Small",
						"Medium",
						"Large"
					});
					this.inventorySubFilter.SelectedIndex = 0;
					applySubFilter();
					break;
				case SimpleGame.Logic.ItemType.Armour:
					this.subFilterMode = Logic.ItemType.Armour;
					if (!inventorySubFilter.Visible)
						this.inventorySubFilter.Show();
					this.inventorySubFilter.Items.Clear();
					this.inventorySubFilter.Items.AddRange(new object[]
					{
						"All",
						"Head",
						"Torso",
						"Hands",
						"Legs",
						"Feet"
					});
					this.inventorySubFilter.SelectedIndex = 0;
					applySubFilter();
					break;
				case SimpleGame.Logic.ItemType.Consumable:
					this.subFilterMode = Logic.ItemType.Consumable;
					if (inventorySubFilter.Visible)
						this.inventorySubFilter.Hide();
					this.inventorySubFilter.SelectedIndex = 0;
					break;
				default:
					break;
			}
		}
		private void applyInventoryFilter()
		{

			switch (this.inventoryFilterBox.SelectedIndex)
			{
				case 0:
					if (subFilterMode != Logic.ItemType.None)
						setSubFilter(Logic.ItemType.None);
					applySubFilter();
					break;
				case 1:
					if (subFilterMode != Logic.ItemType.Weapon)
						setSubFilter(Logic.ItemType.Weapon);
					applySubFilter();
					break;
				case 2:
					if (subFilterMode != Logic.ItemType.Armour)
						setSubFilter(Logic.ItemType.Armour);
					applySubFilter();
					break;
				case 3:
					if (subFilterMode != Logic.ItemType.None)
						setSubFilter(Logic.ItemType.None);
					applySubFilter();
					break;
				default:
					this.inventoryToDisplay = player.Inventory;
					break;
			}
		}
		private void applySubFilter()
		{
			switch (inventoryFilterBox.SelectedIndex)
			{
				case 0:
					this.inventoryToDisplay = player.Inventory;
					break;
				case 1:
					switch (inventorySubFilter.SelectedIndex)
					{
						case 0:
							this.inventoryToDisplay = player.Inventory.WeaponsAsItems();
							break;
						case 1:
							this.inventoryToDisplay = player.Inventory.WeaponsAsItems(Logic.WeaponSize.Small);
							break;
						case 2:
							this.inventoryToDisplay = player.Inventory.WeaponsAsItems(Logic.WeaponSize.Medium);
							break;
						case 3:
							this.inventoryToDisplay = player.Inventory.WeaponsAsItems(Logic.WeaponSize.Large);
							break;
						default:
							break;
					}
					break;
				case 2:
					switch (inventorySubFilter.SelectedIndex)
					{
						case 0:
							this.inventoryToDisplay = player.Inventory.ArmourAsItems();
							break;
						case 1:
							this.inventoryToDisplay = player.Inventory.ArmourAsItems(Logic.ArmourLocation.Head);
							break;
						case 2:
							this.inventoryToDisplay = player.Inventory.ArmourAsItems(Logic.ArmourLocation.Torso);
							break;
						case 3:
							this.inventoryToDisplay = player.Inventory.ArmourAsItems(Logic.ArmourLocation.Hands);
							break;
						case 4:
							this.inventoryToDisplay = player.Inventory.ArmourAsItems(Logic.ArmourLocation.Legs);
							break;
						case 5:
							this.inventoryToDisplay = player.Inventory.ArmourAsItems(Logic.ArmourLocation.Feet);
							break;
						default:
							break;
					}
					break;
				case 3:
					this.inventoryToDisplay = player.Inventory.FindAll(delegate(Logic.Item x) { return x.Type == Logic.ItemType.Consumable; });
					break;
				default:
					break;
			}
		}
		private void matchInventoryFilterToEquipmentSelection(EquipmentSlot location)
		{
			switch (location)
			{
				case EquipmentSlot.Head:
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 1;
					break;
				case EquipmentSlot.Torso:
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 2;
					break;
				case EquipmentSlot.Hands:
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 3;
					break;
				case EquipmentSlot.Legs:
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 4;
					break;
				case EquipmentSlot.Feet:
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 5;
					break;
				case EquipmentSlot.RightHand:
					this.inventoryFilterBox.SelectedIndex = 1;
					this.inventorySubFilter.SelectedIndex = 0;
					break;
				case EquipmentSlot.LeftHand:
					this.inventoryFilterBox.SelectedIndex = 1;
					this.inventorySubFilter.SelectedIndex = 1;
					break;
				default:
					break;
			}
		}
	}
}
