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

	public partial class ListResultDishes : Form
	{
		public ListResultDishes()
		{
			InitializeComponent();
		}
		public List<Dish> result_list_dish = new List<Dish>();
		private void ListResultDishes_Load(object sender, EventArgs e)
		{
			foreach ( var i in result_list_dish )
			{
				Label lbl = new Label();
				lbl.Width = 500;
				lbl.Height = 50;
				lbl.Text = (" DISH: " + i.title);
				flowLayoutPanel1.Controls.Add(lbl);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
