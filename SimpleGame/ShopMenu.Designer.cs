namespace SimpleGame
{
	partial class ShopMenu
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.CurrentWeaponStats = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.CurrentArmourStats = new System.Windows.Forms.Label();
			this.ShopInventoryPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.PlayerInventoryPanel = new System.Windows.Forms.TableLayoutPanel();
			this.LeavePicture = new System.Windows.Forms.PictureBox();
			this.goldlabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LeavePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ShopInventoryPanel, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.PlayerInventoryPanel, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.LeavePicture, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.goldlabel, 0, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 462);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.CurrentWeaponStats, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 34);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Current Weapon:";
			// 
			// CurrentWeaponStats
			// 
			this.CurrentWeaponStats.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CurrentWeaponStats.AutoSize = true;
			this.CurrentWeaponStats.Location = new System.Drawing.Point(153, 10);
			this.CurrentWeaponStats.Name = "CurrentWeaponStats";
			this.CurrentWeaponStats.Size = new System.Drawing.Size(70, 13);
			this.CurrentWeaponStats.TabIndex = 1;
			this.CurrentWeaponStats.Text = "weapon stats";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.CurrentArmourStats, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 34);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Current Armour";
			// 
			// CurrentArmourStats
			// 
			this.CurrentArmourStats.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CurrentArmourStats.AutoSize = true;
			this.CurrentArmourStats.Location = new System.Drawing.Point(153, 10);
			this.CurrentArmourStats.Name = "CurrentArmourStats";
			this.CurrentArmourStats.Size = new System.Drawing.Size(64, 13);
			this.CurrentArmourStats.TabIndex = 1;
			this.CurrentArmourStats.Text = "armour stats";
			// 
			// ShopInventoryPanel
			// 
			this.ShopInventoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ShopInventoryPanel.AutoScroll = true;
			this.ShopInventoryPanel.AutoSize = true;
			this.ShopInventoryPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
			this.ShopInventoryPanel.ColumnCount = 3;
			this.ShopInventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.ShopInventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.ShopInventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ShopInventoryPanel.Location = new System.Drawing.Point(245, 123);
			this.ShopInventoryPanel.Name = "ShopInventoryPanel";
			this.ShopInventoryPanel.RowCount = 1;
			this.ShopInventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
			this.ShopInventoryPanel.Size = new System.Drawing.Size(236, 58);
			this.ShopInventoryPanel.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(71, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Your Inventory";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(317, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Items for sale";
			// 
			// PlayerInventoryPanel
			// 
			this.PlayerInventoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PlayerInventoryPanel.AutoScroll = true;
			this.PlayerInventoryPanel.AutoSize = true;
			this.PlayerInventoryPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
			this.PlayerInventoryPanel.ColumnCount = 3;
			this.PlayerInventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.PlayerInventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.PlayerInventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.PlayerInventoryPanel.Location = new System.Drawing.Point(3, 123);
			this.PlayerInventoryPanel.Name = "PlayerInventoryPanel";
			this.PlayerInventoryPanel.RowCount = 1;
			this.PlayerInventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
			this.PlayerInventoryPanel.Size = new System.Drawing.Size(236, 58);
			this.PlayerInventoryPanel.TabIndex = 5;
			// 
			// LeavePicture
			// 
			this.LeavePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LeavePicture.Image = global::SimpleGame.Properties.Resources.leave_image;
			this.LeavePicture.Location = new System.Drawing.Point(313, 419);
			this.LeavePicture.Name = "LeavePicture";
			this.LeavePicture.Size = new System.Drawing.Size(100, 40);
			this.LeavePicture.TabIndex = 7;
			this.LeavePicture.TabStop = false;
			this.LeavePicture.Click += new System.EventHandler(this.LeavePicture_Click);
			// 
			// goldlabel
			// 
			this.goldlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.goldlabel.AutoSize = true;
			this.goldlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.goldlabel.Location = new System.Drawing.Point(15, 430);
			this.goldlabel.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
			this.goldlabel.Name = "goldlabel";
			this.goldlabel.Size = new System.Drawing.Size(93, 17);
			this.goldlabel.TabIndex = 8;
			this.goldlabel.Text = "Current Gold:";
			// 
			// ShopMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 462);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ShopMenu";
			this.Text = "The Shop";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LeavePicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel ShopInventoryPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TableLayoutPanel PlayerInventoryPanel;
		private System.Windows.Forms.PictureBox LeavePicture;
		private System.Windows.Forms.Label CurrentWeaponStats;
		private System.Windows.Forms.Label CurrentArmourStats;
		private System.Windows.Forms.Label goldlabel;
	}
}