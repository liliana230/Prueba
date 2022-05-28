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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void toolmenu1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmplePage());
        }
    }
}