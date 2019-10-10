using product.Domain;
using purple_Pharmacy.Services;
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
    public partial class Medicamentos : ContentPage
    {
        public Medicamentos()
        {

            InitializeComponent();

            lsContact.ItemsSource = ProductoService.GetProducts();

        }
        private void Contact_selected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactselected = (Product)e.SelectedItem;
            Navigation.PushAsync(new DetailMedicametos(contactselected));
        }
    }
}