using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGame.Logic
{
	public struct ItemDetail
	{
		public string text;
		public int value;

		public ItemDetail(string text, int value)
		{
			this.text = text;
			this.value = value;
		}
	}
}
