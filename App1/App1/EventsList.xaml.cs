using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public class Direction
    {
        public string ImageP { get; set; }
        public Type TargetType { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsList : ContentPage
    {
        public List<Direction> Direct { get; set; }
        public EventsList()
        {
            InitializeComponent();
            //определяем список элементов направления
            Direct = new List<Direction>
            {
                new Direction {ImageP="sc.ipg",TargetType=typeof(Science)},
                new Direction {ImageP="sport.ipg",TargetType=typeof(Sport) },
                new Direction {ImageP="pk.ipg",TargetType=typeof(PS) },
                new Direction {ImageP="kvn.ipg",TargetType=typeof(KVN) },
                new Direction {ImageP="voln.ipg",TargetType=typeof(Volont) },
                new Direction {ImageP="mo.ipg",TargetType=typeof(MG) },
                new Direction {ImageP="so.ipg",TargetType=typeof(StOtr) },
                new Direction {ImageP="ao.ipg",TargetType=typeof(Activ) }
                
            };
            this.BindingContext = this;
            //phonesList.ItemSelected += SelectedItem;
            dirList.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    var selectedItem = e.SelectedItem as Direction;
                    dirList.SelectedItem = null;
                    await Navigation.PushAsync((Page)Activator.CreateInstance(selectedItem.TargetType));
                }
            };

            //public async void OnItemTapped(object sender, ItemTappedEventArgs e)
            //{
            //    //Phone selectedPhone = e.Item as Phone;
            //    //if (selectedPhone != null)
            //    //    await DisplayAlert("Выбранная модель", $"{selectedPhone.Company} - {selectedPhone.Title}", "OK");

            //}
        }
    }
}