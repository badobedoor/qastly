using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Models;
using qastly.SQLite;
using SQLite;
using Xamarin.Forms;

namespace qastly.Helpers
{
    class CostomerService
    {
        private SQLiteConnection _sqLiteConnection;
        public CostomerService()
        {

        }
        public List<string> Costomer_Photo_List_CarouselPage { get; set; }

        public async Task<Data.costomar> CreateCostomer( Data.costomar costomar)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            int res = _sqLiteConnection.Insert(costomar);
            if(res > 0)
            {
                var costomar_res = await getcostomar_id(costomar); 
                if(costomar_res != null)
                {
                    return costomar_res;
                }
                else { return null; }



            }
            else { return null; }
            
            var x = 0;
            
            
            
        }

        public async Task<int> Create_photo_Costomer(Data.photo photo)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();            
            int res = _sqLiteConnection.Insert(photo);
            if (res > 0)
            {
                return res;
            }
            else { return 0; }

            var x = 0;



        }

        public async Task<Data.costomar> getcostomar_id(Data.costomar costomar)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingcostomar = _sqLiteConnection.Query<Data.costomar>("select * from costomar where name = ? and phone1 = ? and IDnum = ? and address = ?", costomar.name, costomar.phone1, costomar.IDnum, costomar.address).FirstOrDefault();



            if (existingcostomar != null)
            {

                return existingcostomar;
            }
            else
            {
                var res = 0;
                return null;

            }

        }
        public async Task<List<Data.costomar>>  GetAllCostomer( )
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
            return _sqLiteConnection.Table<Data.costomar>().ToList();                         
            var x = 5;
        }


        public async Task<List<string>> getCostomer_photo_list(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            var existingcostomar = _sqLiteConnection.Query<Data.V_photo_costomar>("select * from V_photo_costomar where costomar_id = ? ", id);

            if (existingcostomar != null && existingcostomar.Count != 0)
            {
                foreach (var o_item in existingcostomar)
                {

                    if (Costomer_Photo_List_CarouselPage == null)
                    {
                        Costomer_Photo_List_CarouselPage = new List<string> { o_item.path };
                    }
                    else { Costomer_Photo_List_CarouselPage.Add(o_item.path); }

                }

                return Costomer_Photo_List_CarouselPage;
            }
            else
            {
                var res = 0;
                return null;

            }

        }

        public async Task<Data.costomar> GetCostomerDital(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            if(id == 0)
            {
                return null;
            }
            else
            {
                
                var res = _sqLiteConnection.Get<Data.costomar>(id);
                
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

        public async Task<int> UpdateCostomer(Data.costomar costomar)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingcostomar = _sqLiteConnection.Query<Data.costomar>("select * from costomar where costomar_id = ?", costomar.costomar_id).FirstOrDefault();
            if (existingcostomar != null)
            {
                var res = _sqLiteConnection.Update(costomar);
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



        public async Task<int> Dleate_Costomer_photo(int id , string path)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            var ExistingcostomarPhoto = _sqLiteConnection.Query<Data.V_photo_costomar>("select * from photo where costomar_id = ? and path = ?", id , path).FirstOrDefault();
            var DleatePhoto = _sqLiteConnection.Query<Data.photo>("Delete photo  where costomar_id = ? and photo_id = ?", id).FirstOrDefault();
            var existingcostomarPhoto = _sqLiteConnection.Query<Data.photo>("select * from photo where costomar_id = ? ", id ).FirstOrDefault();
            if(existingcostomarPhoto != null) { var res = _sqLiteConnection.Delete(existingcostomarPhoto); return res; }
            else { return 0; }
            
        }

        public async Task<int> Dleate_Costomer_photo_list(int id )
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            var existingcostomarPhoto = _sqLiteConnection.Query<Data.V_photo_costomar>("select * from photo where costomar_id = ? and ", id);
            if (existingcostomarPhoto != null) {
                int res = 1;
                foreach (var o_item in existingcostomarPhoto)
                {
                     res = _sqLiteConnection.Delete(o_item);
                }
                return res; }
            else { return 0; }

        }

        public async Task DleateallCostomer()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            //var db = new ISQLite().Connition;
           var res = _sqLiteConnection.DeleteAll<Data.costomar>();

            var x = 5;
        }

        //public async Task dleatCostomer(Data.costomar costomar)
        //{
        //    _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
        //    //var db = new ISQLite().Connition;
        //    var res = _sqLiteConnection.Update(costomar);

        //    var x = 5;
        //}
    }
}
