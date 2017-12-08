using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public class Sett
    {
        public string Name { get; set; }
        public Type TargetType { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public List<Sett> Setting { get; set; }
        public Settings()
        {
            InitializeComponent();
            //определяем список элементов направления
            Setting = new List<Sett>
            {
                new Sett {Name="Уведомления", TargetType=typeof(Info)},
                new Sett {Name="Информация", TargetType=typeof(Info)},
                new Sett {Name="Пользовательское соглашение", TargetType=typeof(Info)},
            };
            this.BindingContext = this;
            //phonesList.ItemSelected += SelectedItem;
            setList.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    var selectedItem = e.SelectedItem as Sett;
                    setList.SelectedItem = null;
                    await Navigation.PushAsync((Page)Activator.CreateInstance(selectedItem.TargetType));
                }
            };
        }
    }
}