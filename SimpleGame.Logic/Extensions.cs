using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyExtensions
{
	public static class Extensions
	{
		public static string CapitaliseFirstLetter(this string str)
		{
			return str.Substring(0, 1).ToUpper() + str.Substring(1);
		}

		public static string SFormOfVerb(this string str)
		{
			if (str.Substring(str.Length-1) == "h" || str.Substring(str.Length-1) == "o" || str.Substring(str.Length-2, 2) == "ss")
			{
				return str + "es";
			}
			else if (System.Text.RegularExpressions.Regex.IsMatch(str.Substring(str.Length-2, 2), "[^aeiouy]y"))
			{
				return str.Substring(0, str.Length) + "ies";
			}
			else
			{
				return str + "s";
			}
		}


	}
}
