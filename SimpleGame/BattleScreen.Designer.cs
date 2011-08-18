namespace SimpleGame
{
	partial class BattleScreen
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.PlayerName = new System.Windows.Forms.Label();
			this.PlayerHP = new System.Windows.Forms.Label();
			this.MonsterHP = new System.Windows.Forms.Label();
			this.MonsterName = new System.Windows.Forms.Label();
			this.PlayerPicture = new System.Windows.Forms.PictureBox();
			this.MonsterPicture = new System.Windows.Forms.PictureBox();
			this.CombatLogTextBox = new System.Windows.Forms.TextBox();
			this.AttackPicture = new System.Windows.Forms.PictureBox();
			this.AutoPicture = new System.Windows.Forms.PictureBox();
			this.ItemPicture = new System.Windows.Forms.PictureBox();
			this.RunPicture = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MonsterPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AttackPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AutoPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RunPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.PlayerName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.PlayerHP, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.MonsterHP, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.MonsterName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.PlayerPicture, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.MonsterPicture, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.CombatLogTextBox, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.AttackPicture, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.AutoPicture, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.ItemPicture, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.RunPicture, 1, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 373);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// PlayerName
			// 
			this.PlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PlayerName.AutoSize = true;
			this.PlayerName.Location = new System.Drawing.Point(67, 13);
			this.PlayerName.Name = "PlayerName";
			this.PlayerName.Size = new System.Drawing.Size(35, 13);
			this.PlayerName.TabIndex = 0;
			this.PlayerName.Text = "label1";
			// 
			// PlayerHP
			// 
			this.PlayerHP.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PlayerHP.AutoSize = true;
			this.PlayerHP.Location = new System.Drawing.Point(67, 53);
			this.PlayerHP.Name = "PlayerHP";
			this.PlayerHP.Size = new System.Drawing.Size(35, 13);
			this.PlayerHP.TabIndex = 1;
			this.PlayerHP.Text = "label2";
			// 
			// MonsterHP
			// 
			this.MonsterHP.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.MonsterHP.AutoSize = true;
			this.MonsterHP.Location = new System.Drawing.Point(237, 53);
			this.MonsterHP.Name = "MonsterHP";
			this.MonsterHP.Size = new System.Drawing.Size(35, 13);
			this.MonsterHP.TabIndex = 2;
			this.MonsterHP.Text = "label3";
			// 
			// MonsterName
			// 
			this.MonsterName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.MonsterName.AutoSize = true;
			this.MonsterName.Location = new System.Drawing.Point(237, 13);
			this.MonsterName.Name = "MonsterName";
			this.MonsterName.Size = new System.Drawing.Size(35, 13);
			this.MonsterName.TabIndex = 3;
			this.MonsterName.Text = "label4";
			// 
			// PlayerPicture
			// 
			this.PlayerPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PlayerPicture.Location = new System.Drawing.Point(35, 83);
			this.PlayerPicture.Name = "PlayerPicture";
			this.PlayerPicture.Size = new System.Drawing.Size(100, 100);
			this.PlayerPicture.TabIndex = 4;
			this.PlayerPicture.TabStop = false;
			// 
			// MonsterPicture
			// 
			this.MonsterPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.MonsterPicture.Location = new System.Drawing.Point(205, 83);
			this.MonsterPicture.Name = "MonsterPicture";
			this.MonsterPicture.Size = new System.Drawing.Size(100, 100);
			this.MonsterPicture.TabIndex = 5;
			this.MonsterPicture.TabStop = false;
			// 
			// CombatLogTextBox
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.CombatLogTextBox, 2);
			this.CombatLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CombatLogTextBox.Location = new System.Drawing.Point(3, 189);
			this.CombatLogTextBox.Multiline = true;
			this.CombatLogTextBox.Name = "CombatLogTextBox";
			this.CombatLogTextBox.ReadOnly = true;
			this.CombatLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.CombatLogTextBox.Size = new System.Drawing.Size(334, 89);
			this.CombatLogTextBox.TabIndex = 6;
			// 
			// AttackPicture
			// 
			this.AttackPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.AttackPicture.Image = global::SimpleGame.Properties.Resources.attack_image;
			this.AttackPicture.Location = new System.Drawing.Point(35, 284);
			this.AttackPicture.Name = "AttackPicture";
			this.AttackPicture.Size = new System.Drawing.Size(100, 40);
			this.AttackPicture.TabIndex = 7;
			this.AttackPicture.TabStop = false;
			this.AttackPicture.Click += new System.EventHandler(this.AttackPicture_Click);
			// 
			// AutoPicture
			// 
			this.AutoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.AutoPicture.Image = global::SimpleGame.Properties.Resources.auto_image;
			this.AutoPicture.Location = new System.Drawing.Point(205, 284);
			this.AutoPicture.Name = "AutoPicture";
			this.AutoPicture.Size = new System.Drawing.Size(100, 40);
			this.AutoPicture.TabIndex = 8;
			this.AutoPicture.TabStop = false;
			this.AutoPicture.Click += new System.EventHandler(this.AutoPicture_Click);
			// 
			// ItemPicture
			// 
			this.ItemPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ItemPicture.Image = global::SimpleGame.Properties.Resources.item_image;
			this.ItemPicture.Location = new System.Drawing.Point(35, 330);
			this.ItemPicture.Name = "ItemPicture";
			this.ItemPicture.Size = new System.Drawing.Size(100, 40);
			this.ItemPicture.TabIndex = 9;
			this.ItemPicture.TabStop = false;
			this.ItemPicture.Click += new System.EventHandler(this.ItemPicture_Click);
			// 
			// RunPicture
			// 
			this.RunPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RunPicture.Image = global::SimpleGame.Properties.Resources.run_image;
			this.RunPicture.Location = new System.Drawing.Point(205, 330);
			this.RunPicture.Name = "RunPicture";
			this.RunPicture.Size = new System.Drawing.Size(100, 40);
			this.RunPicture.TabIndex = 10;
			this.RunPicture.TabStop = false;
			this.RunPicture.Click += new System.EventHandler(this.RunPicture_Click);
			// 
			// BattleScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 373);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(316, 371);
			this.Name = "BattleScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = " ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatchAltf4);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EndOfBattle);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GetKeys);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MonsterPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AttackPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AutoPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RunPicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label PlayerName;
		private System.Windows.Forms.Label PlayerHP;
		private System.Windows.Forms.Label MonsterHP;
		private System.Windows.Forms.Label MonsterName;
		private System.Windows.Forms.PictureBox PlayerPicture;
		private System.Windows.Forms.PictureBox MonsterPicture;
		private System.Windows.Forms.TextBox CombatLogTextBox;
		private System.Windows.Forms.PictureBox AttackPicture;
		private System.Windows.Forms.PictureBox AutoPicture;
		private System.Windows.Forms.PictureBox ItemPicture;
		private System.Windows.Forms.PictureBox RunPicture;
	}
}