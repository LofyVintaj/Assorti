using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assorti
{
	public partial class DetailDescriptionDish : Form
	{
		public Dish dish_detail = new Dish();
		public DetailDescriptionDish()
		{
			InitializeComponent();
		}

		private void DetailDescriptionDish_Load(object sender, EventArgs e)
		{
			label1.Text = "Title:  " + dish_detail.title;
			label3.Text = "Servings:  " + dish_detail.servings;
			label4.Text = "Ready In Minutes:  " + dish_detail.readyInMinutes;
			
			foreach ( var i in dish_detail.ingredient)
			{
				Label lbl_n = new Label();
				lbl_n.Text = ($"Name - {i.name} \n Amount - {i.amount} \n Unit - {i.unit}");
				lbl_n.Width = 800;
				lbl_n.Height = 100;
				Console.WriteLine($"Name - {i.name} \n Amount - {i.amount} \n Unit - {i.unit}");
				flowLayoutPanel1.Controls.Add(lbl_n);
			}

			richTextBox1.Text = dish_detail.instructions;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			panel1.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}
	}
}
