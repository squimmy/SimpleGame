namespace SimpleGame
{
	partial class ItemInfo
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
			this.ItemTitlePanel = new System.Windows.Forms.TableLayoutPanel();
			this.ItemPicture = new System.Windows.Forms.PictureBox();
			this.ItemName = new System.Windows.Forms.Label();
			this.ItemDetailsPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ItemInfoLabel = new System.Windows.Forms.Label();
			this.detailsPanel = new System.Windows.Forms.TableLayoutPanel();
			this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
			this.mainPanel.SuspendLayout();
			this.ItemTitlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
			this.ItemDetailsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.White;
			this.mainPanel.ColumnCount = 1;
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainPanel.Controls.Add(this.ItemTitlePanel, 0, 0);
			this.mainPanel.Controls.Add(this.ItemDetailsPanel, 0, 1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.RowCount = 3;
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.mainPanel.Size = new System.Drawing.Size(244, 244);
			this.mainPanel.TabIndex = 5;
			// 
			// ItemTitlePanel
			// 
			this.ItemTitlePanel.ColumnCount = 2;
			this.ItemTitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.ItemTitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ItemTitlePanel.Controls.Add(this.ItemPicture, 0, 0);
			this.ItemTitlePanel.Controls.Add(this.ItemName, 1, 0);
			this.ItemTitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ItemTitlePanel.Location = new System.Drawing.Point(25, 0);
			this.ItemTitlePanel.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
			this.ItemTitlePanel.Name = "ItemTitlePanel";
			this.ItemTitlePanel.RowCount = 1;
			this.ItemTitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ItemTitlePanel.Size = new System.Drawing.Size(219, 46);
			this.ItemTitlePanel.TabIndex = 0;
			// 
			// ItemPicture
			// 
			this.ItemPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ItemPicture.Location = new System.Drawing.Point(3, 3);
			this.ItemPicture.Name = "ItemPicture";
			this.ItemPicture.Size = new System.Drawing.Size(40, 40);
			this.ItemPicture.TabIndex = 0;
			this.ItemPicture.TabStop = false;
			// 
			// ItemName
			// 
			this.ItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ItemName.AutoSize = true;
			this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemName.Location = new System.Drawing.Point(66, 14);
			this.ItemName.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
			this.ItemName.Name = "ItemName";
			this.ItemName.Size = new System.Drawing.Size(95, 18);
			this.ItemName.TabIndex = 1;
			this.ItemName.Text = "selected Item";
			// 
			// ItemDetailsPanel
			// 
			this.ItemDetailsPanel.ColumnCount = 1;
			this.ItemDetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ItemDetailsPanel.Controls.Add(this.ItemInfoLabel, 0, 0);
			this.ItemDetailsPanel.Controls.Add(this.detailsPanel, 0, 1);
			this.ItemDetailsPanel.Controls.Add(this.buttonPanel, 0, 2);
			this.ItemDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ItemDetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemDetailsPanel.Location = new System.Drawing.Point(3, 49);
			this.ItemDetailsPanel.Name = "ItemDetailsPanel";
			this.ItemDetailsPanel.RowCount = 3;
			this.ItemDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.ItemDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ItemDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.ItemDetailsPanel.Size = new System.Drawing.Size(238, 192);
			this.ItemDetailsPanel.TabIndex = 1;
			// 
			// ItemInfoLabel
			// 
			this.ItemInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ItemInfoLabel.Location = new System.Drawing.Point(5, 5);
			this.ItemInfoLabel.Margin = new System.Windows.Forms.Padding(5);
			this.ItemInfoLabel.Name = "ItemInfoLabel";
			this.ItemInfoLabel.Size = new System.Drawing.Size(228, 50);
			this.ItemInfoLabel.TabIndex = 0;
			this.ItemInfoLabel.Text = "selectedItemDescription";
			this.ItemInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// detailsPanel
			// 
			this.detailsPanel.ColumnCount = 1;
			this.detailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.detailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailsPanel.Location = new System.Drawing.Point(3, 63);
			this.detailsPanel.Name = "detailsPanel";
			this.detailsPanel.RowCount = 2;
			this.detailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.detailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.detailsPanel.Size = new System.Drawing.Size(232, 97);
			this.detailsPanel.TabIndex = 1;
			// 
			// buttonPanel
			// 
			this.buttonPanel.ColumnCount = 2;
			this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonPanel.Location = new System.Drawing.Point(0, 163);
			this.buttonPanel.Margin = new System.Windows.Forms.Padding(0);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.RowCount = 1;
			this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.buttonPanel.Size = new System.Drawing.Size(238, 29);
			this.buttonPanel.TabIndex = 2;
			// 
			// ItemInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Name = "ItemInfo";
			this.Size = new System.Drawing.Size(244, 244);
			this.mainPanel.ResumeLayout(false);
			this.ItemTitlePanel.ResumeLayout(false);
			this.ItemTitlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
			this.ItemDetailsPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainPanel;
		private System.Windows.Forms.TableLayoutPanel ItemTitlePanel;
		private System.Windows.Forms.PictureBox ItemPicture;
		private System.Windows.Forms.Label ItemName;
		private System.Windows.Forms.TableLayoutPanel ItemDetailsPanel;
		private System.Windows.Forms.Label ItemInfoLabel;
		private System.Windows.Forms.TableLayoutPanel detailsPanel;
		private System.Windows.Forms.TableLayoutPanel buttonPanel;
	}
}
