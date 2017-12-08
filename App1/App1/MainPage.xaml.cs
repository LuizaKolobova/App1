using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
         
        public MainPage()
        {
            //InitializeComponent();

            MasterPage masterPage = new MasterPage();
            Master = masterPage;
            Detail = new NavigationPage(new DetailPage())
            {
                BarBackgroundColor = Color.FromHex("#cc0061")
            };
            masterPage.ListView.ItemSelected += SelectedItem;
            

            void SelectedItem(object sender, SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItem is MasterPageItem item)
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
                    {
                        BarBackgroundColor = Color.FromHex("#cc0061")
                    };

                    masterPage.ListView.SelectedItem = null;
                    IsPresented = false;
                }
            }

        }
    }
}
