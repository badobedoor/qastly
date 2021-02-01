using System;

using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using qastly.Views;
using qastly.Helpers;
using SQLite;
using qastly.SQLite;
using qastly.Models;
using Rg.Plugins.Popup.Services;
using Android.Widget;
using Plugin.Media;
using PropertyChanged;
using System.Linq;
using System.Threading.Tasks;
using Plugin.Media.Abstractions;
using Xamarin.Essentials;

using Xamarin.Forms.Xaml;
using System.IO;
using Microsoft.Graph;

namespace qastly.ViewModels 
{

    [AddINotifyPropertyChangedInterfaceAttribute]
    public class MainViewModel :  abstractTist
    {
        //private SQLiteConnection _sqLiteConnection;

        public event PropertyChangedEventHandler PropertyChanged;

        var v = new Itest();
        var s = new abstractTist();


        private string _massage;

        public string Massage
        {
            get { return _massage; }

            set
            {
                _massage = value;
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs("Massage"));
                    OnPropertyChanged();
                }
            }


        }

        public List<Data.smallEarnings> List_smallEarnings_Data { get; set; }
        private string _fundsItemSlect;
        public string FundsItemSlect
        {
            get { return _fundsItemSlect; }

            set
            {
                _fundsItemSlect = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FundsItemSlect"));
                    OnPropertyChanged();
                }
            }


        }

        public decimal Total_Money { get; set; }


        #region Costomar ********

        #region Costomar Data 

        #region comment ......

        //private string _costomar_name;
        //public string costomar_name
        //{
        //    get { return _costomar_name; }

        //    set
        //    {
        //        _costomar_name = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_name"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private int _costomar_phone1;
        //public int costomar_phone1
        //{
        //    get { return _costomar_phone1; }

        //    set
        //    {
        //        _costomar_phone1 = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_phone1"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private int _costomar_phone2;
        //public int costomar_phone2
        //{
        //    get { return _costomar_phone2; }

        //    set
        //    {
        //        _costomar_phone2 = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_phone2"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private int _costomar_phone3;
        //public int costomar_phone3
        //{
        //    get { return _costomar_phone3; }

        //    set
        //    {
        //        _costomar_phone3 = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_phone3"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private int _costomar_IDnum;
        //public int costomar_IDnum
        //{
        //    get { return _costomar_IDnum; }

        //    set
        //    {
        //        _costomar_IDnum = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_IDnum"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}


        //private bool _costomar_ban;
        //public bool costomar_ban
        //{
        //    get { return _costomar_ban; }

        //    set
        //    {
        //        _costomar_ban = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_ban"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private string _costomar_address;
        //public string costomar_address
        //{
        //    get { return _costomar_address; }

        //    set
        //    {
        //        _costomar_address = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_address"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private string _costomar_BuildingNUM;
        //public string costomar_BuildingNUM
        //{
        //    get { return _costomar_BuildingNUM; }

        //    set
        //    {
        //        _costomar_BuildingNUM = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_BuildingNUM"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private string _costomar_flatNum;
        //public string costomar_flatNum
        //{
        //    get { return _costomar_flatNum; }

        //    set
        //    {
        //        _costomar_flatNum = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_flatNum"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private string _costomar_Email;
        //public string costomar_Email
        //{
        //    get { return _costomar_Email; }

        //    set
        //    {
        //        _costomar_Email = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_Email"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private string _costomar_guarantorName;
        //public string costomar_guarantorName
        //{
        //    get { return _costomar_guarantorName; }

        //    set
        //    {
        //        _costomar_guarantorName = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_guarantorName"));
        //            OnPropertyChanged();
        //        }
        //    }

        //}

        //private int _costomar_guarantorphone;
        //public int costomar_guarantorphone
        //{
        //    get { return _costomar_guarantorphone; }

        //    set
        //    {
        //        _costomar_guarantorphone = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_guarantorphone"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private string _costomar_voucherNUM;
        //public string costomar_voucherNUM
        //{
        //    get { return _costomar_voucherNUM; }

        //    set
        //    {
        //        _costomar_voucherNUM = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_voucherNUM"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        //private string _costomar_costomarColor;
        //public string costomar_costomarColor
        //{
        //    get { return _costomar_costomarColor; }

        //    set
        //    {
        //        _costomar_costomarColor = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("costomar_costomarColor"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}
        #endregion

        public int _costomarItemData_costomar_id { get; set; }

        #region Creat costomar properties ------------------------------------------
        public string costomar_name { get; set; }
        public string costomar_phone1 { get; set; }
        public string costomar_phone2 { get; set; }
        public string costomar_phone3 { get; set; }
        public string costomar_IDnum { get; set; }
        public bool costomar_ban { get; set; }

        public string costomar_address { get; set; }
        public string costomar_BuildingNUM { get; set; }

        public string costomar_flatNum { get; set; }
        public string costomar_Email { get; set; }
        public string costomar_guarantorName { get; set; }
        public string costomar_guarantorphone { get; set; }

        public string costomar_voucherNUM { get; set; }
        public string costomar_costomarColor { get; set; }
        #endregion


        #region Edit costomar properties ------------------------------------------
        public int Edit_costomar_ID { get; set; }
        public string Edit_costomar_name { get; set; }
        public string Edit_costomar_phone1 { get; set; }
        public string Edit_costomar_phone2 { get; set; }
        public string Edit_costomar_phone3 { get; set; }
        public string Edit_costomar_IDnum { get; set; }
        public bool Edit_costomar_ban { get; set; }

        public string Edit_costomar_address { get; set; }
        public string Edit_costomar_BuildingNUM { get; set; }

        public string Edit_costomar_flatNum { get; set; }
        public string Edit_costomar_Email { get; set; }
        public string Edit_costomar_guarantorName { get; set; }
        public string Edit_costomar_guarantorphone { get; set; }

        public string Edit_costomar_voucherNUM { get; set; }
        public string Edit_costomar_costomarColor { get; set; }
        #endregion


        #region get costomar properties ------------------------------------------
        //public string get_costomar_name { get; set; }
        //public int get_costomar_phone1 { get; set; }
        //public int get_costomar_phone2 { get; set; }
        //public int get_costomar_phone3 { get; set; }
        //public int get_costomar_IDnum { get; set; }
        //public bool get_costomar_ban { get; set; }

        //public string get_costomar_address { get; set; }
        //public string get_costomar_BuildingNUM { get; set; }

        //public string get_costomar_flatNum { get; set; }
        //public string get_costomar_Email { get; set; }
        //public string get_costomar_guarantorName { get; set; }
        //public int get_costomar_guarantorphone { get; set; }

        //public string get_costomar_voucherNUM { get; set; }
        //public string get_costomar_costomarColor { get; set; }
        #endregion         

        public List<Data.costomar> Costomar { get; set; }

        public Data.costomar CostomarDital { get; set; }
        public List<string> photo_file_path { get; set; }

        public string Costomar_photo_path { get; set; }
        public List<string> Costomer_Photo_List { get; set; }
        public List<ImageSource> Costomer_Photo_ImageSource { get; set; }




        #endregion

        #region CostomarDataMethod&Command 
        public Command PostcostomarComand
        {
            get
            {
                return new Command(async (pramter) =>
                {
                    //var o_dataservices = new CostomerService();
                    //o_dataservices.DleateallCostomer();
                    //await App.Current.MainPage.Navigation.PushAsync(new Views.Group());

                    var costomardata = new Data.costomar
                    {
                        name = costomar_name,
                        phone1 = costomar_phone1,
                        phone2 = costomar_phone2,
                        phone3 = costomar_phone3,
                        IDnum = costomar_IDnum,
                        address = costomar_address,
                        flatNum = costomar_flatNum,
                        BuildingNUM = costomar_BuildingNUM,
                        Email = costomar_Email,
                        ban = costomar_ban,
                        guarantorName = costomar_guarantorName,
                        guarantorphone = costomar_guarantorphone,
                        costomarColor = costomar_costomarColor,
                        voucherNUM = costomar_voucherNUM
                    };
                    var o_dataservices = new CostomerService();

                    if (costomardata.name == null)
                    {
                        Massage = "برجاء إدخال أسم العميل";
                        Eventalert(Massage);

                    }
                    else if (costomardata.phone1 == null)
                    {
                        Massage = "برجاء إدخال رقم هاتف للعميل";
                        Eventalert(Massage);
                    }
                    else if (costomardata.IDnum == null)
                    {
                        Massage = "برجاء إدخال رقم بطاقة العميل";
                        Eventalert(Massage);
                    }
                    else if (costomardata.address == null)
                    {
                        Massage = "برجاء إدخال الحى او المنطقة";
                        Eventalert(Massage);
                    }
                    else if (costomardata.guarantorName != null && costomardata.guarantorphone == null)
                    {
                        Massage = "برجاء إدخال رقم هاتف الضامن";
                        Eventalert(Massage);
                        #region comment 
                        //if (costomardata.guarantorphone == 0)
                        //{
                        //    Massage = "برجاء إدخال رقم هاتف الضامن";
                        //    Eventalert(Massage);
                        //}
                        //else
                        //{
                        //    int result = await o_dataservices.CreateCostomer(costomardata);
                        //    if (result > 0)
                        //    {
                        //        Massage = "تم إنشاء عميل جديد بنجاح";

                        //        MessagingCenter.Send("AddCostomar", "UbdateListView", "Success");

                        //        Eventalert(Massage);
                        //        await App.Current.MainPage.Navigation.PushAsync(new Views.costomares());
                        //    }
                        //    else
                        //    {
                        //        Massage = "لم يتم إنشاء عميل جديد ";
                        //        Eventalert(Massage);
                        //    }
                        //}
                        #endregion


                    }
                    else
                    {
                        var costomardata_result = await o_dataservices.CreateCostomer(costomardata);
                        if (costomardata_result != null)
                        {
                            var i = 1;
                            var Costomer_photo_res = 0;
                            if (photo_file_path != null)
                            {
                                foreach (var o_item in photo_file_path)
                                {


                                    var photo_data = new Data.photo
                                    {
                                        path = o_item,
                                        costomar_id = costomardata_result.costomar_id,
                                        photo_id = i
                                    };
                                    Costomer_photo_res = await o_dataservices.Create_photo_Costomer(photo_data);
                                    i++;
                                }
                            }

                            if (Costomer_photo_res > 0 || photo_file_path == null)
                            {
                                Massage = "تم إنشاء عميل جديد بنجاح";

                                MessagingCenter.Send("AddCostomar", "UbdateListView", "Success");

                                IMessage_ShortAlert(Massage);
                                if (pramter.ToString() == "1")
                                {
                                    await App.Current.MainPage.Navigation.PushAsync(new Views.costomares());

                                }
                                else if (pramter.ToString() == "2")
                                {
                                    //هنا هاخد العميل بتاعى سليكت 
                                    Settings.Creat_Deal_ItemData_costomar_id = costomardata_result.costomar_id;
                                    Settings.Creat_Deal_ItemData_costomar_Name = costomardata_result.name;
                                    Settings.Creat_Deal_Ceack = 1;
                                    await App.Current.MainPage.Navigation.PushAsync(new Views.CreateDeal());
                                }

                            }
                            else {
                                Massage = "لم يتم إنشاء الصورالخاضة بالعميل  ";
                                Eventalert(Massage);
                            }

                        }
                        else
                        {
                            Massage = "لم يتم إنشاء عميل جديد ";
                            Eventalert(Massage);
                        }
                    }


                    var x = 5;
                    // Massage = () ? "تم إنشاء عميل جديد بنجاح" : "لم يتم إنشاء عميل جديد";
                }

            // await _apiServices.PostCartsAsync(cartdata, Settings.AccessToken);



            );
            }
        }


        public Command UpdatecostomarComand
        {
            get
            {
                return new Command(async () =>
                {
                    var costomardata = new Data.costomar
                    {
                        costomar_id = Edit_costomar_ID,
                        name = Edit_costomar_name,
                        phone1 = Edit_costomar_phone1,
                        phone2 = Edit_costomar_phone2,
                        phone3 = Edit_costomar_phone3,
                        IDnum = Edit_costomar_IDnum,
                        address = Edit_costomar_address,
                        flatNum = Edit_costomar_flatNum,
                        BuildingNUM = Edit_costomar_BuildingNUM,
                        Email = Edit_costomar_Email,
                        ban = Edit_costomar_ban,
                        guarantorName = Edit_costomar_guarantorName,
                        guarantorphone = Edit_costomar_guarantorphone,
                        costomarColor = Edit_costomar_costomarColor,
                        voucherNUM = Edit_costomar_voucherNUM
                    };
                    var o_dataservices = new CostomerService();
                    var result = await o_dataservices.UpdateCostomer(costomardata);
                    if (result > 0)
                    {
                        Massage = "تم تعديل العميل  بنجاح";

                        MessagingCenter.Send("UpdateCostomar", "UbdateListView", "Success");

                        Eventalert(Massage);
                        await App.Current.MainPage.Navigation.PushAsync(new Views.costomares());
                    }
                    else
                    {
                        Massage = "لم يتم تعديل العميل ";
                        Eventalert(Massage);
                    }

                    var x = 5;

                }




            );
            }
        }




        public async void costomarItemTappedMathod(object obj)
        {
            var O_DataServices = new CostomerService();
            var costomarItemData = obj as Data.costomar;
            Settings.costomarID = costomarItemData.costomar_id;
            var costomardata = await O_DataServices.GetCostomerDital(costomarItemData.costomar_id);
            if (costomardata != null)
            {
                CostomarDital = costomardata;
            }
            else
            {
                var x = 1;
            }

            await App.Current.MainPage.Navigation.PushAsync(new CostomarDetail());

        }

        public async void getcostomarDetailData()
        {
            var O_DataServices = new CostomerService();

            var costomardata = await O_DataServices.GetCostomerDital(Settings.costomarID);
            if (costomardata != null)
            {
                CostomarDital = costomardata;
                Edit_costomar_ID = costomardata.costomar_id;
                Edit_costomar_name = costomardata.name;
                Edit_costomar_phone1 = costomardata.phone1;
                Edit_costomar_phone2 = costomardata.phone2;
                Edit_costomar_phone3 = costomardata.phone3;
                Edit_costomar_IDnum = costomardata.IDnum;
                Edit_costomar_address = costomardata.address;
                Edit_costomar_flatNum = costomardata.flatNum;
                Edit_costomar_BuildingNUM = costomardata.BuildingNUM;
                Edit_costomar_Email = costomardata.Email;
                Edit_costomar_ban = costomardata.ban;
                Edit_costomar_guarantorName = costomardata.guarantorName;
                Edit_costomar_guarantorphone = costomardata.guarantorphone;
                Edit_costomar_costomarColor = costomardata.costomarColor;
                Edit_costomar_voucherNUM = costomardata.voucherNUM;


            }
            else
            {
                var x = 1;
            }




        }


        //هنا محتاج مراجعه .................................................
        public Command Take_photo_Comand
        {
            get
            {
                return new Command(async () =>
                {
                    var OcrossMedia = CrossMedia.Current;
                    if (OcrossMedia.IsCameraAvailable && OcrossMedia.IsPickPhotoSupported)
                    {
                        var O_DataServices = new CostomerService();
                        var costomardata_result = await O_DataServices.GetCostomerDital(Settings.costomarID);
                        //code
                        if (photo_file_path == null)
                        {
                            var res_path = await OcrossMedia.TakePhotoAsync(new StoreCameraMediaOptions
                            {
                                Name = DateTime.Now.ToString("yyyy/MM/dd") + ".jpg",
                                Directory = "Pictures",
                                AllowCropping = true,

                            });
                            if (res_path.Path != null)
                            {
                                photo_file_path = new List<string> { res_path.Path };
                                var photo_data = new Data.photo
                                {
                                    path = res_path.Path.ToString(),
                                    costomar_id = costomardata_result.costomar_id,
                                    photo_id = 1
                                };
                                var Costomer_photo_res = await O_DataServices.Create_photo_Costomer(photo_data);
                                Massage = "تم إضافة صورة بنجاح";
                                IMessage_LongAlert(Massage);
                                await App.Current.MainPage.Navigation.PushAsync(new Views.CostomarDetail());

                            }


                        }
                        else
                        {
                            var res_path = await OcrossMedia.TakePhotoAsync(new StoreCameraMediaOptions
                            {
                                Name = DateTime.Now.ToString("yyyy/MM/dd") + ".jpg",
                                Directory = "Pictures",
                                AllowCropping = true,
                            });
                            if (res_path != null)
                            {
                                if (photo_file_path.Count < 8)
                                {
                                    photo_file_path = new List<string> { res_path.Path };
                                    var photo_data = new Data.photo
                                    {
                                        path = res_path.Path.ToString(),
                                        costomar_id = costomardata_result.costomar_id,
                                        photo_id = 1
                                    };
                                    var Costomer_photo_res = await O_DataServices.Create_photo_Costomer(photo_data);
                                }


                                Massage = "تم إضافة الصور بنجاح";
                                IMessage_LongAlert(Massage);
                                App.Current.MainPage.Navigation.PushAsync(new Views.CostomarDetail());
                            }
                            else
                            {
                                Massage = "لم يتم إضافة الصورة لان اقصي عدد متاح للعميل الواحد هو سبعه صور فقط";
                                Eventalert(Massage);
                            }


                        }
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("تحذير!", "الكميرا غير مدعومه على هذا الهاتف", "حسنا");

                    }
                }
            );
            }
        }




        public Command pick_photo_Comand
        {
            get
            {
                return new Command(async () =>
                {

                    var O_DataServices = new CostomerService();
                    var costomardata_result = await O_DataServices.GetCostomerDital(Settings.costomarID);

                    if (costomardata_result != null)
                    {
                        var i = 1;
                        var Costomer_photo_res = 0;
                        var OcrossMedia = CrossMedia.Current;
                        if (OcrossMedia.IsCameraAvailable && OcrossMedia.IsPickPhotoSupported)
                        {
                            //code
                            photo_file_path = await O_DataServices.getCostomer_photo_list(Settings.costomarID);
                            if (photo_file_path == null)
                            {
                                var res_path = await OcrossMedia.PickPhotoAsync();
                                if (res_path.Path != null)
                                {
                                    photo_file_path = new List<string> { res_path.Path };
                                    var photo_data = new Data.photo
                                    {
                                        path = res_path.Path.ToString(),
                                        costomar_id = costomardata_result.costomar_id,
                                        photo_id = 1
                                    };
                                    Costomer_photo_res = await O_DataServices.Create_photo_Costomer(photo_data);
                                    Massage = "تم إضافة صورة بنجاح";
                                    IMessage_LongAlert(Massage);
                                    App.Current.MainPage.Navigation.PushAsync(new Views.CostomarDetail());

                                }

                            }
                            else
                            {
                                var res_path = await OcrossMedia.PickPhotosAsync();
                                if (res_path != null && res_path.Count != 0)
                                {
                                    if (res_path.Count < 8)
                                    {
                                        foreach (var o_item in res_path)
                                        {
                                            var photo_data = new Data.photo
                                            {
                                                path = o_item.ToString(),
                                                costomar_id = costomardata_result.costomar_id,
                                                photo_id = i
                                            };
                                            Costomer_photo_res = await O_DataServices.Create_photo_Costomer(photo_data);
                                            i++;
                                        }

                                        Massage = "تم إضافة الصور بنجاح";
                                        IMessage_LongAlert(Massage);
                                        App.Current.MainPage.Navigation.PushAsync(new Views.CostomarDetail());
                                        //    foreach (var item in res_path)
                                        //{
                                        //    photo_file_path.Add(item.Path);                                       
                                        //}
                                    }
                                    else
                                    {
                                        Massage = "لم يتم إضافة الصور لان اقصي عدد متاح للعميل الواحد هو سبعه صور فقط";
                                        Eventalert(Massage);
                                    }
                                }
                            }
                        }
                        else
                        {
                            await App.Current.MainPage.DisplayAlert("تحذير!", "الكميرا غير مدعومه على هذا الهاتف", "حسنا");

                        }
                    }
                }
            );
            }
        }

        public Command dleate_photo_Comand
        {
            get
            {
                return new Command(async () =>
                {
                    if (Costomar_photo_path != null)
                    {
                        var O_DataServices = new CostomerService();

                        //Eventalert("هل تريد حذف هذه الصوره؟");
                        bool x = await App.Current.MainPage.DisplayAlert("عزيزى العميل", "هل تريد حذف هذه الصوره؟", "حسنا", "إلغاء");
                        if (x == true)
                        {
                            var res = await O_DataServices.Dleate_Costomer_photo(CostomarDital.costomar_id, Costomar_photo_path);
                            if (res < 0)
                            {
                                IMessage_LongAlert("تم مسح الصورة");
                            }
                            else
                            {
                                IMessage_LongAlert("خطأ لم يتم مسح الصورة ");
                            }
                        }




                    }
                }
            );
            }
        }

        #endregion

        #endregion

        #region Deal *******

        #region Data         
        public List<Data.V_costomar_deal_installment> List_Deal_Data { get; set; }
        public List<Data.V_costomar_deal_installment> List_deal_Archives { get; set; }

        public Data.V_costomar_deal_installment Dital_Deal_Data { get; set; }
        public string VM_Creat_Deal_group_id { get; set; }

        public string VM_Creat_Deal_price { get; set; }
        public string VM_Creat_Deal_given { get; set; }
        public string VM_Creat_Deal_selcet_month { get; set; }
        public string VM_Creat_Deal_remainder { get; set; }
        public string VM_Creat_Deal_Total_installment { get; set; }
        public string VM_Creat_Deal_Pons_installment { get; set; }
        public string VM_Creat_Deal_group_name { get; set; }
        public string VM_Creat_Deal_qast { get; set; }
        public string VM_Creat_Deal_ItemData_costomar_id { get; set; }
        public string VM_Creat_Deal_ItemData_costomar_Name { get; set; }
        public string VM_Creat_Deal_Start_Date { get; set; }
        public string VM_Creat_Deal_paymentDay { get; set; }
        public string VM_Creat_Deal_Prodect_Name { get; set; }
        public string VM_Creat_Deal_new_Debt_Name { get; set; }
        #endregion

        #region installment 
        public string payInstallmentDate_picker { get; set; }
        public string pay_part_installment_VM { get; set; }
        public bool pay_part_installment_Entry_IsVisible { get; set; }
        public List<Data.installment> pay_installment_List { get; set; }

        public Command Dleate_All_installment_and_Deal_Command
        {
            get
            {
                return new Command(async (opj) =>
                {
                    var res = await App.Current.MainPage.DisplayAlert("تنبية", "هل تريد مسح كل الصفقات", "نعم", "الغاء");
                    if (res == true)
                    {
                        var o_dataservices = new DealService();

                        await o_dataservices.Dleate_All_installment_and_Deal();
                    }


                });
            }
        }


        public Command Nav_PayInstalment_Command
        {
            get
            {
                return new Command(async (opj) =>
                {
                    var o_dataservices = new DealService();

                    var o_costomar_deal_installment = opj as Data.V_costomar_deal_installment;
                    Dital_Deal_Data = o_costomar_deal_installment;
                    Settings.Dital_deal_id = Dital_Deal_Data.deal_id;
                    Settings.Dital_installment_id = Dital_Deal_Data.installment_id;
                    Settings.Dital_Costomar_id = Dital_Deal_Data.costomar_id;

                    await PopupNavigation.Instance.PushAsync(new Views.PayInstalment());


                });


            }
        }
        public Command Pay_installment_Command
        {
            get
            {
                return new Command(async () =>
                {
                    var o_dataservices = new DealService();
                    var res = Dital_Deal_Data;
                    if (res != null)
                    {
                        if (pay_part_installment_Entry_IsVisible == true)
                        {
                            if (pay_part_installment_VM == null)
                            {
                                Eventalert("لم يتم ادخال اى مبلغ ");
                            }

                            else if (pay_part_installment_VM.Length == 0 || pay_part_installment_VM == "0")
                            {
                                Eventalert("لم يتم ادخال اى مبلغ ");
                            }

                        }
                        else
                        {
                            var O_Deal = new Data.deal
                            {
                                deal_id = res.deal_id,
                                product_given = res.product_given,
                                Start_Date = res.Start_Date,
                                product_Price = res.product_Price,
                                payment_Day = res.payment_Day,
                                product_Name = res.product_Name,
                                costomar_id = res.costomar_id,
                                group_id = res.group_id,
                                funds_id = res.funds_id,
                                dealColor = res.dealColor,
                                group_Name = res.group_Name,
                                installment_amount = res.installment_amount,
                                selcet_month = res.selcet_month,
                                remainder = res.remainder,
                                Total_installment = res.Total_installment,
                                Pons_installment = res.Pons_installment,
                                Total_Paid = res.Total_Paid,
                                Total_Remaining = res.Total_Remaining,
                                pocketMoney_id = res.pocketMoney_id,
                                remaining_installments = res.remaining_installments,
                                paid_installments = res.paid_installments,
                                Deal_condition = res.Deal_condition,
                                Total_Saved = res.Total_Saved,
                            };
                            var O_installment = new Data.installment
                            {
                                installment_id = res.installment_id,
                                deal_id = res.deal_id,
                                Collectedvalue = res.Collectedvalue,
                                installmedntColor = res.installmedntColor,
                                InstallmentDueDate = res.InstallmentDueDate,
                                InstallmentPaymentDate = res.InstallmentPaymentDate,
                                list_Down_visible = res.list_Down_visible,
                                Worthy_amount = res.Worthy_amount,
                                installment_condition = res.installment_condition,
                                delay_Days = res.delay_Days,
                                Remaining_amount = res.Remaining_amount,
                            };

                            bool pay_don = false;
                            bool don = false;
                            bool update_deal = false;
                            int Remaining_Old_installment_amount = 0;
                            //دفع القسط


                            #region  تحديث بينات الخزنه 
                            //اول حاجه الاصول هى التعديل فى فلوس الخزنه عشان لو الخزنه مش موجودة يطلع خطا
                            var o_FundsDataservices = new fundsService();
                            var test_main_funds = true;
                            var eroormsg = "";
                            var funds_msg = "";
                            var main_funds = await o_FundsDataservices.Get_main_funds(test_main_funds);
                            if (main_funds != null)
                            {

                                //القسط

                                #region تحديث بينات القسط القديم


                                if (pay_part_installment_VM == null)
                                {
                                    if (pay_part_installment_Entry_IsVisible == false)
                                    {
                                        O_installment.Collectedvalue = O_Deal.installment_amount;
                                    }

                                }
                                else if (pay_part_installment_VM.Length == 0 || pay_part_installment_VM == "0")
                                {
                                    O_installment.Collectedvalue = O_Deal.installment_amount;
                                }
                                else
                                {
                                    O_installment.Collectedvalue = Convert.ToInt32(pay_part_installment_VM);
                                }


                                O_installment.Remaining_amount = O_installment.Worthy_amount - O_installment.Collectedvalue;


                                if (O_installment.Remaining_amount == 0 && O_installment.Worthy_amount == O_installment.Collectedvalue)
                                {
                                    // القسط مدفوع كامل 
                                    O_installment.installment_condition = true;
                                    O_installment.InstallmentPaymentDate = Convert.ToDateTime(payInstallmentDate_picker);
                                    var Update_installment_Res = await o_dataservices.Update_installment(O_installment);

                                    pay_don = true;
                                }
                                else
                                {

                                    // القسط مش مدفوع بالكامل 
                                    if (O_installment.Remaining_amount != 0 && O_installment.Worthy_amount > O_installment.Collectedvalue)
                                    {
                                        //القيمه المدفوعه اقل من القيمه المستحقة                                         
                                        O_installment.Worthy_amount = O_installment.Remaining_amount; //القيمه المستحقه الجديده 
                                        O_installment.installment_condition = false;
                                        O_installment.InstallmentPaymentDate = Convert.ToDateTime(payInstallmentDate_picker);
                                        var Update_installment_Res = await o_dataservices.Update_installment(O_installment);
                                    }
                                    else if (O_installment.Remaining_amount != 0 && O_installment.Worthy_amount < O_installment.Collectedvalue)
                                    {
                                        int two_month_Worthy_amount = O_installment.Worthy_amount + O_installment.Worthy_amount;
                                        if (two_month_Worthy_amount <= O_installment.Collectedvalue)
                                        {
                                            //خطا لا يمكن دفع قسطين فى قسط واحد
                                            eroormsg = "خطا لا يمكن دفع قسطين فى عملية دفع واحدة";
                                            Eventalert(eroormsg);
                                        }
                                        else
                                        {
                                            //القيمه المدفوعه اكثر من القيمه المستحقة 

                                            //وكمان اخد باقى الفلوس وانزلهم من القسط الجديد 
                                            Remaining_Old_installment_amount = O_installment.Collectedvalue - O_installment.Worthy_amount;

                                            //  لو عاوز اساوى فى القيمه المحصلة والقيمه المدفوعه    O_installment.Collectedvalue = O_installment.Worthy_amount;                                            
                                            O_installment.installment_condition = true;
                                            O_installment.InstallmentPaymentDate = Convert.ToDateTime(payInstallmentDate_picker);
                                            O_installment.Remaining_amount = 0;
                                            var Update_installment_Res = await o_dataservices.Update_installment(O_installment);
                                            pay_don = true;

                                        }

                                    }


                                }

                                #endregion

                                //الخزنه
                                if (eroormsg != "خطا لا يمكن دفع قسطين فى عملية دفع واحدة")
                                {
                                    main_funds.fundsBalance = main_funds.fundsBalance + O_installment.Collectedvalue;
                                    var test_res = o_FundsDataservices.Updatefunds(main_funds);
                                }

                            }
                            else
                            {
                                funds_msg = "لا توجد خزنه رئيسه لاضافه الاقساط اليها , من فضلك أنشأ الخزنه ثم حاول دفع القسط مرة اخري ";
                                Eventalert(funds_msg);
                            }
                            #endregion



                            #region إنشاء قسط جديد 
                            if (pay_don == true && Remaining_Old_installment_amount == 0 && O_Deal.remaining_installments != 0)
                            {
                                //قسط جديد
                                int o_installment_id = await o_dataservices.Get_last_id_installment(O_Deal.deal_id);


                                o_installment_id = o_installment_id + 1;
                                var new_InstallmentDueDate = O_installment.InstallmentDueDate.AddMonths(1);
                                var o_installmedntColor = Color.FromRgb(180, 255, 180);
                                string Color_Hex = o_installmedntColor.ToHex();

                                var New_installment = new Data.installment
                                {
                                    deal_id = O_Deal.deal_id,
                                    InstallmentDueDate = new_InstallmentDueDate,
                                    Worthy_amount = O_Deal.installment_amount,
                                    list_Down_visible = false,
                                    installment_condition = false,
                                    installment_id = o_installment_id,
                                    delay_Days = "0",
                                    installmedntColor = Color_Hex.Remove(1, 2),
                                    //Remaining_amount = res.Remaining_amount,                                    
                                };
                                var New_installment_res = await o_dataservices.Create_installment(New_installment);


                            }
                            else if (pay_don == true && Remaining_Old_installment_amount != 0 && O_Deal.remaining_installments != 0)
                            {
                                //قسط جديد مع تغير في البينات
                                int o_installment_id = await o_dataservices.Get_last_id_installment(O_Deal.deal_id);

                                o_installment_id = o_installment_id + 1;
                                var new_InstallmentDueDate = O_installment.InstallmentDueDate.AddMonths(1);

                                var New_installment = new Data.installment
                                {
                                    deal_id = O_Deal.deal_id,
                                    InstallmentDueDate = new_InstallmentDueDate,
                                    Worthy_amount = O_installment.Worthy_amount - Remaining_Old_installment_amount,
                                    list_Down_visible = false,
                                    installment_condition = false,
                                    installment_id = o_installment_id,

                                    delay_Days = "0",

                                    //Remaining_amount = res.Remaining_amount,

                                };
                                var New_installment_res = await o_dataservices.Create_installment(New_installment);

                            }

                            #endregion

                            #region تحديث بينات الصفقه 
                            if (pay_don == true && O_Deal.remaining_installments != 0)
                            {
                                //فى حالة القسط الكامل - القسط الذياده 
                                O_Deal.paid_installments = O_Deal.paid_installments + 1;
                                O_Deal.remaining_installments = O_Deal.remaining_installments - 1;
                                O_Deal.Total_Paid = O_Deal.Total_Paid + O_installment.Collectedvalue;
                                O_Deal.Total_Remaining = O_Deal.Total_Remaining - O_installment.Collectedvalue;

                                var Update_Deal_Res = await o_dataservices.Update_Deal(O_Deal);
                                update_deal = true;
                            }
                            else if (pay_don != true && O_Deal.remaining_installments != 0 && eroormsg != "خطا لا يمكن دفع قسطين فى عملية دفع واحدة" && funds_msg != "لا توجد خزنه رئيسه لاضافه الاقساط اليها , من فضلك أنشأ الخزنه ثم حاول دفع القسط مرة اخري ")
                            {
                                //فى حالة جزء من القسط
                                O_Deal.Total_Paid = O_Deal.Total_Paid + O_installment.Collectedvalue;
                                O_Deal.Total_Remaining = O_Deal.Total_Remaining - O_installment.Collectedvalue;

                                var Update_Deal_Res = await o_dataservices.Update_Deal(O_Deal);

                                update_deal = true;

                            }
                            else if (O_Deal.remaining_installments == 0)
                            {
                                O_Deal.Deal_condition = true;
                                var Update_Deal_Res = await o_dataservices.Update_Deal(O_Deal);
                                //عاوز اتاكد من التاجيل والعفو بيغيرو حاجه فى الصفقه ولا لا عشان هتاثر على الخطا دا
                                IMessage_LongAlert("أنتهت الصفقة وتم أرشفتها");
                            }



                            #endregion




                            #region تحديث وانشاء ارباح
                            if (update_deal != false)
                            {
                                var Total_Paid_and_given = O_Deal.Total_Paid + O_Deal.product_given;
                                if (Total_Paid_and_given > O_Deal.product_Price)
                                {
                                    int o_amount = Total_Paid_and_given - Convert.ToInt32(O_Deal.product_Price);
                                    //ابحث عن الاي دي لو مش لقيت  هعمل انشاء واحد جديد لو لقيت اعمل تحديث
                                    var o_dataservices_smallEarnings = new smallEarningsService();
                                    var existing_smallEarnings = o_dataservices_smallEarnings.Get_smallEarnings(O_Deal.deal_id).Result;
                                    if (existing_smallEarnings != null)
                                    {
                                        //تحديث
                                        existing_smallEarnings.amount = o_amount;
                                        existing_smallEarnings.date = O_installment.InstallmentPaymentDate;

                                        var smallEarnings_Update_res = o_dataservices_smallEarnings.Update_smallEarnings(existing_smallEarnings);
                                    }
                                    else
                                    {
                                        //انشاء جديد
                                        var note_msg = " ";
                                        var New_smallEarnings = new Data.smallEarnings
                                        {
                                            amount = o_amount,
                                            date = O_installment.InstallmentPaymentDate,
                                            note = note_msg,
                                            deal_id = O_Deal.deal_id,
                                        };

                                        var smallEarnings_Create_res = o_dataservices_smallEarnings.Create_smallEarnings(New_smallEarnings);

                                    }

                                }

                                #region الانهاء

                                if (funds_msg != "لا توجد خزنه رئيسه لاضافه الاقساط اليها , من فضلك أنشأ الخزنه ثم حاول دفع القسط مرة اخري ")
                                {

                                    MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");
                                    IMessage_ShortAlert("تم دفع القسط بنجاح");
                                    await PopupNavigation.Instance.PopAsync();
                                }


                                #endregion

                            }



                            #endregion


                        }
                    }



                });


            }
        }


        public Data.installment Old_installment;

        public Command phone_call_installment_Command
        {
            get
            {
                return new Command(async (opj) =>
                {
                    var o_dataservices = new DealService();

                    var o_costomar_deal_installment = opj as Data.V_costomar_deal_installment;
                    if (o_costomar_deal_installment != null)
                    {
                        try
                        {
                            PhoneDialer.Open(o_costomar_deal_installment.phone1);
                        }
                        catch (Exception ex)
                        {
                            var msg = "خطا اثناء القيام بالاتصال";
                            Eventalert(msg);
                        }
                    }
                    else
                    {
                        var o_costomar = opj as Data.costomar;
                        try
                        {
                            PhoneDialer.Open(o_costomar.phone1);
                        }
                        catch (Exception ex)
                        {
                            var msg = "خطا اثناء القيام بالاتصال";
                            Eventalert(msg);
                        }
                    }

                });


            }
        }

        public Command Send_msg_installment_Command
        {
            get
            {
                return new Command(async (opj) =>
                {
                    var o_dataservices = new DealService();

                    var o_costomar_deal_installment = opj as Data.V_costomar_deal_installment;

                    try
                    {
                        var masag = "عزيزي العميل نريد تنبيهك انك قد تاخرت فى دفع القسط المستحق الرجاء السداد فى اسرع وقت لعدم إتخاذ الاجرائات القانونيه ";
                        await Sms.ComposeAsync(new SmsMessage(masag, o_costomar_deal_installment.phone1));

                    }
                    catch (Exception ex)
                    {
                        var msg = "خطا اثناء القيام بإرسال الرساله";
                        Eventalert(msg);
                    }



                });


            }
        }



        public Command show_installment_List_Command
        {
            get
            {
                return new Command(async (opj) => {

                    var o_dataservices = new DealService();
                    var res = opj as Data.V_costomar_deal_installment;
                    var New_installment = new Data.installment
                    {
                        installment_id = res.installment_id,
                        deal_id = res.deal_id,
                        Collectedvalue = res.Collectedvalue,
                        installmedntColor = res.installmedntColor,
                        InstallmentDueDate = res.InstallmentDueDate,
                        InstallmentPaymentDate = res.InstallmentPaymentDate,
                        list_Down_visible = res.list_Down_visible,
                        delay_Days = res.delay_Days,
                        installment_condition = res.installment_condition,
                        Remaining_amount = res.Remaining_amount,
                        Worthy_amount = res.Worthy_amount,
                    };
                    var res_Old_installment = o_dataservices.Get_installment_by_id(Settings.Deal_deal_id, Settings.Deal_installment_id);
                    if (res_Old_installment != null)
                    {
                        Old_installment = res_Old_installment.Result;
                    }




                    if (Settings.Deal_installment_id == New_installment.installment_id && Settings.Deal_deal_id == New_installment.deal_id)
                    {
                        //ضغط على نفس العنصر مرتين
                        if (New_installment.list_Down_visible == true)
                        {
                            New_installment.list_Down_visible = false;
                        }
                        else
                        {
                            New_installment.list_Down_visible = true;
                        }
                        //New_installment.list_Down_visible =! New_installment.list_Down_visible;
                        var Update_Res = await o_dataservices.Update_installment(New_installment);
                    }
                    else
                    {
                        if (Old_installment != null)
                        {
                            //هنخفي العنصر القديم
                            Old_installment.list_Down_visible = false;
                            var Update_Res = await o_dataservices.Update_installment(Old_installment);
                        }
                        //اظهار العنصر الجديد
                        New_installment.list_Down_visible = true;
                        var Update_Old_installment_Res = await o_dataservices.Update_installment(New_installment);
                    }

                    Settings.Deal_deal_id = New_installment.deal_id;
                    Settings.Deal_installment_id = New_installment.installment_id;
                    MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");
                    //Old_installment = New_installment;

                });
            }
        }

        public Command Exemption_installment_Command
        {
            get
            {
                return new Command(async (opj) => {

                    var o_dataservices = new DealService();
                    var res = opj as Data.V_costomar_deal_installment;
                    var O_installment = new Data.installment
                    {
                        installment_id = res.installment_id,
                        deal_id = res.deal_id,
                        delay_Days = res.delay_Days,
                        installment_condition = res.installment_condition,
                        Remaining_amount = res.Remaining_amount,
                        Worthy_amount = res.Worthy_amount,
                        Collectedvalue = res.Collectedvalue,
                        installmedntColor = res.installmedntColor,
                        InstallmentDueDate = res.InstallmentDueDate,
                        InstallmentPaymentDate = res.InstallmentPaymentDate,
                        list_Down_visible = res.list_Down_visible,
                    };

                    if (O_installment != null)
                    {
                        O_installment.InstallmentDueDate = O_installment.InstallmentDueDate.AddMonths(1);
                        var Update_Res = await o_dataservices.Update_installment(O_installment);
                        if (Update_Res == 1)
                        {
                            MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");
                            IMessage_ShortAlert("تم الاعفاء من القسط الحالى والمطالبه بالقسط فى معاد الاستحقاق القادم ");
                        }
                        else
                        {
                            Eventalert("حدث خطأ اثناء تحديث بينات القسط ");
                        }

                    }
                    else
                    {
                        Eventalert(" خطأ اثناء تحديث بينات القسط ");
                    }
                });
            }
        }
        public Command delay_installment_Command
        {
            get
            {
                return new Command(async (opj) =>
                {

                    var o_dataservices = new DealService();
                    var res = opj as Data.V_costomar_deal_installment;
                    var O_Deal = new Data.deal
                    {
                        deal_id = res.deal_id,
                        product_given = res.product_given,
                        Start_Date = res.Start_Date,
                        product_Price = res.product_Price,
                        payment_Day = res.payment_Day,
                        product_Name = res.product_Name,
                        costomar_id = res.costomar_id,
                        group_id = res.group_id,
                        funds_id = res.funds_id,
                        dealColor = res.dealColor,
                        group_Name = res.group_Name,
                        installment_amount = res.installment_amount,
                        selcet_month = res.selcet_month,
                        remainder = res.remainder,
                        Total_installment = res.Total_installment,
                        Pons_installment = res.Pons_installment,
                        Total_Paid = res.Total_Paid,
                        Total_Remaining = res.Total_Remaining,
                        pocketMoney_id = res.pocketMoney_id,
                        remaining_installments = res.remaining_installments,
                        paid_installments = res.paid_installments,
                        Deal_condition = res.Deal_condition,
                        Total_Saved = res.Total_Saved,
                    };
                    var O_installment = new Data.installment
                    {
                        installment_id = res.installment_id,
                        deal_id = res.deal_id,
                        Collectedvalue = res.Collectedvalue,
                        installmedntColor = res.installmedntColor,
                        InstallmentDueDate = res.InstallmentDueDate,
                        InstallmentPaymentDate = res.InstallmentPaymentDate,
                        list_Down_visible = res.list_Down_visible,
                        delay_Days = res.delay_Days,
                        installment_condition = res.installment_condition,
                        Remaining_amount = res.Remaining_amount,
                        Worthy_amount = res.Worthy_amount,
                    };

                    if (O_installment != null & O_Deal != null)
                    {
                        O_Deal.paid_installments = O_Deal.paid_installments + 1;
                        var s = O_Deal.remaining_installments - 1;
                        O_Deal.remaining_installments = O_Deal.remaining_installments - 1;

                        if (O_Deal.remaining_installments >= 1)
                        {

                            O_installment.InstallmentDueDate = O_installment.InstallmentDueDate.AddMonths(1);
                            O_installment.Collectedvalue += O_Deal.installment_amount;
                            //الاصول اللون بردو يتغير 

                            var Update_Deal_Res = await o_dataservices.Update_Deal(O_Deal);
                            var Update_installment_Res = await o_dataservices.Update_installment(O_installment);
                            if (Update_installment_Res == 1 & Update_Deal_Res == 1)
                            {
                                MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");
                                IMessage_ShortAlert("تم تاجيل القسط الى معاد الاستحقاق القادم ");
                            }
                            else
                            {
                                Eventalert("حدث خطأ اثناء تحديث بينات الصفقه ");
                            }
                        }
                        else
                        {
                            Eventalert("لا يمكن تاجيل القسط الحالى حيث انه اخر قسط فى هذه الصفقه ");
                            //فاضل قسط واحد 
                        }


                    }
                    else
                    {
                        Eventalert(" خطأ اثناء تحديث بينات الصفقه ");
                    }



                });
            }
        }
        #endregion
        #region Creat Deal ---



        public Command Creat_Deal_command
        {
            get
            {
                return new Command(async () =>
                {
                    var No_Erorr = 0;
                    var No_Deal_Erorr = 0;
                    Nullable<int> O_pocketMoney_id = null;
                    int O_Deal_id = -1;
                    if (VM_Creat_Deal_Prodect_Name == null)
                    {
                        Massage = "من فضلك أدخل أسم المنتج";
                        Eventalert(Massage);


                    }
                    else if (VM_Creat_Deal_ItemData_costomar_Name == null)
                    {
                        Massage = "من فضلك اختر العميل";
                        Eventalert(Massage);
                    }
                    else if (VM_Creat_Deal_Start_Date == null)
                    {
                        Massage = "من فضلك اختر تاريخ بداية التعاقد";
                        Eventalert(Massage);
                    }
                    else if (VM_Creat_Deal_paymentDay == "اختر يوم دفع القسط")
                    {
                        Massage = "من فضلك أختر يوم استحقاق القسط كل شهر";
                        Eventalert(Massage);
                    }
                    else if (FundsItemSlect == "أختر حساب" && Debt_name_pickerBtn == "أختر الدائن" && VM_Creat_Deal_new_Debt_Name == null)
                    {

                        if (Debt_name_pickerBtn == "أختر الدائن" && VM_Creat_Deal_new_Debt_Name == null)
                        {
                            if (VM_Creat_Deal_new_Debt_Name == null)
                            {
                                Massage = "من فضلك أدخل طريقه دفع إما كاش او دين ";
                                Eventalert(Massage);
                            }
                            else
                            {
                                Massage = "من فضلك أدخل طريقه دفع إما كاش او دين ";
                                Eventalert(Massage);
                            }

                        }
                        else
                        {
                            Massage = "من فضلك أدخل طريقه دفع إما كاش او دين ";
                            Eventalert(Massage);
                        }
                    }
                    else
                    {
                        var o_fundsServices = new fundsService();
                        var O_FundsData = o_fundsServices.GetFundsbyname(FundsItemSlect).Result;
                        #region إنشاء او اختيار دين 
                        if (VM_Creat_Deal_new_Debt_Name != null || Debt_name_pickerBtn != "أختر الدائن")
                        {
                            if (VM_Creat_Deal_new_Debt_Name != null)
                            {
                                // هنا بانشا دين جديد
                                var o_DebtService = new DebtService();
                                var debt_Detail_Sum = await o_DebtService.GetDebtBydebtorName("Sum", VM_Creat_Deal_new_Debt_Name);
                                var Debt_Notes_msg = "تم إضافه دين بقيمه :- " + VM_Creat_Deal_remainder + " عند إنشاء صفقه للعميل  / " + VM_Creat_Deal_ItemData_costomar_Name + " فى المنتج : - " + VM_Creat_Deal_Prodect_Name;
                                if (debt_Detail_Sum == null)
                                {
                                    DateTime oDate = Convert.ToDateTime(VM_Creat_Deal_Start_Date);
                                    if (oDate != null) { Debt_date = oDate; }
                                    var O_debt_New = new Data.debt
                                    {
                                        amount = Convert.ToInt32(VM_Creat_Deal_remainder),

                                        date = Debt_date,
                                        debtorName = VM_Creat_Deal_new_Debt_Name,
                                        Notes = Debt_Notes_msg,
                                        DebtCondition = "New",
                                    };
                                    var O_debt_Sum = new Data.debt
                                    {
                                        amount = Convert.ToInt32(VM_Creat_Deal_remainder),

                                        date = Debt_date,
                                        debtorName = VM_Creat_Deal_new_Debt_Name,
                                        Notes = Debt_Notes_msg,
                                        DebtCondition = "Sum",
                                    };
                                    int New_result = await o_DebtService.Createdebt(O_debt_New);
                                    int Sum_result = await o_DebtService.Createdebt(O_debt_Sum);
                                    if (New_result > 0 && Sum_result > 0)
                                    {
                                        MessagingCenter.Send("Adddebt", "UbdateListView", "Success");
                                        No_Erorr = 1;
                                    }

                                }
                                else
                                {
                                    Massage = "هذا الدائن مسجل من قبل , من فضلك ادخل اسم دائن جديد";
                                    Eventalert(Massage);
                                }
                            }

                            if (Debt_name_pickerBtn != "أختر الدائن")
                            {
                                //هنا هختار دين موجود واعدل عليه 
                                var o_DebtService = new DebtService();
                                var o_Debt_Data = await o_DebtService.GetDebtBydebtorName("Sum", Debt_name_pickerBtn);
                                var Debt_Notes_msg = "تم إضافه دين بقيمه :- " + VM_Creat_Deal_remainder + " عند إنشاء صفقه للعميل  / " + VM_Creat_Deal_ItemData_costomar_Name + " فى المنتج : - " + VM_Creat_Deal_Prodect_Name;
                                if (o_Debt_Data != null)
                                {
                                    DateTime oDate = Convert.ToDateTime(VM_Creat_Deal_Start_Date);
                                    if (oDate != null) { Debt_date = oDate; }
                                    var O_debt_Sum = new Data.debt
                                    {
                                        debt_id = o_Debt_Data.debt_id,
                                        productname = o_Debt_Data.productname,
                                        //deal_id = o_Debt_Data.deal_id,
                                        amount = o_Debt_Data.amount + Convert.ToInt32(VM_Creat_Deal_remainder),
                                        date = Debt_date,
                                        debtorName = o_Debt_Data.debtorName,
                                        Notes = o_Debt_Data.Notes,
                                        DebtCondition = "Sum",
                                    };
                                    var O_debt_New = new Data.debt
                                    {
                                        amount = Convert.ToInt32(VM_Creat_Deal_remainder),
                                        date = Debt_date,
                                        debtorName = o_Debt_Data.debtorName,
                                        Notes = Debt_Notes_msg,
                                        DebtCondition = "New",
                                    };
                                    int New_result = await o_DebtService.Createdebt(O_debt_New);
                                    int Sum_result = await o_DebtService.Updatedebt(O_debt_Sum);
                                    if (New_result > 0 && Sum_result > 0)
                                    {
                                        MessagingCenter.Send("UbdateSumDebt", "UbdateListView", "Success");
                                        No_Erorr = 1;
                                    }
                                    else
                                    {
                                        Massage = "حدث خطأ أثناء إختيار الدائن";
                                        Eventalert(Massage);
                                    }
                                }

                            }

                        }


                        #endregion

                        #region انشاء خارج خذنه 
                        try
                        {

                            if (O_FundsData != null)
                            {

                                pocketMoney_funds_id = O_FundsData.funds_id;
                                pocketMoney_Note = "تم سحب مبلغ بقيمه :- " + VM_Creat_Deal_remainder + "من الخذنه :- " + O_FundsData.name + " عند إنشاء صفقه للعميل  / " + VM_Creat_Deal_ItemData_costomar_Name + " فى المنتج : - " + VM_Creat_Deal_Prodect_Name;
                                var pocketMoneydata = new Data.pocketMoney
                                {
                                    pocketMoney_name = VM_Creat_Deal_ItemData_costomar_Name,
                                    amount = Convert.ToInt32(VM_Creat_Deal_remainder),
                                    withdrawalDate = Convert.ToDateTime(VM_Creat_Deal_Start_Date),
                                    Note = pocketMoney_Note,
                                    Money_Condition = "out",
                                    funds_id = pocketMoney_funds_id
                                };

                                var fundsdata = new Data.funds
                                {
                                    funds_id = O_FundsData.funds_id,
                                    name = O_FundsData.name,
                                    main_funds = O_FundsData.main_funds,
                                    fundsBalance = O_FundsData.fundsBalance - pocketMoneydata.amount
                                };

                                var fundsRes = o_fundsServices.Updatefunds(fundsdata).Result;
                                if (fundsRes > 0)
                                {
                                    var o_pocketMoneyservices = new pocketMoneyService();
                                    int result = await o_pocketMoneyservices.CreatepocketMoney(pocketMoneydata);
                                    if (result > 0)
                                    {

                                        MessagingCenter.Send("AddpocketMoney", "UbdateListView", "Success");
                                        var O_specific_pocketMoney = await o_pocketMoneyservices.Get_specific_pocketMoney(pocketMoneydata.pocketMoney_name, pocketMoneydata.Note, pocketMoneydata.Money_Condition, pocketMoneydata.amount);
                                        if (O_specific_pocketMoney != null) { O_pocketMoney_id = O_specific_pocketMoney.pocketMoney_id; }
                                        No_Erorr = 1;
                                    }
                                }
                                else
                                {
                                    Massage = " لم يتم سحب اى مبلغ من الخذنه  ";
                                    Eventalert(Massage);
                                }
                            }

                        }


                        catch
                        {
                            Massage = " خطأ .... لم يتم سحب اى مبلغ من الخذنه  ";
                            Eventalert(Massage);
                        }

                        #endregion

                        #region انشاء الصفقه
                        if (No_Erorr == 1)
                        {
                            Nullable<int> o_funds_id = null;
                            if (O_FundsData != null)
                            {
                                o_funds_id = O_FundsData.funds_id;
                            }
                            var Dealdata = new Data.deal
                            {
                                product_given = Convert.ToInt32(VM_Creat_Deal_given),
                                Start_Date = Convert.ToDateTime(VM_Creat_Deal_Start_Date),
                                product_Price = Convert.ToInt32(VM_Creat_Deal_price),
                                payment_Day = VM_Creat_Deal_paymentDay,
                                product_Name = VM_Creat_Deal_Prodect_Name,
                                installment_amount = Convert.ToInt32(VM_Creat_Deal_qast),
                                selcet_month = VM_Creat_Deal_selcet_month,
                                remainder = Convert.ToInt32(VM_Creat_Deal_remainder),
                                Total_installment = Convert.ToInt32(VM_Creat_Deal_Total_installment),
                                Pons_installment = Convert.ToInt32(VM_Creat_Deal_Pons_installment),
                                funds_id = o_funds_id,
                                pocketMoney_id = O_pocketMoney_id,
                                group_id = Convert.ToInt32(VM_Creat_Deal_group_id),
                                group_Name = Settings.Creat_Deal_group_name,
                                costomar_id = Convert.ToInt32(VM_Creat_Deal_ItemData_costomar_id),
                                Total_Paid = 0,
                                Total_Remaining = Convert.ToInt32(VM_Creat_Deal_remainder),
                                paid_installments = 0,
                                remaining_installments = Convert.ToInt32(VM_Creat_Deal_selcet_month),
                                Total_Saved = "0",
                                Deal_condition = false,


                            };
                            var o_dataservices = new DealService();
                            var res = await o_dataservices.CreateDeal(Dealdata);
                            if (res != 0)
                            {
                                No_Deal_Erorr = 1;
                                O_Deal_id = await o_dataservices.GetLastDealId();
                                //تم انشاء صفقه وهنا الاول انشاء قسط 
                            }
                            else
                            {
                                Massage = "لم يتم إنشاء صفقه جديدا من فضلك راجع البينات المدخله";
                                Eventalert(Massage);
                            }
                        }
                        #endregion

                        #region انشاء قسط
                        if (No_Deal_Erorr == 1 && O_Deal_id != -1)
                        {
                            var o_dataservices = new DealService();
                            int o_installment_id = await o_dataservices.Get_last_id_installment(O_Deal_id);
                            var start_day = Convert.ToDateTime(VM_Creat_Deal_Start_Date);
                            var payDay = VM_Creat_Deal_paymentDay;
                            var o_installmedntColor = Color.FromRgb(180, 255, 180);
                            string Color_Hex = o_installmedntColor.ToHex();

                            var installment = new Data.installment
                            {
                                deal_id = O_Deal_id,
                                InstallmentDueDate = Convert.ToDateTime(payDay),
                                Worthy_amount = Convert.ToInt32(VM_Creat_Deal_qast),
                                list_Down_visible = false,
                                installment_id = 1,
                                installment_condition = false,
                                delay_Days = "0",
                                installmedntColor = Color_Hex.Remove(1, 2),
                                //InstallmentPaymentDate

                                //الاصول يكون فى القيمه المستحقه والقيمه المدفوعه فى القسط 
                            };
                            o_dataservices = new DealService();
                            var res = await o_dataservices.Create_installment(installment);
                            if (res != 0)
                            {
                                Massage = "تم إنشاء صفقه بنجاح";
                                IMessage_LongAlert(Massage);

                                MessagingCenter.Send("Addinstallment", "UbdateListView", "Success");

                                await App.Current.MainPage.Navigation.PushAsync(new Views.installment());
                            }
                            else
                            {
                                Massage = "حدث خطا عند انشاء اقساط الصفقه";
                                Eventalert(Massage);
                            }
                        }
                        else
                        {
                            Massage = "حدث خطا عند انشاء صفقه";
                            Eventalert(Massage);
                        }
                    }

                }
                );
            }
        }

        public Command nav_deal_installment_dital_Command
        {
            get
            {
                return new Command(async (opj) =>
                {
                    var o_dataservices = new DealService();

                    var o_costomar_deal_installment = opj as Data.V_costomar_deal_installment;
                    Dital_Deal_Data = o_costomar_deal_installment;
                    Settings.Dital_deal_id = Dital_Deal_Data.deal_id;
                    Settings.Dital_installment_id = Dital_Deal_Data.installment_id;
                    Settings.Dital_Costomar_id = Dital_Deal_Data.costomar_id;


                    await App.Current.MainPage.Navigation.PushAsync(new Views.DetailReport());

                });


            }
        }

        public Command nav_deal_CostomarDetail_Command
        {
            get
            {
                return new Command(async (opj) =>
                {
                    var o_dataservices = new DealService();

                    var o_costomar_deal_installment = opj as Data.V_costomar_deal_installment;
                    Dital_Deal_Data = o_costomar_deal_installment;
                    Settings.Dital_Costomar_id = Dital_Deal_Data.costomar_id;

                    await App.Current.MainPage.Navigation.PushAsync(new Views.CostomarDetail());

                });


            }
        }


        public async void get_Deal_Detail_Data()
        {
            var O_DataServices = new DealService();
            if (Settings.Dital_deal_id != -1 && Settings.Dital_installment_id != -1 && Settings.Dital_Costomar_id != -1)
            {
                var O_Dital_Deal_Data = await O_DataServices.Get_Dital_costomar_deal_installment(Settings.Dital_deal_id, Settings.Dital_installment_id, Settings.Dital_Costomar_id);
                if (O_Dital_Deal_Data != null)
                {
                    Dital_Deal_Data = O_Dital_Deal_Data;
                }

                var O_installments_by_Deal_id = O_DataServices.Get_installments_by_Deal_id(Settings.Dital_deal_id).Result;
                if (O_installments_by_Deal_id != null)
                {
                    pay_installment_List = O_installments_by_Deal_id;
                }

            }

        }

        /// <summary>
        /// //
        /// </summary>
        public Command nav_to_Creat_Deal_page
        {
            get
            {
                return new Command(async () =>
                {

                    if (VM_Creat_Deal_group_id == "0" || VM_Creat_Deal_group_id == null || VM_Creat_Deal_group_id == "" || VM_Creat_Deal_group_id == "المجموعة")
                    {
                        var msg = "من فضللك أختر مجموعه";
                        Eventalert(msg);
                    }
                    else if (VM_Creat_Deal_price == "0" || VM_Creat_Deal_price == null || VM_Creat_Deal_price == "")
                    {
                        var msg = "من فضللك ادخل سعر المنتج";
                        Eventalert(msg);
                    }
                    else if (VM_Creat_Deal_given == "0" || VM_Creat_Deal_given == null || VM_Creat_Deal_given == "")
                    {
                        var msg = "من فضللك ادخل مبلغ المقدم  ";
                        Eventalert(msg);
                    }
                    else if (VM_Creat_Deal_selcet_month == "0" || VM_Creat_Deal_selcet_month == null || VM_Creat_Deal_selcet_month == "" || VM_Creat_Deal_selcet_month == "عدد الأشهر")
                    {
                        var msg = "من فضللك أختر عدد الشهور";
                        Eventalert(msg);
                    }
                    else
                    {
                        Settings.Creat_Deal_group_id = Convert.ToInt32(VM_Creat_Deal_group_id);
                        Settings.Creat_Deal_price = Convert.ToInt32(VM_Creat_Deal_price);
                        Settings.Creat_Deal_given = Convert.ToInt32(VM_Creat_Deal_given);
                        Settings.Creat_Deal_selcet_month = Convert.ToInt32(VM_Creat_Deal_selcet_month);
                        Settings.Creat_Deal_remainder = Convert.ToInt32(VM_Creat_Deal_remainder);
                        Settings.Creat_Deal_Total_installment = Convert.ToInt32(VM_Creat_Deal_Total_installment);
                        Settings.Creat_Deal_Pons_installment = Convert.ToInt32(VM_Creat_Deal_Pons_installment);
                        Settings.Creat_Deal_qast = Convert.ToInt32(VM_Creat_Deal_qast);
                        Settings.Creat_Deal_group_name = VM_Creat_Deal_group_name;


                        Settings.Creat_Deal_ItemData_costomar_id = 0;
                        Settings.Creat_Deal_ItemData_costomar_Name = "";
                        Settings.Creat_Deal_Prodect_Name = "";

                        //string d = DateTime.Now.ToString(); 
                        var c = DateTime.Now;
                        string d = String.Format("{0:yyyy/MM/dd}", c);
                        Settings.Creat_Deal_Start_Date = d;
                        Settings.Creat_Deal_paymentDay = "اختر يوم دفع القسط";

                        Settings.Creat_Deal_Ceack = 1;


                        await App.Current.MainPage.Navigation.PushAsync(new Views.CreateDeal());

                    }

                }
            );
            }
        }


        public Command costomarSearchItemTappedComand
        {
            get
            {
                return new Command(async (obj) =>
                {

                    var O_DataServices = new CostomerService();
                    var costomarItemData = obj as Data.costomar;




                    if (costomarItemData != null)
                    {
                        var msg = "هل أنت  تريد اختيار العميل  " + costomarItemData.name;
                        var res = await App.Current.MainPage.DisplayAlert("عزيزى العميل", msg, "حسنا", "إلغاء");
                        if (res == true)
                        {
                            Settings.Creat_Deal_ItemData_costomar_id = costomarItemData.costomar_id;
                            Settings.Creat_Deal_ItemData_costomar_Name = costomarItemData.name;
                            Settings.Creat_Deal_Ceack = 1;
                            await App.Current.MainPage.Navigation.PushAsync(new Views.CreateDeal());
                        }
                    }
                    else
                    {
                        var msg = "هنالك خطأ فى أختيار العميل ";
                        await App.Current.MainPage.DisplayAlert("عزيزى المدير", msg, "حسنا");
                    }



                }
                );
            }
        }


        public Command Nav_To_CostomarSearch_Command
        {
            get { return new Command(async () => {
                if (VM_Creat_Deal_Prodect_Name != null)
                {
                    Settings.Creat_Deal_Prodect_Name = VM_Creat_Deal_Prodect_Name;
                }
                await App.Current.MainPage.Navigation.PushAsync(new Views.CostomarSearch()); }); }
        }

        #endregion
        #endregion
        #endregion

        #region funds ********


        #region funds Data 

        #region Creat funds properties ------------------------------------------
        public string funds_name { get; set; }
        public string main_funds_lable { get; set; }
        public decimal funds_fundsBalance { get; set; }

        #endregion


        #region Edit funds properties ------------------------------------------

        public int Edit_funds_id { get; set; }
        public string Edit_funds_name { get; set; }
        public decimal Edit_funds_fundsBalance { get; set; }

        #endregion



        private List<Data.funds> _funds;

        public List<Data.funds> Funds
        {
            get { return _funds; }

            set
            {
                _funds = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Funds"));
                    OnPropertyChanged();
                }
            }


        }

        private Data.funds _fundsDital;

        public Data.funds FundsDital
        {
            get { return _fundsDital; }

            set
            {
                _fundsDital = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FundsDital"));
                    OnPropertyChanged();
                }
            }


        }


        private decimal _fundsTotalMount;

        public decimal FundsTotalMount
        {
            get { return _fundsTotalMount; }

            set
            {
                _fundsTotalMount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FundsTotalMount"));
                    OnPropertyChanged();
                }
            }


        }
        #endregion


        #region fundsDataMethod&Command 
        public Command PostfundsComand
        {
            get
            {
                return new Command(async () =>
                {
                    var main_funds_bool = false;
                    if (main_funds_lable == "1")
                    {
                        main_funds_bool = true;
                    }
                    var fundsdata = new Data.funds
                    {
                        name = funds_name,
                        fundsBalance = funds_fundsBalance,
                        main_funds = main_funds_bool,//هنا احط قيمه الخزنه الرئسيه
                    };
                    var o_FundsDataservices = new fundsService();

                    if (fundsdata.name == null)
                    {
                        Massage = "برجاء إدخال أسم المحفظة";
                        Eventalert(Massage);

                    }
                    else if (fundsdata.fundsBalance == 0)
                    {
                        Massage = "برجاء إدخال قيمة راس المال";
                        Eventalert(Massage);
                    }
                    else
                    {

                        var main_funds = await o_FundsDataservices.Get_main_funds(fundsdata.main_funds);
                        if (main_funds == null)
                        {
                            int result = await o_FundsDataservices.CreateFunds(fundsdata);
                            if (result > 0)
                            {
                                Massage = "تم إنشاء محفظة جديده بنجاح";

                                MessagingCenter.Send("AddFunds", "UbdateListView", "Success");

                                Eventalert(Massage);


                                await PopupNavigation.Instance.PopAsync(false);

                            }
                            else
                            {
                                Massage = "لم يتم إنشاء محفظة جديده ";
                                Eventalert(Massage);
                            }
                        }
                        else
                        {
                            Massage = "لا يمكن إنشاء اكثر من خزنه رئيسيه واحدة ";
                            Eventalert(Massage);
                        }

                    }
                    var x = 5;
                }
            );
            }
        }


        public Command UpdatefundsComand
        {
            get
            {
                return new Command(async () =>
                {
                    var fundsdata = new Data.funds
                    {

                        funds_id = Edit_funds_id,
                        name = Edit_funds_name,
                        //   هنا الاصول اضيف دى  main_funds = 
                        fundsBalance = Edit_funds_fundsBalance
                    };
                    var o_FundsDataservices = new fundsService();
                    var result = await o_FundsDataservices.Updatefunds(fundsdata);
                    if (result > 0)
                    {
                        Massage = "تم تعديل المحفظة  بنجاح";

                        MessagingCenter.Send("UpdateFunds", "UbdateListView", "Success");

                        Eventalert(Massage);
                        await PopupNavigation.Instance.PopAsync(false);
                    }
                    else
                    {
                        Massage = "لم يتم تعديل المحفظة ";
                        Eventalert(Massage);
                    }

                    var x = 5;

                }




            );
            }
        }

        //  لازم اتاكد ان المحفظة ددى غير مرتبطة باى جدول تانى 

        public Command DleateFundsItemComand
        {
            get
            {


                return new Command(async (object obj) =>
                {
                    var o_FundsDataservices = new fundsService();
                    var fundsItemData = obj as Data.funds;
                    if (fundsItemData.fundsBalance != 0)
                    {
                        Massage = "لازم تسحب الفلوس الى فى الخزنة الاول او عدل قيمتها الى 0";

                        Eventalert(Massage);
                    }
                    else
                    {
                        var msg = "هل تريد حذف شنطة :-  " + fundsItemData.name;
                        bool dleateconfirm = await App.Current.MainPage.DisplayAlert("عزيزى العميل", msg, "نعم", "رجوع");
                        if (dleateconfirm == true)
                        {
                            var res = await o_FundsDataservices.DleateFunds(fundsItemData);
                            if (res > 0)
                            {
                                Massage = "تم حذف محفظة او شنطة بنجاح";

                                Eventalert(Massage);

                                MessagingCenter.Send("DleateFunds", "UbdateListView", "Success");
                                //await PopupNavigation.Instance.PushAsync(new Views.UpdateWallet());
                            }
                            else if (fundsItemData.funds_id == 0)
                            {
                                var x = 0;
                            }
                            else
                            {
                                Massage = "خطأ فى الارسال";

                                Eventalert(Massage);
                            }
                        }
                        else { var x = 5; }
                    }




                    //  await App.Current.MainPage.Navigation.PushAsync(new CostomarDetail());

                }

            );
            }
        }

        //public async void getfundsTotal_fundsBalance()
        //{

        //    var o_FundsDataservices = new fundsService();

        //    var FundsIndexNum = await o_FundsDataservices.GetTotalfundsBalance();
        //    FundsTotalMount = FundsIndexNum;
        //    var x = 0;
        //    //var FristId = o_FundsDataservices.GetFristFundsId().Result;
        //    //for (int i = FristId; i <= FundsIndexNum; i++)
        //    //{
        //    //    var o_Funds = await o_FundsDataservices. (i);
        //    //    FundsTotalMount += o_Funds.fundsBalance;
        //    //}

        //}

        public Command FundsItemTappedComand
        {
            get
            {
                return new Command(async (object obj) =>
                {
                    var o_FundsDataservices = new fundsService();
                    var fundsItemData = obj as Data.funds;
                    Settings.fundsID = fundsItemData.funds_id;
                    var fundsdata = await o_FundsDataservices.GetfundsDital(fundsItemData.funds_id);
                    if (fundsdata != null)
                    {
                        FundsDital = fundsdata;
                        Edit_funds_id = fundsdata.funds_id;
                        Edit_funds_name = fundsdata.name;
                        Edit_funds_fundsBalance = fundsdata.fundsBalance;
                        await PopupNavigation.Instance.PushAsync(new Views.UpdateWallet());
                    }
                    else if (fundsItemData.funds_id == 0)
                    {
                        var x = 0;
                    }
                    else
                    {
                        Massage = "خطأ فى الارسال";

                        Eventalert(Massage);
                    }

                    //  await App.Current.MainPage.Navigation.PushAsync(new CostomarDetail());

                }

            );
            }
        }


        public async void getfundsDetailData()
        {
            var O_fundsServices = new fundsService();
            var fundsdata = await O_fundsServices.GetfundsDital(Settings.fundsID);
            if (fundsdata != null)
            {
                FundsDital = fundsdata;
                Edit_funds_id = fundsdata.funds_id;
                Edit_funds_name = fundsdata.name;
                Edit_funds_fundsBalance = fundsdata.fundsBalance;

            }
            else if (Settings.fundsID == 0)
            {
                var x = 0;
            }
            else
            {
                Massage = "خطأ فى الارسال";

                Eventalert(Massage);
            }
        }

        #endregion

        #endregion

        #region pocketMoney ********


        #region pocketMoney Data 

        #region Creat pocketMoney properties ------------------------------------------        
        public string pocketMoney_name { get; set; }
        public string pocketMoney_name_pickerBtn { get; set; }
        public int pocketMoney_amount { get; set; }
        public DateTime pocketMoney_withdrawalDate { get; set; }
        public string pocketMoney_Note { get; set; }
        public int pocketMoney_funds_id { get; set; }
        public string pocketMoney_Money_Condition { get; set; }


        #endregion


        #region Edit pocketMoney properties ------------------------------------------

        public int Edit_pocketMoney_id { get; set; }
        public string Edit_pocketMoney_pocketMoney_name { get; set; }
        public int Edit_pocketMoney_amount { get; set; }
        public DateTime Edit_pocketMoney_withdrawalDate { get; set; }
        public string Edit_pocketMoney_Note { get; set; }
        public int Edit_pocketMoney_funds_id { get; set; }
        public string Edit_pocketMoney_Money_Condition { get; set; }
        #endregion





        public List<Data.V_pocketMoney_funds> List_Pocket_Money { get; set; }
        public List<Data.V_pocketMoney_funds> List_out_Money { get; set; }

        private Data.pocketMoney _pocketMoneyDital;

        public Data.pocketMoney PocketMoneyDital
        {
            get { return _pocketMoneyDital; }

            set
            {
                _pocketMoneyDital = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PocketMoneyDital"));
                    OnPropertyChanged();
                }
            }
        }
        public decimal outMoneyTotal_Mount { get; set; }

        private List<string> _listpocketMoney_Name;

        public List<string> ListPocketMoney_Name
        {
            get { return _listpocketMoney_Name; }

            set
            {
                _listpocketMoney_Name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ListPocketMoney_Name"));
                    OnPropertyChanged();
                }
            }
        }


        private bool _pocketMoney_picker_Entry_show;
        public bool PocketMoney_picker_Entry_show
        {
            get { return _pocketMoney_picker_Entry_show; }

            set
            {
                _pocketMoney_picker_Entry_show = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PocketMoney_picker_Entry_show"));
                    OnPropertyChanged();
                }
            }


        }


        private bool _pocketMoney_picker_Btn_show;
        public bool PocketMoney_picker_Btn_show
        {
            get { return _pocketMoney_picker_Btn_show; }

            set
            {
                _pocketMoney_picker_Btn_show = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PocketMoney_picker_Btn_show"));
                    OnPropertyChanged();
                }
            }


        }


        private decimal _pocketMoneyTotal_Mount;
        public decimal PocketMoneyTotal_Mount
        {
            get { return _pocketMoneyTotal_Mount; }

            set
            {
                _pocketMoneyTotal_Mount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PocketMoneyTotal_Mount"));
                    OnPropertyChanged();
                }
            }


        }



        private string _pocketMoneyTotal_Name;
        public string PocketMoneyTotal_Name
        {
            get { return _pocketMoneyTotal_Name; }

            set
            {
                _pocketMoneyTotal_Name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("_pocketMoneyTotal_Name"));
                    OnPropertyChanged();
                }
            }


        }


        private string _pocketMoneyDate_picker;
        public string PocketMoneyDate_picker
        {
            get { return _pocketMoneyDate_picker; }

            set
            {
                _pocketMoneyDate_picker = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PocketMoneyDate_picker"));
                    OnPropertyChanged();
                }
            }


        }
        #endregion

        #region pocketMoney_Method_&_Command 
        public Command PostpocketMoneyComand
        {
            get
            {
                return new Command(async () =>
                {
                    if (ListPocketMoney_Name == null)
                    {
                        if (pocketMoney_name == null)
                        {
                            Massage = "برجاء إدخال سبب سحب المبلغ";
                            Eventalert(Massage);
                        }
                    }
                    else if (PocketMoney_picker_Entry_show == true && ListPocketMoney_Name.Find(o => o.Contains(pocketMoney_name)) != null)
                    {
                        Massage = "برجاء أختر سبب سحب المبلغ";
                        Eventalert(Massage);

                        PocketMoney_picker_Entry_show = false;
                        PocketMoney_picker_Btn_show = true;


                    }

                    else if (PocketMoney_picker_Entry_show == true && pocketMoney_name == null)
                    {
                        Massage = "برجاء أدخل سبب سحب المبلغ";
                        Eventalert(Massage);
                    }
                    else if (PocketMoney_picker_Btn_show == true && pocketMoney_name_pickerBtn == "أختر البيان")
                    {
                        Massage = "برجاء أختر سبب سحب المبلغ";
                        Eventalert(Massage);
                    }
                    else if (FundsItemSlect == "أختر حساب")
                    {
                        Massage = "برجاء أختر حساب ";
                        Eventalert(Massage);
                    }
                    else if (pocketMoney_amount == 0)
                    {
                        Massage = "برجاء إدخال قيمة المبلغ المسحوب";
                        Eventalert(Massage);
                    }
                    else if (PocketMoneyDate_picker == null)
                    {
                        Massage = "برجاء إدخال تاريخ السحب";
                        Eventalert(Massage);
                    }
                    else
                    {
                        try
                        {

                            var o_fundsServices = new fundsService();
                            var O_FundsData = o_fundsServices.GetFundsbyname(FundsItemSlect).Result;
                            if (O_FundsData != null) { pocketMoney_funds_id = O_FundsData.funds_id; } else pocketMoney_funds_id = 0;

                            DateTime oDate = Convert.ToDateTime(PocketMoneyDate_picker);
                            if (oDate != null) { pocketMoney_withdrawalDate = oDate; }
                            if (pocketMoney_name == null) { pocketMoney_name = pocketMoney_name_pickerBtn; }
                            var pocketMoneydata = new Data.pocketMoney
                            {
                                pocketMoney_name = pocketMoney_name,
                                amount = pocketMoney_amount,
                                withdrawalDate = pocketMoney_withdrawalDate,
                                Note = pocketMoney_Note,
                                Money_Condition = "pocket",
                                funds_id = pocketMoney_funds_id
                            };
                            if (O_FundsData.fundsBalance < pocketMoneydata.amount)
                            {
                                Massage = "خطأ :- قيمة السحب المدخله أعلى من راس المال المجوجود فى خزينة - " + O_FundsData.name;

                                Eventalert(Massage);


                            }
                            else
                            {
                                var fundsdata = new Data.funds
                                {

                                    funds_id = O_FundsData.funds_id,
                                    name = O_FundsData.name,
                                    main_funds = O_FundsData.main_funds,
                                    fundsBalance = O_FundsData.fundsBalance - pocketMoneydata.amount
                                };

                                var fundsRes = o_fundsServices.Updatefunds(fundsdata).Result;
                                if (fundsRes > 0)
                                {
                                    var o_pocketMoneyservices = new pocketMoneyService();

                                    int result = await o_pocketMoneyservices.CreatepocketMoney(pocketMoneydata);
                                    if (ListPocketMoney_Name == null)
                                    {
                                        ListPocketMoney_Name = new List<string>
                                    {
                                        pocketMoney_name,
                                    };
                                    }
                                    else { ListPocketMoney_Name.Add(pocketMoneydata.pocketMoney_name); }



                                    if (result > 0)
                                    {
                                        Massage = "تم سحب مبلغ :- " + pocketMoneydata.amount;

                                        MessagingCenter.Send("AddpocketMoney", "UbdateListView", "Success");



                                        Eventalert(Massage);


                                        await PopupNavigation.Instance.PopAsync(false);



                                    }
                                }
                                else
                                {
                                    Massage = "لم يتم سحب اى مبلغ  ";
                                    Eventalert(Massage);
                                }

                            }
                        }
                        catch
                        {
                            Massage = "خطأ .... لم يتم سحب اى مبلغ  ";
                            Eventalert(Massage);
                        }



                    }

                }
            );
            }
        }


        public Command PocketMoneySlectItemComand
        {
            get
            {
                return new Command(async (object obj) =>
                {
                    if (obj != null)
                    {
                        FundsItemSlect = obj as string;
                    }

                }

            );
            }
        }

        public Command PocketMoney_picker_show_Comand
        {
            get
            {
                return new Command(() =>
               {
                   PocketMoney_picker_Entry_show = true;
                   PocketMoney_picker_Btn_show = false;
               }
            );
            }
        }


        public Command Display_PocketMoney_Note_alert_Comand
        {
            get
            {
                return new Command(async (object obj) =>
                {
                    var t = obj as Data.V_pocketMoney_funds;

                    var titleMsg = t.pocketMoney_name + " :- " + t.amount.ToString();
                    var noteMsg = t.Note;
                    var Msg = titleMsg + "@" + noteMsg;
                    Msg = Msg.Replace("@", System.Environment.NewLine);
                    await App.Current.MainPage.DisplayAlert("ملاحظات ", Msg, "حسنا");

                    //var v = new Data.pocketMoney
                    //{
                    //    amount = t.amount,
                    //    funds_id = t.funds_id,
                    //    Note = t.Note,
                    //    pocketMoney_id = t.pocketMoney_id,
                    //    pocketMoney_name = t.pocketMoney_name,
                    //    withdrawalDate = t.withdrawalDate,
                    //};

                    //var o = new pocketMoneyService();
                    // var s = o.DleatepocketMoney(v).Result;
                    //if(s < 0) { var msg = "تم المسح بنجاح"; Eventalert(msg); }


                }
            );
            }
        }


        public Command DleateAll_PocketMoney
        {
            get
            {
                return new Command(async () =>
                {

                    var o = new pocketMoneyService();
                    var res = o.DleateallpocketMoney().Result;
                    if (res < 0)
                    {
                        var Msg = "تم مسح كل المصروفات";
                        ListPocketMoney_Name.Clear();
                        await App.Current.MainPage.DisplayAlert("ملاحظات ", Msg, "حسنا");
                        MessagingCenter.Send("AddpocketMoney", "UbdateListView", "Success");
                    }


                }
            );
            }
        }


        #endregion

        #endregion


        #region CapitalAddition ********

        #region CapitalAddition  Date

        #region CapitalAddition  Create Date 
        public int CapitalAddition_id { get; set; }

        public string CapitalAddition_name { get; set; }

        public DateTime CapitalAddition_additionDate { get; set; }

        public int CapitalAddition_amount { get; set; }

        public string CapitalAddition_Note { get; set; }

        public int CapitalAddition_funds_id { get; set; }
        #endregion


        private List<Data.CapitalAddition> _listCapitalAddition;

        public List<Data.CapitalAddition> ListCapitalAddition
        {
            get { return _listCapitalAddition; }

            set
            {
                _listCapitalAddition = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ListCapitalAddition"));
                    OnPropertyChanged();
                }
            }


        }

        private Data.CapitalAddition _capitalAdditionDital;

        public Data.CapitalAddition CapitalAdditionDital
        {
            get { return _capitalAdditionDital; }

            set
            {
                _capitalAdditionDital = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CapitalAdditionDital"));
                    OnPropertyChanged();
                }
            }


        }


        private string _capitalAdditionDate_picker;
        public string CapitalAdditionDate_picker
        {
            get { return _capitalAdditionDate_picker; }

            set
            {
                _capitalAdditionDate_picker = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CapitalAdditionDate_picker"));
                    OnPropertyChanged();
                }
            }


        }

        #endregion


        #region CapitalAddition _Method_&_Command 
        public Command PostCapitalAdditionComand
        {
            get
            {
                return new Command(async () =>
                {
                    if (FundsItemSlect == "أختر حساب")
                    {
                        Massage = "برجاء أختر حساب ";
                        Eventalert(Massage);
                    }
                    else if (CapitalAddition_amount == 0)
                    {
                        Massage = "برجاء إدخال قيمة المبلغ المضاف";
                        Eventalert(Massage);
                    }
                    else if (CapitalAdditionDate_picker == null)
                    {
                        Massage = "برجاء إدخال تاريخ الاضافة";
                        Eventalert(Massage);
                    }
                    else
                    {
                        var o_fundsServices = new fundsService();
                        var O_FundsData = o_fundsServices.GetFundsbyname(FundsItemSlect).Result;
                        if (O_FundsData != null) { CapitalAddition_funds_id = O_FundsData.funds_id; } else CapitalAddition_funds_id = 0;

                        DateTime oDate = Convert.ToDateTime(CapitalAdditionDate_picker);
                        if (oDate != null) { CapitalAddition_additionDate = oDate; }
                        var O_CapitalAddition = new Data.CapitalAddition
                        {
                            amount = CapitalAddition_amount,
                            additionDate = CapitalAddition_additionDate,
                            Note = CapitalAddition_Note,
                            funds_id = CapitalAddition_funds_id
                        };



                        var fundsdata = new Data.funds
                        {

                            funds_id = O_FundsData.funds_id,
                            name = O_FundsData.name,
                            main_funds = O_FundsData.main_funds,
                            fundsBalance = O_FundsData.fundsBalance + O_CapitalAddition.amount
                        };

                        var fundsRes = o_fundsServices.Updatefunds(fundsdata).Result;
                        if (fundsRes > 0)
                        {
                            MessagingCenter.Send("UpdateFunds", "UbdateListView", "Success");
                            var o_CapitalAdditionService = new CapitalAdditionService();

                            int result = await o_CapitalAdditionService.CreateCapitalAddition(O_CapitalAddition);
                            if (result > 0)
                            {
                                Massage = "تم إضافة مبلغ :- " + O_CapitalAddition.amount + " إلى الخزينه :-" + fundsdata.name;
                                MessagingCenter.Send("AddCapitalAddition", "UbdateListView", "Success");
                                Eventalert(Massage);
                                await PopupNavigation.Instance.PopAsync(false);
                            }
                        }
                        else
                        {
                            Massage = "لم يتم إضافة اى مبلغ  ";
                            Eventalert(Massage);
                        }

                    }



                    var x = 5;
                }
            );
            }
        }
        #endregion

        #endregion

        #region moneyTransfer ***********************
        #region moneyTransfer Data


        #region moneyTransfer Create
        public int moneyTransfer_funds_id_1 { get; set; }
        public int moneyTransfer_funds_id_2 { get; set; }
        public DateTime moneyTransfer_TransferDate { get; set; }

        public int moneyTransfer_amount { get; set; }

        public string moneyTransfer_Note { get; set; }
        #endregion

        private List<Data.moneyTransfer> _listmoneyTransfer;

        public List<Data.moneyTransfer> ListmoneyTransfer
        {
            get { return _listmoneyTransfer; }

            set
            {
                _listmoneyTransfer = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ListmoneyTransfer"));
                    OnPropertyChanged();
                }
            }


        }

        private Data.moneyTransfer _moneyTransferDital;

        public Data.moneyTransfer MoneyTransferDital
        {
            get { return _moneyTransferDital; }

            set
            {
                _moneyTransferDital = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MoneyTransferDital"));
                    OnPropertyChanged();
                }
            }


        }


        private string _moneyTransferDate_picker;
        public string MoneyTransferDate_picker
        {
            get { return _moneyTransferDate_picker; }

            set
            {
                _moneyTransferDate_picker = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MoneyTransferDate_picker"));
                    OnPropertyChanged();
                }
            }


        }

        private string _fundsItemSlect_one;
        public string FundsItemSlect_one
        {
            get { return _fundsItemSlect_one; }

            set
            {
                _fundsItemSlect_one = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FundsItemSlect_one"));
                    OnPropertyChanged();
                }
            }


        }

        private string _fundsItemSlect_Two;
        public string FundsItemSlect_Two
        {
            get { return _fundsItemSlect_Two; }

            set
            {
                _fundsItemSlect_Two = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FundsItemSlect_Two"));
                    OnPropertyChanged();
                }
            }


        }
        #endregion

        #region moneyTransfer Method Command 

        public Command PostCapitalmoneyTransferComand
        {
            get
            {
                return new Command(async () =>
                {
                    if (FundsItemSlect_one == "أختر حساب السحب")
                    {
                        Massage = "برجاء أختر حساب السحب ";
                        Eventalert(Massage);

                    }
                    else if (FundsItemSlect_Two == "أختر حساب الايداع")
                    {
                        Massage = "برجاء أختر حساب الايداع ";
                        Eventalert(Massage);

                    }
                    else if (moneyTransfer_amount == 0)
                    {
                        Massage = "برجاء إدخال قيمة مبلغ التحويل ";
                        Eventalert(Massage);
                    }
                    else if (MoneyTransferDate_picker == null)
                    {
                        Massage = "برجاء إدخال تاريخ التحويل";
                        Eventalert(Massage);
                    }
                    else
                    {
                        var o_fundsServices = new fundsService();
                        var O_FundsData_one = o_fundsServices.GetFundsbyname(FundsItemSlect_one).Result;
                        var O_FundsData_Two = o_fundsServices.GetFundsbyname(FundsItemSlect_Two).Result;
                        if (O_FundsData_one != null) { moneyTransfer_funds_id_1 = O_FundsData_one.funds_id; } else moneyTransfer_funds_id_1 = 0;
                        if (O_FundsData_Two != null) { moneyTransfer_funds_id_2 = O_FundsData_Two.funds_id; } else moneyTransfer_funds_id_2 = 0;
                        if (O_FundsData_one.fundsBalance < moneyTransfer_amount) { Massage = "المبلغ المراد سحبه أعلى من المبلغ المجود في حساب السحب"; Eventalert(Massage); }
                        else
                        {
                            DateTime oDate = Convert.ToDateTime(MoneyTransferDate_picker);
                            if (oDate != null) { moneyTransfer_TransferDate = oDate; }
                            var O_moneyTransfer = new Data.moneyTransfer
                            {
                                amount = moneyTransfer_amount,
                                funds_id_1 = moneyTransfer_funds_id_1,
                                funds_id_2 = moneyTransfer_funds_id_2,
                                TransferDate = moneyTransfer_TransferDate,
                                Note = moneyTransfer_Note,
                            };



                            var fundsdata_one = new Data.funds
                            {

                                funds_id = O_FundsData_one.funds_id,
                                name = O_FundsData_one.name,
                                main_funds = O_FundsData_one.main_funds,
                                fundsBalance = O_FundsData_one.fundsBalance - O_moneyTransfer.amount
                            };
                            var fundsRes_one = o_fundsServices.Updatefunds(fundsdata_one).Result;

                            var fundsdata_two = new Data.funds
                            {

                                funds_id = O_FundsData_Two.funds_id,
                                name = O_FundsData_Two.name,
                                main_funds = O_FundsData_Two.main_funds,
                                fundsBalance = O_FundsData_Two.fundsBalance + O_moneyTransfer.amount
                            };
                            var fundsRes_two = o_fundsServices.Updatefunds(fundsdata_two).Result;

                            if (fundsRes_one > 0 && fundsRes_two > 0)
                            {
                                MessagingCenter.Send("UpdateFunds", "UbdateListView", "Success");
                                var o_moneyTransferService = new moneyTransferService();

                                int result = await o_moneyTransferService.CreatemoneyTransfer(O_moneyTransfer);
                                if (result > 0)
                                {
                                    Massage = "تم تحويل مبلغ :- " + O_moneyTransfer.amount + " " + "من خذينه :- " + fundsdata_one.name + " إلى خذينه :-" + " " + fundsdata_two.name;
                                    MessagingCenter.Send("AddmoneyTransfer", "UbdateListView", "Success");
                                    await PopupNavigation.Instance.PopAsync(false);
                                    Eventalert(Massage);

                                }
                            }

                            else
                            {
                                Massage = "لم يتم إضافة اى مبلغ  ";
                                Eventalert(Massage);
                            }
                        }


                    }



                    var x = 5;
                }
            );
            }
        }
        #endregion

        #endregion

        #region Group ********

        #region Group Data 

        public int group_id { get; set; }
        public string group_name { get; set; }
        public Nullable<double> group_maximumAmount { get; set; }
        public Nullable<decimal> group_MonthlyProfitRate { get; set; }
        public Nullable<int> group_MonthlyNum { get; set; }

        public List<Data.V_Group_month_Lisst> Listgroup { get; set; }
        public List<Data.Group_month> Listgroup_month { get; set; }
        public ObservableCollection<string> group_month_Num_Items { get; set; }
        public bool group_month_picker_show { get; set; }
        public List<int> group_month_Num_Piker_Items { get; set; }
        public ObservableCollection<Data.group_month_Num> Items { get; set; }


        #endregion

        #region Group Comand

        #region Group omment

        //public Command select_group_month_Num_data_Command
        //{
        //    get
        //    {
        //        return new Command(async (object obj) =>
        //        {

        //            var s = obj as ObservableCollection<string>;
        //            if (s != null)
        //            { group_month_Num_Items = s; }
        //            await PopupNavigation.Instance.PopAsync(false);

        //            var o_group_month_Num = obj as Data.group_month_Num;
        //            if (o_group_month_Num.Selected == false)
        //            {
        //                if (group_month_Num_Items == null)
        //                {
        //                    group_month_Num_Items = new ObservableCollection<string> { o_group_month_Num.DisplaymonthNum };
        //                    var o = Items.FirstOrDefault(x => x.DisplaymonthNum == o_group_month_Num.DisplaymonthNum);
        //                    if (o != null) o.Selected = true;
        //                    MessagingCenter.Send("UbdateItems", "UbdateListView", "Success");
        //                }
        //                else
        //                {
        //                    group_month_Num_Items.Add(o_group_month_Num.DisplaymonthNum);
        //                    var o = Items.FirstOrDefault(x => x.DisplaymonthNum == o_group_month_Num.DisplaymonthNum);
        //                    if (o != null) o.Selected = true;
        //                    MessagingCenter.Send("UbdateItems", "UbdateListView", "Success");
        //                }

        //            }
        //            else if (o_group_month_Num.Selected == true)
        //            {
        //                var res = group_month_Num_Items.FirstOrDefault(x => x.Contains(o_group_month_Num.DisplaymonthNum));
        //                var resIndex = group_month_Num_Items.IndexOf(res);
        //                group_month_Num_Items.RemoveAt(resIndex);
        //                //o_group_month_Num.Selected = false;
        //                var o = Items.FirstOrDefault(x => x.DisplaymonthNum == o_group_month_Num.DisplaymonthNum);
        //                if (o != null) o.Selected = false;
        //            }
        //        });

        //        //await App.Current.MainPage.Navigation.PushAsync(new Views.testselcteditem()); }); 

        //    }
        //}

        //public Command slecetGroupMonthNumComand
        //{
        //    get
        //    {
        //        return new Command(async (object obj) =>
        //        {
        //            var o_V_Group_month_Lisst = obj as Data.V_Group_month_Lisst;
        //            Settings.GroupID = o_V_Group_month_Lisst.group_id;
        //            group_month_picker_show = true;

        //            var o_GroupService = new GroupService();
        //            var o_Group_Month_Num_Picker = o_GroupService.getGroup_Month_Num_Picker(Settings.GroupID);
        //            if (o_Group_Month_Num_Picker.Result != null) { group_month_Num_Piker_Items = o_Group_Month_Num_Picker.Result; }
        //        }
        //  );
        //    }
        //}
        #endregion



        public Command PostGroupComand
        {
            get
            {
                return new Command(async (object obj) =>
                {
                    var o_obj = obj as ObservableCollection<string>;
                    group_month_Num_Items = o_obj;
                    if (group_name == null)
                    {
                        Massage = "برجاء اضف اسم المجموعة ";
                        IMessage_ShortAlert(Massage);
                    }
                    else if (group_maximumAmount == null)
                    {
                        Massage = "برجاء اضف الحد الاقصى للتقسيط";
                        IMessage_ShortAlert(Massage);
                    }
                    else if (group_MonthlyProfitRate == null)
                    {
                        Massage = "برجاء اضف النسبة الشهرية للتقسيط";
                        IMessage_ShortAlert(Massage);
                    }
                    else if (group_month_Num_Items == null)
                    {
                        Massage = "برجاء اختيار عدد الاشهر المتاحة التقسيط";
                        IMessage_ShortAlert(Massage);
                    }
                    else
                    {
                        var Groupdata = new Data.Lisst
                        {
                            name = group_name,
                            maximumAmount = group_maximumAmount,
                            MonthlyNum = group_MonthlyNum,
                            MonthlyProfitRate = group_MonthlyProfitRate
                        };
                        var o_dataservices = new GroupService();
                        var res = await o_dataservices.Creategroup(Groupdata);
                        if (res != 0)
                        {
                            var o_Group = await o_dataservices.getGroup_id(group_name, group_maximumAmount.Value, group_MonthlyProfitRate.Value);
                            if (o_Group != null)
                            {
                                var i = 1;
                                foreach (var o_item in group_month_Num_Items)
                                {
                                    var GroupMonth_data = new Data.Group_month
                                    {
                                        group_id = o_Group.group_id,
                                        Month_id = i,
                                        Month_num = Convert.ToInt32(o_item)
                                    };
                                    var GroupMonth_res = await o_dataservices.Creategroup_month(GroupMonth_data);
                                    i++;
                                }

                                MessagingCenter.Send("PostGroup", "UbdateListView", "Success");
                                Massage = "تم إنشاء مجموعة جديدة ";
                                IMessage_ShortAlert(Massage);
                                await PopupNavigation.Instance.PopAsync(false);
                                //await App.Current.MainPage.Navigation.PushAsync(new Views.Group());
                            }
                            else
                            {
                                Massage = "حدث خطأ أثناء الانشاء";
                                Eventalert(Massage);
                            }
                        }
                        else
                        {
                            Massage = "خطأ أثناء الانشاء ";
                            Eventalert(Massage);
                        }

                    }



                    var x = 5;

                }
          );
            }
        }


        public Command slecetGroupMonthNumComand
        {
            get
            {
                return new Command(async (object obj) =>
                {
                    var o_V_Group_month_Lisst = obj as Data.V_Group_month_Lisst;
                    Settings.GroupID = o_V_Group_month_Lisst.group_id;
                    await PopupNavigation.Instance.PushAsync(new Views.createGroupMonth());
                }
          );
            }
        }

        #endregion


        #endregion


        #region Debt ********

        #region Debt Data 

        #region Create Debt Data         
        public Nullable<int> Debt_debt_id { get; set; }

        public Nullable<int> Debt_deal_id { get; set; }
        public DateTime Debt_date { get; set; }
        public int Debt_amount { get; set; }
        public string Debt_Notes { get; set; }
        public string Debt_debtorName { get; set; }
        public string Debt_productname { get; set; }
        public string Debt_DebtCondition { get; set; }

        #endregion
        #region Edit Debt Data 

        public int Edit_debt_id { get; set; }
        public int Edit_Debt_deal_id { get; set; }
        public DateTime Edit_Debt_date { get; set; }
        public int Edit_Debt_amount { get; set; }
        public string Edit_Debt_Notes { get; set; }
        public string Edit_Debt_debtorName { get; set; }
        public string Edit_Debt_productname { get; set; }
        public string Edit_Debt_DebtCondition { get; set; }

        #endregion

        public string Debt_name_pickerBtn { get; set; }
        public string Debt_Date_pickerBtn { get; set; }
        public int Debt_Total_amount_Sum { get; set; }
        public int Debt_Total_amount_New { get; set; }
        public int Debt_Total_amount_Old { get; set; }

        private List<Data.debt> _listdebt;
        public List<Data.debt> Listdebt
        {
            get { return _listdebt; }

            set
            {
                _listdebt = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Listdebt"));
                    OnPropertyChanged();
                }
            }


        }

        private List<Data.debt> _listdebt_Sum;
        public List<Data.debt> Listdebt_Sum

        {
            get { return _listdebt_Sum; }

            set
            {
                _listdebt_Sum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Listdebt_Sum"));
                    OnPropertyChanged();
                }
            }


        }

        private List<Data.debt> _listdebt_New;
        public List<Data.debt> Listdebt_New

        {
            get { return _listdebt_New; }

            set
            {
                _listdebt_New = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Listdebt_New"));
                    OnPropertyChanged();
                }
            }


        }

        private List<Data.debt> _listdebt_Old;
        public List<Data.debt> Listdebt_Old

        {
            get { return _listdebt_Old; }

            set
            {
                _listdebt_Old = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Listdebt_Old"));
                    OnPropertyChanged();
                }
            }


        }

        private Data.debt _debt_Detail;
        public Data.debt debt_Detail

        {
            get { return _debt_Detail; }

            set
            {
                _debt_Detail = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("debt_Detail"));
                    OnPropertyChanged();
                }
            }


        }

        private bool _debt_picker_Entry_show;
        public bool Debt_picker_Entry_show
        {
            get { return _debt_picker_Entry_show; }

            set
            {
                _debt_picker_Entry_show = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Debt_picker_Entry_show"));
                    OnPropertyChanged();
                }
            }


        }

        private bool _debt_picker_Btn_show;
        public bool Debt_picker_Btn_show
        {
            get { return _debt_picker_Btn_show; }

            set
            {
                _debt_picker_Btn_show = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Debt_picker_Btn_show"));
                    OnPropertyChanged();
                }
            }


        }

        //private string _debtDate_picker;
        //public string DebtDate_picker
        //{
        //    get { return _debtDate_picker; }

        //    set
        //    {
        //        _debtDate_picker = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("DebtDate_picker"));
        //            OnPropertyChanged();
        //        }
        //    }


        //}

        #endregion



        #region Debt Method Command 
        public Command PostDebtComand
        {
            get
            {
                return new Command(async () =>
                {
                    int NoEroor = 0;

                    if (Debt_picker_Btn_show == true && Debt_name_pickerBtn == "أختر الدائن")
                    {
                        Massage = "برجاء أختر أسم الدائن ";
                        Eventalert(Massage);
                    }
                    else if (Debt_amount == 0)
                    {
                        Massage = "برجاء إدخال قيمة مبلغ الدين ";
                        Eventalert(Massage);
                    }
                    else if (Debt_Date_pickerBtn == null)
                    {
                        Massage = "برجاء إدخال تاريخ الدين";
                        Eventalert(Massage);
                    }
                    else if (Debt_picker_Entry_show == true)
                    {

                        if (Debt_debtorName == null)
                        {
                            Massage = "برجاء أدخل أسم الدائن";
                            Eventalert(Massage);
                        }
                        else
                        {
                            var o_DebtService = new DebtService();
                            var debt_Detail_Sum = await o_DebtService.GetDebtBydebtorName("Sum", Debt_debtorName);
                            if (debt_Detail_Sum != null)
                            {
                                Massage = "هذا الدائن مسجل من قبل , من فضلك ادخل اسم دائن جديد";
                                Eventalert(Massage);
                                Debt_picker_Entry_show = false;
                                Debt_picker_Btn_show = true;
                            }
                            else { NoEroor = 1; }

                        }
                    }
                    else { NoEroor = 1; }
                    if (NoEroor == 1)
                    {

                        var o_DebtService = new DebtService();
                        var o_Debt_Data = await o_DebtService.GetDebtBydebtorName("Sum", Debt_name_pickerBtn);

                        if (o_Debt_Data == null)
                        {
                            DateTime oDate = Convert.ToDateTime(Debt_Date_pickerBtn);
                            if (oDate != null) { Debt_date = oDate; }
                            var O_debt_New = new Data.debt
                            {
                                //deal_id =  Debt_deal_id,
                                amount = Debt_amount,
                                date = Debt_date,
                                debtorName = Debt_debtorName,
                                Notes = Debt_Notes,
                                DebtCondition = "New",
                            };
                            var O_debt_Sum = new Data.debt
                            {
                                //deal_id = Debt_deal_id,
                                amount = Debt_amount,
                                date = Debt_date,
                                debtorName = Debt_debtorName,
                                Notes = Debt_Notes,
                                DebtCondition = "Sum",
                            };
                            int New_result = await o_DebtService.Createdebt(O_debt_New);
                            int Sum_result = await o_DebtService.Createdebt(O_debt_Sum);
                            if (New_result > 0 && Sum_result > 0)
                            {
                                Massage = "تم إضافة دين بقيمه :- " + O_debt_New.amount + " إلى " + O_debt_New.debtorName;

                                MessagingCenter.Send("Adddebt", "UbdateListView", "Success");
                                await PopupNavigation.Instance.PopAsync(false);
                                IMessage_ShortAlert(Massage);
                                //Eventalert(Massage);
                            }
                        }
                        else if (o_Debt_Data != null)
                        {
                            DateTime oDate = Convert.ToDateTime(Debt_Date_pickerBtn);
                            if (oDate != null) { Debt_date = oDate; }
                            var O_debt_Sum = new Data.debt
                            {
                                debt_id = o_Debt_Data.debt_id,
                                productname = o_Debt_Data.productname,
                                //deal_id = o_Debt_Data.deal_id,
                                amount = o_Debt_Data.amount + Debt_amount,
                                date = Debt_date,
                                debtorName = o_Debt_Data.debtorName,
                                Notes = o_Debt_Data.Notes,
                                DebtCondition = "Sum",
                            };
                            var O_debt_New = new Data.debt
                            {
                                amount = Debt_amount,
                                date = Debt_date,
                                debtorName = o_Debt_Data.debtorName,
                                Notes = Debt_Notes,
                                DebtCondition = "New",
                            };
                            int New_result = await o_DebtService.Createdebt(O_debt_New);
                            int Sum_result = await o_DebtService.Updatedebt(O_debt_Sum);
                            if (New_result > 0 && Sum_result > 0)
                            {
                                Massage = "تم إضافة دين بقيمه :- " + O_debt_New.amount + " إلى " + O_debt_New.debtorName;
                                //Listdebt_Sum = o_DebtService.GetAlldebt_By_DebtCondition("Sum").Result;
                                //Listdebt_New = o_DebtService.GetAlldebt_By_DebtCondition("New").Result;
                                MessagingCenter.Send("UbdateSumDebt", "UbdateListView", "Success");

                                await PopupNavigation.Instance.PopAsync(false);
                                Eventalert(Massage);

                            }

                        }

                        else
                        {
                            Massage = "لم يتم إضافة اى دين  ";
                            Eventalert(Massage);
                        }


                    }

                    var x = 5;
                }
            );
            }
        }
        public Command Pay_DebtComand
        {
            get
            {
                return new Command(async () =>
                {

                    var O_debt = debt_Detail;
                    int NoEroor = 0;

                    if (O_debt == null)
                    {
                        Massage = "خطأ فى اختيار الدين ";
                        Eventalert(Massage);
                    }
                    if (Debt_amount == 0)
                    {
                        Massage = "برجاء إدخال قيمة مبلغ الدين ";
                        Eventalert(Massage);
                    }
                    else if (Debt_Date_pickerBtn == null)
                    {
                        Massage = "برجاء إدخال تاريخ الدين";
                        Eventalert(Massage);
                    }
                    else { NoEroor = 1; }
                    if (NoEroor == 1)
                    {

                        var o_DebtService = new DebtService();
                        if (O_debt != null && O_debt.amount < Debt_amount)
                        {
                            Massage = "المبلغ المكتوب اعلى من قيمة الدين المطلوب سداداة";
                            Eventalert(Massage);
                        }
                        else if (O_debt != null)
                        {
                            DateTime oDate = Convert.ToDateTime(Debt_Date_pickerBtn);
                            if (oDate != null) { Debt_date = oDate; }
                            var O_debt_Sum = new Data.debt
                            {
                                debt_id = O_debt.debt_id,
                                productname = O_debt.productname,
                                //deal_id = O_debt.deal_id,
                                amount = O_debt.amount - Debt_amount,
                                date = Debt_date,
                                debtorName = O_debt.debtorName,
                                Notes = O_debt.Notes,
                                DebtCondition = "Sum",
                            };
                            var O_debt_Old = new Data.debt
                            {
                                amount = Debt_amount,
                                date = Debt_date,
                                debtorName = O_debt.debtorName,
                                Notes = Debt_Notes,
                                DebtCondition = "Old",
                            };
                            int New_result = await o_DebtService.Createdebt(O_debt_Old);
                            int Sum_result = await o_DebtService.Updatedebt(O_debt_Sum);
                            if (New_result > 0 && Sum_result > 0)
                            {
                                Massage = "تم دفع دين بقيمه :- " + O_debt_Old.amount + " من " + O_debt_Old.debtorName;
                                MessagingCenter.Send("PaySumDebt", "UbdateListView", "Success");

                                await PopupNavigation.Instance.PopAsync(false);
                                Eventalert(Massage);

                            }

                        }

                        else
                        {
                            Massage = "لم يتم دفع اى دين  ";
                            Eventalert(Massage);
                        }


                    }

                    var x = 5;
                }
            );
            }
        }





        public Command Debt_picker_show_Comand
        {
            get
            {
                return new Command(() =>
                {
                    Debt_picker_Entry_show = true;
                    Debt_picker_Btn_show = false;
                }
            );
            }
        }

        public Command Debt_Select_List_Sum_Comand
        {
            get
            {
                return new Command(async (object obj) =>
                {
                    var O_debt = obj as Data.debt;
                    Settings.debtorName = O_debt.debtorName;
                    await App.Current.MainPage.Navigation.PushAsync(new Views.Debt_NewPage());
                }
                );
            }
        }

        public Command Display_Debt_Note_alert_Comand
        {
            get
            {
                return new Command(async (object obj) =>
                {
                    var o_Debt = obj as Data.debt;

                    var titleMsg = o_Debt.debtorName + " :- " + o_Debt.amount.ToString();
                    var noteMsg = o_Debt.Notes;
                    var Msg = titleMsg + "@" + noteMsg;
                    Msg = Msg.Replace("@", System.Environment.NewLine);
                    await App.Current.MainPage.DisplayAlert("ملاحظات ", Msg, "حسنا");
                }
            );
            }
        }

        public Command Debt_Dleate_Select_List_Comand
        {
            get
            {
                return new Command(async (object obj) =>
                {
                    var O_debt = obj as Data.debt;
                    var O_DebtService = new DebtService();
                    var Res = O_DebtService.Dleatedebt(O_debt).Result;
                    if (Res != 0)
                    {
                        Massage = "تم المسح بنجاح";
                        MessagingCenter.Send("DleateDebt", "UbdateListView", "Success");
                        Eventalert(Massage);
                    }
                    else
                    {
                        Massage = "لم يتم المسح";
                        Eventalert(Massage);
                    }
                }
                );
            }
        }


        #endregion


        #endregion


        #region Test Group month List

        #region Prop

        #endregion

        #region Method

        #endregion
        #region Command



        #endregion

        #endregion

        



        #region Colores..............................
        private Color _installment_icon_color;

        public Color installment_icon_color
        {
            set
            {
                _installment_icon_color = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("installment_icon_color"));
                }
            }
            get => _installment_icon_color;

        }

        private Color _Group_icon_color;

        public Color Group_icon_color
        {
            set
            {
                _Group_icon_color = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Group_icon_color"));
                }
            }
            get => _Group_icon_color;

        }

        private Color _InquiryPage_icon_color;

        public Color InquiryPage_icon_color
        {
            set
            {
                _InquiryPage_icon_color = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("InquiryPage_icon_color"));
                }
            }
            get => _InquiryPage_icon_color;

        }


        private Color _costomares_icon_color;

        public Color costomares_icon_color
        {
            set
            {
                _costomares_icon_color = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("costomares_icon_color"));
                }
            }
            get => _costomares_icon_color;

        }

        private Color _Management_icon_color;        
        public Color Management_icon_color
        {
            set
            {
                _Management_icon_color = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Management_icon_color"));
                }
            }
            get => _Management_icon_color;

        }
        #endregion

        #region Command --------------------------------------------------------------------------
        public ICommand costomarItemTappedCommand { get; protected set; }
        #endregion

        #region Navigation Command --------------------------------------------------------------------------

        public Command Nav_To_Deal_Archives_Command
        {
            get
            { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.Deal_Archives()); }); }

        }
        public Command Nav_To_OutMoney_Command
        {
            get
            { return new Command(async () => {  await App.Current.MainPage.Navigation.PushAsync(new Views.OutMoney()); }); }

        }
        public Command Nav_To_CostomarDetailPhoto_Command
        {
            get
            { return new Command(async () => { Settings.costomarID = CostomarDital.costomar_id; await App.Current.MainPage.Navigation.PushAsync(new Views.CostomarDetailPhoto()); }); }

        }
        public Command Nav_To_createGroupMonth_Command
        {
            get
            {return new Command(async () =>{  await PopupNavigation.Instance.PushAsync(new Views.createGroupMonth()); });}

        }
        public Command Nav_To_CreateGroup_Command
        {
            get
            { return new Command(async () => { await PopupNavigation.Instance.PushAsync(new Views.CreateGroup()); }); }
            //{ return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.CreateGroup()); }); }

        }
        public Command Nav_To_testselcteditem_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.testselcteditem()); }); }
        }

        public Command Nav_To_Debt_NewPage_Command
        {
            get { return new Command(async () => {
                if (debt_Detail != null)
                { Settings.debtorName = debt_Detail.debtorName; }
                await App.Current.MainPage.Navigation.PushAsync(new Views.Debt_NewPage()); }); }
        }
        public Command Nav_To_Debt_Old_P_Command
        {
            get { return new Command(async () => { 
                if (debt_Detail != null) 
                { Settings.debtorName = debt_Detail.debtorName; }
                await App.Current.MainPage.Navigation.PushAsync(new Views.Debt_Old_P()); }); }
        }
        public Command Nav_To_PayDebt_Command
        {
            get { return new Command(async (object obj) => 
            { var O_debt = obj as Data.debt;
                
                Settings.DebtID = O_debt.debt_id;
                await PopupNavigation.Instance.PushAsync(new Views.PayDebt()); }); }

        }
        public Command Nav_To_CreateDebt_Command
        {
            get { return new Command(async () => { await PopupNavigation.Instance.PushAsync(new Views.CreateDebt()); }); }

        }
        public Command Nav_To_CreatemoneyTransfer_Command
        {
            get { return new Command(async () => {  if(Funds.Count < 2) { Massage = "لابد من وجود شنطتين على الاقل لتتمكن من التحويل"; Eventalert(Massage);  } else { await PopupNavigation.Instance.PushAsync(new Views.CreatemoneyTransfer()); }}); }

        }
        public Command Nav_To_CreateCapitalAddition_Command
        {
            get { return new Command(async () => { await PopupNavigation.Instance.PushAsync(new Views.CreateCapitalAddition()); }); }

        }
        public Command Nav_To_CreatepocketMoney_Command
        {
            get { return new Command(async () => { await PopupNavigation.Instance.PushAsync(new Views.CreatepocketMoney()); }); }

        }
        public Command Nav_To_CreateWallet_Command
        {
            get {  return new Command(async () => { await PopupNavigation.Instance.PushAsync(new Views.CreateWallet());}); }
            
        }

        public Command Nav_To_UpdateWallet_Command
        {
            get { return new Command(async () => { await PopupNavigation.Instance.PushAsync(new Views.UpdateWallet()); }); }

        }
        public Command Nav_To_UpdateCostomares_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.UpdateCostomares()); }); }
        }
        public Command Nav_To_testPage_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.testPage()); }); }
        }
        public Command Nav_To_lastPage_Command
        {
            get { return new Command(async () => {  await App.Current.MainPage.Navigation.PopAsync(); }); }
            //await App.Current.MainPage.Navigation.PopAsync();
        }
        public Command Nav_To_lastPage_PopUp_Command
        {
            get { return new Command(async () => { await PopupNavigation.Instance.PopAsync(); }); }            
        }

        public Command Nav_To_AddMoney_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.AddMoney()); }); }
        }
        public Command Nav_To_CostomarDetail_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.CostomarDetail()); }); }

        }

        public Command Nav_To_CreateCostomar_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.CreateCostomar()); }); }
        }

        public Command Nav_To_CreateCostomarTwo_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.CreateCostomarTwo()); }); }
        }
        //public Command Nav_To_CreateDeal_Command
        //{
        //    get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.CreateDeal()); }); }
        //}

        public Command Nav_To_DealDetail_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.DealDetail()); }); }
        }
        public Command Nav_To_debt_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.debt()); }); }
        }
        public Command Nav_To_DetailReport_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.DetailReport()); }); }
        }
        

        public Command Nav_To_installmentRecord_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.installmentRecord()); }); }
        }

        public Command Nav_To_moneyTransfer_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.moneyTransfer()); }); }
        }
        public Command Nav_To_PaymentDebt_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.PaymentDebt()); }); }
        }
        public Command Nav_To_pocketMoney_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.pocketMoney()); }); }
        }
        public Command Nav_To_Profits_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.Profits()); }); }
        }
        public Command Nav_To_Wallet_Command
        {
            get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new Views.walet()); }); }
        }
        #region Foter navigation --------------------
        //00000000000000000000000000000000000000000000000000000000000
        public Command Nav_To_installment_Command
        {
            get { return new Command(async () => {
                var o_dataservices = new DealService();
                o_dataservices.UpdateAll_list_Down_visible_installment(); 
                Settings.PageIconColor = "installment"; Settings.Deal_installment_id = -1; Settings.Deal_deal_id = -1; await App.Current.MainPage.Navigation.PushAsync(new Views.installment()); }); }
        }
        public Command Nav_To_Group_Command
        {
            get { return new Command(async () => { Settings.PageIconColor = "Group"; await App.Current.MainPage.Navigation.PushAsync(new Views.Group()); }); }
        }
        public Command Nav_To_InquiryPage_Command
        {
            get { return new Command(async () => { Settings.PageIconColor = "InquiryPage"; await App.Current.MainPage.Navigation.PushAsync(new Views.InquiryPage()); }); }
        }

        public Command Nav_To_costomares_Command
        {
            get { return new Command(async () => { Settings.PageIconColor = "costomares"; await App.Current.MainPage.Navigation.PushAsync(new Views.costomares()); }); }
        }
        public Command Nav_To_Management_Command
        {
            get { return new Command(async () => { Settings.PageIconColor = "Management"; await App.Current.MainPage.Navigation.PushAsync(new Views.Management()); }); }
        }

        #endregion




        //public Command Nav_To_EditCustomerProfilePage_Command
        //{
        //    ///get { return new Command(async () => { await App.Current.MainPage.Navigation.PushAsync(new views.EditCustomerProfilePage()); }); }
        //}
        #endregion

        #region constractor ---------------------------------------------------------------------------
        public MainViewModel()
        {
            changeIconecolor(Settings.PageIconColor);
          
            Settings.PageIconColor = "installment";
            //installment_List_show = false;
            getdata();
           // RefeshListView();
            costomarItemTappedCommand = new Command(costomarItemTappedMathod);
            getcostomarDetailData();
            get_Deal_Detail_Data();
            getfundsDetailData();
            //getfundsTotal_fundsBalance();
            //get_group_month_Num_data();
            Settings.costomarID = 0;
            Settings.fundsID = 0;
            Settings.debtorName = "null";
            Settings.DebtID = 0;
            Settings.Dital_Costomar_id = -1;
            Settings.GroupID = 0;
            Settings.Creat_Deal_Ceack = 0;
            Settings.Dital_deal_id = -1;
            Settings.Dital_installment_id = -1;
            Settings.Dital_Costomar_id = -1;
            PocketMoney_picker_Entry_show = false;
            PocketMoney_picker_Btn_show = true;
            Debt_picker_Entry_show = false;
            Debt_picker_Btn_show = true;
            group_month_picker_show = false;
            FundsItemSlect = "أختر حساب";
            FundsItemSlect_Two = "أختر حساب الايداع";
            FundsItemSlect_one = "أختر حساب السحب";
            pocketMoney_name_pickerBtn = "أختر البيان";
            Debt_name_pickerBtn = "أختر الدائن";

            if (group_month_Num_Piker_Items != null )
            {
                group_month_picker_show = true;
            }

            if (ListPocketMoney_Name == null || ListPocketMoney_Name.Count == 0)
            {                             
                    PocketMoney_picker_Entry_show = true;
                    PocketMoney_picker_Btn_show = false;                
            }
            if (Listdebt_Sum == null || Listdebt_Sum.Count == 0)
            {
                Debt_picker_Entry_show = true;
                Debt_picker_Btn_show = false;
            }


        }
        

        public void getdata()
        {

            //Get_Costomer_______________
            var o_CostomerService = new CostomerService();
            var Costomeres = o_CostomerService.GetAllCostomer();
            if (Costomeres.Result != null) { Costomar = Costomeres.Result; }
            if (Settings.Dital_Costomar_id != -1 ) 
            {  
                var o_CostomarDital = o_CostomerService.GetCostomerDital(Settings.Dital_Costomar_id).Result;
                if(o_CostomarDital != null) { CostomarDital = o_CostomarDital; }
            }
            var O_Costomer_Photo = o_CostomerService.getCostomer_photo_list(Settings.costomarID);
            if (O_Costomer_Photo.Result != null) { 
                Costomer_Photo_List = O_Costomer_Photo.Result;
                foreach(var o_item in Costomer_Photo_List)
                {
                    if(Costomer_Photo_ImageSource == null || Costomer_Photo_ImageSource.Count == 0)
                    {
                        Costomer_Photo_ImageSource = new List<ImageSource> { ImageSource.FromFile(o_item) };
                    }
                    else { Costomer_Photo_ImageSource.Add(ImageSource.FromFile(o_item)); }
                    
                    
                }
                
            }

            //List<ContentPage> ContentPages = new List<ContentPage>();
            //foreach (var photo in Costomer_Photo_List)
            //{
            //    var page = new ContentPage();
            //    page.BindingContext = new PhotoDetailViewModel(photo);
            //    ContentPages.Add(page);
            //}
            //Pages = new ObservableCollection<PhotoDetailViewModel>(Photos.Select(p => new PhotoDetailViewModel(p));
            //Pages = new ObservableCollection<ContentPage>(ContentPages);
            //Get_funds_______________
            var o_fundsService = new fundsService();
            var funds = o_fundsService.GetAllFunds();
            if (funds.Result != null) { Funds = funds.Result; }
            var FundsIndexNum =  o_fundsService.GetTotalfundsBalance();
            if(FundsIndexNum != null)
            {
                FundsTotalMount = FundsIndexNum.Result;
            }
            
            //Get_groupres_______________
            var o_GroupService = new GroupService();
            var groupres = o_GroupService.GetAllgroup();
            if (groupres.Result != null) { Listgroup = groupres.Result; }

            var o_Group_Month_Num_Picker = o_GroupService.getGroup_Month_Num_Picker(Settings.GroupID);
            if (o_Group_Month_Num_Picker.Result != null) { group_month_Num_Piker_Items = o_Group_Month_Num_Picker.Result; }
            //Get_pocketMoney_______________
            var o_pocketMoneyService = new pocketMoneyService();
            var pocketMoney = o_pocketMoneyService.GetAllpocketMoney("pocket");
            if (pocketMoney.Result != null) { List_Pocket_Money = pocketMoney.Result; }
            var out_Money = o_pocketMoneyService.GetAllpocketMoney("out");
            if (out_Money.Result != null) { List_out_Money = out_Money.Result; }
            ListPocketMoney_Name = o_pocketMoneyService.GetpocketMoneyName().Result;
            var o_PocketMoneyTotal_Mount = o_pocketMoneyService.GetpocketMoney_sum("pocket");
            if(o_PocketMoneyTotal_Mount != null)
            {
                PocketMoneyTotal_Mount = o_PocketMoneyTotal_Mount.Result;
            }
            var o_outMoneyTotal_Mount = o_pocketMoneyService.GetpocketMoney_sum("out");
            if (o_outMoneyTotal_Mount != null) 
            {
                outMoneyTotal_Mount = o_outMoneyTotal_Mount.Result;
            }
            
            //Listgroup = groupres.Result;
            //Get_Debt_______________
            var o_DebtService = new DebtService();
            var Listdebt_Sum_Res = o_DebtService.GetAlldebt_By_DebtCondition("Sum").Result;
            if (Listdebt_Sum_Res != null)
            { Listdebt_Sum = Listdebt_Sum_Res; Debt_Total_amount_Sum = o_DebtService.GetTotalamount("Sum").Result; }
            var Listdebt_New_Res = o_DebtService.GetListDebtBydebtorName("New", Settings.debtorName).Result;
            if (Listdebt_New_Res != null)
            { Listdebt_New = Listdebt_New_Res; Debt_Total_amount_New = o_DebtService.GetTotalamount("New").Result; debt_Detail = o_DebtService.GetDebtBydebtorName("Sum", Settings.debtorName).Result; }
            var Listdebt_Old_Res = o_DebtService.GetListDebtBydebtorName("Old", Settings.debtorName).Result;
            if (Listdebt_Old_Res != null)
            { Listdebt_Old = Listdebt_Old_Res; debt_Detail = o_DebtService.GetDebtBydebtorName("Sum", Settings.debtorName).Result; }
            if (Settings.DebtID != 0)
            {
                var Listdebt_Old_Dital_Res = o_DebtService.GetdebtDital(Settings.DebtID).Result;
                if (Listdebt_Old_Dital_Res != null)
                { debt_Detail = Listdebt_Old_Dital_Res; }
            }

            //Get_Deal_______________
            var o_DealService = new DealService();
            var view_Deal_Data = o_DealService.GetAll_costomar_deal_installment_payed();
            if (view_Deal_Data.Result != null) { 
                List_Deal_Data = view_Deal_Data.Result; 
            }
            var Deal_Data_Archives = o_DealService.GetAll_costomar_deal_installment_Archives();
            if (Deal_Data_Archives.Result != null)
            {
                List_deal_Archives = Deal_Data_Archives.Result;
            }
            //Get Small Earnings
            var o_smallEarningsService = new smallEarningsService();
            var smallEarningsService_Data = o_smallEarningsService.Get_All_smallEarnings();
            if (smallEarningsService_Data.Result != null)
            {
                List_smallEarnings_Data = smallEarningsService_Data.Result;
            }
            

            //Total_Money
            if (o_outMoneyTotal_Mount != null && FundsIndexNum != null)
            {
                Total_Money = outMoneyTotal_Mount + FundsTotalMount;


            }
            



            //GET_Creat Deal Data
            if ( Settings.Creat_Deal_price != 0 && Settings.Creat_Deal_given != 0 && Settings.Creat_Deal_selcet_month != 0 && Settings.Creat_Deal_Ceack != 0)
            {
                VM_Creat_Deal_group_id = Settings.Creat_Deal_group_id.ToString() ;
                VM_Creat_Deal_price =Settings.Creat_Deal_price.ToString();
                VM_Creat_Deal_given=Settings.Creat_Deal_given.ToString();
                VM_Creat_Deal_selcet_month = Settings.Creat_Deal_selcet_month.ToString();
                VM_Creat_Deal_remainder = Settings.Creat_Deal_remainder.ToString();
                VM_Creat_Deal_Total_installment=  Settings.Creat_Deal_Total_installment.ToString();
                VM_Creat_Deal_Pons_installment = Settings.Creat_Deal_Pons_installment.ToString();                
                VM_Creat_Deal_qast = Settings.Creat_Deal_qast.ToString();
                VM_Creat_Deal_group_name = Settings.Creat_Deal_group_name;

                VM_Creat_Deal_Prodect_Name = Settings.Creat_Deal_Prodect_Name;

                VM_Creat_Deal_Start_Date =  Settings.Creat_Deal_Start_Date;
                VM_Creat_Deal_paymentDay = Settings.Creat_Deal_paymentDay;

                if (Settings.Creat_Deal_ItemData_costomar_id != 0 && Settings.Creat_Deal_ItemData_costomar_Name != "")
                {
                    VM_Creat_Deal_ItemData_costomar_id = Settings.Creat_Deal_ItemData_costomar_id.ToString();
                    VM_Creat_Deal_ItemData_costomar_Name = Settings.Creat_Deal_ItemData_costomar_Name.ToString();
                }

            }
            var x = 5;
        }
        #endregion

        

        #region  method -----------------------------------------------------------------






        //public async void RefeshListView()
        //{

        //    // SQLiteConnection sqLiteConn;
        //    try
        //    {


        //        _sqLiteConnection = await DependencyService.Get<ISQLite>().GetConnection();
        //        var listData = _sqLiteConnection.Table<Data.costomar>().ToList();
        //        Costomar = listData;

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //}
        public async void changeIconecolor(string iconTabedName)
        {
            Color a = Color.FromHex("#374957");
            Color b = Color.FromHex("3D72FF");
            if (iconTabedName == "installment")
            {
                installment_icon_color = b;
                Group_icon_color = a;
                InquiryPage_icon_color = a;
                costomares_icon_color = a;
                Management_icon_color = a;

            }
            else if (iconTabedName == "Group")
            {
                installment_icon_color = a;
                Group_icon_color = b;
                InquiryPage_icon_color = a;
                costomares_icon_color = a;
                Management_icon_color = a;

            }
            else if (iconTabedName == "InquiryPage")
            {
                installment_icon_color = a;
                Group_icon_color = a;
                InquiryPage_icon_color = b;
                costomares_icon_color = a;
                Management_icon_color = a;
            }
            else if (iconTabedName == "costomares")
            {
                installment_icon_color = a;
                Group_icon_color = a;
                InquiryPage_icon_color = a;
                costomares_icon_color = b;
                Management_icon_color = a;

            }
            else if (iconTabedName == "Management")
            {
                installment_icon_color = a;
                Group_icon_color = a;
                InquiryPage_icon_color = a;
                costomares_icon_color = a;
                Management_icon_color = b;

            }
            else
            {
                installment_icon_color = a;
                Group_icon_color = a;
                InquiryPage_icon_color = a;
                costomares_icon_color = a;
                Management_icon_color = a;

            }

        }

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        //await RequestPermission();
        //string imagePath = "Put here local file path";
        //DependencyService.Get<IOpenFile>().OpenFile(imagePath);


        //private async Task RequestPermission()
        //{
        //    var res = await Plugin.Permissions.CrossPermissions.Current.CheckPermissionStatusAsync(
        //    Plugin.Permissions.Abstractions.Permission.Storage);
        //    if (res == Plugin.Permissions.Abstractions.PermissionStatus.Granted)
        //        return;
        //    else
        //    {
        //        await Plugin.Permissions.CrossPermissions.Current.RequestPermissionsAsync(
        //       Plugin.Permissions.Abstractions.Permission.Storage);

        //    }
        //}
        public async void Erorralert(string msg)
        {
           await App.Current.MainPage.DisplayAlert("خطأ" , "القيمة المدخلة فى الخانة " +  msg + " غير صحيحة" , "حسنا");
        }

        public async void Eventalert(string msg)
        {
            await App.Current.MainPage.DisplayAlert("تنبية " , msg , "حسنا");          
        }
        public async void IMessage_ShortAlert(string msg)
        {
           DependencyService.Get<IMessage>().ShortAlert(msg);
           
           
        }
        public async void IMessage_LongAlert(string msg)
        {
           
            DependencyService.Get<IMessage>().LongAlert(msg);
            
           
        }

        #endregion


        public Command UploadpackUPAsync
        {
            get
            {
                return new Command(async () =>

                {
                    //فى دالة انشاء نسخه احتياطية من البينات

                    Stream contentStream = null;

                    string databaseName = "qastlly101.db3";
                    var s = System.Environment.SpecialFolder.LocalApplicationData;                    
                    //var ss = System.Environment.;
                    var docFolder = System.Environment.GetFolderPath(s);
                    var dbName = Path.Combine("data", databaseName); // FILE NAME TO USE WHEN COPIED
                    var x = 5;                                                  //



                    //بيضرب وهو بيجيب ال path
                    try
                    {
                        var p =  App.GraphClient.Me.Drive.Special.AppRoot.ItemWithPath("qastlly101.db3");
                        var ph =  App.GraphClient.Me.Drive.Special.AppRoot.ItemWithPath("qastlly101.db3").Request();
                        var pht =  App.GraphClient.Me.Drive.Special.AppRoot.ItemWithPath("qastlly101.db3").Request().GetAsync();
                        //var path = await App.GraphClient
                        //.Me
                        //.Drive
                        //.Special
                        //.AppRoot
                        //.ItemWithPath("qastlly101.db3")
                        //.Request()
                        //.GetAsync();
                        //foundFile = await path.Request().GetAsync();
                        if (pht == null)
                        {
                            await App.Current.MainPage.DisplayAlert("Attention", "Backup file not found", "OK");
                        }
                        else
                        {
                            contentStream = await App.GraphClient.Me
                                                        .Drive
                                                        .Special
                                                        .AppRoot
                                                        .ItemWithPath("qastlly101.db3")
                                                        .Content
                                                        .Request()
                                                        .GetAsync();

                            var dbNam = Path.Combine("/data", databaseName);
                            var destPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName));
                            
                            var driveItemFile = System.IO.File.Create(dbNam);
                            contentStream.Seek(0, SeekOrigin.Begin);
                            contentStream.CopyTo(driveItemFile);
                            //
                        }
                    }
                    catch (Exception ex)
                    {
                        var error = ex;
                        await App.Current.MainPage.DisplayAlert("Attention", error.ToString(), "OK");
                    }
                }


                );

            }
        }


        public Command DowenloadpackUPAsync
        {
            get
            {
                return new Command(async () =>
                {
                    
                        //لاستعاده قاعدة البينات

                        string databaseName = "qastlly101.db3";
                        var docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                        var dbName = Path.Combine(docFolder, databaseName); // FILE NAME TO USE WHEN COPIED


                        var dbPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName));
                        byte[] data = System.IO.File.ReadAllBytes(dbPath);
                        Stream stream = new MemoryStream(data);
                        //
                        try
                        {
                            await App.GraphClient.Me
                                .Drive
                                .Special
                                .AppRoot
                                .ItemWithPath("qastlly101.db3")
                                .Content
                                .Request()
                                .PutAsync<DriveItem>(stream);
                        }
                        catch
                        {
                            await App.Current.MainPage.DisplayAlert("Attention", "Problem during file copy...", "OK");
                        }
                   
                });

            }
        }



        


    }
}

