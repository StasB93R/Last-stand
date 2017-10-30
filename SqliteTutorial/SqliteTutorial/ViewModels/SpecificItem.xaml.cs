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
    public partial class SpecificItem : ContentPage
    {
        int itemId;
        public SpecificItem(int id)
        {
            InitializeComponent();

            itemId = id;
            itemImage = new Image();
            //Position itemLocation = new Position(-27.477356, 153.0284231);
            itemName.Text = "Book";
            itemAddress.Text = "QUT Gardens Point Campus, 2 George St";
            itemCategory.Text = "Books";
            itemAvailability.Text = "In Stock";
            itemDiscount.Text = "10% off";
            itemDescription.Text = "";
            itemPrice.Text = "$10.00";
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
            Navigation.PushModalAsync(new EditItem(itemId));
        }
    }
}
