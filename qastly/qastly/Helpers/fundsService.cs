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
    class fundsService
    {

        private SQLiteConnection _sqLiteConnection;
        public fundsService()
        {

        }


        public async Task<int> GetFristFundsId()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            int res = _sqLiteConnection.Table<Data.funds>().First().funds_id;
            return res;
            var x = 5;
        }
        public async Task<int> GetAllFundsCount()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();            
             int res =_sqLiteConnection.Table<Data.funds>().ToList().Count();
            return res;
            var x = 5;
        }

        public async Task<decimal> GetTotalfundsBalance()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
           // var res = _sqLiteConnection.Query<decimal>("SELECT SUM(fundsBalance)FROM funds;");
            var sum =  _sqLiteConnection.ExecuteScalar<decimal>("SELECT SUM(fundsBalance) FROM funds");

            return sum;
            var x = 5;
        }

        public async Task<Data.funds> GetFundsbyid(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingFund = _sqLiteConnection.Query<Data.funds>("select * from funds where funds_id = ?", id).FirstOrDefault();
            if(existingFund != null)
            {
                return existingFund;
            }
            else { return null; }
            
            var x = 5;
        }

        public async Task<Data.funds> GetFundsbyname(string name)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingFund = _sqLiteConnection.Query<Data.funds>("select * from funds where name = ?", name).FirstOrDefault();
            if (existingFund != null)
            {
                return existingFund;
            }
            else { return null; }

            var x = 5;
        }
  
        public async Task<List<Data.funds>> GetAllFunds()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            return _sqLiteConnection.Table<Data.funds>().ToList();
            var x = 5;
        }

        public async Task<Data.funds> GetfundsDital(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            if (id == 0)
            {
                return null;
            }
            else
            {

                var res = _sqLiteConnection.Get<Data.funds>(id);

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


        public async Task<Data.funds> Get_main_funds(bool O_main_funds)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existing_main_funds = _sqLiteConnection.Query<Data.funds>("select * from funds where main_funds = ? ", O_main_funds).FirstOrDefault();
            if (existing_main_funds != null)
            {
                return existing_main_funds;
            }
            else
            {
                return null;
            }
        
            
        }
        public async Task<int> CreateFunds(Data.funds funds)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            int res = _sqLiteConnection.Insert(funds);
            var x = 0;
            return res;


        }

        public async Task<int> Updatefunds(Data.funds funds)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingfunds = _sqLiteConnection.Query<Data.funds>("select * from funds where funds_id = ?", funds.funds_id).FirstOrDefault();
            if (existingfunds != null)
            {
                var res = _sqLiteConnection.Update(funds);
                return res;
            }
            else
            {
                var res = 0;
                return res;

            }


            #region ubdate Comment ------------------------ 
            //var db = new ISQLite().Connition;            
            //var res =_sqLiteConnection.Execute(
            //    "UPDATE costomar " +
            //    "SET name = " + costomar.name +
            //    ",phone1 = " + costomar.phone1 +
            //    ",phone2 = " + costomar.phone2 +
            //    ",phone3 = " + costomar.phone3 +
            //    ",IDnum = " + costomar.IDnum +
            //    ",address = " + costomar.address +
            //    ",BuildingNUM = " + costomar.BuildingNUM +
            //    ",flatNum = " + costomar.flatNum +
            //    ",Email = " + costomar.Email +
            //    ",guarantorName = " + costomar.guarantorName +
            //    ",guarantorphone = " + costomar.guarantorphone +
            //    ",ban = " + costomar.ban +
            //    ",costomarColor = " + costomar.costomarColor +
            //    ",voucherNUM = " + costomar.voucherNUM +
            //    " WHERE employeeid = ? ;" , costomar.costomar_id);

            //var res = _sqLiteConnection.Query<Data.costomar>(
            //    "UPDATE costomar " +
            //    "SET name = " + costomar.name +
            //    ",phone1 = " + costomar.phone1 +
            //    ",phone2 = " + costomar.phone2 +
            //    ",phone3 = " + costomar.phone3 +
            //    ",IDnum = " + costomar.IDnum +
            //    ",address = " + costomar.address +
            //    ",BuildingNUM = " + costomar.BuildingNUM +
            //    ",flatNum = " + costomar.flatNum +
            //    ",Email = " + costomar.Email +
            //    ",guarantorName = " + costomar.guarantorName +
            //    ",guarantorphone = " + costomar.guarantorphone +
            //    ",ban = " + costomar.ban +
            //    ",costomarColor = " + costomar.costomarColor +
            //    ",voucherNUM = " + costomar.voucherNUM +                 
            //    " WHERE employeeid = "+ costomar.costomar_id +";");

            //var existingcostomar = _sqLiteConnection.Query<Data.costomar>("select * from costomar where costomar_id = ?", costomar.costomar_id).FirstOrDefault();             
            //if (existingcostomar != null)
            //{
            //    existingcostomar.name = costomar.name;



            //    _sqLiteConnection.RunInTransaction(() =>
            //    {
            //        _sqLiteConnection.Update(existingcostomar);                    
            //    });
            //    var res = 1;
            //    return res;
            //}
            //else
            //{
            //    var res = 0;
            //    return res;
            //}
            #endregion



        }

        public async Task<int> DleateFunds(Data.funds funds)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            var res = _sqLiteConnection.Delete(funds);
            if (res != null)
            {
                return res;
            }
            else return 0;
            var x = 5;
        }
    }
}
