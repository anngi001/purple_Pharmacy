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

                new Product { FullName = "Acetaminofen", NombreGenerico ="Paracetamol", Precio ="10.2356.147 $", Codigo ="7485961235",  ImageUrl ="LoginMain.png"},
                new Product { FullName = "Ibuprofeno", NombreGenerico ="Advil", Precio ="12.365 $", Codigo ="M01AE01", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Vaporub", NombreGenerico ="Plectranthus ", Precio ="4.123 $", Codigo ="452269", ImageUrl ="LoginMain.png"},
                new Product { FullName = "nospirin", NombreGenerico ="no lo enocntre", Precio ="89.125 $", Codigo ="42645315", ImageUrl ="LoginMain.png"},

                new Product { FullName = "Abacavir", NombreGenerico ="ZIAGEN", Precio ="48.154 $", Codigo ="452185", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Abatacept", NombreGenerico ="ORENCIA", Precio ="78.268 $", Codigo ="631482", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Abciximab", NombreGenerico ="REOPRO", Precio ="96.265 $", Codigo ="6425796", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Acarbosa", NombreGenerico ="PRECOSE", Precio ="15.235 $", Codigo ="273452345", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Acebutolol", NombreGenerico ="SECTRAL", Precio ="14.258 $", Codigo ="46942665", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Acetazolamida", NombreGenerico ="DIAMOX", Precio ="75.123 $", Codigo ="6145823", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Acetilcisteína", NombreGenerico ="ACETADOTE", Precio ="45.254 $", Codigo ="62345365", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Actinomicina", NombreGenerico ="Dactinomicina", Precio ="34.784 $", Codigo ="787245256", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Aciclovir", NombreGenerico ="ZOVIRAX", Precio ="32.124 $", Codigo ="4564565", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Adalimumab", NombreGenerico ="HUMIRA", Precio ="52.149 $", Codigo ="766453465", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Adapaleno", NombreGenerico ="DIFFERIN", Precio ="17.584 $", Codigo ="3243564563", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Adefovir", NombreGenerico ="HEPSERA", Precio ="87.458 $", Codigo ="23445345", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Adenosina", NombreGenerico ="ADENOCARD", Precio ="99.154 $", Codigo ="23434563463", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Albendazol", NombreGenerico ="ALBENZA", Precio ="11.254 $", Codigo ="2356456", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Alclometasona", NombreGenerico ="ACLOVATE", Precio ="22.365 $", Codigo ="3454352345", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Alemtuzumab", NombreGenerico ="CAMPATH", Precio ="36.458 $", Codigo ="23564534523", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Alendronato", NombreGenerico ="FOSAMAX", Precio ="65.215 $", Codigo ="456342535", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Alfuzosina", NombreGenerico ="UROXATRAL", Precio ="39.125 $", Codigo ="234565634", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Alopurinol", NombreGenerico ="LOPURIN", Precio ="78.156 $", Codigo ="234563452", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Almotriptán", NombreGenerico ="AXERT", Precio ="92.158 $", Codigo ="7434235363", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Alosetrón", NombreGenerico ="LOTRONEX", Precio ="56.236 $", Codigo ="734534546", ImageUrl ="LoginMain.png"},
                new Product { FullName = "Alprazolam", NombreGenerico ="XANAX", Precio ="88.459 $", Codigo ="345757634", ImageUrl ="LoginMain.png"},



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