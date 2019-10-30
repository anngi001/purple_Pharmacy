
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml; 
using purple_Pharmacy.Resources;

namespace purple_Pharmacy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DomicilesPage : MasterDetailPage
    {
        public DomicilesPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {

            List<Menu> menu = new List<Menu>
            {
                new Menu { MenuTitle = AppResources.Medicamento },
                new Menu {MenuTitle = AppResources.Mis_Pedidos },
                new Menu {MenuTitle = AppResources.Domicilio },
            };
            ListMenu.ItemsSource = menu;
            Detail = new NavigationPage(new Welcome());
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                if (menu.MenuTitle.Equals(AppResources.Medicamento))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new Medicamentos());

                }
                else if (menu.MenuTitle.Equals(AppResources.Mis_Pedidos))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new OrdersPage());
                }
                else if (menu.MenuTitle.Equals(AppResources.Domicilio))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new DomicilioPage());
                }


            }
        }
    }

    public class Menu
    {

        public string MenuTitle
        {
            get;
            set;
        }
        public object MenuDetail
        {
            get;
            set;
        }

    }
}