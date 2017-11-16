using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public class Phone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {

        public List<Phone> Phones { get; set; }
        public Page2()
        {

            InitializeComponent();
            Phones = new List<Phone>
            {
                new Phone {Title="Galaxy S8", Company="Samsung", Price=48000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=35000 },
                new Phone {Title="HTC U Ultra", Company="HTC", Price=42000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=52000 }
            };
            this.BindingContext = this;
            //phonesList.ItemSelected += SelectedItem;
            phonesList.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    string selectedItem = e.SelectedItem.ToString();

                    // clear selected item
                    phonesList.SelectedItem = null;

                    //var detailsPage = new ItemDetails(selectedItem);
                    await Navigation.PushAsync(new Page4());
                }
            };


            //public async void SelectedItem(object sender, SelectedItemChangedEventArgs e)
            //        {
            //            Phone selectedPhone = e.SelectedItem as Phone;
            //            if (selectedPhone != null)
            //                await Application.Current.MainPage.Navigation.PushAsync(new Page4());
            //        }

            //public async void OnItemTapped(object sender, ItemTappedEventArgs e)
            //{
            //    Phone selectedPhone = e.Item as Phone;
            //    if (selectedPhone != null)
            //        await DisplayAlert("Выбранная модель", $"{selectedPhone.Company} - {selectedPhone.Title}", "OK");
            //}

        }
    }
}