namespace SimpleGame
{
	partial class GameMenu
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
			this.SavePicture = new System.Windows.Forms.PictureBox();
			this.QuitPicture = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.HPLabel = new System.Windows.Forms.Label();
			this.LevelLabel = new System.Windows.Forms.Label();
			this.XPLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.GoldLabel = new System.Windows.Forms.Label();
			this.FightMonstersPicture = new System.Windows.Forms.PictureBox();
			this.ShopPicture = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SavePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QuitPicture)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FightMonstersPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShopPicture)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.SavePicture, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.QuitPicture, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.FightMonstersPicture, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.ShopPicture, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 306);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// SavePicture
			// 
			this.SavePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.SavePicture.Image = global::SimpleGame.Properties.Resources.save_image;
			this.SavePicture.Location = new System.Drawing.Point(4, 216);
			this.SavePicture.Name = "SavePicture";
			this.SavePicture.Size = new System.Drawing.Size(130, 80);
			this.SavePicture.TabIndex = 2;
			this.SavePicture.TabStop = false;
			this.SavePicture.Click += new System.EventHandler(this.SavePicture_Click);
			// 
			// QuitPicture
			// 
			this.QuitPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.QuitPicture.Image = global::SimpleGame.Properties.Resources.quit_image;
			this.QuitPicture.Location = new System.Drawing.Point(142, 216);
			this.QuitPicture.Name = "QuitPicture";
			this.QuitPicture.Size = new System.Drawing.Size(130, 80);
			this.QuitPicture.TabIndex = 3;
			this.QuitPicture.TabStop = false;
			this.QuitPicture.Click += new System.EventHandler(this.QuitPicture_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.NameLabel, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.HPLabel, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.LevelLabel, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.XPLabel, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.GoldLabel, 1, 4);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 100);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(1);
			this.label1.Size = new System.Drawing.Size(37, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 20);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(1);
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hit Points";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 40);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(1);
			this.label3.Size = new System.Drawing.Size(35, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Level";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 60);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(1);
			this.label4.Size = new System.Drawing.Size(62, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Experience";
			// 
			// NameLabel
			// 
			this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(171, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Padding = new System.Windows.Forms.Padding(1);
			this.NameLabel.Size = new System.Drawing.Size(63, 15);
			this.NameLabel.TabIndex = 4;
			this.NameLabel.Text = "NameLabel";
			// 
			// HPLabel
			// 
			this.HPLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.HPLabel.AutoSize = true;
			this.HPLabel.Location = new System.Drawing.Point(177, 20);
			this.HPLabel.Name = "HPLabel";
			this.HPLabel.Padding = new System.Windows.Forms.Padding(1);
			this.HPLabel.Size = new System.Drawing.Size(50, 15);
			this.HPLabel.TabIndex = 5;
			this.HPLabel.Text = "HPLabel";
			// 
			// LevelLabel
			// 
			this.LevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LevelLabel.AutoSize = true;
			this.LevelLabel.Location = new System.Drawing.Point(172, 40);
			this.LevelLabel.Name = "LevelLabel";
			this.LevelLabel.Padding = new System.Windows.Forms.Padding(1);
			this.LevelLabel.Size = new System.Drawing.Size(61, 15);
			this.LevelLabel.TabIndex = 6;
			this.LevelLabel.Text = "LevelLabel";
			// 
			// XPLabel
			// 
			this.XPLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.XPLabel.AutoSize = true;
			this.XPLabel.Location = new System.Drawing.Point(178, 60);
			this.XPLabel.Name = "XPLabel";
			this.XPLabel.Padding = new System.Windows.Forms.Padding(1);
			this.XPLabel.Size = new System.Drawing.Size(49, 15);
			this.XPLabel.TabIndex = 7;
			this.XPLabel.Text = "XPLabel";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(53, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Gold";
			// 
			// GoldLabel
			// 
			this.GoldLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.GoldLabel.AutoSize = true;
			this.GoldLabel.Location = new System.Drawing.Point(185, 80);
			this.GoldLabel.Name = "GoldLabel";
			this.GoldLabel.Size = new System.Drawing.Size(35, 13);
			this.GoldLabel.TabIndex = 9;
			this.GoldLabel.Text = "label6";
			// 
			// FightMonstersPicture
			// 
			this.FightMonstersPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.FightMonstersPicture.Image = global::SimpleGame.Properties.Resources.fight_image;
			this.FightMonstersPicture.InitialImage = null;
			this.FightMonstersPicture.Location = new System.Drawing.Point(142, 116);
			this.FightMonstersPicture.Name = "FightMonstersPicture";
			this.FightMonstersPicture.Size = new System.Drawing.Size(130, 80);
			this.FightMonstersPicture.TabIndex = 0;
			this.FightMonstersPicture.TabStop = false;
			this.FightMonstersPicture.Click += new System.EventHandler(this.FightMonstersPicture_Click);
			// 
			// ShopPicture
			// 
			this.ShopPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ShopPicture.Image = global::SimpleGame.Properties.Resources.shop_image;
			this.ShopPicture.Location = new System.Drawing.Point(4, 116);
			this.ShopPicture.Name = "ShopPicture";
			this.ShopPicture.Size = new System.Drawing.Size(130, 80);
			this.ShopPicture.TabIndex = 1;
			this.ShopPicture.TabStop = false;
			this.ShopPicture.Click += new System.EventHandler(this.ShopPicture_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(276, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// saveGameToolStripMenuItem
			// 
			this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
			this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.saveGameToolStripMenuItem.Text = "Save Game";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// GameMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 330);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(292, 346);
			this.Name = "GameMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Monster Fighting Game";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SavePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QuitPicture)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FightMonstersPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShopPicture)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.PictureBox FightMonstersPicture;
		private System.Windows.Forms.PictureBox ShopPicture;
		private System.Windows.Forms.PictureBox SavePicture;
		private System.Windows.Forms.PictureBox QuitPicture;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label HPLabel;
		private System.Windows.Forms.Label LevelLabel;
		private System.Windows.Forms.Label XPLabel;
		private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label GoldLabel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

