using product.Domain;
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
    public partial class DetailMedicametos : ContentPage
    {
        public DetailMedicametos(Product product)
        {
            InitializeComponent();
            btcomprar.Clicked += Btcomprar_Clicked;


            LoadData(product);
            
        }

        private void LoadData(Product contact)
        {
            Datos.BindingContext = contact;
        }
        private void Btcomprar_Clicked(object sender, EventArgs e)
        {
           
            Navigation.PushAsync(new OrdersPage());
        }
    }
}