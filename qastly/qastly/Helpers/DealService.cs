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
    class DealService
    {
        private SQLiteConnection _sqLiteConnection;

        #region Deal
        public async Task<int> CreateDeal(Data.deal deals)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            var res = _sqLiteConnection.Insert(deals);
            if(res != 1)
            {
                return 0;
            }
            else
            {
                return res;
            }
            
            
        }

        public async Task<int> GetLastDealId()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var res = _sqLiteConnection.Table<Data.deal>().Last();
            if(res != null)
            {
                var res_id = res.deal_id;
                return res_id;
            }
            else
            {
                return -1;
            }
            
            var x = 5;
        }

        public async Task<Data.deal> GetdealDital(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            if (id == -1)
            {
                return null;
            }
            else
            {

                var res = _sqLiteConnection.Get<Data.deal>(id);

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
        public async Task<List<Data.V_costomar_deal_installment>> GetAll_costomar_deal_installment_payed()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var res =_sqLiteConnection.Query<Data.V_costomar_deal_installment>(" SELECT* FROM V_costomar_deal_installment where installment_condition = false ORDER BY InstallmentDueDate");
           
            // var res = _sqLiteConnection.Table<Data.V_costomar_deal_installment>().ToList();
            if(res != null)
            {
                return  res;
            }
            else
            {
                return  null;
            }

        }

        public async Task<List<Data.V_costomar_deal_installment>> GetAll_costomar_deal_installment_Archives()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var res = _sqLiteConnection.Query<Data.V_costomar_deal_installment>(" SELECT* FROM V_costomar_deal_installment where Deal_condition = true ORDER BY Start_Date DESC");

            // var res = _sqLiteConnection.Table<Data.V_costomar_deal_installment>().ToList();
            if (res != null)
            {
                return res;
            }
            else
            {
                return null;
            }

        }
        public async Task<Data.V_costomar_deal_installment> Get_Dital_costomar_deal_installment(int deal_id , int installment_id, int costomar_id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            var existing_installment = _sqLiteConnection.Query<Data.V_costomar_deal_installment>("select * from V_costomar_deal_installment where deal_id = ? and installment_id = ? and costomar_id = ?", deal_id, installment_id, costomar_id).FirstOrDefault();
            if (existing_installment != null)
            {
                return existing_installment;
            }
            else
            {
                return null;
            }



        }

        public async Task<int> Update_Deal(Data.deal o_deal)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingDeal = _sqLiteConnection.Query<Data.deal>("select * from deal where deal_id = ?", o_deal.deal_id).FirstOrDefault();
            if (existingDeal != null)
            {
                var res = _sqLiteConnection.Update(o_deal);
                return res;
            }
            else
            {
                var res = 0;
                return res;

            }

        }

        #endregion
        #region installment
        public async Task<int> Create_installment(Data.installment Installment)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            int res = _sqLiteConnection.Insert(Installment);
            var x = 0;
            return res;
        }


        public async Task<Data.installment> Get_installment_by_id(int Deal_id, int installment_id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existing_installment = _sqLiteConnection.Query<Data.installment>("select * from installment where deal_id = ? and installment_id = ? ", Deal_id, installment_id).FirstOrDefault();
            if (existing_installment != null)
            {
                return existing_installment;
            }
            else
            {
                return null;
            }
        }
        public async Task<List<Data.installment>> Get_installments_by_Deal_id(int Deal_id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existing_installment = _sqLiteConnection.Query<Data.installment>("select * from installment  where installment_condition = ? and deal_id = ?  ", true, Deal_id);
            if (existing_installment != null )
            {
                if(existing_installment.Count != 0)
                {
                    return existing_installment;
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public async Task<Data.installment> Get_Unpayed_installment_by_Deal_id(int Deal_id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existing_installment = _sqLiteConnection.Query<Data.installment>("select * from installment  where installment_condition = ? and deal_id = ?  ", false, Deal_id).FirstOrDefault();
            if (existing_installment != null)
            {

                    return existing_installment;


            }
            else
            {
                return null;
            }
        }
        public async Task<int> Get_last_id_installment(int Deal_id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existing_installment_id = _sqLiteConnection.Query<Data.installment>("select * from installment where deal_id = ? ", Deal_id).LastOrDefault();
            if(existing_installment_id != null)
            {
                return existing_installment_id.installment_id;
            }
            else
            {
                return 1;
            }
        }

        public async Task<int> UpdateAll_list_Down_visible_installment()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            try
            
            {
               _sqLiteConnection.Query<Data.installment>("UPDATE installment SET list_Down_visible = false");
                return 1;

            }
            catch (Exception e)
            {
                return 0;
            }
                

        }

        public async Task<int> Update_installment(Data.installment Installment)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            
            
            try
            {
                //var res = _sqLiteConnection.Update(existing_installment);
                
                var res = _sqLiteConnection.Query<Data.installment>
                    (" UPDATE installment SET list_Down_visible = ? , InstallmentDueDate = ? ,  InstallmentPaymentDate = ? , Collectedvalue = ? , installmedntColor = ? , installment_condition = ? , Worthy_amount = ? , delay_Days = ? , Remaining_amount = ? WHERE deal_id = ? and installment_id = ? ",
                                  Installment.list_Down_visible, Installment.InstallmentDueDate, Installment.InstallmentPaymentDate, Installment.Collectedvalue, Installment.installmedntColor, Installment.installment_condition, Installment.Worthy_amount, Installment.delay_Days, Installment.Remaining_amount, Installment.deal_id, Installment.installment_id).FirstOrDefault();
                //var existing_installment = _sqLiteConnection.Query<Data.installment>("UPDATE installment SET list_Down_visible = ?  where deal_id = ? and installment_id = ? ", Installment.list_Down_visible, Installment.deal_id, Installment.installment_id).FirstOrDefault();
                return 1;
            }                                
            catch(Exception e)
            {                
                return 0;
            }

        }
        #endregion

        public async Task<int> Dleate_All_installment_and_Deal()
        {
            try
            {
                _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
                _sqLiteConnection.DeleteAll<Data.installment>();
                _sqLiteConnection.DeleteAll<Data.deal>();

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }

        }


    }
}
