using Eventors.MODELS;
using Plugin.Media;
using Plugin.Media.Abstractions;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eventors.ADMIN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupAdmin : ContentPage
    {
        public static string PicPath = "N/A";
        public SignupAdmin()
        {
            InitializeComponent();
        }

        private async void BtnSignUpAdmin_Clicked(object sender, EventArgs e)
        {
           

            var db = new SQLiteConnection(App.dbPath);

            db.CreateTable<UsersListModel>();

            UsersListModel u = new UsersListModel()
            {
                UserEmail = txtEmail.Text,
                UserName = txtName.Text,
                UserPassword = txtPass.Text,
                UserPhone = txtPhone.Text,
                UserImage = PicPath,
                UserAddress = double.Parse(txtAddress.Text),
                UserCNIC = int.Parse(txtCNIC.Text),

            };

            db.Insert(u);

            var selection = await DisplayAlert("Polices", "Do you Agree with our Polices", "Agree", "Disagree");
            if (selection)
            {
                await DisplayAlert("Done", "Your Data is Inserted", "OK");
            }
            else
            {
                await DisplayAlert("Caution", "Sorry you don't Create Account", "OK");
                return;

            }

            App.Current.MainPage = new AdminSideBar(); 

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            try
            {



                var response = await DisplayActionSheet("Select Image", "Close", "", "From Camera", "From Gallery");
                if (response == "From Camera")
                {
                    await CrossMedia.Current.Initialize();
                    if (!CrossMedia.Current.IsTakePhotoSupported)
                    {
                        await DisplayAlert("Error", "Phone is not Pick Photo Supported", "OK");
                        return;
                    }
                    var mediaOptions = new StoreCameraMediaOptions()
                    {
                        PhotoSize = PhotoSize.Medium
                    };

                    var SelectedImg = await CrossMedia.Current.TakePhotoAsync(mediaOptions);
                    if (SelectedImg == null)
                    {
                        await DisplayAlert("Error", "Error Picking Image...", "OK");
                        return;
                    }
                    PicPath = SelectedImg.Path;
                    PreviewImage.Source = SelectedImg.Path;

                }


                if (response == "From Gallery")
                {
                    {
                        await CrossMedia.Current.Initialize();
                        if (!CrossMedia.Current.IsPickPhotoSupported)
                        {
                            await DisplayAlert("Error", "Phone is not Pick Photo Supported", "OK");
                            return;
                        }

                        var mediaOptions = new PickMediaOptions()
                        {
                            PhotoSize = PhotoSize.Medium
                        };

                        var SelectedImg = await CrossMedia.Current.PickPhotoAsync(mediaOptions);

                        if (SelectedImg == null)
                        {
                            await DisplayAlert("Error", "Error Picking Image...", "OK");
                            return;
                        }

                        PicPath = SelectedImg.Path;

                        PreviewImage.Source = SelectedImg.Path;

                    }

                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Message", "Something went Wrong" + ex.Message, "OK");

            }

        }
    }
}