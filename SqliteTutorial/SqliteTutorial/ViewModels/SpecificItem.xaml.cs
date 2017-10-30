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
    public partial class SpecificItem : ContentPage
    {
        ShopItems item;

        public SpecificItem(int id)
        {
            InitializeComponent();

            //Position itemLocation = new Position(item.Lat, item.Lng);
            item = Search.getShopItems().First(shopitem => shopitem.Id == id);
            itemImage = new Image(); //item.Img
            itemName.Text = item.Title;
            itemAddress.Text = item.Address;
            itemCategory.Text = item.Category;
            itemAvailability.Text = item.Availability;
            itemDiscount.Text = item.Discount;
            itemDescription.Text = item.Description;
            itemPrice.Text = item.Price.ToString();

            /*
            map.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    itemLocation, Distance.FromMiles(1)));

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = itemLocation,
                Label = itemName.Text,
                Address = itemAddress.Text
            };
            map.Pins.Add(pin);
            */
        }

        void EditItem(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new EditItem(item.Id));
        }
    }
}
