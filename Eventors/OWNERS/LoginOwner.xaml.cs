using Eventors.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eventors.OWNERS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginOwner : ContentPage
    {
        public LoginOwner()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var check = App.db.Table<UsersListModel>().Where(x => x.UserEmail == txtEmail.Text && x.UserPassword == txtPassword.Text).FirstOrDefault();
            if (check == null)
            {
                await DisplayAlert("ERROR", "Your Email or Password No Match Please Try Again", "OK");
                return;
            }


            if (txtEmail.Text == null || txtPassword.Text == null)
            {
                await DisplayAlert("Caution", "Please Fill the empty Entry.", "Ok");
                return;
            }

            else
            {
                App.LoggedInUser = check;

                await Navigation.PushAsync(new OwnerSidebarDetail());

            }

        }
    }
}