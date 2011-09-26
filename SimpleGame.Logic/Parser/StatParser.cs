using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public static class StatParser
	{
		public static string XMLStats(int entityid, string stat, string statsfile)
		{
			using (System.Xml.XmlReader xmlReader = System.Xml.XmlReader.Create(statsfile))
			{
				string idtag = "id" + entityid.ToString();
				while (xmlReader.Read())
				{
					if (xmlReader.NodeType == System.Xml.XmlNodeType.Element && xmlReader.Name == idtag)
					{
						if (xmlReader.HasAttributes)
						{
							string result = xmlReader.GetAttribute(stat);
							return result;
						}
					}
				}
			}
			return null;
		}

		public static DamageType ParseDamageType(string text)
		{
			switch (text)
			{
				case "cutting":		return DamageType.Cutting;
				case "stabbing":	return DamageType.Stabbing;
				case "crushing":	return DamageType.Crushing;
				case "fire":	return DamageType.Fire;
				case "ice":		return DamageType.Ice;
				case "magic":	return DamageType.Magic;
				case "holy":	return DamageType.Holy;
				default:		return DamageType.Crushing;
			}
		}
		public static ArmourLocation ParseArmourLocation(string text)
		{
			switch (text)
			{
				case "head":	return ArmourLocation.Head;
				case "torso":	return ArmourLocation.Torso;
				case "hands":	return ArmourLocation.Hands;
				case "legs":	return ArmourLocation.Legs;
				case "feet":	return ArmourLocation.Feet;
				default:		return ArmourLocation.Torso;
			}
		}
		public static WeaponSize ParseWeaponSize(string text)
		{
			switch (text)
			{
				case "small": return WeaponSize.Small;
				case "medium": return WeaponSize.Medium;
				case "large": return WeaponSize.Large;
				default: return WeaponSize.Medium;
			}
		}

		public static bool IDExists(int entityid, string statsfile)
		{
			System.Xml.XmlReader xmlReader = System.Xml.XmlReader.Create(statsfile);
			string idtag = "id" + entityid.ToString();
			while (xmlReader.Read())
			{
				if (xmlReader.NodeType == System.Xml.XmlNodeType.Element && xmlReader.Name == idtag)
				{
					return true;
				}
			}
			return false;
		}
	}
}
