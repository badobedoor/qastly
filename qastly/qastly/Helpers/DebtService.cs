using qastly.Models;
using qastly.SQLite;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace qastly.Helpers
{
    class DebtService
    {

        private SQLiteConnection _sqLiteConnection;

        public async Task<List<Data.debt>> GetAlldebt()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            return _sqLiteConnection.Table<Data.debt>().ToList();
            var x = 5;
        }

        public async Task<List<Data.debt>> GetAlldebt_By_DebtCondition(string O_DebtCondition)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingdebt = _sqLiteConnection.Query<Data.debt>("select * from debt where  DebtCondition =?", O_DebtCondition);
            if(existingdebt.Count != 0)
            {
                return existingdebt;
            }
            else
            {
                return null;
                var x = 5;
            }
            
            
        }
        public async Task<int> Createdebt(Data.debt O_debt)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;            
            int res = _sqLiteConnection.Insert(O_debt);
            var x = 0;
            return res;

        }

        public async Task<Data.debt> GetdebtDital(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            if (id == 0)
            {
                return null;
            }
            else
            {

                var res = _sqLiteConnection.Get<Data.debt>(id);

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

        

        public async Task<int> Updatedebt(Data.debt O_debt)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingdebt = _sqLiteConnection.Query<Data.debt>("select * from debt where debt_id = ? and DebtCondition =?", O_debt.debt_id, O_debt.DebtCondition).FirstOrDefault();
            if (existingdebt != null)
            {
                var res = _sqLiteConnection.Update(O_debt);
                return res;
            }
            else
            {
                var res = 0;
                return res;

            }        
        }

        public async Task<int> Dleatedebt(Data.debt O_debt)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            var res = _sqLiteConnection.Delete(O_debt);
            if (res != null)
            {
                return res;
            }
            else return 0;
            var x = 5;
        }



        public async Task<Data.debt> GetDebtBydebtorName(string DebtCondition, string debtorName)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingdebt = _sqLiteConnection.Query<Data.debt>("select * from debt where DebtCondition = ? and debtorName =?", DebtCondition, debtorName).FirstOrDefault();
            if (existingdebt != null)
            {
                return existingdebt;
            }
            else
            {
                var res = 0;
                return null;
            }

        }
        public async Task<List<Data.debt>> GetListDebtBydebtorName(string DebtCondition, string debtorName)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingdebt = _sqLiteConnection.Query<Data.debt>("select * from debt where DebtCondition = ? and debtorName =?", DebtCondition, debtorName);
            if (existingdebt.Count != 0 )
            {
                return existingdebt;
            }
            else
            {
                var res = 0;
                return null;
            }

        }

        public async Task<int> GetTotalamount(string DebtCondition) 
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();            
            var sum = _sqLiteConnection.ExecuteScalar<int>("SELECT SUM(amount) FROM debt where DebtCondition = ?", DebtCondition);

            return sum;
            var x = 5;
        }

    }
}
