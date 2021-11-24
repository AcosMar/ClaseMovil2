using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaboratorioFirmas.Controllers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaFirmas : ContentPage
    {
        public ListaFirmas()
        {
            InitializeComponent();
            LlenarDatos();
        }

         public async void LlenarDatos()
        {
            var personlist = await App.SQLiteDB.GetPersonasAync();
            if (personlist != null)
            {
                lstdatos.ItemsSource = personlist;
            }
            else
            {

            }
        }
        protected async override void OnAppearing()
        {
            var personlist = await App.SQLiteDB.GetPersonasAync();
            if (personlist != null)
            {
                lstdatos.ItemsSource = personlist;
            }
            else
            {

            }
        }
        private void lstdatos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.Persona item = (Models.Persona)e.Item;
            
    }
    }
}