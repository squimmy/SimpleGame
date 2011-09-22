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
		private EquipmentSlot selection;
		private List<Logic.Item> inventoryToDisplay;
		private List<PictureBox> inventoryPictures;
		private List<Label> inventoryLabels;
		private Logic.Player player;
		//private Logic.ArmourLocation selection;
		private bool locationSelected;
		private bool rightHandSelected;
		private bool leftHandSelected;
		private Logic.Item selectedEquipment;
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
			this.inventoryToDisplay = new List<Logic.Item>();
			this.inventoryLabels = new List<Label>();
			this.inventoryPictures = new List<PictureBox>();
			this.inventoryLabels = new List<Label>();

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
			
			this.deselectAll();
			this.updatePlayerStatData();
			this.updateEquipmentIcons();

			this.headArmourLabel.Click += new EventHandler(this.headClicked);
			this.headPicture.Click += new EventHandler(this.headClicked);
			this.torsoArmourLabel.Click += new EventHandler(this.torsoClicked);
			this.torsoPicture.Click += new EventHandler(this.torsoClicked);
			this.handArmourLabel.Click += new EventHandler(this.handsClicked);
			this.handPicture.Click += new EventHandler(this.handsClicked);
			this.legArmourLabel.Click += new EventHandler(this.legsClicked);
			this.legPicture.Click += new EventHandler(this.legsClicked);
			this.feetArmourLabel.Click += new EventHandler(this.feetClicked);
			this.feetPicture.Click += new EventHandler(this.feetClicked);

			this.inventoryFilterBox.SelectedValueChanged += new EventHandler(displayInventory);
			this.inventorySubFilter.SelectedValueChanged += new EventHandler(displayInventory);
			this.inventoryFilterBox.SelectedIndex = 0;
			this.inventorySubFilter.SelectedIndex = 0;
		}
		
		private void updateEquipmentIcons()
		{
			this.primaryWeaponPicture.Image =  Art.GetItemImage(player.Equipment.RightHandWeapon.ID);
			this.primaryWeaponLabel.Text = player.Equipment.RightHandWeapon.Name;
			
			if (player.Equipment.LeftHandWeapon != null)
			{
				this.secondaryWeaponPicture.Image = Art.GetItemImage(player.Equipment.LeftHandWeapon.ID);
				this.secondaryWeaponPicture.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
				this.secondaryWeaponLabel.Text = player.Equipment.LeftHandWeapon.Name;
			}
			else
			{
				this.secondaryWeaponPicture.Image = null;
				this.secondaryWeaponLabel.Text = null;
			}
			
			this.headPicture.Image = Art.GetItemImage(player.Equipment.EquippedArmour[Logic.ArmourLocation.Head].ID);
			this.headArmourLabel.Text = player.Equipment.EquippedArmour[Logic.ArmourLocation.Head].Name;
			this.torsoPicture.Image = Art.GetItemImage(player.Equipment.EquippedArmour[SimpleGame.Logic.ArmourLocation.Torso].ID);
			this.torsoArmourLabel.Text = player.Equipment.EquippedArmour[Logic.ArmourLocation.Torso].Name;
			this.handPicture.Image = Art.GetItemImage(player.Equipment.EquippedArmour[SimpleGame.Logic.ArmourLocation.Hands].ID);
			this.handArmourLabel.Text = player.Equipment.EquippedArmour[Logic.ArmourLocation.Hands].Name;
			this.legPicture.Image = Art.GetItemImage(player.Equipment.EquippedArmour[SimpleGame.Logic.ArmourLocation.Legs].ID);
			this.legArmourLabel.Text = player.Equipment.EquippedArmour[Logic.ArmourLocation.Legs].Name;
			this.feetPicture.Image = Art.GetItemImage(player.Equipment.EquippedArmour[SimpleGame.Logic.ArmourLocation.Feet].ID);
			this.feetArmourLabel.Text = player.Equipment.EquippedArmour[Logic.ArmourLocation.Feet].Name;
		}
		private void updatePlayerStatData()
		{
			if (player.PrimaryAbility != null)
			{
				this.primaryAttackDamageIcon.Image = Art.GetDamageIcon(player.Equipment.RightHandWeapon.DamageType);
				this.primaryAttackLabel.Text = weaponText(player.PrimaryAbility);
			}
			else
			{
				this.primaryAttackDamageIcon.Image = SimpleGame.Properties.Resources.none;
				this.primaryAttackLabel.Text = null;
			}
			
			if (player.SecondaryAbility != null)
			{
				this.secondaryAttackDamageIcon.Image = Art.GetDamageIcon(player.Equipment.LeftHandWeapon.DamageType);
				this.secondaryAttackLabel.Text = weaponText(player.SecondaryAbility);
			}
			else
			{
				this.secondaryAttackDamageIcon.Image = SimpleGame.Properties.Resources.none;
				this.secondaryAttackLabel.Text = null;
			}


			this.crushInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Crush));
			this.cutInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Cut));
			this.stabInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Stab));
			this.fireInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Fire));
			this.iceInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Ice));
			this.poisonInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Poison));
			this.electricityInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Electricity));
			this.magicInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Magic));
			this.holyInfo.Text = armourText(player.Equipment.Protection(Logic.DamageType.Holy));
		}
		private void updateSelectedEquipmentInfo()
		{
			if (this.selectedEquipment != null)
			{
				this.selectedEquipmentPicture.Image = Art.GetItemImage(selectedEquipment.ID);
				this.selectedEquipmentName.Text = selectedEquipment.Name;
				this.selectedEquipmentInfoLabel.Text = selectedEquipment.Info;	
			}
			else
			{
				this.selectedEquipmentPicture.Image = null;
				this.selectedEquipmentName.Text = null;
				this.selectedEquipmentInfoLabel.Text = null;
			}
			
		}
		
		private string armourText(int protection)
		{
			return string.Format("{0, 2}   ({1, 2}% dmg taken)", protection, Logic.Combat.ProtectionPercentage(protection));
		}
		private string weaponText(Logic.Ability ability)
		{
			return string.Format("{0} (damage: {1}, speed: {2})", ability.Name, ability.Effectiveness, ability.Speed);
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
				legsClicked(sender, e);
			}
			else if (handsLocation.Contains(mouse.Location))
			{
				handsClicked(sender, e);
			}
			else if (feetLocation.Contains(mouse.Location))
			{
				feetClicked(sender, e);
			}
			else
			{
				deselectAll();
			}
		}

		private void deselectAll()
		{
			this.locationSelected = false;
			this.characterImage.Image = SimpleGame.Properties.Resources.none_selected;
			this.selectedEquipment = null;
			this.updateSelectedEquipmentInfo();
			this.rightHandSelected = false;
			this.leftHandSelected = false;
		}
		private void headClicked(object sender, EventArgs e)
		{
			if (locationSelected == true && selection == EquipmentSlot.Head)
			{
				deselectAll();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Head);
			}
		}
		private void torsoClicked(object sender, EventArgs e)
		{
			if (locationSelected == true && selection == EquipmentSlot.Torso)
			{
				deselectAll();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Torso);
			}
		}
		private void legsClicked(object sender, EventArgs e)
		{
			if (locationSelected == true && selection == EquipmentSlot.Legs)
			{
				deselectAll();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Legs);
			}
		}
		private void handsClicked(object sender, EventArgs e)
		{
			if (locationSelected == true && selection == EquipmentSlot.Hands)
			{
				deselectAll();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Hands);
			}
		}
		private void feetClicked(object sender, EventArgs e)
		{
			if (locationSelected == true && selection == EquipmentSlot.Feet)
			{
				deselectAll();
			}
			else
			{
				this.selectLocation(EquipmentSlot.Feet);
			}
		}
		private void rightHandClicked(object sender, EventArgs e)
		{
			if (locationSelected == true && selection == EquipmentSlot.RightHand)
			{
				deselectAll();
			}
			else
			{
				this.selectLocation(EquipmentSlot.RightHand);
				// change this to use a similar method to "selectLocation", e.g. "SelectRightHand" or w/e
			}
		}
		private void leftHandClicked(object sender, EventArgs e)
		{
			if (locationSelected == true && selection == EquipmentSlot.LeftHand)
			{
				deselectAll();
			}
			else
			{
				this.selectLocation(EquipmentSlot.LeftHand);
				// change this to use a similar method to "selectLocation", e.g. "SelectRightHand" or w/e
			}
		}

		private void displayInventory()
		{
			applyInventoryFilter();
			inventoryPanel.Controls.Clear();
			this.inventoryPanel.RowCount = 0;
			createInventoryPictures();
			createInventoryLabels();

			for (int i = 0; i < inventoryPictures.Count; i++)
			{
				this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
				inventoryPanel.Controls.Add(inventoryPictures[i], 0, i);
				inventoryPanel.Controls.Add(inventoryLabels[i], 1, i);
			}
			this.inventoryPanel.VerticalScroll.Value = inventoryPanel.VerticalScroll.Minimum;
			
			ActiveControl = inventoryPanel;
		}
		private void displayInventory(object sender, EventArgs e)
		{
			displayInventory();
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
		private void createInventoryPictures()
		{

			this.inventoryPictures.Clear();
			foreach (Logic.Item item in inventoryToDisplay)
			{
				inventoryPictures.Add(new PictureBox());
				int max = inventoryPictures.Count -1;
				setPictureBoxAttributes(inventoryPictures[max]);
				inventoryPictures[max].Image = Art.GetItemImage(inventoryToDisplay[max].ID);
				inventoryPictures[max].Tag = inventoryToDisplay[max];
			}
		}
		private void setPictureBoxAttributes(PictureBox picturebox)
		{
			picturebox.BorderStyle = BorderStyle.Fixed3D;
			picturebox.Margin = new System.Windows.Forms.Padding(1);
			picturebox.Size = new System.Drawing.Size(44, 44);
		}
		private void createInventoryLabels()
		{

			this.inventoryLabels.Clear();
			foreach (Logic.Item item in inventoryToDisplay)
			{
				inventoryLabels.Add(new Label());
				int max = inventoryLabels.Count - 1;
				setLabelAttributes(inventoryLabels[max]);
				inventoryLabels[max].Text = inventoryToDisplay[max].Name;
				inventoryLabels[max].Tag = inventoryToDisplay[max];
			}
		}
		private void setLabelAttributes(Label label)
		{
			label.BorderStyle = BorderStyle.Fixed3D;
			label.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label.Margin = new Padding(15, 10, 10, 10);
			label.TextAlign = ContentAlignment.MiddleLeft;
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
		
		private void selectLocation(EquipmentSlot location)
		{
			this.locationSelected = true;
			this.selection = location;
			this.selectedEquipment = getLocationItem(location);
			this.inventoryFilterBox.SelectedIndex = 2;
			switch (location)
			{
				case EquipmentSlot.Head:
					this.characterImage.Image = SimpleGame.Properties.Resources.head_selected;
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 1;
					break;
				case EquipmentSlot.Torso:
					this.characterImage.Image = SimpleGame.Properties.Resources.torso_selected;
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 2;
					break;
				case EquipmentSlot.Hands:
					this.characterImage.Image = SimpleGame.Properties.Resources.hands_selected;
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 3;
					break;
				case EquipmentSlot.Legs:
					this.characterImage.Image = SimpleGame.Properties.Resources.legs_selected;
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 4;
					break;
				case EquipmentSlot.Feet:
					this.characterImage.Image = SimpleGame.Properties.Resources.feet_selected;
					this.inventoryFilterBox.SelectedIndex = 2;
					this.inventorySubFilter.SelectedIndex = 5;
					break;
				case EquipmentSlot.RightHand:
					this.characterImage.Image = SimpleGame.Properties.Resources.none_selected;
					this.inventoryFilterBox.SelectedIndex = 1;
					this.inventorySubFilter.SelectedIndex = 0;
					break;
				case EquipmentSlot.LeftHand:
					this.characterImage.Image = SimpleGame.Properties.Resources.none_selected;
					this.inventoryFilterBox.SelectedIndex = 1;
					this.inventorySubFilter.SelectedIndex = 1;
					break;
				default:
					this.characterImage.Image = SimpleGame.Properties.Resources.none_selected;
					break;
			}
			updateSelectedEquipmentInfo();
		}

		private Logic.Item getLocationItem(EquipmentSlot location)
		{
			switch (location)
			{
				case EquipmentSlot.Head:			return player.Equipment.EquippedArmour[Logic.ArmourLocation.Head];
				case EquipmentSlot.Torso:		return player.Equipment.EquippedArmour[Logic.ArmourLocation.Torso];
				case EquipmentSlot.Hands:		return player.Equipment.EquippedArmour[Logic.ArmourLocation.Hands];
				case EquipmentSlot.Legs:			return player.Equipment.EquippedArmour[Logic.ArmourLocation.Legs];
				case EquipmentSlot.Feet:			return player.Equipment.EquippedArmour[Logic.ArmourLocation.Feet];
				case EquipmentSlot.RightHand:	return player.Equipment.RightHandWeapon;
				case EquipmentSlot.LeftHand:		return player.Equipment.LeftHandWeapon;
				default:						return null;
			}
		}
	}
}
