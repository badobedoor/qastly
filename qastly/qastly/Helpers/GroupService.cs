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
    class GroupService
    {
        private SQLiteConnection _sqLiteConnection;
        public List<Data.V_Group_month_Lisst> Group_month_List { get; set; }
        public List<int> Group_month_List_piker { get; set; }
        public GroupService()
        {

        }

        public async Task<int> Creategroup(Data.Lisst group)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            
            if(group != null)
            {
                var res = _sqLiteConnection.Insert(group);
                if(res != 0) { return res; } else { return 0; }
                var x = 5;
            }
            else { return 0; }
            

            
        }
        public async Task<int> Creategroup_month(Data.Group_month group_month)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            if (group_month != null)
            {
                var res = _sqLiteConnection.Insert(group_month);
                if (res != 0) { return res; } else { return 0; }
                var x = 5;
            }
            else { return 0; }

        }

        public async Task<Data.Lisst> getGroup_id(string name , double maximumAmount , decimal MonthlyProfitRate)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            var existingGroup = _sqLiteConnection.Query<Data.Lisst>("select * from Lisst where name = ? and maximumAmount = ? and MonthlyProfitRate = ?", name, maximumAmount, MonthlyProfitRate).FirstOrDefault();
            
                
                
            if (existingGroup != null)
            {
                
                return existingGroup;
            }
            else
            {
                var res = 0;
                return null;

            }

        }
        public async Task<Data.V_Group_month_Lisst> getGroup_by_Id(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();

            var existingGroup = _sqLiteConnection.Query<Data.V_Group_month_Lisst>("select * from V_Group_month_Lisst where group_id = ? ", id).FirstOrDefault();

            if (existingGroup != null)
            {
                return existingGroup;
            }
            else return null;

        }

        public async Task<List<int>> getGroup_Month_Num_Picker(int id)
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
            
            var existingGroup = _sqLiteConnection.Query<Data.V_Group_month_Lisst>("select * from V_Group_month_Lisst where group_id = ? ", id);           

            if (existingGroup != null)
            {
                foreach (var o_item in existingGroup)
                {
                    
                    if(Group_month_List_piker == null)
                    {
                        Group_month_List_piker = new List<int> { o_item.Month_num.Value };
                    }
                    else { Group_month_List_piker.Add(o_item.Month_num.Value); }
                        
                }
                    
                return Group_month_List_piker;
            }
            else
            {
                var res = 0;
                return null;

            }

        }

        

        public async Task<List<Data.V_Group_month_Lisst>> GetAllgroup()
        {
            _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
        
            var List_Res = _sqLiteConnection.Table<Data.V_Group_month_Lisst>().ToList();
            var id = 0;
            foreach (var o_item in List_Res )
            {
                if( o_item.group_id != id)
                {
                    id = o_item.group_id;

                    if (Group_month_List != null)
                    {
                        Group_month_List.Add(o_item);

                        //var existingGroup = _sqLiteConnection.Query<Data.V_Group_month_Lisst>("select * from V_Group_month_Lisst where group_id = ? ", o_item.group_id).FirstOrDefault();
                        //var o = Group_month_List.FirstOrDefault(x => x.group_id == o_item.group_id);
                        //if (o == null)
                        //{
                            
                        //}
                        //else
                        //{
                        //    var x = 5;
                        //}

                    }
                    else
                    {
                        Group_month_List = new List<Data.V_Group_month_Lisst> { o_item };
                    }

                }
                else
                {
                    var c = 2;
                }



            }
            return Group_month_List;


        }
    }
}
