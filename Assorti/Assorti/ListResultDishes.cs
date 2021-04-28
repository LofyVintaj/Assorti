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

		private void voidLabelMouseClick(object sender, System.EventArgs e)
		{
			var label = (Label)sender;
			label.BackColor = Color.Gray;
			label.ForeColor = Color.White;
			DetailDescriptionDish frm = new DetailDescriptionDish();
			string connectionString = "AssortiBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			Dish dish = db.SearchDishAtName<Dish>("Dish", label.Text);
			frm.dish_detail = dish;
			frm.Show();
		}
		//При двойном клике у нас переходит к самому тесту
		private void LabelMouseDoubleClick(object sender, System.EventArgs e)
		{
			var label = (Label)sender;
			label.BackColor = Color.White;
			label.ForeColor = Color.Black;
		}
			private void ListResultDishes_Load(object sender, EventArgs e)
		{
			foreach ( var i in result_list_dish )
			{
				Label lbl = new Label();
				lbl.Width = 500;
				lbl.Height = 50;
				lbl.MouseClick += voidLabelMouseClick;
				lbl.MouseDoubleClick += LabelMouseDoubleClick;
				lbl.Text = i.title;
				flowLayoutPanel1.Controls.Add(lbl);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
