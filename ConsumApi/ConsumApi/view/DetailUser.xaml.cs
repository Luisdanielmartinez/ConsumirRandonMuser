using ConsumApi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsumApi.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailUser : ContentPage
	{
        //la clase detail
		public DetailUser(Usuario usuario)
		{
			InitializeComponent ();
            BindingContext = usuario;
		}
	}
}