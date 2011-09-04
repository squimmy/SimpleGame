using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyExtensions
{
	public static class Extensions
	{
		public static string CapitaliseFirstLetter(this String str)
		{
			return str.Substring(0, 1).ToUpper() + str.Substring(1);
		}
	}
}
