using SQLite.Net;
using SqliteTutorial.Core.Database;
using SqliteTutorial.Core.Interfaces;
using SqliteTutorial.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SqliteTutorial.Core.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //to get to database
        private readonly MyDatabase _connect_db;

        //declaring everything for submitting item to DB
        private string title;
        private int price;
        private string location;
        private string category;

        //establishing getters and setters for information we are going to recieve

        //the first one is the title of the item
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        //Declaring for the price
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        //Declaring location
        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                OnPropertyChanged();
            }
        }
        //this will be used when we add items to the users list

        //For category of the item

        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                OnPropertyChanged();
            }
        }

        //This is used when submitting the to DB
        public ICommand SubmitCommand { protected set; get; }
       
        public ICommand GoSpecific { protected set; get; }
        public ICommand SecondPageCommand { protected set; get; }

        public MainViewModel()
        {
            _connect_db = new MyDatabase();
            SubmitCommand = new Command(Submit);
            SecondPageCommand = new Command(() =>
            {
            });
        }
   
        public void Submit()
        {
            _connect_db.Insert(new ShopItems()
            {
                Title = this.Title,
                Price = this.Price,
                Location = this.Location,
                Mine = true,
                Category = this.Category
            });
            Title = String.Empty;

           
           
        }
       
    }
}
//var nameValue = productName.Text;
//var priceValue = productPrice.Text;
//var categoryValue = productCategory.Text;
//var locationValue = productLocation.Text;