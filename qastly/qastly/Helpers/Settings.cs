using System;
using System.Collections.Generic;
using System.Text;
// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;


namespace qastly.Helpers{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }
        
        #region Setting Constants

        private const string SettingsKey = "settings_key";
    private static readonly string SettingsDefault = string.Empty;

        #endregion

        #region Setting Creat Deal
        public static int Creat_Deal_group_id
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_group_id", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_group_id", value);
            }
        }
         public static int Creat_Deal_price
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_price", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_price", value);
            }
        }
        public static int Creat_Deal_given
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_given", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_given", value);
            }
        }
        public static int Creat_Deal_selcet_month
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_selcet_month", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_selcet_month", value);
            }
        }
        public static int Creat_Deal_remainder
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_remainder", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_remainder", value);
            }
        }
        public static int Creat_Deal_Total_installment
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_Total_installment", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_Total_installment", value);
            }
        }
        public static int Creat_Deal_Pons_installment
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_Pons_installment", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_Pons_installment", value);
            }
        }
        public static int Creat_Deal_Ceack
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_Ceack", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_Ceack", value);
            }
        }

        public static int Creat_Deal_qast
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_qast", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_qast", value);
            }
        }
        public static string Creat_Deal_group_name
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_group_name", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_group_name", value);
            }
        }

        public static int Creat_Deal_ItemData_costomar_id
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_ItemData_costomar_id", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_ItemData_costomar_id", value);
            }
        }
        public static string Creat_Deal_ItemData_costomar_Name
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_ItemData_costomar_Name", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_ItemData_costomar_Name", value);
            }
        }

        public static string Creat_Deal_Start_Date
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_Start_Date", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_Start_Date", value);
            }
        }

        public static string Creat_Deal_paymentDay
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_paymentDay", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_paymentDay", value);
            }
        }

        public static string Creat_Deal_Prodect_Name
        {
            get
            {
                return AppSettings.GetValueOrDefault("Creat_Deal_Prodect_Name", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Creat_Deal_Prodect_Name", value);
            }
        }

        //END
        #endregion

        public static string GeneralSettings
    {
      get
      {
        return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
      }
      set
      {
        AppSettings.AddOrUpdateValue(SettingsKey, value);
      }
    }

    public static string PageIconColor
    {
        get
        {
            return AppSettings.GetValueOrDefault("PageIconColor", "");
        }
        set
        {
            AppSettings.AddOrUpdateValue("PageIconColor", value);
        }
    }

        public static int costomarID
        {
            get
            {
                return AppSettings.GetValueOrDefault("costomarID",-1);
            }
            set
            {
                AppSettings.AddOrUpdateValue("costomarID", value);
            }
        }

        public static int fundsID
        {
            get
            {
                return AppSettings.GetValueOrDefault("fundsID", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("fundsID", value);
            }
        }
        public static string debtorName
        {
            get
            {
                return AppSettings.GetValueOrDefault("debtorName", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("debtorName", value);
            }
        }


        public static int DebtID
        {
            get
            {
                return AppSettings.GetValueOrDefault("DebtID", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("DebtID", value);
            }
        }

        public static int GroupID
        {
            get
            {
                return AppSettings.GetValueOrDefault("GroupID", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("GroupID", value);
            }
        }

        public static string Group_month
        {
            get
            {
                return AppSettings.GetValueOrDefault("Group_month","");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Group_month", value);
            }
        }

        public static int pop_navigation
        {
            get
            {
                return AppSettings.GetValueOrDefault("pop_navigation", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("pop_navigation", value);
            }
        }



        public static int Deal_installment_id
        {
            get
            {
                return AppSettings.GetValueOrDefault("Deal_installment_id", -1);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Deal_installment_id", value);
            }
        }


        public static int Deal_deal_id
        {
            get
            {
                return AppSettings.GetValueOrDefault("Deal_deal_id", -1);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Deal_deal_id", value);
            }
        }

        public static int Dital_deal_id
        {
            get
            {
                return AppSettings.GetValueOrDefault("Dital_deal_id", -1);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Dital_deal_id", value);
            }
        }
        public static int Dital_installment_id
        {
            get
            {
                return AppSettings.GetValueOrDefault("Dital_installment_id", -1);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Dital_installment_id", value);
            }
        }
        public static int Dital_Costomar_id
        {
            get
            {
                return AppSettings.GetValueOrDefault("Dital_Costomar_id", -1);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Dital_Costomar_id", value);
            }
        }
    }
}

