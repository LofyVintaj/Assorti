
namespace Assorti
{
	partial class ListResultDishes
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
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Cornsilk;
			this.label2.Location = new System.Drawing.Point(570, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 41);
			this.label2.TabIndex = 4;
			this.label2.Text = "Assorty";
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.FloralWhite;
			this.button2.Location = new System.Drawing.Point(1248, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 47);
			this.button2.TabIndex = 0;
			this.button2.Text = "Х";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1347, 50);
			this.panel1.TabIndex = 2;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 138);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1249, 616);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 45);
			this.label1.TabIndex = 4;
			this.label1.Text = "Result";
			// 
			// ListResultDishes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 817);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Calibri", 14.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "ListResultDishes";
			this.Text = "ListResultDishes";
			this.Load += new System.EventHandler(this.ListResultDishes_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
	}
}