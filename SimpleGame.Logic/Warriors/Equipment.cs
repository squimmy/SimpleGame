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
				 return equippedArmour.ToArray().Sum(x => x.Value.Protection[damagetype]) + rightHandWeapon.Protection[damagetype];
			}
			else
			{
				return equippedArmour.ToArray().Sum(x => x.Value.Protection[damagetype]) + rightHandWeapon.Protection[damagetype] + leftHandWeapon.Protection[damagetype];
			}
		}
		public int Bonus(Stat stat)
		{
			if (leftHandWeapon == null)
			{
				return equippedArmour.ToArray().Sum(x => x.Value.Bonus[stat]) + rightHandWeapon.Bonus[stat];
			}
			else
			{
				return equippedArmour.ToArray().Sum(x => x.Value.Bonus[stat]) + rightHandWeapon.Bonus[stat] + leftHandWeapon.Bonus[stat];
			}
		}

		public void EquipArmour(Armour armour)
		{
			equippedArmour[armour.Location] = armour;
		}
		public void EquipRightHandWeapon(Weapon weapon)
		{
			rightHandWeapon = weapon;
		}
		public void EquipLeftHandWeapon(Weapon weapon)
		{
			if (weapon.Size == WeaponSize.Small)
			{
				leftHandWeapon = weapon;
			}
		}

		public void UnequipArmour(ArmourLocation location)
		{
			equippedArmour[location] = new Armour(location);
		}
		public void UnequipRightHand()
		{
			rightHandWeapon = new Weapon();
		}
		public void UnequipLeftHand()
		{
			leftHandWeapon = new Weapon();
		}
	}
}
