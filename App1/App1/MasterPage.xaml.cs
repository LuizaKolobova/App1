using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{

    //public class Info
    //{
    //    public string Title { get; set; }
    //}

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public List<Phone> Phones { get; set; }
        public MasterPage()
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

            //    public List<Info> Information { get; set; }
            //    public MasterPage()
            //    {

            //        InitializeComponent();
            //        Information = new List<Info>
            //        {
            //            new Info {Title="   Новости"},
            //            new Info {Title="   Мероприятия"},
            //            new Info {Title="   Направления"},
            //            new Info {Title="   Информация"},
            //            new Info {Title="   Настройки"},
            //            new Info {Title="   Мои предложения"},
            //            new Info {Title="   Избранное"},
            //            new Info {Title="   Авторизация"}

            //        };

            //        this.BindingContext = this;

            //        infoList.ItemSelected += async (sender, e) =>
            //        {
            //            if (e.SelectedItem != null)
            //            {
            //                string selectedItem = e.SelectedItem.ToString();

            //                // clear selected item
            //                infoList.SelectedItem = null;

            //                //var detailsPage = new ItemDetails(selectedItem);
            //                await Navigation.PushAsync(new News());
            //            }
            //        };
            //    }


            //}
        }
    }
}