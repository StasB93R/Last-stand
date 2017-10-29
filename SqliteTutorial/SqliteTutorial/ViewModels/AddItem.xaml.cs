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
    public partial class AddItem : ContentPage
    {
        public AddItem()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        void uploadItem(object sender, System.EventArgs e)
        {
            var nameValue = productName.Text;
            var priceValue = productPrice.Text;
            var categoryValue = productCategory.Text;
            var locationValue = productLocation.Text;


     


        }

        void upload_Image(object sender, System.EventArgs e)
        {
            
        }
    }
}
