using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaboratorioFirmas
{
    public partial class App : Application
    {
        internal static object SQLiteDB;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
