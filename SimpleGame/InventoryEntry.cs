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
	public partial class InventoryEntry : UserControl
	{

		private Logic.Item item;
		public bool ImageFlipped;
		public InventoryEntry()
		{
			InitializeComponent();
			this.ImageFlipped = false;
			this.itemIcon.Click += new EventHandler((s, e) => this.OnClick(e));
			this.itemNameLabel.Click += new EventHandler((s, e) => this.OnClick(e));
		}

		public void UpdateEntry()
		{
			if (item != null)
			{
				this.itemNameLabel.Text = item.Name;
				this.itemIcon.Image = Art.GetItemImage(item.ID);
				if (ImageFlipped)
					this.itemIcon.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
			}
			else
			{
				this.itemNameLabel.Text = null;
				this.itemIcon.Image = null;
			}
		}


		public void Highlight()
		{
			this.itemIcon.BackColor = Color.FromArgb(229, 244, 255);
			this.itemNameLabel.BackColor = Color.FromArgb(229, 244, 255);
		}
		public void UnHighlight()
		{
			this.itemIcon.BackColor = SystemColors.Control;
			this.itemNameLabel.BackColor = SystemColors.Control;
		}

		public Logic.Item Item
		{
			get { return item; }
			set
			{
				item = value;
				UpdateEntry();
			}
		}
	}
}
