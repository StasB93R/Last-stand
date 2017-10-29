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
    public partial class MyList : ContentPage
    {
        public MyList()
        {
            InitializeComponent();
            BindingContext = new SecondViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
