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
	public partial class CalculatePlat : Form
	{
		public CalculatePlat()
		{
			InitializeComponent();
		}

		List<Ingredient> user_declarated_list_ingredient = new List<Ingredient>();

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			panel1.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Label new_label = new Label();
			new_label.Height = 20;
			new_label.Text = textBox1.Text;
			tableLayoutPanel1.Controls.Add(new_label);
			Ingredient user_declarated_ingedient = new Ingredient();
			user_declarated_ingedient.name = textBox1.Text;
			user_declarated_list_ingredient.Add(user_declarated_ingedient);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectionString = "AssortiBook";
			MongoCRUD db = new MongoCRUD(connectionString);
		}
	}
}
