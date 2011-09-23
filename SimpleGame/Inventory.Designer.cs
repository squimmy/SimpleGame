namespace SimpleGame
{
	partial class Inventory
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.masterPanel = new System.Windows.Forms.TableLayoutPanel();
			this.characterImage = new System.Windows.Forms.PictureBox();
			this.armourPanel = new System.Windows.Forms.TableLayoutPanel();
			this.headEquipment = new SimpleGame.InventoryEntry();
			this.torsoEquipment = new SimpleGame.InventoryEntry();
			this.handEquipment = new SimpleGame.InventoryEntry();
			this.legEquipment = new SimpleGame.InventoryEntry();
			this.feetEquipment = new SimpleGame.InventoryEntry();
			this.rightHandLabel = new System.Windows.Forms.Label();
			this.leftHandLabel = new System.Windows.Forms.Label();
			this.inventoryScrollPanel = new System.Windows.Forms.Panel();
			this.inventoryPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.inventorySubFilter = new System.Windows.Forms.ComboBox();
			this.inventoryFilterBox = new System.Windows.Forms.ComboBox();
			this.attackDefenseInfo = new SimpleGame.AttackDefenseInfo();
			this.selectedEquipmentInfo = new SimpleGame.ItemInfo();
			this.selectedItemInfo = new SimpleGame.ItemInfo();
			this.mainHandEquipment = new SimpleGame.InventoryEntry();
			this.offHandEquipment = new SimpleGame.InventoryEntry();
			this.masterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
			this.armourPanel.SuspendLayout();
			this.inventoryScrollPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// masterPanel
			// 
			this.masterPanel.ColumnCount = 3;
			this.masterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.masterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.masterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.masterPanel.Controls.Add(this.characterImage, 0, 2);
			this.masterPanel.Controls.Add(this.armourPanel, 1, 2);
			this.masterPanel.Controls.Add(this.rightHandLabel, 0, 0);
			this.masterPanel.Controls.Add(this.leftHandLabel, 0, 1);
			this.masterPanel.Controls.Add(this.inventoryScrollPanel, 2, 1);
			this.masterPanel.Controls.Add(this.tableLayoutPanel1, 2, 0);
			this.masterPanel.Controls.Add(this.attackDefenseInfo, 0, 3);
			this.masterPanel.Controls.Add(this.selectedEquipmentInfo, 1, 3);
			this.masterPanel.Controls.Add(this.selectedItemInfo, 2, 3);
			this.masterPanel.Controls.Add(this.mainHandEquipment, 1, 0);
			this.masterPanel.Controls.Add(this.offHandEquipment, 1, 1);
			this.masterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.masterPanel.Location = new System.Drawing.Point(0, 0);
			this.masterPanel.Name = "masterPanel";
			this.masterPanel.RowCount = 4;
			this.masterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.masterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.masterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.masterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.masterPanel.Size = new System.Drawing.Size(702, 626);
			this.masterPanel.TabIndex = 0;
			// 
			// characterImage
			// 
			this.characterImage.Location = new System.Drawing.Point(20, 112);
			this.characterImage.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
			this.characterImage.Name = "characterImage";
			this.characterImage.Size = new System.Drawing.Size(180, 210);
			this.characterImage.TabIndex = 0;
			this.characterImage.TabStop = false;
			this.characterImage.Click += new System.EventHandler(this.characterImage_Click);
			// 
			// armourPanel
			// 
			this.armourPanel.ColumnCount = 1;
			this.armourPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.armourPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.armourPanel.Controls.Add(this.headEquipment, 0, 0);
			this.armourPanel.Controls.Add(this.torsoEquipment, 0, 1);
			this.armourPanel.Controls.Add(this.handEquipment, 0, 2);
			this.armourPanel.Controls.Add(this.legEquipment, 0, 3);
			this.armourPanel.Controls.Add(this.feetEquipment, 0, 4);
			this.armourPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.armourPanel.Location = new System.Drawing.Point(200, 102);
			this.armourPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.armourPanel.Name = "armourPanel";
			this.armourPanel.RowCount = 5;
			this.armourPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.armourPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.armourPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.armourPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.armourPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.armourPanel.Size = new System.Drawing.Size(250, 230);
			this.armourPanel.TabIndex = 0;
			// 
			// headEquipment
			// 
			this.headEquipment.Item = null;
			this.headEquipment.Location = new System.Drawing.Point(0, 0);
			this.headEquipment.Margin = new System.Windows.Forms.Padding(0);
			this.headEquipment.Name = "headEquipment";
			this.headEquipment.Size = new System.Drawing.Size(250, 46);
			this.headEquipment.TabIndex = 0;
			this.headEquipment.Click += new System.EventHandler(this.headClicked);
			// 
			// torsoEquipment
			// 
			this.torsoEquipment.Item = null;
			this.torsoEquipment.Location = new System.Drawing.Point(0, 46);
			this.torsoEquipment.Margin = new System.Windows.Forms.Padding(0);
			this.torsoEquipment.Name = "torsoEquipment";
			this.torsoEquipment.Size = new System.Drawing.Size(250, 46);
			this.torsoEquipment.TabIndex = 1;
			this.torsoEquipment.Click += new System.EventHandler(this.torsoClicked);
			// 
			// handEquipment
			// 
			this.handEquipment.Item = null;
			this.handEquipment.Location = new System.Drawing.Point(0, 92);
			this.handEquipment.Margin = new System.Windows.Forms.Padding(0);
			this.handEquipment.Name = "handEquipment";
			this.handEquipment.Size = new System.Drawing.Size(250, 46);
			this.handEquipment.TabIndex = 2;
			this.handEquipment.Click += new System.EventHandler(this.handClicked);
			// 
			// legEquipment
			// 
			this.legEquipment.Item = null;
			this.legEquipment.Location = new System.Drawing.Point(0, 138);
			this.legEquipment.Margin = new System.Windows.Forms.Padding(0);
			this.legEquipment.Name = "legEquipment";
			this.legEquipment.Size = new System.Drawing.Size(250, 46);
			this.legEquipment.TabIndex = 3;
			this.legEquipment.Click += new System.EventHandler(this.legClicked);
			// 
			// feetEquipment
			// 
			this.feetEquipment.Item = null;
			this.feetEquipment.Location = new System.Drawing.Point(0, 184);
			this.feetEquipment.Margin = new System.Windows.Forms.Padding(0);
			this.feetEquipment.Name = "feetEquipment";
			this.feetEquipment.Size = new System.Drawing.Size(250, 46);
			this.feetEquipment.TabIndex = 4;
			this.feetEquipment.Click += new System.EventHandler(this.feetClicked);
			// 
			// rightHandLabel
			// 
			this.rightHandLabel.AutoSize = true;
			this.rightHandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rightHandLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rightHandLabel.Location = new System.Drawing.Point(3, 3);
			this.rightHandLabel.Margin = new System.Windows.Forms.Padding(3);
			this.rightHandLabel.Name = "rightHandLabel";
			this.rightHandLabel.Size = new System.Drawing.Size(194, 40);
			this.rightHandLabel.TabIndex = 1;
			this.rightHandLabel.Text = "Right Hand Item:";
			this.rightHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rightHandLabel.Click += new System.EventHandler(this.mainHandClicked);
			// 
			// leftHandLabel
			// 
			this.leftHandLabel.AutoSize = true;
			this.leftHandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.leftHandLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.leftHandLabel.Location = new System.Drawing.Point(3, 49);
			this.leftHandLabel.Margin = new System.Windows.Forms.Padding(3);
			this.leftHandLabel.Name = "leftHandLabel";
			this.leftHandLabel.Size = new System.Drawing.Size(194, 40);
			this.leftHandLabel.TabIndex = 2;
			this.leftHandLabel.Text = "Left Hand Item:";
			this.leftHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.leftHandLabel.Click += new System.EventHandler(this.offHandClicked);
			// 
			// inventoryScrollPanel
			// 
			this.inventoryScrollPanel.AutoScroll = true;
			this.inventoryScrollPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.inventoryScrollPanel.Controls.Add(this.inventoryPanel);
			this.inventoryScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inventoryScrollPanel.Location = new System.Drawing.Point(453, 49);
			this.inventoryScrollPanel.Name = "inventoryScrollPanel";
			this.masterPanel.SetRowSpan(this.inventoryScrollPanel, 2);
			this.inventoryScrollPanel.Size = new System.Drawing.Size(246, 290);
			this.inventoryScrollPanel.TabIndex = 10;
			// 
			// inventoryPanel
			// 
			this.inventoryPanel.AutoSize = true;
			this.inventoryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.inventoryPanel.ColumnCount = 1;
			this.inventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.inventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.inventoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.inventoryPanel.Location = new System.Drawing.Point(0, 0);
			this.inventoryPanel.Name = "inventoryPanel";
			this.inventoryPanel.RowCount = 2;
			this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.inventoryPanel.Size = new System.Drawing.Size(242, 92);
			this.inventoryPanel.TabIndex = 9;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.inventorySubFilter, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.inventoryFilterBox, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(453, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 40);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// inventorySubFilter
			// 
			this.inventorySubFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.inventorySubFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inventorySubFilter.FormattingEnabled = true;
			this.inventorySubFilter.Items.AddRange(new object[] {
            "All"});
			this.inventorySubFilter.Location = new System.Drawing.Point(126, 9);
			this.inventorySubFilter.Name = "inventorySubFilter";
			this.inventorySubFilter.Size = new System.Drawing.Size(117, 21);
			this.inventorySubFilter.TabIndex = 9;
			this.inventorySubFilter.TabStop = false;
			this.inventorySubFilter.Visible = false;
			// 
			// inventoryFilterBox
			// 
			this.inventoryFilterBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.inventoryFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inventoryFilterBox.FormattingEnabled = true;
			this.inventoryFilterBox.Items.AddRange(new object[] {
            "All",
            "Weapons",
            "Armour",
            "Consumables"});
			this.inventoryFilterBox.Location = new System.Drawing.Point(3, 9);
			this.inventoryFilterBox.Name = "inventoryFilterBox";
			this.inventoryFilterBox.Size = new System.Drawing.Size(117, 21);
			this.inventoryFilterBox.TabIndex = 7;
			this.inventoryFilterBox.TabStop = false;
			// 
			// attackDefenseInfo
			// 
			this.attackDefenseInfo.Location = new System.Drawing.Point(0, 342);
			this.attackDefenseInfo.Margin = new System.Windows.Forms.Padding(0);
			this.attackDefenseInfo.Name = "attackDefenseInfo";
			this.attackDefenseInfo.Size = new System.Drawing.Size(194, 259);
			this.attackDefenseInfo.TabIndex = 13;
			// 
			// selectedEquipmentInfo
			// 
			this.selectedEquipmentInfo.Location = new System.Drawing.Point(203, 345);
			this.selectedEquipmentInfo.Name = "selectedEquipmentInfo";
			this.selectedEquipmentInfo.Size = new System.Drawing.Size(244, 244);
			this.selectedEquipmentInfo.TabIndex = 14;
			// 
			// selectedItemInfo
			// 
			this.selectedItemInfo.Location = new System.Drawing.Point(453, 345);
			this.selectedItemInfo.Name = "selectedItemInfo";
			this.selectedItemInfo.Size = new System.Drawing.Size(244, 244);
			this.selectedItemInfo.TabIndex = 15;
			// 
			// mainHandEquipment
			// 
			this.mainHandEquipment.Item = null;
			this.mainHandEquipment.Location = new System.Drawing.Point(200, 0);
			this.mainHandEquipment.Margin = new System.Windows.Forms.Padding(0);
			this.mainHandEquipment.Name = "mainHandEquipment";
			this.mainHandEquipment.Size = new System.Drawing.Size(250, 46);
			this.mainHandEquipment.TabIndex = 16;
			this.mainHandEquipment.Click += new System.EventHandler(this.mainHandClicked);
			// 
			// offHandEquipment
			// 
			this.offHandEquipment.Item = null;
			this.offHandEquipment.Location = new System.Drawing.Point(200, 46);
			this.offHandEquipment.Margin = new System.Windows.Forms.Padding(0);
			this.offHandEquipment.Name = "offHandEquipment";
			this.offHandEquipment.Size = new System.Drawing.Size(250, 46);
			this.offHandEquipment.TabIndex = 17;
			this.offHandEquipment.Click += new System.EventHandler(this.offHandClicked);
			// 
			// Inventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 626);
			this.Controls.Add(this.masterPanel);
			this.Name = "Inventory";
			this.Text = "Inventory";
			this.masterPanel.ResumeLayout(false);
			this.masterPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
			this.armourPanel.ResumeLayout(false);
			this.inventoryScrollPanel.ResumeLayout(false);
			this.inventoryScrollPanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel masterPanel;
		private System.Windows.Forms.PictureBox characterImage;
		private System.Windows.Forms.TableLayoutPanel armourPanel;
		private System.Windows.Forms.Label rightHandLabel;
		private System.Windows.Forms.Label leftHandLabel;
		private System.Windows.Forms.ComboBox inventoryFilterBox;
		private System.Windows.Forms.ComboBox inventorySubFilter;
		private System.Windows.Forms.Panel inventoryScrollPanel;
		private System.Windows.Forms.TableLayoutPanel inventoryPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private AttackDefenseInfo attackDefenseInfo;
		private ItemInfo selectedEquipmentInfo;
		private ItemInfo selectedItemInfo;
		private InventoryEntry headEquipment;
		private InventoryEntry torsoEquipment;
		private InventoryEntry handEquipment;
		private InventoryEntry legEquipment;
		private InventoryEntry feetEquipment;
		private InventoryEntry mainHandEquipment;
		private InventoryEntry offHandEquipment;

	}
}