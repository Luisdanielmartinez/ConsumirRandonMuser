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
		public DetailUser (string first,string last,string medium)
		{
			InitializeComponent ();
            lb_first.Text = first;
            lb_last.Text = last;
            img_users.Source = new UriImageSource() {
                Uri = new Uri(medium)
            };
		}
	}
}