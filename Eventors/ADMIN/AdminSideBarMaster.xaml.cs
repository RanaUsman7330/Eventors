using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eventors.ADMIN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminSideBarMaster : ContentPage
    {
        public ListView ListView;

        public AdminSideBarMaster()
        {
            InitializeComponent();

            BindingContext = new AdminSideBarMasterViewModel();
            ListView = MenuItemsListView;
        }

        class AdminSideBarMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AdminSideBarMasterMenuItem> MenuItems { get; set; }

            public AdminSideBarMasterViewModel()
            {
                MenuItems = new ObservableCollection<AdminSideBarMasterMenuItem>(new[]
                {
                    new AdminSideBarMasterMenuItem { Id = 0, Title = "Registered Users", TargetType= typeof(RegisterUsers) },
                    new AdminSideBarMasterMenuItem { Id = 1, Title = "Registered Owners", TargetType = typeof(RegisterOwner) },
                    new AdminSideBarMasterMenuItem { Id = 2, Title = "Event Handle", TargetType = typeof(AddEventsAdmin) },
                    new AdminSideBarMasterMenuItem { Id = 3, Title = "Places", TargetType = typeof(AddHotelsAdmin) },
                    new AdminSideBarMasterMenuItem { Id = 4, Title = "Requests", TargetType = typeof(Requests) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}