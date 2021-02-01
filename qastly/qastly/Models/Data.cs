using System;
using System.Collections.Generic;
using System.Text;
using PropertyChanged;
using SQLite;


namespace qastly.Models
{
    [AddINotifyPropertyChangedInterfaceAttribute]
    public class Data
    {
        public class costomar
        {
            [PrimaryKey, AutoIncrement, Unique]

            public int costomar_id { get; set; }
            public string name { get; set; }
            public string phone1 { get; set; }
            public string phone2 { get; set; }
            public string phone3 { get; set; }

            public string IDnum { get; set; }
            public bool ban { get; set; }
            public string address { get; set; }
            public string BuildingNUM { get; set; }
            public string flatNum { get; set; }
            public string Email { get; set; }
            public string guarantorName { get; set; }
            public string guarantorphone { get; set; }
            
            public string voucherNUM { get; set; }
            public string costomarColor { get; set; }
        }

        public class deal
        {
            [PrimaryKey, AutoIncrement]
            public int deal_id { get; set; }
            public int product_given { get; set; }
            public DateTime Start_Date { get; set; }
            public Decimal product_Price { get; set; }
            public string payment_Day { get; set; }
            public string product_Name { get; set; }
            public int costomar_id { get; set; }
            public int group_id { get; set; }
            public Nullable<int>  funds_id { get; set; }
            public string dealColor { get; set; }
            public string group_Name { get; set; }
            public int installment_amount { get; set; }
            public string selcet_month { get; set; }
            public int remainder { get; set; }
            public int Total_installment { get; set; }
            public int Pons_installment { get; set; }
            public int Total_Paid { get; set; }
            public int Total_Remaining { get; set; }
            public Nullable<int> pocketMoney_id { get; set; }
            public int remaining_installments { get; set; }
            public int paid_installments { get; set; }            
            public string Total_Saved { get; set; }
                            
            public bool Deal_condition { get; set; }

        }

        public class funds
        {
            [PrimaryKey, AutoIncrement]
            public int funds_id { get; set; }
            public string name { get; set; }            
            public decimal fundsBalance { get; set; }
            public bool main_funds { get; set; }
            
        }


        public class pocketMoney
        {
            [PrimaryKey, AutoIncrement]
            public int pocketMoney_id { get; set; }
            public int funds_id { get; set; }
            public string pocketMoney_name { get; set; }
            public int amount { get; set; }
            public DateTime withdrawalDate { get; set; }
            public string Note { get; set; }
            public string Money_Condition { get; set; }
            

        }
        public class installment
        {
            [PrimaryKey]
            public int installment_id { get; set; }
            public DateTime InstallmentDueDate { get; set; }
            public DateTime InstallmentPaymentDate { get; set; }
            public int Collectedvalue { get; set; }
            public bool list_Down_visible { get; set; }
            public string installmedntColor { get; set; }           
            public int deal_id { get; set; }
            public string delay_Days { get; set; }
            public int Remaining_amount { get; set; }
            public int Worthy_amount { get; set; }
            public bool installment_condition { get; set; }

        }
        public class smallEarnings
        {
            [PrimaryKey]
            public int smallEarnings_Id { get; set; }
            public int amount { get; set; }
            public DateTime date { get; set; }
            public string note { get; set; }
            public int deal_id { get; set; }

        }
       public class msg
        {
            [PrimaryKey, AutoIncrement]
            public int msg_id { get; set; }
            public string msd_name { get; set; }
            public string msg_content { get; set; }          

        }

        #region Views
        public class V_pocketMoney_funds
        {
            [PrimaryKey, AutoIncrement]
            public int pocketMoney_id { get; set; }
            public int funds_id { get; set; }
            public string pocketMoney_name { get; set; }
            public int amount { get; set; }
            public DateTime withdrawalDate { get; set; }
            public string Note { get; set; }
            public string name { get; set; }
            public decimal fundsBalance { get; set; }

        }
        public class V_Group_month_Lisst
        {
            [PrimaryKey, AutoIncrement]
            public int group_id { get; set; }
            public int Month_id { get; set; }
            public Nullable<int> Month_num { get; set; }
            public string name { get; set; }
            public Nullable<double> maximumAmount { get; set; }
            public Nullable<decimal> MonthlyProfitRate { get; set; }
            public Nullable<int> MonthlyNum { get; set; }



        }

        
        public class V_photo_costomar
        {            

            public int costomar_id { get; set; }
            public string name { get; set; }
            public Nullable<int> phone1 { get; set; }
            public Nullable<int> phone2 { get; set; }
            public Nullable<int> phone3 { get; set; }

            public Nullable<int> IDnum { get; set; }
            public bool ban { get; set; }
            public string address { get; set; }
            public string BuildingNUM { get; set; }
            public string flatNum { get; set; }
            public string Email { get; set; }
            public string guarantorName { get; set; }
            public Nullable<int> guarantorphone { get; set; }

            public string voucherNUM { get; set; }
            public string costomarColor { get; set; }
            public string path { get; set; }
            public int photo_id { get; set; }

        }

        public class V_costomar_deal_installment
        {
            public int installment_amount { get; set; }
            public string delay_Days { get; set; }
            public int Remaining_amount { get; set; }
            public int Worthy_amount { get; set; }
            public bool installment_condition { get; set; }
            public int Pons_installment { get; set; }
            public int remainder { get; set; }
            public string selcet_month { get; set; }
            public int Total_installment { get; set; }
            public int Total_Paid { get; set; }
            public int pocketMoney_id { get; set; }
            public int debt_id { get; set; }
            public int remaining_installments { get; set; }
            public int paid_installments { get; set; }
            public int Total_Remaining { get; set; }
            public int deal_id { get; set; }
            public int group_id { get; set; }
            public int costomar_id { get; set; }
            public int installment_id { get; set; }
            public string group_Name { get; set; }
            public int product_given { get; set; }
            public DateTime Start_Date { get; set; }
            public int product_Price { get; set; }
            public string payment_Day { get; set; }
            public string product_Name { get; set; }
            public string name { get; set; }
            public string phone1 { get; set; }
            public string phone2 { get; set; }
            public string phone3 { get; set; }
            public bool ban { get; set; }
            public string address { get; set; }
            public string BuildingNUM { get; set; }
            public string flatNum { get; set; }
            public string Email { get; set; }
            public string guarantorName { get; set; }
            public string guarantorphone { get; set; }
            public string IDnum { get; set; }
            public string voucherNUM { get; set; }
            public int Collectedvalue { get; set; }
            public bool list_Down_visible { get; set; }
            public DateTime InstallmentDueDate { get; set; }
            public DateTime InstallmentPaymentDate { get; set; }
            public string installmedntColor { get; set; }
            public string costomarColor { get; set; }
            public string dealColor { get; set; }
            public int funds_id { get; set; }
            public string Total_Saved { get; set; }
            public bool Deal_condition { get; set; }
        }
       
        #endregion
        public class photo
        {
            public string path { get; set; }
            public int photo_id { get; set; }
            public int costomar_id { get; set; }
        }



       public class CapitalAddition
        {
            [PrimaryKey, AutoIncrement]
            public int CapitalAddition_id { get; set; }

            public string CapitalAddition_name { get; set; }

            public DateTime additionDate { get; set; }

            public int amount { get; set; }

            public string Note { get; set; }

            public int funds_id { get; set; }
            



        }


        public class moneyTransfer
        {
            public int funds_id_1 { get; set; }
            public int funds_id_2 { get; set; }
            public DateTime TransferDate { get; set; }

            public int amount { get; set; }

            public string Note { get; set; }


        }

        public class Lisst
        {
            [PrimaryKey, AutoIncrement]
            public int group_id { get; set; }
            public string name { get; set; }

            public Nullable<double>  maximumAmount { get; set; }
            public Nullable<decimal>  MonthlyProfitRate { get; set; }
            public Nullable<int>  MonthlyNum { get; set; }
        }
        public class debt
        {
            [PrimaryKey, AutoIncrement]

            public int debt_id { get; set; }
            //public Nullable<int> debt_id { get; set; }
            //public Nullable<int> deal_id { get; set; }            
            public DateTime date { get; set; }
            public int amount { get; set; }
            public string Notes { get; set; }
            public string debtorName { get; set; }
            public string productname { get; set; }
            public string DebtCondition { get; set; }
            


        }

        public class group_month_Num
        {
            public string DisplaymonthNum { get; set; }            
            public bool Selected { get; set; }
        }
        public class group_month_Num_arary
        {
            public string arary_DisplaymonthNum { get; set; }            
        }
        public class Group_month
        {
            public int group_id { get; set; }
            public int Month_id { get; set; }
            public int Month_num { get; set; }
        }
        
    }
}
