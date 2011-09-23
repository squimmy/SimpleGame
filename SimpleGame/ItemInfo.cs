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
	public partial class ItemInfo : UserControl
	{
		public ItemInfo()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Clears the panel completely, leaving a blank white panel
		/// </summary>
		public void ClearPanel()
		{
			this.ItemPicture.Image = null;
			this.ItemName.Text = null;
			this.ItemInfoLabel.Text = null;
		}

		public void ShowItemInfo(Logic.Item item)
		{
			this.ItemPicture.Image = Art.GetItemImage(item.ID);
			this.ItemName.Text = item.Name;
			this.ItemInfoLabel.Text = item.Info;
		}

		public void ShowItemInfo(Logic.Item item, Logic.Item itemToCompareTo)
		{
		}

	}
}
