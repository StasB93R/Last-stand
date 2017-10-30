using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SqliteTutorial.Core.Models;

namespace SqliteTutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditItem : ContentPage
    {
        ShopItems item;

        public EditItem(int id)
        {
            InitializeComponent();

            item = Search.shopList.First(shopitem => shopitem.Id == id);
            itemImage = new Image(); //item.Img
            itemName.Text = item.Title;
            itemAddress.Text = item.Address;
            itemCategory.Text = item.Category;
            itemAvailability.Text = item.Availability;
            itemDiscount.Text = item.Discount;
            itemDescription.Text = item.Description;
            itemPrice.Text = item.Price.ToString();
            itemLat.Text = item.Lat.ToString();
            itemLng.Text = item.Lng.ToString();
        }

        void UpdateItem(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new SpecificItem(item.Id));
        }

    }
}