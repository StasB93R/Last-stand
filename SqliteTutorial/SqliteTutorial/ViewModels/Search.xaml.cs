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

            shopList.Add(new ShopItems { Id = 1, Title = "Adidas", Price = 40, Location = "dont know",
                    Mine = false, Category = "Clothing", Lng = 27.5030, Lat = 153.1016  });


            shopList.Add(new ShopItems { Id = 2, Title = "Nike", Price = 40, Location = "dont know",
                    Mine = false, Category = "Clothing", Lng = 27.3847, Lat = 153.0321  });

            shopList.Add(new ShopItems { Id = 3, Title = "Baran", Price = 40, Location = "dont know",
                                Mine = false, Category = "Clothing", Lng = 27.4996, Lat = 152.9762  });

            shopList.Add(new ShopItems { Id = 4, Title = "Ishak", Price = 40, Location = "dont know",
                                Mine = false, Category = "Clothing", Lng = 27.5630, Lat = 153.0825  });

            shopList.Add(new ShopItems { Id = 5, Title = "Adidas", Price = 40, Location = "dont know",
                                Mine = false, Category = "Clothing", Lng = 27.5030, Lat = 153.1016  });

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

        void ViewItem(object sender, EventArgs e) {
            var button = ((Button)sender);
            Navigation.PushModalAsync(new SpecificItem((int)button.CommandParameter));
        }

    }
}
