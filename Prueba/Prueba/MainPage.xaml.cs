using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prueba
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(DateTime date)
        {
            InitializeComponent();
        }

        private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            /*Forma uno:
          await DisplayAlert("Nombre : " + txtnombre.Text + "Edad : " + txtedad.Text, "Aviso", "Ok");*/

            /*Forma dos*/
            await DisplayAlert("Aviso", String.Format("Nombre : {0} Edad : {1}   Aviso", txtnombre.Text, txtedad.Text), "Ok");
        }

        private async void btnpagina_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Empleado
            {
                nombre = txtnombre.Text,
                edad = txtedad.Text
            };

            /*var segunda = new SecondPage();
            segunda.BindingContext = emple;
            await Navigation.PushAsync(segunda);*/

            await Navigation.PushAsync(new SecondPage(txtnombre.Text, txtedad.Text));

        }
    }
}
