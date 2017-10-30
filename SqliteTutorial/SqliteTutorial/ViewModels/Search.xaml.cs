using SqliteTutorial.Core.Interfaces;
using SqliteTutorial.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using SqliteTutorial.Core.Models;
using System.Collections.ObjectModel;

namespace SqliteTutorial
{
    public partial class Search : ContentPage
    {
        public static ObservableCollection<ShopItems> shopList = new ObservableCollection<ShopItems>();

        public Search()
        {
            InitializeComponent();

            shopList.Add(new ShopItems
            {
                Id = 1,
                Img = "http://wikiclipart.com/wp-content/uploads/2016/12/Shopping-bags-shopping-bag-clipart-5.jpeg",
                Title = "Adidas",
                Price = 40,
                Location = "Big W",
                Mine = false,
                Category = "Clothing",
                Lng = -27.5030,
                Lat = 153.1016,
                Discount = "10% off",
                Availability = "In Stock",
            });

            shopList.Add(new ShopItems
            {
                Id = 2,
                Img = "http://wikiclipart.com/wp-content/uploads/2016/12/Shopping-bags-shopping-bag-clipart-5.jpeg",
                Title = "Nike",
                Price = 40,
                Location = "Shop Level 4",
                Mine = false,
                Category = "Clothing",
                Lng = -27.3847,
                Lat = 153.0321,
                Discount = "Buy 1 get one Free",
                Availability = "In Stock",
            });

            shopList.Add(new ShopItems
            {
                Id = 3,
                Img = "http://wikiclipart.com/wp-content/uploads/2016/12/Shopping-bags-shopping-bag-clipart-5.jpeg",
                Title = "Baran",
                Price = 40,
                Location = "Garden City",
                Mine = false,
                Category = "Clothing",
                Lng = -27.4996,
                Lat = 152.9762,
                Discount = "Buy 1 get one Free",
                Availability = "In Stock",
            });

            shopList.Add(new ShopItems
            {
                Id = 4,
                Img = "http://wikiclipart.com/wp-content/uploads/2016/12/Shopping-bags-shopping-bag-clipart-5.jpeg",
                Title = "Ishak",
                Price = 40,
                Location = "Shop Level 1",
                Mine = false,
                Category = "Clothing",
                Lng = -27.5630,
                Lat = 153.0825,
                Discount = "5% off",
                Availability = "In Stock",
            });

            shopList.Add(new ShopItems
            {
                Id = 5,
                Img = "http://wikiclipart.com/wp-content/uploads/2016/12/Shopping-bags-shopping-bag-clipart-5.jpeg",
                Title = "Adidas",
                Price = 40,
                Location = "Rebel Sport",
                Mine = false,
                Category = "Clothing",
                Lng = -27.5030,
                Lat = 153.1016,
                Discount = "5% off",
                Availability = "In Stock",
            });

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

        protected override void OnAppearing()
        {

            listSearch.ItemsSource = shopList;


            base.OnAppearing();
        }

        void ViewItem(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            Navigation.PushModalAsync(new SpecificItem((int)button.CommandParameter));
        }

    }
}
