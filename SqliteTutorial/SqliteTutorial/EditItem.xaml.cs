using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqliteTutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditItem : ContentPage
    {
        int itemId;

        public EditItem(int id)
        {
            InitializeComponent();
            itemId = id;
            itemImage = new Image();
            itemName.Text = "Book";
            itemAddress.Text = "QUT Gardens Point Campus, 2 George St";
            itemCategory.Text = "Books";
            itemAvailability.Text = "In Stock";
            itemDiscount.Text = "10% off";
            itemDescription.Text = "";
            itemPrice.Text = "$10.00";
            itemLat.Text = "-27.477356";
            itemLng.Text = "153.0284231";
        }

        void UpdateItem(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new SpecificItem(itemId));
        }

    }
}