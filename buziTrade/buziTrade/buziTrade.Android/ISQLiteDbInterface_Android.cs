using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SQLite.Net;
using buziTrade.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetSQLiteConnnection))]

namespace buziTrade.Droid
{
    public class GetSQLiteConnnection : ISQLiteInterface
    {
        public GetSQLiteConnnection()
        {
        }
        public SQLite.Net.SQLiteConnection GetSQLiteConnection()
        {
            var fileName = "UserDatabase.db3";
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, fileName);
            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}