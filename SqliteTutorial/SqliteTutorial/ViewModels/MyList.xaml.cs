using SqliteTutorial.Core.Interfaces;
using SqliteTutorial.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SqliteTutorial.Core.Database;

namespace SqliteTutorial
{
    public partial class MyList : ContentPage
    {
       
        public MyList()
        {
            InitializeComponent();

        }

       


        protected override void OnAppearing()
        {

            BindingContext = new SecondViewModel();

            base.OnAppearing();
        }
    }
}
