
using ConsumApi.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsumApi
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            obtenerResult();

            LvResults.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = e.SelectedItem as Usuario;
                Navigation.PushAsync(new view.DetailUser(item.fisrt, item.last, item.medium));
              
            };
        }
       
        private async void obtenerResult() {
            // getById();

            try
            {
                Entity.EntityResults entityResults = new Entity.EntityResults();
                var result = await entityResults.getResults("https://randomuser.me/api/?results=20");
                if (result != null)
                {
                    LvResults.ItemsSource = result;

                }
            }
            catch (Exception e)
            {
               await DisplayAlert("alert", "error", "Ok");
            }
        }
        

      
    }
}
