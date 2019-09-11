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
    public partial class Medicamentos : ContentPage
    {
        public Medicamentos()
        {
            InitializeComponent();
            LoadContacts();
        }


        private void LoadContacts()
        {
            var contactclist = new List<Product>
            {

                new Product { FullName = "Acetaminofen", NombreCientifico ="Paracetamol", Precio ="10.2356.147", Codigo ="7485961235",  ImageUrl ="login.png"},
                new Product { FullName = "Ibuprofeno", NombreCientifico ="Advil", Precio ="12.365", Codigo ="M01AE01", ImageUrl ="login.png"},
                new Product { FullName = "Vaporub", NombreCientifico ="Plectranthus ", Precio ="4.123", Codigo ="452269", ImageUrl ="login.png"},
                new Product { FullName = "nospirin", NombreCientifico ="no lo enocntre", Precio ="89.125", Codigo ="42645315", ImageUrl ="login.png"}

            };

            lsContact.ItemsSource = contactclist;
        }

        private void Contact_selected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactselected = (Product)e.SelectedItem;
            Navigation.PushAsync(new DetailMedicametos(contactselected));
        }
    }
}