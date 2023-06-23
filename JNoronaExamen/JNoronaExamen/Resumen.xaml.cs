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
    public partial class Resumen : ContentPage
    {
        string user;
        string nombre;
        string apellido;
        string edad;
        string fecha;
        string ciudad;
        string pais;
        double monto;
        double pagoM;
        double pagoT;
        public Resumen(
            string user,
            string nombre,
            string apellido,
            string edad,
            string fecha,
            string ciudad,
            string pais,
            double monto,
            double pagoM,
            double pagoT
            )
        {

            InitializeComponent();
            lblUser.Text = "Usuario conectado " + user;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtCiudad.Text = ciudad;
            txtPais.Text = pais;
            txtFecha.Text = fecha;
            txtEdad.Text = edad;
            txtMonto.Text = monto + "";
            txtPagoM.Text = pagoM + "";
            txtPagoT.Text = pagoT + "";
        }

        private void btnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
            Navigation.PushAsync(new Login());


        }
    }
}









