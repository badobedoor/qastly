using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using SQLite;
using qastly.Droid.SQLite;
using qastly.SQLite;
using Android.Widget;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Google.Apis;

[assembly: Dependency(typeof(SQLite_Android))]
namespace qastly.Droid.SQLite
{
    class SQLite_Android : ISQLite
    {

        async Task<SQLiteConnection> ISQLite.GetConnection()
        {

            string databaseName = "qastlly101.db3";
            var docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var dbFile = Path.Combine(docFolder, databaseName); // FILE NAME TO USE WHEN COPIED
            if (!File.Exists(dbFile))
            {
                FileStream writeStream = new FileStream(dbFile, FileMode.OpenOrCreate, FileAccess.Write);
                await Forms.Context.Assets.Open(databaseName).CopyToAsync(writeStream);
             
            }

            var path = dbFile;
            // Create the connection
            var conn = new SQLiteConnection(path);
            // Return the database connection
            return conn;


        }
    }
}