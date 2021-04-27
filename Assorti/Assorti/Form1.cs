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
			System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"https://api.spoonacular.com/recipes/random?number=100&apiKey=87baa01dfec640b29f2ecb5576218aae");
			System.Net.WebResponse resp = reqGET.GetResponse();
			System.IO.Stream stream = resp.GetResponseStream();
			System.IO.StreamReader sr = new System.IO.StreamReader(stream);
			string s = sr.ReadToEnd();


			dynamic dynJson = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(s);

			Console.WriteLine(dynJson.recipes[0]);

			// --------------------------------

			List<Dish> list_dish = new List<Dish>();


			// Подключаемся к монге
			string connectionString = "AssortiBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			



			foreach (var i in dynJson.recipes)
			{
				Dish dish = new Dish
				{
					title = i.title,
					readyInMinutes = i.readyInMinutes,
					servings = i.servings,
					instructions = i.instructions
				};
				List<Ingredient> list_ingridient = new List<Ingredient>();
				foreach (var j in i.extendedIngredients)
				{
					Ingredient ingridient = new Ingredient
					{
						name = j.name,
						amount = j.amount,
						unit = j.unit
					};
					list_ingridient.Add(ingridient);
				}
				dish.ingredient = list_ingridient;

				db.InsertRecord("Dish", dish);

				list_dish.Add(dish);

			}
			Recipes recipes = new Recipes();
			recipes.resipes = list_dish;

			db.InsertRecord("Recipes", recipes);

			// --------------------------------

			Console.WriteLine(" ================= ");


			foreach (var i in list_dish)
			{
				Console.WriteLine(i.title);
			}

			Console.WriteLine(" ================= ");

	


		}
	}
}
