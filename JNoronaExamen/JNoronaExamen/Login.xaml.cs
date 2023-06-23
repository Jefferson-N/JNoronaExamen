using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JNoronaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private string userPredeterminado = "estudiante2023";
        public Login()
        {
            InitializeComponent();
        }

        private void session_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (!userPredeterminado.Equals(user) || !"uisrael2023".Equals(pass))
            {
                DisplayAlert("DATOS iNCORRECTOS","Usuario o contraseña incorrectos", "OK");
                return;
            }

            Navigation.PushAsync(new Registro(user));

        }
    }
}