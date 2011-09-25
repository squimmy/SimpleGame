namespace SimpleGame
{
	partial class InventoryEntry
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.itemIcon = new System.Windows.Forms.PictureBox();
			this.itemNameLabel = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.ColumnCount = 2;
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainPanel.Controls.Add(this.itemIcon, 0, 0);
			this.mainPanel.Controls.Add(this.itemNameLabel, 1, 0);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.RowCount = 1;
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.mainPanel.Size = new System.Drawing.Size(250, 46);
			this.mainPanel.TabIndex = 6;
			// 
			// itemIcon
			// 
			this.itemIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.itemIcon.Location = new System.Drawing.Point(1, 1);
			this.itemIcon.Margin = new System.Windows.Forms.Padding(1);
			this.itemIcon.Name = "itemIcon";
			this.itemIcon.Size = new System.Drawing.Size(44, 44);
			this.itemIcon.TabIndex = 0;
			this.itemIcon.TabStop = false;
			// 
			// itemNameLabel
			// 
			this.itemNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.itemNameLabel.Location = new System.Drawing.Point(61, 10);
			this.itemNameLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
			this.itemNameLabel.Name = "itemNameLabel";
			this.itemNameLabel.Size = new System.Drawing.Size(179, 26);
			this.itemNameLabel.TabIndex = 1;
			this.itemNameLabel.Text = "Item Name";
			this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InventoryEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "InventoryEntry";
			this.Size = new System.Drawing.Size(250, 46);
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.itemIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainPanel;
		private System.Windows.Forms.PictureBox itemIcon;
		private System.Windows.Forms.Label itemNameLabel;
	}
}
