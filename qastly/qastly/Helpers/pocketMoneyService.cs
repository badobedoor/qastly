using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using qastly.Models;
using qastly.SQLite;
using SQLite;
using Xamarin.Forms;

namespace qastly.Helpers
{

    class pocketMoneyService
    {

        private SQLiteConnection _sqLiteConnection;

        #region Not Use Fontion
        #region Comment
        //public async Task<int> GetTotalPocketMoneyWithdrawalLastMonth()
        //{
        //    _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
        //    // var res = _sqLiteConnection.Query<decimal>("SELECT SUM(fundsBalance)FROM funds;");
        //    var sum = _sqLiteConnection.ExecuteScalar<int>("SELECT SUM(fundsBalance) FROM funds");

        //    return sum;
        //    var x = 5;
        //}


        //public async Task<Data.funds> GetFundsbyid(int id)
        //{
        //    _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
        //    var existingFund = _sqLiteConnection.Query<Data.funds>("select * from funds where funds_id = ?", id).FirstOrDefault();
        //    if (existingFund != null)
        //    {
        //        return existingFund;
        //    }
        //    else { return null; }

        //    var x = 5;
        //}



        //public async Task<decimal> GetpocketMoney_sum(List<string> List_string)
        //{
        //    _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

        //    var lIST_pocketMoney_O = _sqLiteConnection.Query<Data.pocketMoney>("select * from pocketMoney where pocketMoney_name = ?", "no");
        //    decimal sum = 0;

        //    foreach (var item in List_string)
        //    {
        //        var lIST_pocketMoney_N = _sqLiteConnection.Query<Data.pocketMoney>("select * from pocketMoney where pocketMoney_name = ?", item);

        //        if (lIST_pocketMoney_O.Count == 0)
        //        {
        //            lIST_pocketMoney_O = lIST_pocketMoney_N;                    
        //        }
        //        else if(lIST_pocketMoney_O.Count < lIST_pocketMoney_N.Count)
        //        {
        //            lIST_pocketMoney_O = lIST_pocketMoney_N;

        //            var today = DateTime.Today;
        //            var N_today = today.AddDays(1);
        //            var month = new DateTime(today.Year, today.Month, 1);
        //            var first = month.AddMonths(-1);
        //            var last = month.AddDays(-1);
        //            var item_value = item;
        //            sum = _sqLiteConnection.ExecuteScalar<decimal>("SELECT SUM(amount) from pocketMoney where   withdrawalDate <= ? and withdrawalDate >= ? ", N_today, month);
        //            //var r = _sqLiteConnection.ExecuteScalar<decimal>("SELECT SUM(amount) from pocketMoney where withdrawalDate <= ?  ", today);
        //           // var r = _sqLiteConnection.ExecuteScalar<decimal>("SELECT SUM(amount) from pocketMoney where withdrawalDate >= ?  ", month);

        //        }
        //        //"AND "
        //    }
        //    return sum;
        //}
        #endregion


        public async Task<Data.pocketMoney> Get_specific_pocketMoney(string pocketMoney_name, string pocketMoney_Note, string Money_Condition, int amount)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingpocketMoney = _sqLiteConnection.Query<Data.pocketMoney>("select * from pocketMoney where pocketMoney_name = ? and Money_Condition =? and Note =? and amount =?", pocketMoney_name , Money_Condition, pocketMoney_Note, amount).FirstOrDefault();
            if (existingpocketMoney != null)
            {
                return existingpocketMoney;
            }
            else
            {
                var res = 0;
                return null;
            }
        }
        public async Task<int> GetFristpocketMoneyId()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            int res = _sqLiteConnection.Table<Data.pocketMoney>().First().pocketMoney_id;
            return res;
            var x = 5;
        }
        public async Task<int> GetAllpocketMoneyCount()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            int res = _sqLiteConnection.Table<Data.pocketMoney>().ToList().Count();
            return res;
            var x = 5;
        }

        #endregion
        public async Task<decimal> GetpocketMoney_sum(string pocketMoney_Conditon)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();           
            decimal sum = 0;
            var today = DateTime.Today;
            var N_today = today.AddDays(1);
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);            
            if(pocketMoney_Conditon == "pocket")
            {
                sum = _sqLiteConnection.ExecuteScalar<decimal>("SELECT SUM(amount) from pocketMoney where Money_Condition = ? and  withdrawalDate <= ? and withdrawalDate >= ? ", "pocket", N_today, month);
            }
            else if(pocketMoney_Conditon == "out")
            {
                sum = _sqLiteConnection.ExecuteScalar<decimal>("SELECT SUM(amount) from pocketMoney where   Money_Condition = ?","out");
            }
            else if (pocketMoney_Conditon == "Out_month")
            {
                sum = _sqLiteConnection.ExecuteScalar<decimal>("SELECT SUM(amount) from pocketMoney where   withdrawalDate <= ? and withdrawalDate >= ? ", N_today, month);
            }



            return sum;
        }




        public async Task<string> GetpocketMoney_most_withdrawal_name(List<string> List_string)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            var lIST_pocketMoney_O = _sqLiteConnection.Query<Data.pocketMoney>("select * from pocketMoney where pocketMoney_name = ?", "no");

            var item_value = "null";
            foreach (var item in List_string)
            {
                var lIST_pocketMoney_N = _sqLiteConnection.Query<Data.pocketMoney>("select * from pocketMoney where pocketMoney_name = ?", item);

                if (lIST_pocketMoney_O == null)
                {
                    lIST_pocketMoney_O = lIST_pocketMoney_N;                    
                }
                else if (lIST_pocketMoney_O.Count < lIST_pocketMoney_N.Count)
                {
                    lIST_pocketMoney_O = lIST_pocketMoney_N;
                     item_value = item;                    
                }

            }
            return item_value;
        }

        public async Task<List<string>> GetpocketMoneyName()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            var list_pocketMoney = _sqLiteConnection.Table<Data.pocketMoney>().ToList();

            var list_pocketMoney_name = new List<string> { };
            foreach (var item in list_pocketMoney)
            {
                if(list_pocketMoney_name.Count == 0)
                {
                    
                    list_pocketMoney_name.Add(item.pocketMoney_name);
                }
                else if(list_pocketMoney_name.Contains(item.pocketMoney_name))
                {
                    var j = 15;
                }
                else { list_pocketMoney_name.Add(item.pocketMoney_name); }                    
            }
            return list_pocketMoney_name;


        }

        public async Task<List<Data.V_pocketMoney_funds>> GetAllpocketMoney(string Money_Condition)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingpocketMoney = _sqLiteConnection.Query<Data.V_pocketMoney_funds>("select * from V_pocketMoney_funds where Money_Condition = ? ", Money_Condition);
            if (existingpocketMoney.Count != 0)
            {
                return existingpocketMoney;
            }
            else
            {
                var res = 0;
                return null;
            }
        }
    

        public async Task<int> CreatepocketMoney(Data.pocketMoney pocketMoney)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            int res = _sqLiteConnection.Insert(pocketMoney);
            var x = 0;
            return res;

        }



        public async Task<Data.pocketMoney> GetpocketMoneyDital(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            if (id == 0)
            {
                return null;
            }
            else
            {

                var res = _sqLiteConnection.Get<Data.pocketMoney>(id);

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

        public async Task<int> UpdatepocketMoney(Data.pocketMoney pocketMoney)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingpocketMoney = _sqLiteConnection.Query<Data.pocketMoney>("select * from pocketMoney where pocketMoney_id = ?", pocketMoney.pocketMoney_id).FirstOrDefault();
            if (existingpocketMoney != null)
            {
                var res = _sqLiteConnection.Update(pocketMoney);
                return res;
            }
            else
            {
                var res = 0;
                return res;

            }

        }

        public async Task<int> DleatepocketMoney(Data.pocketMoney pocketMoney)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            var res = _sqLiteConnection.Delete(pocketMoney);
            if (res != null)
            {
                return res;
            }
            else return 0;
            var x = 5;
        }

 
        public async Task<int> DleateallpocketMoney()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();            
            var res = _sqLiteConnection.DeleteAll<Data.pocketMoney>();

            var x = 5;
            return res;
        }
    }
}
