using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using qastly.Droid.SQLite;
using SQLite;

namespace qastly.SQLite
{

    public interface ISQLite
    {
        Task<SQLiteConnection> GetConnection();
    }
    //public interface ISQLite
    //{
    //    Task<SQLiteConnection> GetConnection();
    //    //public SQLiteConnection Connition { get; set; }
    //    //public ISQLite()
    //    //{
    //    //    Initialize();
    //    //}
    //    //void Initialize()
    //    //{
    //    //    Connition = new SQLiteConnection(SQLiteCoon.database , SQLiteOpenFlags.ReadWrite );
    //    //}

    //}

}
