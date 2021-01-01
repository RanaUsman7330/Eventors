using Eventors.ADMIN;
using Eventors.OWNERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eventors
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            //App.Current.MainPage = new AdminSideBar(); 
            Navigation.PushAsync(new SignupAdmin());

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginOwner());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginOwner());
        }
    }
}
