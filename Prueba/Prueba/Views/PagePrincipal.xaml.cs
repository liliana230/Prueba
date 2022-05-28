using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }


        private async void ListaEmpleados_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var emple = (Empleado)e.Item;
            await DisplayAlert("INFORMACION", "Empleado Seleccionado " + emple.nombre, "OK");
            await Navigation.PushAsync(new EmpleView(emple.id, emple.nombre, emple.edad, emple.genero, emple.fechaingreso));
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = await App.DBase.ObtenerListaEmple();
        }
    }
}