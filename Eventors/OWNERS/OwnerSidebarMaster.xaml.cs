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

namespace Eventors.OWNERS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OwnerSidebarMaster : ContentPage
    {
        public ListView ListView;

        public OwnerSidebarMaster()
        {
            InitializeComponent();

            BindingContext = new OwnerSidebarMasterViewModel();
            ListView = MenuItemsListView;
        }

        class OwnerSidebarMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<OwnerSidebarMasterMenuItem> MenuItems { get; set; }

            public OwnerSidebarMasterViewModel()
            {
                MenuItems = new ObservableCollection<OwnerSidebarMasterMenuItem>(new[]
                {
                    new OwnerSidebarMasterMenuItem { Id = 0, Title = "Page 1" },
                    new OwnerSidebarMasterMenuItem { Id = 1, Title = "Page 2" },
                    new OwnerSidebarMasterMenuItem { Id = 2, Title = "Page 3" },
                    new OwnerSidebarMasterMenuItem { Id = 3, Title = "Page 4" },
                    new OwnerSidebarMasterMenuItem { Id = 4, Title = "Page 5" },
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