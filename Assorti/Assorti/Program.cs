using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Assorti
{
	public class Category
	{
		public string name { get; set; }
	}

	// класс ингридиента
	public class Ingredient
	{
		public string name { get; set; }
		public int price { get; set; }
	}
	// класс блюда
	public class Dish
	{
		public string name { get; set; }
		public string description { get; set; }
		public int price { get; set; }
		public Category category { get; set; }
		public List<Ingredient> Ingredients { get; set; } 
	}

	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}

	public class MongoCRUD
	{
		private IMongoDatabase db;

		public MongoCRUD(string database)
		{
			var client = new MongoClient();
			db = client.GetDatabase(database);
		}

		public void InsertRecord<T>(string table, T record)
		{
			var collection = db.GetCollection<T>(table);
			collection.InsertOne(record);
		}
	}
}
