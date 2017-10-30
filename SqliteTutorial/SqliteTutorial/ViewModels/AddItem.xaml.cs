using Plugin.Media;
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

            takePhoto.Clicked += async (sender, args) =>
            {

                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {

                    Directory = "Sample",
                    Name = "test.jpg"
                });

                if (file == null)
                    return;




                upload.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();

                    file.Dispose();
                    return stream;
                });
            };

            pickPhoto.Clicked += async (sender, args) =>
            {
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    
                    return;
                }
                var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Small
                });



                if (file == null)
                    return;         


                upload.Source = ImageSource.FromStream(() =>
                {
                   var stream = file.GetStream();

                    file.Dispose();

                    return stream;
                });


            };







            BindingContext = new MainViewModel();
        }

        void uploadItem(object sender, System.EventArgs e)
        {
           
            var nameValue = productName.Text;
            var priceValue = productPrice.Text;
            var categoryValue = productCategory.Text;
            var locationValue = productLocation.Text;


     


        }



       
    }
}
