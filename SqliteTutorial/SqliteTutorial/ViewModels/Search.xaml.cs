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
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }


        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //input we get for search
            var priceFromValue = priceFrom.Text;
            var priceToValue = priceTo.Text;
            var locationValue = location.Text;
            var categoryValue = category.Text;

            throw new NotImplementedException();
        }

    }
}
