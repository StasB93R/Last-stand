using SqliteTutorial.Core.Interfaces;
using SqliteTutorial.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SqliteTutorial
{
    public partial class Login : ContentPage
    {
        void logUser(object sender, System.EventArgs e)
        {
            //THESE are the variables receiving input
            var userValue = username.Text;
            var passwordValue = password.Text;


            Navigation.PushModalAsync(new MainPage());
        }



        public Login()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("SqliteTutorial.Images.shopping.png");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new Registration());
            };

            goRegister.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
