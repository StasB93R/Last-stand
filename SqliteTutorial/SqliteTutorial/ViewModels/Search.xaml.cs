using SqliteTutorial.Core.Interfaces;
using SqliteTutorial.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using SqliteTutorial.Core.Models;

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

        protected override void OnAppearing()
        {

            listSearch.ItemsSource = new List<ShopItems>
            {
                
                new ShopItems { Title = "Adidas", Price = 40, Location = "dont know",
                    Mine = false, Category = "Clothing", Long = 27.5030, Latit = 153.1016  },

                new ShopItems { Title = "Nike", Price = 40, Location = "dont know",
                    Mine = false, Category = "Clothing", Long = 27.3847, Latit = 153.0321  },

                new ShopItems { Title = "Baran", Price = 40, Location = "dont know",
                                Mine = false, Category = "Clothing", Long = 27.4996, Latit = 152.9762  },

                new ShopItems { Title = "Ishak", Price = 40, Location = "dont know",
                                Mine = false, Category = "Clothing", Long = 27.5630, Latit = 153.0825  },

                new ShopItems { Title = "Adidas", Price = 40, Location = "dont know",
                                Mine = false, Category = "Clothing", Long = 27.5030, Latit = 153.1016  },


            };


    

            base.OnAppearing();
        }

    }
}
