using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;


namespace CoffeeAPI.Models
{
	public class DAL
	{
		public static MySqlConnection DB;
		public static List<Category> GetAllCategories()
		{
			return DB.GetAll<Category>().ToList();
		}

		public static Category GetCategory(string id)
		{
			return DB.Get<Category>(id);
		}

		public static CategoryProducts GetAllForCategory(string theCatId)
		{
			var keyvalues = new { catId = theCatId };
			string sql = "select * from product where categoryId = @catId";  // Code in another language, stored in a string!
			CategoryProducts cp = new CategoryProducts();
			cp.prods = DB.Query<Product>(sql, keyvalues).ToList();
			cp.cat = DAL.GetCategory(theCatId);
			return cp;
		}

		public static void InsertCategory(Category cat)
		{
			DB.Insert(cat);
		}

		public static void UpdateCategory(Category cat)
		{
			Category testcat = DAL.GetCategory(cat.id);
			DB.Update(cat);
		}
		public static void DeleteCategory(string id)
		{
			Category cat = new Category() { id = id };
			DB.Delete(cat);
		}
	}
}