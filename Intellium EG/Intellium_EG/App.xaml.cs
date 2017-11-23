using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Intellium_EG
{
   
    public partial class App : Application
    {
        public static string AppName { get { return "StoreAccountInfoApp"; } }
        public static ICredentialsService CredentialsService { get; private set; }

        public App()
        {
            CredentialsService = new CredentialsService();
            InitializeComponent();

            if (CredentialsService.DoCredentialsExist())
            {
                MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            /*
            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();

            else
                MainPage = new NavigationPage(new MainPage());*/
        }
    }
}