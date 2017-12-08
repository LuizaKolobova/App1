using Plugin.Messaging;
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
    public partial class MyOffers : ContentPage
    {
        public MyOffers()
        {
            InitializeComponent();

        }

        private void SendToEmail(object sender, EventArgs e)
        {

            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail("goodlifetoday@mail.ru", nameEntry.Text + " " + kindEntry.Text, textEntry.Text);

            }

        }
    }
}