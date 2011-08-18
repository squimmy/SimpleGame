namespace SimpleGame
{
	partial class NewGame
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
			this.label1 = new System.Windows.Forms.Label();
			this.CharacterNameInput = new System.Windows.Forms.TextBox();
			this.StartGameButton = new System.Windows.Forms.Button();
			this.CancelStartGameButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.CharacterNameInput, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.StartGameButton, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.CancelStartGameButton, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 132);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
			this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(25, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(225, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please enter a name for your character:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// CharacterNameInput
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.CharacterNameInput, 2);
			this.CharacterNameInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CharacterNameInput.Location = new System.Drawing.Point(15, 49);
			this.CharacterNameInput.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.CharacterNameInput.Name = "CharacterNameInput";
			this.CharacterNameInput.Size = new System.Drawing.Size(244, 20);
			this.CharacterNameInput.TabIndex = 1;
			// 
			// StartGameButton
			// 
			this.StartGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.StartGameButton.Location = new System.Drawing.Point(31, 90);
			this.StartGameButton.Name = "StartGameButton";
			this.StartGameButton.Size = new System.Drawing.Size(75, 23);
			this.StartGameButton.TabIndex = 2;
			this.StartGameButton.Text = "Start Game!";
			this.StartGameButton.UseVisualStyleBackColor = true;
			this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
			// 
			// CancelStartGameButton
			// 
			this.CancelStartGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CancelStartGameButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelStartGameButton.Location = new System.Drawing.Point(168, 90);
			this.CancelStartGameButton.Name = "CancelStartGameButton";
			this.CancelStartGameButton.Size = new System.Drawing.Size(75, 23);
			this.CancelStartGameButton.TabIndex = 3;
			this.CancelStartGameButton.Text = "Cancel";
			this.CancelStartGameButton.UseVisualStyleBackColor = true;
			this.CancelStartGameButton.Click += new System.EventHandler(this.CancelStartGameButton_Click);
			// 
			// NewGame
			// 
			this.AcceptButton = this.StartGameButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelStartGameButton;
			this.ClientSize = new System.Drawing.Size(274, 132);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(290, 170);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(290, 170);
			this.Name = "NewGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NewGame";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CharacterNameInput;
		private System.Windows.Forms.Button StartGameButton;
		private System.Windows.Forms.Button CancelStartGameButton;
	}
}