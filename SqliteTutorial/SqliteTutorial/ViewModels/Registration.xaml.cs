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
    public partial class Registration : ContentPage
    {


        public Registration()
        {
            InitializeComponent();



            image.Source = ImageSource.FromResource("SqliteTutorial.Images.shopping.png");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new Login());
            };

            goLogin.GestureRecognizers.Add(tapGestureRecognizer);


        }

        void registerUser(object sender, System.EventArgs e)
        {
            //THESE are the variables receiving input
            var usernameValue = username.Text;
            var emailValue = email.Text;
            var passwordValue = password.Text;
            var confrimation = confirmation.Text;



            throw new NotImplementedException();
        }




    }
}
