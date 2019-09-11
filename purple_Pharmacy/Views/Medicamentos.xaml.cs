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
              
                new Product { FullName = "Acetaminofen", NombreGenerico ="Paracetamol", Precio ="10.2356.147 $", Codigo ="7485961235",  ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Ibuprofeno", NombreGenerico ="Advil", Precio ="12.365 $", Codigo ="M01AE01", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Vaporub", NombreGenerico ="Plectranthus ", Precio ="4.123 $", Codigo ="452269", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "nospirin", NombreGenerico ="no lo enocntre", Precio ="89.125 $", Codigo ="42645315", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Abacavir", NombreGenerico ="ZIAGEN", Precio ="48.154 $", Codigo ="452185", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Abatacept", NombreGenerico ="ORENCIA", Precio ="78.268 $", Codigo ="631482", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Abciximab", NombreGenerico ="REOPRO", Precio ="96.265 $", Codigo ="6425796", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Acarbosa", NombreGenerico ="PRECOSE", Precio ="15.235 $", Codigo ="273452345", ImageUrl ="LoginMain.png",ImageUrl2 ="compras"},
                new Product { FullName = "Acebutolol", NombreGenerico ="SECTRAL", Precio ="14.258 $", Codigo ="46942665", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Acetazolamida", NombreGenerico ="DIAMOX", Precio ="75.123 $", Codigo ="6145823", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Acetilcisteína", NombreGenerico ="ACETADOTE", Precio ="45.254 $", Codigo ="62345365", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Actinomicina", NombreGenerico ="Dactinomicina", Precio ="34.784 $", Codigo ="787245256", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Aciclovir", NombreGenerico ="ZOVIRAX", Precio ="32.124 $", Codigo ="4564565", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Adalimumab", NombreGenerico ="HUMIRA", Precio ="52.149 $", Codigo ="766453465", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Adapaleno", NombreGenerico ="DIFFERIN", Precio ="17.584 $", Codigo ="3243564563", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Adefovir", NombreGenerico ="HEPSERA", Precio ="87.458 $", Codigo ="23445345", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Adenosina", NombreGenerico ="ADENOCARD", Precio ="99.154 $", Codigo ="23434563463", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Albendazol", NombreGenerico ="ALBENZA", Precio ="11.254 $", Codigo ="2356456", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Alclometasona", NombreGenerico ="ACLOVATE", Precio ="22.365 $", Codigo ="3454352345", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Alemtuzumab", NombreGenerico ="CAMPATH", Precio ="36.458 $", Codigo ="23564534523", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Alendronato", NombreGenerico ="FOSAMAX", Precio ="65.215 $", Codigo ="456342535", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Alfuzosina", NombreGenerico ="UROXATRAL", Precio ="39.125 $", Codigo ="234565634", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Alopurinol", NombreGenerico ="LOPURIN", Precio ="78.156 $", Codigo ="234563452", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Almotriptán", NombreGenerico ="AXERT", Precio ="92.158 $", Codigo ="7434235363", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Alosetrón", NombreGenerico ="LOTRONEX", Precio ="56.236 $", Codigo ="734534546", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Alprazolam", NombreGenerico ="XANAX", Precio ="88.459 $", Codigo ="345757634", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Amantadina", NombreGenerico ="SYMMETREL", Precio ="87.589 $", Codigo ="456345", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Ambrisentan", NombreGenerico ="LETAIRIS", Precio ="58.197 $", Codigo ="3453453", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Ácido aminocaproico", NombreGenerico ="AMICAR", Precio ="79.267 $", Codigo ="9213452364", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Amiodarona", NombreGenerico ="CORDARONE", Precio ="99.458 $", Codigo ="923734634", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Amlexanox", NombreGenerico ="APHTHASOL", Precio ="5.896 $", Codigo ="7525785", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Amlodipina", NombreGenerico ="NORVASC (Amlodipino)", Precio ="8.459 $", Codigo ="453753", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Amorolfina", NombreGenerico ="LOCERYL", Precio ="7.459 $", Codigo ="78527", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Amoxicilina", NombreGenerico ="AMOXIL", Precio ="2.679 $", Codigo ="785236", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Anfetamina", NombreGenerico ="ADDERALL", Precio ="8.959 $", Codigo ="123786", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Anfotericina B", NombreGenerico ="FUNGIZONE", Precio ="7.459 $", Codigo ="3782485", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Ampicilina", NombreGenerico ="PRINCIPEN", Precio ="6.759 $", Codigo ="7828963", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Ampicilina/sulbactam", NombreGenerico ="UNASYN", Precio ="9.359 $", Codigo ="16786732", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Amprenavir", NombreGenerico ="AGENERASE", Precio ="8.459 $", Codigo ="77864", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Anagrelida", NombreGenerico ="AGRYLIN", Precio ="65.235 $", Codigo ="327862", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Anakinra", NombreGenerico ="KINERET", Precio ="7.159 $", Codigo ="78652", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Anastrozol", NombreGenerico ="ARIMIDEX", Precio ="152.4856 $", Codigo ="7867568", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Anidulafungina", NombreGenerico ="ERAXIS", Precio ="8.987 $", Codigo ="3457547634", ImageUrl ="LoginMain.png",ImageUrl2 ="compras"},
                new Product { FullName = "Anistreplasa", NombreGenerico ="EMINASE", Precio ="158.697 $", Codigo ="45786624", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Antazolina", NombreGenerico ="VASOCON-A", Precio ="9.789 $", Codigo ="47856", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Antralina", NombreGenerico ="ANTHRA-DERM", Precio ="4.258 $", Codigo ="96752452", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Apomorfina", NombreGenerico ="APOKYN", Precio ="6.791 $", Codigo ="744279869", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Apraclonidina", NombreGenerico ="IOPIDINE", Precio ="88.459 $", Codigo ="728692", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Argatroban", NombreGenerico ="ARGATROBAN", Precio ="8.963 $", Codigo ="289637527", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Aripiprazol", NombreGenerico ="ABILIFY", Precio ="99.999 $", Codigo ="2789863245", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Trióxido de arsénico", NombreGenerico ="TRISENOX", Precio ="54.900 $", Codigo ="5279638", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Asparaginasa", NombreGenerico ="ELSPAR ", Precio ="15.758 $", Codigo ="7852787", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Atenolol", NombreGenerico ="TENORMIN", Precio ="12.358 $", Codigo ="1786721", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Atorvastatina", NombreGenerico ="LIPITOR", Precio ="48.369 $", Codigo ="78527896", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Atovacuona", NombreGenerico ="MEPRON", Precio ="11.236 $", Codigo ="78527982", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Atropina", NombreGenerico ="ATROPEN", Precio ="8.000 $", Codigo ="524524", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Auranofina", NombreGenerico ="RIDAURA", Precio ="3.258 $", Codigo ="42563752", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Azacitidina", NombreGenerico ="VIDAZA", Precio ="4.258 $", Codigo ="86574", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Azatioprina", NombreGenerico ="IMURAN", Precio ="97.856 $", Codigo ="96374", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Azelastina", NombreGenerico ="OPTIVAR", Precio ="67.589 $", Codigo ="7412885", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Azitromicina", NombreGenerico ="ZITHROMAX", Precio ="33.500 $", Codigo ="1475287", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Bacitracina", NombreGenerico ="BACiiM", Precio ="40.150 $", Codigo ="3921741", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},
                new Product { FullName = "Balsalazida", NombreGenerico ="COLAZAL", Precio ="10.500 $", Codigo ="1859632", ImageUrl ="LoginMain.png", ImageUrl2 ="compras"},







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