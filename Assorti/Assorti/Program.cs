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
	// Категории блюд
	public class Category
	{
		public string name { get; set; }
	}

	// Класс ингридиента
	public class Ingredient
	{
		public ObjectId Id { get; set; }
		public string name { get; set; }
		public int amount { get; set; }
		public string unit { get; set; }
	}

	// Шаги
	public class Step
	{
		public string name { get; set; }
	}

	// Подробные инструкции
	public class analyzedInstructions
	{
		public ObjectId Id { get; set; }
		public string name { get; set; }
		public List<Step> step { get; set; }
	}

	// класс блюда
	public class Dish
	{
		public ObjectId Id { get; set; }
		public string title { get; set; }

		public int readyInMinutes { get; set; }

		public int servings	 { get; set; }

		public string instructions { get; set; }

		public List<Ingredient> ingredient { get; set; }
		//public Category category { get; set; }
	}

	public class Recipes
	{
		public List<Dish> resipes { get; set; }
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
