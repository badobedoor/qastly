
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using qastly.Models;
using Xamarin.Forms;
using qastly.SQLite;
using System.Linq;

namespace qastly.Helpers
{
    class smallEarningsService
    {
        private SQLiteConnection _sqLiteConnection;

        public async Task<int> Create_smallEarnings(Data.smallEarnings O_smallEarnings)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            var res = _sqLiteConnection.Insert(O_smallEarnings);
            if (res != 1)
            {
                return 0;
            }
            else
            {
                return res;
            }


        }

        public async Task<int> Update_smallEarnings(Data.smallEarnings O_smallEarnings)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existing_smallEarnings = _sqLiteConnection.Query<Data.costomar>("select * from smallEarnings where smallEarnings_Id = ?", O_smallEarnings.smallEarnings_Id).FirstOrDefault();
            if (existing_smallEarnings != null)
            {
                var res = _sqLiteConnection.Update(O_smallEarnings);
                return res;
            }
            else
            {
                var res = 0;
                return res;

            }


          
          


        }

        public async Task<Data.smallEarnings> Get_smallEarnings(int Deal_id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existing_smallEarnings = _sqLiteConnection.Query<Data.smallEarnings>("select * from smallEarnings where deal_id = ? ", Deal_id).FirstOrDefault();
            if (existing_smallEarnings != null)
            {
                return existing_smallEarnings;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Data.smallEarnings>> Get_All_smallEarnings()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existing_smallEarnings = _sqLiteConnection.Query<Data.smallEarnings>("select * from smallEarnings ");
            if (existing_smallEarnings != null)
            {
                return existing_smallEarnings;
            }
            else
            {
                return null;
            }
        }

    }
}
