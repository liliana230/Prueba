﻿using System;
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
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void toolmenu1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmplePage());
        }

        private async void ListaEmpleados_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var emple = (Empleado)e.Item;
            await DisplayAlert("INFO", "Empleado Seleccionado " + emple.nombre, "OK");
            await Navigation.PushAsync(new EmpleView(emple.id, emple.nombre, emple.edad, emple.genero, emple.fechaingreso));
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = await App.DBase.ObtenerListaEmple();
        }
    }
}