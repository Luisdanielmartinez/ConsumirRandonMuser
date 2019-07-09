
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
        private viewModel.UsersViewModel users=new viewModel.UsersViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = users;

            LvResults.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                model.Usuario item = e.SelectedItem as Usuario;
                Navigation.PushAsync(new view.DetailUser(item));
              
            };
        }
       
        

      
    }
}
