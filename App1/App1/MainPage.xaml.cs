using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
	{
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new DetailPage())
            {
                BarBackgroundColor = Color.FromHex("#cc0061")
            };

		}
	}
}
