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
    class moneyTransferService
    {

        private SQLiteConnection _sqLiteConnection;

        public async Task<List<Data.moneyTransfer>> GetAllmoneyTransfer()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            return _sqLiteConnection.Table<Data.moneyTransfer>().ToList();
            var x = 5;
        }

        public async Task<int> CreatemoneyTransfer(Data.moneyTransfer O_moneyTransfer)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            int res = _sqLiteConnection.Insert(O_moneyTransfer);
            var x = 0;
            return res;

        }


        public async Task<Data.moneyTransfer> GetmoneyTransferDital(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            if (id == 0)
            {
                return null;
            }
            else
            {

                var res = _sqLiteConnection.Get<Data.moneyTransfer>(id);

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



        public async Task<int> DleatemoneyTransfer(Data.moneyTransfer O_moneyTransfer)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            var res = _sqLiteConnection.Delete(O_moneyTransfer);
            if (res != null)
            {
                return res;
            }
            else return 0;
            var x = 5;
        }



    }
}
