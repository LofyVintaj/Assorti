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
		}

	}
}
