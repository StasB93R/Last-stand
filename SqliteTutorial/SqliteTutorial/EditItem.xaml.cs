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
            itemDiscount.Text = item.Discount;
            itemDescription.Text = item.Description;
            itemPrice.Text = item.Price.ToString();
        }

        void UpdateItem(object sender, System.EventArgs e)
        {
            Search.shopList.Remove(item);

            item.Title = itemName.Text;
            item.Address = itemAddress.Text;
            item.Category = itemCategory.Text;
            item.Discount = itemDiscount.Text;
            item.Description = itemDescription.Text;
            item.Price = Double.Parse(itemPrice.Text);
            Search.shopList.Add(item);


            Navigation.PushModalAsync(new SpecificItem(item.Id));
        }

    }
}