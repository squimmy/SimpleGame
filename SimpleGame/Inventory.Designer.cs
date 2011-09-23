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
			this.headItemPictureBox = new System.Windows.Forms.PictureBox();
			this.torsoItemPictureBox = new System.Windows.Forms.PictureBox();
			this.handItemPictureBox = new System.Windows.Forms.PictureBox();
			this.legItemPictureBox = new System.Windows.Forms.PictureBox();
			this.feetItemPictureBox = new System.Windows.Forms.PictureBox();
			this.headItemLabel = new System.Windows.Forms.Label();
			this.torsoItemLabel = new System.Windows.Forms.Label();
			this.handItemLabel = new System.Windows.Forms.Label();
			this.legItemLabel = new System.Windows.Forms.Label();
			this.feetItemLabel = new System.Windows.Forms.Label();
			this.rightHandLabel = new System.Windows.Forms.Label();
			this.leftHandLabel = new System.Windows.Forms.Label();
			this.primaryWeaponPanel = new System.Windows.Forms.TableLayoutPanel();
			this.rightHandItemPictureBox = new System.Windows.Forms.PictureBox();
			this.rightHandItemLabel = new System.Windows.Forms.Label();
			this.secondaryWeaponPanel = new System.Windows.Forms.TableLayoutPanel();
			this.leftHandItemPictureBox = new System.Windows.Forms.PictureBox();
			this.leftHandItemLabel = new System.Windows.Forms.Label();
			this.inventoryScrollPanel = new System.Windows.Forms.Panel();
			this.inventoryPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.inventorySubFilter = new System.Windows.Forms.ComboBox();
			this.inventoryFilterBox = new System.Windows.Forms.ComboBox();
			this.attackDefenseInfo = new SimpleGame.AttackDefenseInfo();
			this.selectedEquipmentInfo = new SimpleGame.ItemInfo();
			this.selectedItemInfo = new SimpleGame.ItemInfo();
			this.masterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
			this.armourPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.headItemPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.torsoItemPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.handItemPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.legItemPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.feetItemPictureBox)).BeginInit();
			this.primaryWeaponPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rightHandItemPictureBox)).BeginInit();
			this.secondaryWeaponPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftHandItemPictureBox)).BeginInit();
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
			this.masterPanel.Controls.Add(this.primaryWeaponPanel, 1, 0);
			this.masterPanel.Controls.Add(this.secondaryWeaponPanel, 1, 1);
			this.masterPanel.Controls.Add(this.inventoryScrollPanel, 2, 1);
			this.masterPanel.Controls.Add(this.tableLayoutPanel1, 2, 0);
			this.masterPanel.Controls.Add(this.attackDefenseInfo, 0, 3);
			this.masterPanel.Controls.Add(this.selectedEquipmentInfo, 1, 3);
			this.masterPanel.Controls.Add(this.selectedItemInfo, 2, 3);
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
			this.armourPanel.ColumnCount = 2;
			this.armourPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.armourPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.armourPanel.Controls.Add(this.headItemPictureBox, 0, 0);
			this.armourPanel.Controls.Add(this.torsoItemPictureBox, 0, 1);
			this.armourPanel.Controls.Add(this.handItemPictureBox, 0, 2);
			this.armourPanel.Controls.Add(this.legItemPictureBox, 0, 3);
			this.armourPanel.Controls.Add(this.feetItemPictureBox, 0, 4);
			this.armourPanel.Controls.Add(this.headItemLabel, 1, 0);
			this.armourPanel.Controls.Add(this.torsoItemLabel, 1, 1);
			this.armourPanel.Controls.Add(this.handItemLabel, 1, 2);
			this.armourPanel.Controls.Add(this.legItemLabel, 1, 3);
			this.armourPanel.Controls.Add(this.feetItemLabel, 1, 4);
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
			// headItemPictureBox
			// 
			this.headItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.headItemPictureBox.Location = new System.Drawing.Point(1, 1);
			this.headItemPictureBox.Margin = new System.Windows.Forms.Padding(1);
			this.headItemPictureBox.Name = "headItemPictureBox";
			this.headItemPictureBox.Size = new System.Drawing.Size(44, 44);
			this.headItemPictureBox.TabIndex = 0;
			this.headItemPictureBox.TabStop = false;
			// 
			// torsoItemPictureBox
			// 
			this.torsoItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.torsoItemPictureBox.Location = new System.Drawing.Point(1, 47);
			this.torsoItemPictureBox.Margin = new System.Windows.Forms.Padding(1);
			this.torsoItemPictureBox.Name = "torsoItemPictureBox";
			this.torsoItemPictureBox.Size = new System.Drawing.Size(44, 44);
			this.torsoItemPictureBox.TabIndex = 1;
			this.torsoItemPictureBox.TabStop = false;
			// 
			// handItemPictureBox
			// 
			this.handItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.handItemPictureBox.Location = new System.Drawing.Point(1, 93);
			this.handItemPictureBox.Margin = new System.Windows.Forms.Padding(1);
			this.handItemPictureBox.Name = "handItemPictureBox";
			this.handItemPictureBox.Size = new System.Drawing.Size(44, 44);
			this.handItemPictureBox.TabIndex = 2;
			this.handItemPictureBox.TabStop = false;
			// 
			// legItemPictureBox
			// 
			this.legItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.legItemPictureBox.Location = new System.Drawing.Point(1, 139);
			this.legItemPictureBox.Margin = new System.Windows.Forms.Padding(1);
			this.legItemPictureBox.Name = "legItemPictureBox";
			this.legItemPictureBox.Size = new System.Drawing.Size(44, 44);
			this.legItemPictureBox.TabIndex = 3;
			this.legItemPictureBox.TabStop = false;
			// 
			// feetItemPictureBox
			// 
			this.feetItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.feetItemPictureBox.Location = new System.Drawing.Point(1, 185);
			this.feetItemPictureBox.Margin = new System.Windows.Forms.Padding(1);
			this.feetItemPictureBox.Name = "feetItemPictureBox";
			this.feetItemPictureBox.Size = new System.Drawing.Size(44, 44);
			this.feetItemPictureBox.TabIndex = 4;
			this.feetItemPictureBox.TabStop = false;
			// 
			// headItemLabel
			// 
			this.headItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.headItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.headItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headItemLabel.Location = new System.Drawing.Point(61, 10);
			this.headItemLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
			this.headItemLabel.Name = "headItemLabel";
			this.headItemLabel.Size = new System.Drawing.Size(179, 26);
			this.headItemLabel.TabIndex = 5;
			this.headItemLabel.Text = "headArmourLabel";
			this.headItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// torsoItemLabel
			// 
			this.torsoItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.torsoItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.torsoItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.torsoItemLabel.Location = new System.Drawing.Point(61, 56);
			this.torsoItemLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
			this.torsoItemLabel.Name = "torsoItemLabel";
			this.torsoItemLabel.Size = new System.Drawing.Size(179, 26);
			this.torsoItemLabel.TabIndex = 6;
			this.torsoItemLabel.Text = "torsoArmourLabel";
			this.torsoItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// handItemLabel
			// 
			this.handItemLabel.BackColor = System.Drawing.SystemColors.Control;
			this.handItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.handItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.handItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.handItemLabel.Location = new System.Drawing.Point(61, 102);
			this.handItemLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
			this.handItemLabel.Name = "handItemLabel";
			this.handItemLabel.Size = new System.Drawing.Size(179, 26);
			this.handItemLabel.TabIndex = 7;
			this.handItemLabel.Text = "handArmourLabel";
			this.handItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// legItemLabel
			// 
			this.legItemLabel.BackColor = System.Drawing.SystemColors.Control;
			this.legItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.legItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.legItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.legItemLabel.Location = new System.Drawing.Point(61, 148);
			this.legItemLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
			this.legItemLabel.Name = "legItemLabel";
			this.legItemLabel.Size = new System.Drawing.Size(179, 26);
			this.legItemLabel.TabIndex = 8;
			this.legItemLabel.Text = "legArmourLabel";
			this.legItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// feetItemLabel
			// 
			this.feetItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.feetItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.feetItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.feetItemLabel.Location = new System.Drawing.Point(61, 194);
			this.feetItemLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
			this.feetItemLabel.Name = "feetItemLabel";
			this.feetItemLabel.Size = new System.Drawing.Size(179, 26);
			this.feetItemLabel.TabIndex = 9;
			this.feetItemLabel.Text = "feetArmourLabel";
			this.feetItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.rightHandLabel.Click += new System.EventHandler(this.rightHandClicked);
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
			this.leftHandLabel.Click += new System.EventHandler(this.leftHandClicked);
			// 
			// primaryWeaponPanel
			// 
			this.primaryWeaponPanel.ColumnCount = 2;
			this.primaryWeaponPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.primaryWeaponPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.primaryWeaponPanel.Controls.Add(this.rightHandItemPictureBox, 0, 0);
			this.primaryWeaponPanel.Controls.Add(this.rightHandItemLabel, 1, 0);
			this.primaryWeaponPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.primaryWeaponPanel.Location = new System.Drawing.Point(200, 0);
			this.primaryWeaponPanel.Margin = new System.Windows.Forms.Padding(0);
			this.primaryWeaponPanel.Name = "primaryWeaponPanel";
			this.primaryWeaponPanel.RowCount = 1;
			this.primaryWeaponPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.primaryWeaponPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.primaryWeaponPanel.Size = new System.Drawing.Size(250, 46);
			this.primaryWeaponPanel.TabIndex = 5;
			// 
			// rightHandItemPictureBox
			// 
			this.rightHandItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.rightHandItemPictureBox.Location = new System.Drawing.Point(1, 1);
			this.rightHandItemPictureBox.Margin = new System.Windows.Forms.Padding(1);
			this.rightHandItemPictureBox.Name = "rightHandItemPictureBox";
			this.rightHandItemPictureBox.Size = new System.Drawing.Size(44, 44);
			this.rightHandItemPictureBox.TabIndex = 0;
			this.rightHandItemPictureBox.TabStop = false;
			this.rightHandItemPictureBox.Click += new System.EventHandler(this.rightHandClicked);
			// 
			// rightHandItemLabel
			// 
			this.rightHandItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.rightHandItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightHandItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rightHandItemLabel.Location = new System.Drawing.Point(61, 10);
			this.rightHandItemLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
			this.rightHandItemLabel.Name = "rightHandItemLabel";
			this.rightHandItemLabel.Size = new System.Drawing.Size(179, 26);
			this.rightHandItemLabel.TabIndex = 1;
			this.rightHandItemLabel.Text = "primaryWeaponLabel";
			this.rightHandItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rightHandItemLabel.Click += new System.EventHandler(this.rightHandClicked);
			// 
			// secondaryWeaponPanel
			// 
			this.secondaryWeaponPanel.ColumnCount = 2;
			this.secondaryWeaponPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.secondaryWeaponPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.secondaryWeaponPanel.Controls.Add(this.leftHandItemPictureBox, 0, 0);
			this.secondaryWeaponPanel.Controls.Add(this.leftHandItemLabel, 1, 0);
			this.secondaryWeaponPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.secondaryWeaponPanel.Location = new System.Drawing.Point(200, 46);
			this.secondaryWeaponPanel.Margin = new System.Windows.Forms.Padding(0);
			this.secondaryWeaponPanel.Name = "secondaryWeaponPanel";
			this.secondaryWeaponPanel.RowCount = 1;
			this.secondaryWeaponPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.secondaryWeaponPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.secondaryWeaponPanel.Size = new System.Drawing.Size(250, 46);
			this.secondaryWeaponPanel.TabIndex = 6;
			// 
			// leftHandItemPictureBox
			// 
			this.leftHandItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.leftHandItemPictureBox.Location = new System.Drawing.Point(1, 1);
			this.leftHandItemPictureBox.Margin = new System.Windows.Forms.Padding(1);
			this.leftHandItemPictureBox.Name = "leftHandItemPictureBox";
			this.leftHandItemPictureBox.Size = new System.Drawing.Size(44, 44);
			this.leftHandItemPictureBox.TabIndex = 0;
			this.leftHandItemPictureBox.TabStop = false;
			this.leftHandItemPictureBox.Click += new System.EventHandler(this.leftHandClicked);
			// 
			// leftHandItemLabel
			// 
			this.leftHandItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.leftHandItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftHandItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.leftHandItemLabel.Location = new System.Drawing.Point(61, 10);
			this.leftHandItemLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
			this.leftHandItemLabel.Name = "leftHandItemLabel";
			this.leftHandItemLabel.Size = new System.Drawing.Size(179, 26);
			this.leftHandItemLabel.TabIndex = 1;
			this.leftHandItemLabel.Text = "secondaryWeaponLabel";
			this.leftHandItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.leftHandItemLabel.Click += new System.EventHandler(this.leftHandClicked);
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
			((System.ComponentModel.ISupportInitialize)(this.headItemPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.torsoItemPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.handItemPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.legItemPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.feetItemPictureBox)).EndInit();
			this.primaryWeaponPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rightHandItemPictureBox)).EndInit();
			this.secondaryWeaponPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.leftHandItemPictureBox)).EndInit();
			this.inventoryScrollPanel.ResumeLayout(false);
			this.inventoryScrollPanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel masterPanel;
		private System.Windows.Forms.PictureBox characterImage;
		private System.Windows.Forms.TableLayoutPanel armourPanel;
		private System.Windows.Forms.PictureBox headItemPictureBox;
		private System.Windows.Forms.PictureBox torsoItemPictureBox;
		private System.Windows.Forms.PictureBox handItemPictureBox;
		private System.Windows.Forms.PictureBox legItemPictureBox;
		private System.Windows.Forms.PictureBox feetItemPictureBox;
		private System.Windows.Forms.Label rightHandLabel;
		private System.Windows.Forms.Label leftHandLabel;
		private System.Windows.Forms.Label headItemLabel;
		private System.Windows.Forms.Label torsoItemLabel;
		private System.Windows.Forms.Label handItemLabel;
		private System.Windows.Forms.Label legItemLabel;
		private System.Windows.Forms.Label feetItemLabel;
		private System.Windows.Forms.TableLayoutPanel primaryWeaponPanel;
		private System.Windows.Forms.TableLayoutPanel secondaryWeaponPanel;
		private System.Windows.Forms.PictureBox rightHandItemPictureBox;
		private System.Windows.Forms.Label rightHandItemLabel;
		private System.Windows.Forms.PictureBox leftHandItemPictureBox;
		private System.Windows.Forms.Label leftHandItemLabel;
		private System.Windows.Forms.ComboBox inventoryFilterBox;
		private System.Windows.Forms.ComboBox inventorySubFilter;
		private System.Windows.Forms.Panel inventoryScrollPanel;
		private System.Windows.Forms.TableLayoutPanel inventoryPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private AttackDefenseInfo attackDefenseInfo;
		private ItemInfo selectedEquipmentInfo;
		private ItemInfo selectedItemInfo;

	}
}