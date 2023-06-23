using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JNoronaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string user;
        double pagoM;
        double pagoT;

        public Registro(string user)
        {
            InitializeComponent();
            lblUser.Text = "Usuario conectado " + user;
            this.user = user;
        }

        private void btnPago_Clicked(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            if (monto < 0)
            {
                DisplayAlert("Error", "El monto no puede ser negativo", "ok");
            }
            if (txtMonto.Text == null || txtMonto.Text =="")
            {
                DisplayAlert("Error", "Ingrese el valor del monto", "ok");
            }
            pagoM = ((1500 - double.Parse(txtMonto.Text)) / 4) + (1500 * .04);

            txtPagoM.Text = pagoM + "";

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            pagoT = (double.Parse(txtMonto.Text)) + (pagoM * 4);

            Navigation.PushAsync(new Resumen(
                            this.user,
                            txtNombre.Text,
                            txtApellido.Text,
                            txtEdad.Text,
                            dpFecha.Date.ToString(),
                            pkrPais.Items[pkrPais.SelectedIndex],
                            pkrCiudad.Items[pkrCiudad.SelectedIndex],
                            double.Parse(txtMonto.Text),
                            pagoM,
                            pagoT
                ));
        }
    }
}