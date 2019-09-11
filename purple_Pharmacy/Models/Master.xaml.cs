﻿
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using purple_Pharmacy.Views;
using product.Domain;

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
            
            List<Menu> menu = new List <Menu>
            {
                new Menu { MenuTitle = "Medicamentos" },
                new Menu {MenuTitle = "Mis Pedidos" },
                new Menu {MenuTitle = "Domicilio" },
            };
            ListMenu.ItemsSource = menu;
            Detail = new NavigationPage(new OrdersPage());
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if(menu!= null)
            {
                if(menu.MenuTitle.Equals("Medicamentos"))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new Medicamentos()) ;

                }
                else if (menu.MenuTitle.Equals("Mis Pedidos"))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new OrdersPage());
                }
                else if (menu.MenuTitle.Equals("Domicilio"))
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