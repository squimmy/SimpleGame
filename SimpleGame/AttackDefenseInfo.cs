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
	public partial class AttackDefenseInfo : UserControl
	{
		public Logic.Player Player;
		private Dictionary<Logic.DamageType, Label> infoLabels;

		public AttackDefenseInfo()
		{
			InitializeComponent();
			infoLabels = new Dictionary<Logic.DamageType, Label>()
			{
				{Logic.DamageType.Crush, crushInfo},
				{Logic.DamageType.Cut, cutInfo},
				{Logic.DamageType.Stab, stabInfo},
				{Logic.DamageType.Fire, fireInfo},
				{Logic.DamageType.Ice, iceInfo},
				{Logic.DamageType.Poison, poisonInfo},
				{Logic.DamageType.Electricity, electricityInfo},
				{Logic.DamageType.Magic, magicInfo},
				{Logic.DamageType.Holy, holyInfo},
			};
			this.Update();
		}

		public void UpdateLabels()
		{
			if (Player != null)
			{
				if (Player.PrimaryAbility != null)
				{
					this.primaryAttackDamageIcon.Image = Art.GetDamageIcon(Player.Equipment.RightHandWeapon.DamageType);
					this.primaryAttackLabel.Text = weaponText(Player.PrimaryAbility);
				}
				else
				{
					this.primaryAttackDamageIcon.Image = SimpleGame.Properties.Resources.none;
					this.primaryAttackLabel.Text = null;
				}

				if (Player.SecondaryAbility != null)
				{
					this.secondaryAttackDamageIcon.Image = Art.GetDamageIcon(Player.Equipment.LeftHandWeapon.DamageType);
					this.secondaryAttackLabel.Text = weaponText(Player.SecondaryAbility);
				}
				else
				{
					this.secondaryAttackDamageIcon.Image = SimpleGame.Properties.Resources.none;
					this.secondaryAttackLabel.Text = null;
				}

				foreach (KeyValuePair<Logic.DamageType, Label> pair in infoLabels)
				{
					pair.Value.Text = this.armourText(Player.Equipment.Protection(pair.Key));
				}
			}
			else
			{
				this.primaryAttackDamageIcon.Image = null;
				this.primaryAttackLabel.Text = null;
				this.secondaryAttackDamageIcon.Image = null;
				this.secondaryAttackLabel.Text = null;

				foreach (Label label in infoLabels.Values)
				{
					label.Text = null;
				}

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
	}
}
