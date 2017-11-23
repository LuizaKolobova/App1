using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{

    public class MasterPageItem
    {
        public string Title { get; set; }
        public Type TargetType { get; set; }

    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return infoList; } }
        public List<MasterPageItem> Information { get; set; }
        public MasterPage()
        {

            InitializeComponent();
            Information = new List<MasterPageItem>
                {
                    new MasterPageItem {Title="   Главная", TargetType=typeof(DetailPage)},
                    new MasterPageItem {Title="   Новости", TargetType = typeof(News)},
                    new MasterPageItem {Title="   Мероприятия",TargetType = typeof(Events)},
                    new MasterPageItem {Title="   Направления", TargetType = typeof(Directions)},
                    new MasterPageItem {Title="   Информация",TargetType = typeof(Info)},
                    new MasterPageItem {Title="   Настройки",TargetType = typeof(Settings)},
                    new MasterPageItem {Title="   Мои предложения",TargetType = typeof(MyOffers)},
                    new MasterPageItem {Title="   Избранное",TargetType = typeof(Likes)},
                    new MasterPageItem {Title="   Авторизация",TargetType = typeof(Authorization)}

                };

            infoList.ItemsSource = Information;

        }
    }
}