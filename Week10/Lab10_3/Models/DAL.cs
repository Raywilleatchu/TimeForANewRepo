using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace Lab10_3.Models
{
    public class DAL
    {
        public static MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");


        public static List<Coffee> getAllCoffee()
        {
            return db.GetAll<Coffee>().ToList();
        }

        public static Coffee getCoffee(int id)
        {
            return db.Get<Coffee>(id);
        }

        public static void delCoffee(int id)
        {
            Coffee coff = new Coffee();
            coff.ProductID = id;
            db.Delete<Coffee>(coff);
        }

        public static void addCoffee(Coffee coff)
        {
            db.Insert(coff);
        }

        public static void EditCoffee(Coffee coff)
        {
            db.Update(coff);
        }

    }
}
