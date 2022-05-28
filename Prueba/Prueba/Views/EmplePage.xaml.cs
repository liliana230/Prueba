using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prueba.Models;
using Prueba.Controller;

namespace Prueba.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmplePage : ContentPage
    {
        public EmplePage()
        {
            InitializeComponent();
            
        }

        private async void toolmenu2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePrincipal());
        }

        private async void btngregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePrincipal());
            var emple = new Empleado
            {
                id = 0,
                nombre = txtnombre.Text,
                edad = txtedad.Text,
                genero = genero.SelectedItem.ToString(),
                fechaingreso = fecha.Date.ToString()
            };


            var result = await App.DBase.EmpleSave(emple);

            if (result > 0)
            {
                await DisplayAlert("INFORMACION", "Empleado Adicionado", "OK");
            }
            else {
                await DisplayAlert("ALERTA", "ERROR: Empleado NO Adicionado", "NO");
            }

            
        }

        private void btneliminar_Clicked(object sender, EventArgs e)
        {

        }
    }
}