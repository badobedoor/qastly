using qastly.Models;
using qastly.SQLite;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace qastly.Helpers
{
    class CapitalAdditionService
    {

        private SQLiteConnection _sqLiteConnection;           

        public async Task<List<Data.CapitalAddition>> GetAllCapitalAddition()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();            
            return _sqLiteConnection.Table<Data.CapitalAddition>().ToList();
            var x = 5;
        }

        public async Task<int> CreateCapitalAddition(Data.CapitalAddition O_CapitalAddition)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            int res = _sqLiteConnection.Insert(O_CapitalAddition);
            var x = 0;
            return res;

        }


        public async Task<Data.CapitalAddition> GetCapitalAdditionDital(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            if (id == 0)
            {
                return null;
            }
            else
            {

                var res = _sqLiteConnection.Get<Data.CapitalAddition>(id);

                if (res == null)
                {
                    return null;
                }
                else
                {
                    return res;
                }
            }
        }

        

        public async Task<int> DleateCapitalAddition(Data.CapitalAddition O_CapitalAddition)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            var res = _sqLiteConnection.Delete(O_CapitalAddition);
            if (res != null)
            {
                return res;
            }
            else return 0;
            var x = 5;
        }


        
    }
}
