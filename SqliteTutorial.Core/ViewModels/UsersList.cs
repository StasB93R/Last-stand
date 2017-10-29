using SqliteTutorial.Core.Database;
using SqliteTutorial.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteTutorial.Core.ViewModels
{
    public class UsersList : ViewModelBase
    {
        private readonly MyDatabase _connect_db;
        private ObservableCollection<ShopItems> shopItems;

        public ObservableCollection<ShopItems> ShopItems
        {
            get { return shopItems; }
            set
            {
                shopItems = value;
                OnPropertyChanged();
            }
        }

        public UsersList()
        {
            _connect_db = new MyDatabase();
            ShopItems = new ObservableCollection<ShopItems>((System.Collections.Generic.IEnumerable<SqliteTutorial.Core.Models.ShopItems>)_connect_db.GetUserItems());
        }
    }
}

