using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using purple_Pharmacy.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace purple_Pharmacy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersPage : ContentPage
    {

        public OrdersPage()
        {
            InitializeComponent();
            Init();
        }
      
    }
}