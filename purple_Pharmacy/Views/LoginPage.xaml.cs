using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace purple_Pharmacy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {


        public LoginPage()
        {
            InitializeComponent();
            btLogin.Clicked += BtLogin_Clicked;
        }

        private async void BtLogin_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {

                await DisplayAlert("Validacion", "Por favor digite un usuario", "ok");
                txtUsuario.Focus();
                return;


            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {

                await DisplayAlert("Validacion", "Por favor digite una contraseña ", "ok");
                txtPassword.Focus();
                return;


            }
            await ((NavigationPage)this.Parent).PushAsync(new DomicilesPage());


        }




    }
}