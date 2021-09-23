using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace Lab10_3Demo.Models
{
    public class DAL
    {
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=BigCoffee;Uid=root;Password=abc123");

        // Category

        public static List<Category> GetAllCategories()
        {
            return DB.GetAll<Category>().ToList();
        }

        public static Category GetCategory(string id)
        {
            return DB.Get<Category>(id);
        }

        public static void CreateCategory(Category cat)
        {
            DB.Insert(cat);
        }

        public static void UpdateCategory(Category cat)
        {
            DB.Update(cat);
        }


        public static void DeleteCategory(string id)
        {
            Category cat = new Category() { id = id };
            DB.Delete(cat);
        }

        // Product

        public static void AddProductAndCategory(Product prod, Category cat)
        {
            DB.Insert(cat);
            DB.Insert(prod);
        }

        public static CategoryProducts GetAllForCategory(string thecatId)
        {
            var keyvalues = new { catId = thecatId };
            string sql = "select * from product where categoryId = @catId";

            CategoryProducts cp = new CategoryProducts();
            cp.prods = DB.Query<Product>(sql, keyvalues).ToList();
            cp.cat = DAL.GetCategory(thecatId);
            return cp;
        }


        public static Product GetProduct(int prodId)
        {
            return DB.Get<Product>(prodId);
        }

        public static void CreateProduct(Product prod)
        {
            DB.Insert(prod);
        }

        public static void UpdateProduct(Product prod)
        {
            DB.Update(prod);
        }

        public static void DeleteProduct(int id)
        {
            Product prod = new Product() { id = id };
            DB.Delete(prod);
        }

        public static List<Product> SearchProduct(string str)
        {
            // Build a SQL string like this:
            //    select * from product where description like '%En%' or name like '%En%';
            var keyvaluepair = new { search = $"%{str}%" };
            string sql = "select * from product where description like @search or name like @search";
            return DB.Query<Product>(sql, keyvaluepair).ToList();
        }
    }
}
