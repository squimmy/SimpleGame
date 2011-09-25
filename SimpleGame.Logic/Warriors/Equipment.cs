using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public class Equipment
	{
		private Weapon rightHandWeapon;
		private Weapon leftHandWeapon;
		private readonly Dictionary<ArmourLocation, Armour> equippedArmour;
		public delegate void LoadoutChangedEventHandler(object sender);
		public event LoadoutChangedEventHandler LoadoutChanged;

		public Equipment()
		{
			this.rightHandWeapon = new Weapon();
			this.leftHandWeapon = new Weapon();
			this.equippedArmour = new Dictionary<ArmourLocation, Armour>();
			foreach (ArmourLocation location in Enum.GetValues(typeof(ArmourLocation)))
			{
				this.equippedArmour[location] = new Armour(location);
			}
		}

		public Weapon RightHandWeapon
		{
			get { return rightHandWeapon; }
		}
		public Weapon LeftHandWeapon
		{
			get { return leftHandWeapon; }
		}
		public Dictionary<ArmourLocation, Armour> EquippedArmour
		{
			get { return equippedArmour; }
		}

		public int Protection(DamageType damagetype)
		{
			if (leftHandWeapon == null)
			{
				 return equippedArmour.Sum(x => x.Value.Protection[damagetype]) + rightHandWeapon.Protection[damagetype];
			}
			else
			{
				return equippedArmour.Sum(x => x.Value.Protection[damagetype]) + rightHandWeapon.Protection[damagetype] + leftHandWeapon.Protection[damagetype];
			}
		}
		public int Bonus(Stat stat)
		{
			if (leftHandWeapon == null)
			{
				return equippedArmour.Sum(x => x.Value.Bonus[stat]) + rightHandWeapon.Bonus[stat];
			}
			else
			{
				return equippedArmour.Sum(x => x.Value.Bonus[stat]) + rightHandWeapon.Bonus[stat] + leftHandWeapon.Bonus[stat];
			}
		}

		public void EquipArmour(Armour armour)
		{
			equippedArmour[armour.Location] = armour;
			this.OnLoadoutChanged();
		}
		public void EquipRightHandWeapon(Weapon weapon)
		{
			rightHandWeapon = weapon;
			this.OnLoadoutChanged();
		}
		public void EquipLeftHandWeapon(Weapon weapon)
		{
			if (weapon.Size == WeaponSize.Small)
			{
				leftHandWeapon = weapon;
				this.OnLoadoutChanged();
			}
		}

		public void UnequipArmour(ArmourLocation location)
		{
			equippedArmour[location] = new Armour(location);
			this.OnLoadoutChanged();
		}
		public void UnequipRightHand()
		{
			rightHandWeapon = new Weapon();
			this.OnLoadoutChanged();
		}
		public void UnequipLeftHand()
		{
			leftHandWeapon = new Weapon();
			this.OnLoadoutChanged();
		}
		public void UnequipItem(Item item)
		{
			if (item.Type == ItemType.Armour)
			{
				Armour armour = item as Armour;
				if (equippedArmour[armour.Location] == armour)
					this.UnequipArmour(armour.Location);
			}
			else if (item.Type == ItemType.Weapon)
			{
				if (this.rightHandWeapon == item)
					UnequipRightHand();
				else if (this.leftHandWeapon == item)
					UnequipLeftHand();
			}
		}

		public bool IsEquipped(Item item)
		{
			if (item == this.rightHandWeapon || item == this.leftHandWeapon)
				return true;
			if (item.Type == ItemType.Armour)
				return (item == this.equippedArmour[((Armour)item).Location]);
			return false;
		}

		private void OnLoadoutChanged()
		{
			if (LoadoutChanged != null)
				LoadoutChanged(this);
		}

	}
}
