using System;

using Xamarin.Forms;

namespace Intellium_EG
{ 

	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
            InitializeComponent();
            bool doCredentialsExist = App.CredentialsService.DoCredentialsExist();
            if (doCredentialsExist){
                usernameEntry.Text = App.CredentialsService.UserName;
                passwordEntry.Text = App.CredentialsService.Password;
            }
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string serverName = serverEntry.Text;
            string userName = usernameEntry.Text;
            string password = passwordEntry.Text;

            var isValid = AreCredentialsCorrect(serverName, userName, password);
            if (isValid)
            {
                bool doCredentialsExist = App.CredentialsService.DoCredentialsExist();
                if (!doCredentialsExist)
                {
                    App.CredentialsService.SaveCredentials(userName, password);
                }
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }
        bool AreCredentialsCorrect(string servername, string username, string password)
        {
            return true;
        }
	}
}