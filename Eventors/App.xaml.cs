using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using SQLite;
using System.Collections.Generic;
using Eventors.MODELS;

namespace Eventors
{
    public partial class App : Application
    {
        public static string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Eventors.db3");
        public static SQLiteConnection db = new SQLiteConnection(dbPath);

        public static UsersListModel LoggedInUser = null;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
    }
}
