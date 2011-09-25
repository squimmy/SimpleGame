namespace SimpleGame
{
	partial class AttackDefenseInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttackDefenseInfo));
			this.playerStatsPanel = new System.Windows.Forms.TableLayoutPanel();
			this.playerAttackPanel = new System.Windows.Forms.TableLayoutPanel();
			this.primaryAttackDamageIcon = new System.Windows.Forms.PictureBox();
			this.secondaryAttackDamageIcon = new System.Windows.Forms.PictureBox();
			this.primaryAttackLabel = new System.Windows.Forms.Label();
			this.secondaryAttackLabel = new System.Windows.Forms.Label();
			this.playerProtectionPanel = new System.Windows.Forms.TableLayoutPanel();
			this.crushDamageIcon = new System.Windows.Forms.PictureBox();
			this.cutDamageIcon = new System.Windows.Forms.PictureBox();
			this.stabDamageIcon = new System.Windows.Forms.PictureBox();
			this.fireDamageIcon = new System.Windows.Forms.PictureBox();
			this.iceDamageIcon = new System.Windows.Forms.PictureBox();
			this.poisonDamageIcon = new System.Windows.Forms.PictureBox();
			this.electricityDamageIcon = new System.Windows.Forms.PictureBox();
			this.magicDamageIcon = new System.Windows.Forms.PictureBox();
			this.holyDamageIcon = new System.Windows.Forms.PictureBox();
			this.crushInfo = new System.Windows.Forms.Label();
			this.cutInfo = new System.Windows.Forms.Label();
			this.stabInfo = new System.Windows.Forms.Label();
			this.fireInfo = new System.Windows.Forms.Label();
			this.iceInfo = new System.Windows.Forms.Label();
			this.poisonInfo = new System.Windows.Forms.Label();
			this.electricityInfo = new System.Windows.Forms.Label();
			this.magicInfo = new System.Windows.Forms.Label();
			this.holyInfo = new System.Windows.Forms.Label();
			this.crushLabel = new System.Windows.Forms.Label();
			this.cutLabel = new System.Windows.Forms.Label();
			this.stabLabel = new System.Windows.Forms.Label();
			this.fireLabel = new System.Windows.Forms.Label();
			this.iceLabel = new System.Windows.Forms.Label();
			this.poisonLabel = new System.Windows.Forms.Label();
			this.electricityLabel = new System.Windows.Forms.Label();
			this.magicLabel = new System.Windows.Forms.Label();
			this.holyLabel = new System.Windows.Forms.Label();
			this.attackLabel = new System.Windows.Forms.Label();
			this.protectionLabel = new System.Windows.Forms.Label();
			this.playerStatsPanel.SuspendLayout();
			this.playerAttackPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.primaryAttackDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.secondaryAttackDamageIcon)).BeginInit();
			this.playerProtectionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.crushDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cutDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stabDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fireDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iceDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.poisonDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.electricityDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.magicDamageIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.holyDamageIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// playerStatsPanel
			// 
			this.playerStatsPanel.ColumnCount = 1;
			this.playerStatsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.playerStatsPanel.Controls.Add(this.playerAttackPanel, 0, 1);
			this.playerStatsPanel.Controls.Add(this.playerProtectionPanel, 0, 3);
			this.playerStatsPanel.Controls.Add(this.attackLabel, 0, 0);
			this.playerStatsPanel.Controls.Add(this.protectionLabel, 0, 2);
			this.playerStatsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerStatsPanel.Location = new System.Drawing.Point(0, 0);
			this.playerStatsPanel.Name = "playerStatsPanel";
			this.playerStatsPanel.RowCount = 4;
			this.playerStatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.playerStatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.playerStatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.playerStatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
			this.playerStatsPanel.Size = new System.Drawing.Size(194, 259);
			this.playerStatsPanel.TabIndex = 4;
			// 
			// playerAttackPanel
			// 
			this.playerAttackPanel.BackColor = System.Drawing.Color.White;
			this.playerAttackPanel.ColumnCount = 2;
			this.playerAttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerAttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.playerAttackPanel.Controls.Add(this.primaryAttackDamageIcon, 0, 0);
			this.playerAttackPanel.Controls.Add(this.secondaryAttackDamageIcon, 0, 1);
			this.playerAttackPanel.Controls.Add(this.primaryAttackLabel, 1, 0);
			this.playerAttackPanel.Controls.Add(this.secondaryAttackLabel, 1, 1);
			this.playerAttackPanel.Location = new System.Drawing.Point(0, 30);
			this.playerAttackPanel.Margin = new System.Windows.Forms.Padding(0);
			this.playerAttackPanel.Name = "playerAttackPanel";
			this.playerAttackPanel.RowCount = 2;
			this.playerAttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerAttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.playerAttackPanel.Size = new System.Drawing.Size(194, 36);
			this.playerAttackPanel.TabIndex = 0;
			// 
			// primaryAttackDamageIcon
			// 
			this.primaryAttackDamageIcon.Location = new System.Drawing.Point(3, 3);
			this.primaryAttackDamageIcon.Name = "primaryAttackDamageIcon";
			this.primaryAttackDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.primaryAttackDamageIcon.TabIndex = 0;
			this.primaryAttackDamageIcon.TabStop = false;
			// 
			// secondaryAttackDamageIcon
			// 
			this.secondaryAttackDamageIcon.Location = new System.Drawing.Point(3, 21);
			this.secondaryAttackDamageIcon.Name = "secondaryAttackDamageIcon";
			this.secondaryAttackDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.secondaryAttackDamageIcon.TabIndex = 1;
			this.secondaryAttackDamageIcon.TabStop = false;
			// 
			// primaryAttackLabel
			// 
			this.primaryAttackLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.primaryAttackLabel.AutoSize = true;
			this.primaryAttackLabel.Location = new System.Drawing.Point(28, 2);
			this.primaryAttackLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.primaryAttackLabel.Name = "primaryAttackLabel";
			this.primaryAttackLabel.Size = new System.Drawing.Size(7, 13);
			this.primaryAttackLabel.TabIndex = 2;
			this.primaryAttackLabel.Text = "\r\n";
			// 
			// secondaryAttackLabel
			// 
			this.secondaryAttackLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.secondaryAttackLabel.AutoSize = true;
			this.secondaryAttackLabel.Location = new System.Drawing.Point(28, 20);
			this.secondaryAttackLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.secondaryAttackLabel.Name = "secondaryAttackLabel";
			this.secondaryAttackLabel.Size = new System.Drawing.Size(0, 13);
			this.secondaryAttackLabel.TabIndex = 3;
			// 
			// playerProtectionPanel
			// 
			this.playerProtectionPanel.BackColor = System.Drawing.Color.White;
			this.playerProtectionPanel.ColumnCount = 3;
			this.playerProtectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.playerProtectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.playerProtectionPanel.Controls.Add(this.crushDamageIcon, 1, 0);
			this.playerProtectionPanel.Controls.Add(this.cutDamageIcon, 1, 1);
			this.playerProtectionPanel.Controls.Add(this.stabDamageIcon, 1, 2);
			this.playerProtectionPanel.Controls.Add(this.fireDamageIcon, 1, 3);
			this.playerProtectionPanel.Controls.Add(this.iceDamageIcon, 1, 4);
			this.playerProtectionPanel.Controls.Add(this.poisonDamageIcon, 1, 5);
			this.playerProtectionPanel.Controls.Add(this.electricityDamageIcon, 1, 6);
			this.playerProtectionPanel.Controls.Add(this.magicDamageIcon, 1, 7);
			this.playerProtectionPanel.Controls.Add(this.holyDamageIcon, 1, 8);
			this.playerProtectionPanel.Controls.Add(this.crushInfo, 2, 0);
			this.playerProtectionPanel.Controls.Add(this.cutInfo, 2, 1);
			this.playerProtectionPanel.Controls.Add(this.stabInfo, 2, 2);
			this.playerProtectionPanel.Controls.Add(this.fireInfo, 2, 3);
			this.playerProtectionPanel.Controls.Add(this.iceInfo, 2, 4);
			this.playerProtectionPanel.Controls.Add(this.poisonInfo, 2, 5);
			this.playerProtectionPanel.Controls.Add(this.electricityInfo, 2, 6);
			this.playerProtectionPanel.Controls.Add(this.magicInfo, 2, 7);
			this.playerProtectionPanel.Controls.Add(this.holyInfo, 2, 8);
			this.playerProtectionPanel.Controls.Add(this.crushLabel, 0, 0);
			this.playerProtectionPanel.Controls.Add(this.cutLabel, 0, 1);
			this.playerProtectionPanel.Controls.Add(this.stabLabel, 0, 2);
			this.playerProtectionPanel.Controls.Add(this.fireLabel, 0, 3);
			this.playerProtectionPanel.Controls.Add(this.iceLabel, 0, 4);
			this.playerProtectionPanel.Controls.Add(this.poisonLabel, 0, 5);
			this.playerProtectionPanel.Controls.Add(this.electricityLabel, 0, 6);
			this.playerProtectionPanel.Controls.Add(this.magicLabel, 0, 7);
			this.playerProtectionPanel.Controls.Add(this.holyLabel, 0, 8);
			this.playerProtectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.playerProtectionPanel.Location = new System.Drawing.Point(0, 96);
			this.playerProtectionPanel.Margin = new System.Windows.Forms.Padding(0);
			this.playerProtectionPanel.Name = "playerProtectionPanel";
			this.playerProtectionPanel.RowCount = 9;
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.playerProtectionPanel.Size = new System.Drawing.Size(194, 163);
			this.playerProtectionPanel.TabIndex = 1;
			// 
			// crushDamageIcon
			// 
			this.crushDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.crushDamageIcon.Image = global::SimpleGame.Properties.Resources.crush;
			this.crushDamageIcon.Location = new System.Drawing.Point(58, 3);
			this.crushDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.crushDamageIcon.Name = "crushDamageIcon";
			this.crushDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.crushDamageIcon.TabIndex = 0;
			this.crushDamageIcon.TabStop = false;
			// 
			// cutDamageIcon
			// 
			this.cutDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cutDamageIcon.Image = ((System.Drawing.Image)(resources.GetObject("cutDamageIcon.Image")));
			this.cutDamageIcon.Location = new System.Drawing.Point(58, 21);
			this.cutDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.cutDamageIcon.Name = "cutDamageIcon";
			this.cutDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.cutDamageIcon.TabIndex = 1;
			this.cutDamageIcon.TabStop = false;
			// 
			// stabDamageIcon
			// 
			this.stabDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.stabDamageIcon.Image = ((System.Drawing.Image)(resources.GetObject("stabDamageIcon.Image")));
			this.stabDamageIcon.Location = new System.Drawing.Point(58, 39);
			this.stabDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.stabDamageIcon.Name = "stabDamageIcon";
			this.stabDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.stabDamageIcon.TabIndex = 2;
			this.stabDamageIcon.TabStop = false;
			// 
			// fireDamageIcon
			// 
			this.fireDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fireDamageIcon.Image = ((System.Drawing.Image)(resources.GetObject("fireDamageIcon.Image")));
			this.fireDamageIcon.Location = new System.Drawing.Point(58, 57);
			this.fireDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.fireDamageIcon.Name = "fireDamageIcon";
			this.fireDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.fireDamageIcon.TabIndex = 3;
			this.fireDamageIcon.TabStop = false;
			// 
			// iceDamageIcon
			// 
			this.iceDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.iceDamageIcon.Image = global::SimpleGame.Properties.Resources.ice;
			this.iceDamageIcon.Location = new System.Drawing.Point(58, 75);
			this.iceDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.iceDamageIcon.Name = "iceDamageIcon";
			this.iceDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.iceDamageIcon.TabIndex = 4;
			this.iceDamageIcon.TabStop = false;
			// 
			// poisonDamageIcon
			// 
			this.poisonDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.poisonDamageIcon.Image = ((System.Drawing.Image)(resources.GetObject("poisonDamageIcon.Image")));
			this.poisonDamageIcon.Location = new System.Drawing.Point(58, 93);
			this.poisonDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.poisonDamageIcon.Name = "poisonDamageIcon";
			this.poisonDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.poisonDamageIcon.TabIndex = 5;
			this.poisonDamageIcon.TabStop = false;
			// 
			// electricityDamageIcon
			// 
			this.electricityDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.electricityDamageIcon.Image = ((System.Drawing.Image)(resources.GetObject("electricityDamageIcon.Image")));
			this.electricityDamageIcon.Location = new System.Drawing.Point(58, 111);
			this.electricityDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.electricityDamageIcon.Name = "electricityDamageIcon";
			this.electricityDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.electricityDamageIcon.TabIndex = 6;
			this.electricityDamageIcon.TabStop = false;
			// 
			// magicDamageIcon
			// 
			this.magicDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.magicDamageIcon.Image = ((System.Drawing.Image)(resources.GetObject("magicDamageIcon.Image")));
			this.magicDamageIcon.Location = new System.Drawing.Point(58, 129);
			this.magicDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.magicDamageIcon.Name = "magicDamageIcon";
			this.magicDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.magicDamageIcon.TabIndex = 7;
			this.magicDamageIcon.TabStop = false;
			// 
			// holyDamageIcon
			// 
			this.holyDamageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.holyDamageIcon.Image = ((System.Drawing.Image)(resources.GetObject("holyDamageIcon.Image")));
			this.holyDamageIcon.Location = new System.Drawing.Point(58, 147);
			this.holyDamageIcon.Margin = new System.Windows.Forms.Padding(0);
			this.holyDamageIcon.Name = "holyDamageIcon";
			this.holyDamageIcon.Size = new System.Drawing.Size(12, 12);
			this.holyDamageIcon.TabIndex = 8;
			this.holyDamageIcon.TabStop = false;
			// 
			// crushInfo
			// 
			this.crushInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.crushInfo.AutoSize = true;
			this.crushInfo.Location = new System.Drawing.Point(76, 2);
			this.crushInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.crushInfo.Name = "crushInfo";
			this.crushInfo.Size = new System.Drawing.Size(0, 13);
			this.crushInfo.TabIndex = 9;
			// 
			// cutInfo
			// 
			this.cutInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cutInfo.AutoSize = true;
			this.cutInfo.Location = new System.Drawing.Point(76, 20);
			this.cutInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.cutInfo.Name = "cutInfo";
			this.cutInfo.Size = new System.Drawing.Size(0, 13);
			this.cutInfo.TabIndex = 10;
			// 
			// stabInfo
			// 
			this.stabInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.stabInfo.AutoSize = true;
			this.stabInfo.Location = new System.Drawing.Point(76, 38);
			this.stabInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.stabInfo.Name = "stabInfo";
			this.stabInfo.Size = new System.Drawing.Size(0, 13);
			this.stabInfo.TabIndex = 11;
			// 
			// fireInfo
			// 
			this.fireInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fireInfo.AutoSize = true;
			this.fireInfo.Location = new System.Drawing.Point(76, 56);
			this.fireInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.fireInfo.Name = "fireInfo";
			this.fireInfo.Size = new System.Drawing.Size(0, 13);
			this.fireInfo.TabIndex = 12;
			// 
			// iceInfo
			// 
			this.iceInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.iceInfo.AutoSize = true;
			this.iceInfo.Location = new System.Drawing.Point(76, 74);
			this.iceInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.iceInfo.Name = "iceInfo";
			this.iceInfo.Size = new System.Drawing.Size(0, 13);
			this.iceInfo.TabIndex = 13;
			// 
			// poisonInfo
			// 
			this.poisonInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.poisonInfo.AutoSize = true;
			this.poisonInfo.Location = new System.Drawing.Point(76, 92);
			this.poisonInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.poisonInfo.Name = "poisonInfo";
			this.poisonInfo.Size = new System.Drawing.Size(0, 13);
			this.poisonInfo.TabIndex = 14;
			// 
			// electricityInfo
			// 
			this.electricityInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.electricityInfo.AutoSize = true;
			this.electricityInfo.Location = new System.Drawing.Point(76, 110);
			this.electricityInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.electricityInfo.Name = "electricityInfo";
			this.electricityInfo.Size = new System.Drawing.Size(0, 13);
			this.electricityInfo.TabIndex = 15;
			// 
			// magicInfo
			// 
			this.magicInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.magicInfo.AutoSize = true;
			this.magicInfo.Location = new System.Drawing.Point(76, 128);
			this.magicInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.magicInfo.Name = "magicInfo";
			this.magicInfo.Size = new System.Drawing.Size(0, 13);
			this.magicInfo.TabIndex = 16;
			// 
			// holyInfo
			// 
			this.holyInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.holyInfo.AutoSize = true;
			this.holyInfo.Location = new System.Drawing.Point(76, 147);
			this.holyInfo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.holyInfo.Name = "holyInfo";
			this.holyInfo.Size = new System.Drawing.Size(0, 13);
			this.holyInfo.TabIndex = 17;
			// 
			// crushLabel
			// 
			this.crushLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.crushLabel.AutoSize = true;
			this.crushLabel.Location = new System.Drawing.Point(3, 2);
			this.crushLabel.Margin = new System.Windows.Forms.Padding(0);
			this.crushLabel.Name = "crushLabel";
			this.crushLabel.Size = new System.Drawing.Size(48, 13);
			this.crushLabel.TabIndex = 18;
			this.crushLabel.Text = "Crushing";
			// 
			// cutLabel
			// 
			this.cutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cutLabel.AutoSize = true;
			this.cutLabel.Location = new System.Drawing.Point(7, 20);
			this.cutLabel.Margin = new System.Windows.Forms.Padding(0);
			this.cutLabel.Name = "cutLabel";
			this.cutLabel.Size = new System.Drawing.Size(40, 13);
			this.cutLabel.TabIndex = 19;
			this.cutLabel.Text = "Cutting";
			// 
			// stabLabel
			// 
			this.stabLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.stabLabel.AutoSize = true;
			this.stabLabel.Location = new System.Drawing.Point(3, 38);
			this.stabLabel.Margin = new System.Windows.Forms.Padding(0);
			this.stabLabel.Name = "stabLabel";
			this.stabLabel.Size = new System.Drawing.Size(49, 13);
			this.stabLabel.TabIndex = 20;
			this.stabLabel.Text = "Stabbing";
			// 
			// fireLabel
			// 
			this.fireLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fireLabel.AutoSize = true;
			this.fireLabel.Location = new System.Drawing.Point(15, 56);
			this.fireLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fireLabel.Name = "fireLabel";
			this.fireLabel.Size = new System.Drawing.Size(24, 13);
			this.fireLabel.TabIndex = 21;
			this.fireLabel.Text = "Fire";
			// 
			// iceLabel
			// 
			this.iceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.iceLabel.AutoSize = true;
			this.iceLabel.Location = new System.Drawing.Point(16, 74);
			this.iceLabel.Margin = new System.Windows.Forms.Padding(0);
			this.iceLabel.Name = "iceLabel";
			this.iceLabel.Size = new System.Drawing.Size(22, 13);
			this.iceLabel.TabIndex = 22;
			this.iceLabel.Text = "Ice";
			// 
			// poisonLabel
			// 
			this.poisonLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.poisonLabel.AutoSize = true;
			this.poisonLabel.Location = new System.Drawing.Point(8, 92);
			this.poisonLabel.Margin = new System.Windows.Forms.Padding(0);
			this.poisonLabel.Name = "poisonLabel";
			this.poisonLabel.Size = new System.Drawing.Size(39, 13);
			this.poisonLabel.TabIndex = 23;
			this.poisonLabel.Text = "Poison";
			// 
			// electricityLabel
			// 
			this.electricityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.electricityLabel.AutoSize = true;
			this.electricityLabel.Location = new System.Drawing.Point(1, 110);
			this.electricityLabel.Margin = new System.Windows.Forms.Padding(0);
			this.electricityLabel.Name = "electricityLabel";
			this.electricityLabel.Size = new System.Drawing.Size(52, 13);
			this.electricityLabel.TabIndex = 24;
			this.electricityLabel.Text = "Electricity";
			// 
			// magicLabel
			// 
			this.magicLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.magicLabel.AutoSize = true;
			this.magicLabel.Location = new System.Drawing.Point(9, 128);
			this.magicLabel.Margin = new System.Windows.Forms.Padding(0);
			this.magicLabel.Name = "magicLabel";
			this.magicLabel.Size = new System.Drawing.Size(36, 13);
			this.magicLabel.TabIndex = 25;
			this.magicLabel.Text = "Magic";
			// 
			// holyLabel
			// 
			this.holyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.holyLabel.AutoSize = true;
			this.holyLabel.Location = new System.Drawing.Point(13, 147);
			this.holyLabel.Margin = new System.Windows.Forms.Padding(0);
			this.holyLabel.Name = "holyLabel";
			this.holyLabel.Size = new System.Drawing.Size(28, 13);
			this.holyLabel.TabIndex = 26;
			this.holyLabel.Text = "Holy";
			// 
			// attackLabel
			// 
			this.attackLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.attackLabel.AutoSize = true;
			this.attackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attackLabel.Location = new System.Drawing.Point(72, 6);
			this.attackLabel.Name = "attackLabel";
			this.attackLabel.Size = new System.Drawing.Size(49, 18);
			this.attackLabel.TabIndex = 2;
			this.attackLabel.Text = "Attack";
			// 
			// protectionLabel
			// 
			this.protectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.protectionLabel.AutoSize = true;
			this.protectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.protectionLabel.Location = new System.Drawing.Point(68, 72);
			this.protectionLabel.Name = "protectionLabel";
			this.protectionLabel.Size = new System.Drawing.Size(57, 18);
			this.protectionLabel.TabIndex = 3;
			this.protectionLabel.Text = "Armour";
			// 
			// AttackDefenseInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.playerStatsPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "AttackDefenseInfo";
			this.Size = new System.Drawing.Size(194, 259);
			this.playerStatsPanel.ResumeLayout(false);
			this.playerStatsPanel.PerformLayout();
			this.playerAttackPanel.ResumeLayout(false);
			this.playerAttackPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.primaryAttackDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.secondaryAttackDamageIcon)).EndInit();
			this.playerProtectionPanel.ResumeLayout(false);
			this.playerProtectionPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.crushDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cutDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stabDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fireDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iceDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.poisonDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.electricityDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.magicDamageIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.holyDamageIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel playerStatsPanel;
		private System.Windows.Forms.TableLayoutPanel playerAttackPanel;
		private System.Windows.Forms.PictureBox primaryAttackDamageIcon;
		private System.Windows.Forms.PictureBox secondaryAttackDamageIcon;
		private System.Windows.Forms.Label primaryAttackLabel;
		private System.Windows.Forms.Label secondaryAttackLabel;
		private System.Windows.Forms.TableLayoutPanel playerProtectionPanel;
		private System.Windows.Forms.PictureBox crushDamageIcon;
		private System.Windows.Forms.PictureBox cutDamageIcon;
		private System.Windows.Forms.PictureBox stabDamageIcon;
		private System.Windows.Forms.PictureBox fireDamageIcon;
		private System.Windows.Forms.PictureBox iceDamageIcon;
		private System.Windows.Forms.PictureBox poisonDamageIcon;
		private System.Windows.Forms.PictureBox electricityDamageIcon;
		private System.Windows.Forms.PictureBox magicDamageIcon;
		private System.Windows.Forms.PictureBox holyDamageIcon;
		private System.Windows.Forms.Label crushInfo;
		private System.Windows.Forms.Label cutInfo;
		private System.Windows.Forms.Label stabInfo;
		private System.Windows.Forms.Label fireInfo;
		private System.Windows.Forms.Label iceInfo;
		private System.Windows.Forms.Label poisonInfo;
		private System.Windows.Forms.Label electricityInfo;
		private System.Windows.Forms.Label magicInfo;
		private System.Windows.Forms.Label holyInfo;
		private System.Windows.Forms.Label crushLabel;
		private System.Windows.Forms.Label cutLabel;
		private System.Windows.Forms.Label stabLabel;
		private System.Windows.Forms.Label fireLabel;
		private System.Windows.Forms.Label iceLabel;
		private System.Windows.Forms.Label poisonLabel;
		private System.Windows.Forms.Label electricityLabel;
		private System.Windows.Forms.Label magicLabel;
		private System.Windows.Forms.Label holyLabel;
		private System.Windows.Forms.Label attackLabel;
		private System.Windows.Forms.Label protectionLabel;
	}
}
