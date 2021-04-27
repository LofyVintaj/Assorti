using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Assorti
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			panel1.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CalculatePlat frm = new CalculatePlat();
			frm.Show();
			this.Hide();
		}



		private void button3_Click(object sender, EventArgs e)
		{
			System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"https://api.spoonacular.com/recipes/random?number=1&apiKey=87baa01dfec640b29f2ecb5576218aae");
			System.Net.WebResponse resp = reqGET.GetResponse();
			System.IO.Stream stream = resp.GetResponseStream();
			System.IO.StreamReader sr = new System.IO.StreamReader(stream);
			string s = sr.ReadToEnd();


			dynamic dynJson = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(s);

			Console.WriteLine(" ================= ");

			List<Dish> list_dish = new List<Dish>(); 

			foreach (var i in dynJson.recipes)
			{
				Dish dish = new Dish
				{
					title = i.title,
					readyInMinutes = 4,
				};

				list_dish.Add(dish);
			}

			Console.WriteLine(" ================= ");


		}
	}
}
