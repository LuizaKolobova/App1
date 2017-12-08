using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1

{
    public class Offer
    {
        public string Name { get; set; }
        public string Kind { get; set; }
        public string Text { get; set; }
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyOffers : ContentPage
    {
        public ObservableCollection<Offer> Offers = new ObservableCollection<Offer>();
        
         
        public MyOffers()
        {
            InitializeComponent();
            offersList.ItemsSource = Offers;
        }


        private void SendToEmail(object sender, EventArgs e)
        {
               Offer a = new Offer()
                { Name = nameEntry.Text, Kind = kindEntry.Text, Text = textEntry.Text };
                Offers.Add(a);
                offersList.ItemsSource = Offers;
                var emailMessenger = CrossMessaging.Current.EmailMessenger;
                if (emailMessenger.CanSendEmail)
                {

                    emailMessenger.SendEmail("goodlifetoday@mail.ru", nameEntry.Text + " " + kindEntry.Text, textEntry.Text);

                }
        }

        private void DisplayAlert(string v)
        {
            throw new NotImplementedException();
        }
    }
}