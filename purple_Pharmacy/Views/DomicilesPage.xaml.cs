using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
                new Menu {Title = "Inicio", Detail = "Regresa a la pagina principal" },
                new Menu {Title = "Opciones", Detail = "Navegar a la pagina principal" },
            };
            ListMenu.ItemsSource = menu;
            
            Detail = new NavigationPage(new OrdersPage());
        }
    }
    public class Menu
    {
        public string Title
        {
            get;
            set;
        }
        public object Detail
        {
            get;
            set;
        }
    }
}