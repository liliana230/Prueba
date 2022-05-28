using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prueba.Controller;
using Prueba.Views;
using System.IO;

namespace Prueba
{
    public partial class App : Application
    {
        static DataBase db;
        public static DataBase DBase
        {
            get
            {
                if (db == null)
                {
                    db = new DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Emple.db3"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Inicio());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
