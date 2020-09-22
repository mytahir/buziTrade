using buziTrade.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace buziTrade.Data
{
    public class buzyTrade_Database
    {
        readonly SQLiteConnection _database;

        public buzyTrade_Database()
        {

        }

        public buzyTrade_Database(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Users>();
        }

        public string SaveUserAsync(Users user)
        {
            var data = _database.Table<Users>();
            var d1 = data.Where(x => x.BusinessName == user.BusinessName).FirstOrDefault();
            //if (d1 == null)
            //{

                 _database.Insert(user);
                return "Added Successfully!";
            //}
            //else
            //{
            //    return "Business Name Exists!";
            //}
        }

        public bool LoginUser(string emailorPhone, string password)
        {
            var data = _database.Table<Users>();

            var data1 = data.Where(x => (x.PhoneNumber == emailorPhone || x.BusinessEmail == emailorPhone)
            && x.Password == password).FirstOrDefault();
            if (data1 != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
