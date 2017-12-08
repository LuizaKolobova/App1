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
	public partial class Authorization : ContentPage
	{
		public Authorization ()
		{
			InitializeComponent ();
		}

        private void Signin(object sender, EventArgs e)
        {
            if (login.Text == "Luiza" && password.Text == "makl3333")
            {
                DisplayAlert("Авторизация", "Авторизация прошла успешно! ", "OK");
            }
            else
            {
                DisplayAlert("Авторизация", "Неверно введен логин или пароль!", "OK");
            }
        }
    }
}