using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using qastly.Views;
using qastly.Helpers;
using System.Collections.Generic;
using qastly.Models;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;


using Microsoft.Identity.Client;

using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using Microsoft.Graph;

namespace qastly
{
    //public partial class App : Application, INotifyPropertyChanged
    public partial class App : Xamarin.Forms.Application, INotifyPropertyChanged
    {

        #region properties **********************************
        private bool isSignedIn;
        public bool IsSignedIn
        {
            get { return isSignedIn; }
            set
            {
                isSignedIn = value;
                OnPropertyChanged("IsSignedIn");
                OnPropertyChanged("IsSignedOut");
            }
        }

        public bool IsSignedOut { get { return !isSignedIn; } }

        // The user's display name
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        // The user's email address
        private string userEmail;
        public string UserEmail
        {
            get { return userEmail; }
            set
            {
                userEmail = value;
                OnPropertyChanged("UserEmail");
            }
        }

        // The user's profile photo
        private ImageSource userPhoto;
        public ImageSource UserPhoto
        {
            get { return userPhoto; }
            set
            {
                userPhoto = value;
                OnPropertyChanged("UserPhoto");
            }
        }


        // UIParent used by Android version of the app
        public static object AuthUIParent = null;

        // Keychain security group used by iOS version of the app
        public static string iOSKeychainSecurityGroup = null;

        // Microsoft Authentication client for native/mobile apps
        public static IPublicClientApplication PCA;

        // Microsoft Graph client
        public static GraphServiceClient GraphClient;

        // Microsoft Graph permissions used by app
        private readonly string[] Scopes = OAuthSettings.Scopes.Split(' ');
        #endregion





        public App()
        {
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjkzMzMzQDMxMzgyZTMyMmUzMFkrbThkQ0FqejNXS2YyUkRoQUFzZVhTbnhUK09BOFNPQjliS2RDUTJDSnM9");
            InitializeComponent();

            //start 
            var builder = PublicClientApplicationBuilder.Create(OAuthSettings.ApplicationId).WithRedirectUri(OAuthSettings.RedirectUri);

            if (!string.IsNullOrEmpty(iOSKeychainSecurityGroup))
            {
                builder = builder.WithIosKeychainSecurityGroup(iOSKeychainSecurityGroup);
            }

            PCA = builder.Build();
            //end
            var o_dataservices = new DealService();
            o_dataservices.UpdateAll_list_Down_visible_installment();
            //تحديث ايام التاخير            
            List<Data.V_costomar_deal_installment> List_Deal_Data;
            var view_Deal_Data = o_dataservices.GetAll_costomar_deal_installment_payed();

            if (view_Deal_Data.Result != null)
            {
                List_Deal_Data = view_Deal_Data.Result;

                var date = DateTime.Now;
                foreach (var element in List_Deal_Data)
                {
                    var O_installment = new Data.installment
                    {
                        installment_id = element.installment_id,
                        deal_id = element.deal_id,
                        InstallmentPaymentDate = element.InstallmentPaymentDate,
                        InstallmentDueDate = element.InstallmentDueDate,
                        installment_condition = element.installment_condition,
                        Collectedvalue = element.Collectedvalue,
                        Worthy_amount = element.Worthy_amount,
                        Remaining_amount = element.Remaining_amount,
                        list_Down_visible = element.list_Down_visible,
                        installmedntColor = element.installmedntColor,
                        delay_Days = element.delay_Days,


                    };
                    if(date > element.InstallmentDueDate)
                    {
                        var res = (date - O_installment.InstallmentDueDate).Days;
                        // عدد ايام التاخير اقصاها 3 شهور يعنى 90 يوم واللون الاحمر والاخضر بالرجي بي بيكونو 255  يعنى كل يوم تخير بيساوى 3 درجات فى اللون غالبا ...يعنى اضرب عدد اليام التاخير فى 3 يطلع الدرجة الى انا محتاج اظبطها 
                        int total_delay_Days = 0;
                        int gren = 0;
                        int red = 0; 
                        int blue = 0;
                        Color o_installmedntColor;
                        
                        if ( res <= 90)
                        {
                            if(res <= 30)
                            {
                                total_delay_Days = Convert.ToInt32(res * 2.5);
                                red = 180 + total_delay_Days;
                                gren = 255;                                
                                blue = 180;
                                 o_installmedntColor = Color.FromRgb(red, gren, blue);
                                
                            }
                            else if (res <= 60 && res > 30)
                            {
                                total_delay_Days = Convert.ToInt32(res * 1.3);
                                red = 255;
                                gren = 255 - total_delay_Days;
                                blue = 180;
                                o_installmedntColor = Color.FromRgb(red, gren, blue);
                            }
                            else
                            {
                                total_delay_Days = Convert.ToInt32(res * 1.4);
                                red = 255;
                                gren = 180 - total_delay_Days;
                                blue = 180 - total_delay_Days;
                                o_installmedntColor = Color.FromRgb(red, gren, blue);

                            }
                        }
                        else
                        {
                            // اكثر من 90 يوم يبقى هحط الاحمر والاخضر على طول 
                            red = 255;
                            gren = 60;
                            blue = 60;
                            o_installmedntColor = Color.FromRgb(red, gren, blue);
                        }
                           
                        O_installment.delay_Days = res.ToString();
                        string Color_Hex = o_installmedntColor.ToHex();
                        O_installment.installmedntColor = Color_Hex.Remove(1, 2);
                       // Color v = Color.FromHex(O_installment.installmedntColor);
                        int test =  o_dataservices.Update_installment(O_installment).Result;
                        int x = 5;
                    }
                }
            }

            Settings.Deal_installment_id = -1; Settings.Deal_deal_id = -1;
            MainPage = new NavigationPage(new Views.installment());
            //MainPage = new NavigationPage(new Views.MasterPage());
        }
    

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public async Task SignIn()
        {
            // First, attempt silent sign in
            // If the user's information is already in the app's cache,
            // they won't have to sign in again.
            try
            {
                var accounts = await PCA.GetAccountsAsync();

                var silentAuthResult = await PCA
                    .AcquireTokenSilent(Scopes, accounts.FirstOrDefault())
                    .ExecuteAsync();

                Debug.WriteLine("User already signed in.");
                Debug.WriteLine($"Successful silent authentication for: {silentAuthResult.Account.Username}");
                Debug.WriteLine($"Access token: {silentAuthResult.AccessToken}");
            }
            catch (MsalUiRequiredException msalEx)
            {
                // This exception is thrown when an interactive sign-in is required.
                Debug.WriteLine("Silent token request failed, user needs to sign-in: " + msalEx.Message);
                // Prompt the user to sign-in
                var interactiveRequest = PCA.AcquireTokenInteractive(Scopes);

                if (AuthUIParent != null)
                {
                    interactiveRequest = interactiveRequest
                        .WithParentActivityOrWindow(AuthUIParent);
                }

                var interactiveAuthResult = await interactiveRequest.ExecuteAsync();
                Debug.WriteLine($"Successful interactive authentication for: {interactiveAuthResult.Account.Username}");
                Debug.WriteLine($"Access token: {interactiveAuthResult.AccessToken}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Authentication failed. See exception messsage for more details: " + ex.Message);
            }
            await InitializeGraphClientAsync();
        }

        public async Task SignOut()
        {

            // Get all cached accounts for the app
            // (Should only be one)
            var accounts = await PCA.GetAccountsAsync();
            while (accounts.Any())
            {
                // Remove the account info from the cache
                await PCA.RemoveAsync(accounts.First());
                accounts = await PCA.GetAccountsAsync();
            }

            UserPhoto = null;
            UserName = string.Empty;
            UserEmail = string.Empty;
            IsSignedIn = false;

        }
        private async Task GetUserInfo()
        {
            // Get the logged on user's profile (/me)
            var user = await GraphClient.Me.Request().GetAsync();

            UserPhoto = ImageSource.FromStream(() => GetUserPhoto());
            UserName = user.DisplayName;
            UserEmail = string.IsNullOrEmpty(user.Mail) ? user.UserPrincipalName : user.Mail;
        }

        private Stream GetUserPhoto()
        {
            // Return the default photo
            return Assembly.GetExecutingAssembly().GetManifestResourceStream("GraphTutorial.no-profile-pic.png");
        }

        private async Task InitializeGraphClientAsync()
        {
            var currentAccounts = await PCA.GetAccountsAsync();
            try
            {
                if (currentAccounts.Count() > 0)
                {
                    // Initialize Graph client
                    GraphClient = new GraphServiceClient(new DelegateAuthenticationProvider(
                        async (requestMessage) =>
                        {
                            var result = await PCA.AcquireTokenSilent(Scopes, currentAccounts.FirstOrDefault())
                                .ExecuteAsync();

                            requestMessage.Headers.Authorization =
                                new AuthenticationHeaderValue("Bearer", result.AccessToken);
                        }));

                    await GetUserInfo();

                    IsSignedIn = true;
                }
                else
                {
                    IsSignedIn = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to initialized graph client.");
                Debug.WriteLine($"Accounts in the msal cache: {currentAccounts.Count()}.");
                Debug.WriteLine($"See exception message for details: {ex.Message}");
            }
        }
    }
}
