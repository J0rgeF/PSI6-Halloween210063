
namespace PSI6_Halloween210063
{
	partial class Form1
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
            this.tbxDoor = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBadNeighbors = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.cbxDoor = new System.Windows.Forms.CheckBox();
            this.lbxDoorSweets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxDoor
            // 
            this.tbxDoor.Location = new System.Drawing.Point(12, 43);
            this.tbxDoor.Name = "tbxDoor";
            this.tbxDoor.Size = new System.Drawing.Size(100, 20);
            this.tbxDoor.TabIndex = 0;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(118, 43);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbxQuantity.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(299, 43);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBadNeighbors
            // 
            this.btnBadNeighbors.Location = new System.Drawing.Point(299, 72);
            this.btnBadNeighbors.Name = "btnBadNeighbors";
            this.btnBadNeighbors.Size = new System.Drawing.Size(96, 23);
            this.btnBadNeighbors.TabIndex = 3;
            this.btnBadNeighbors.Text = "Bad Neighbors";
            this.btnBadNeighbors.UseVisualStyleBackColor = true;
            this.btnBadNeighbors.Click += new System.EventHandler(this.btnBadNeighbors_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(299, 101);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(96, 23);
            this.btnAverage.TabIndex = 4;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // cbxDoor
            // 
            this.cbxDoor.AutoSize = true;
            this.cbxDoor.Location = new System.Drawing.Point(13, 77);
            this.cbxDoor.Name = "cbxDoor";
            this.cbxDoor.Size = new System.Drawing.Size(106, 17);
            this.cbxDoor.TabIndex = 5;
            this.cbxDoor.Text = "Opened the door";
            this.cbxDoor.UseVisualStyleBackColor = true;
            // 
            // lbxDoorSweets
            // 
            this.lbxDoorSweets.FormattingEnabled = true;
            this.lbxDoorSweets.Location = new System.Drawing.Point(13, 172);
            this.lbxDoorSweets.Name = "lbxDoorSweets";
            this.lbxDoorSweets.Size = new System.Drawing.Size(387, 290);
            this.lbxDoorSweets.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Door";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quant.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxDoorSweets);
            this.Controls.Add(this.cbxDoor);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnBadNeighbors);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxDoor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Halloween";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbxDoor;
		private System.Windows.Forms.TextBox tbxQuantity;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnBadNeighbors;
		private System.Windows.Forms.Button btnAverage;
		private System.Windows.Forms.CheckBox cbxDoor;
		private System.Windows.Forms.ListBox lbxDoorSweets;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

