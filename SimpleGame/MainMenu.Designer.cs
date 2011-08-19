namespace SimpleGame
{
	partial class MainMenu
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.NewGamePicture = new System.Windows.Forms.PictureBox();
			this.LoadGamePicture = new System.Windows.Forms.PictureBox();
			this.QuitButton = new System.Windows.Forms.PictureBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NewGamePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LoadGamePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(173, 24);
			this.menuStrip1.TabIndex = 2;
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
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// saveGameToolStripMenuItem
			// 
			this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
			this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.saveGameToolStripMenuItem.Text = "Load Game";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.NewGamePicture, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.LoadGamePicture, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.QuitButton, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 317);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// NewGamePicture
			// 
			this.NewGamePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.NewGamePicture.Image = global::SimpleGame.Properties.Resources.new_image;
			this.NewGamePicture.Location = new System.Drawing.Point(21, 12);
			this.NewGamePicture.Name = "NewGamePicture";
			this.NewGamePicture.Size = new System.Drawing.Size(130, 80);
			this.NewGamePicture.TabIndex = 0;
			this.NewGamePicture.TabStop = false;
			this.NewGamePicture.Click += new System.EventHandler(this.NewGamePicture_Click);
			// 
			// LoadGamePicture
			// 
			this.LoadGamePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LoadGamePicture.Image = global::SimpleGame.Properties.Resources.load_image;
			this.LoadGamePicture.Location = new System.Drawing.Point(21, 117);
			this.LoadGamePicture.Name = "LoadGamePicture";
			this.LoadGamePicture.Size = new System.Drawing.Size(130, 80);
			this.LoadGamePicture.TabIndex = 1;
			this.LoadGamePicture.TabStop = false;
			this.LoadGamePicture.Click += new System.EventHandler(this.LoadGamePicture_Click);
			// 
			// QuitButton
			// 
			this.QuitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.QuitButton.Image = global::SimpleGame.Properties.Resources.quit_image;
			this.QuitButton.Location = new System.Drawing.Point(21, 223);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(130, 80);
			this.QuitButton.TabIndex = 2;
			this.QuitButton.TabStop = false;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(173, 341);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NewGamePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LoadGamePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox NewGamePicture;
		private System.Windows.Forms.PictureBox LoadGamePicture;
		private System.Windows.Forms.PictureBox QuitButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}