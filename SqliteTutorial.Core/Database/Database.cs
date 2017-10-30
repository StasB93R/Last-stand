using SQLite.Net;
using SQLite.Net.Interop;
using SqliteTutorial.Core.Interfaces;
using SqliteTutorial.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SqliteTutorial.Core.Database
{
    public class MyDatabase
    {
        static SQLiteConnection database;
       
        public MyDatabase()
        {
            database = new SQLiteConnection(DependencyService.Get<ISQLitePlatform>(), 
            DependencyService.Get<IFileHelper>().GetLocalPath("ShopItemsDB1.db3"));
            database.CreateTable<ShopItems>();
        }

        public int Insert(ShopItems shopItem)
        {
            var item = database.Insert(shopItem);
            database.Commit();
            return item;

        }

        internal IEnumerable<ShopItems> GetUserItems()
        {
            throw new NotImplementedException();
        }

        public int InsertOrUpdate(ShopItems shopItem)
        {
            int num;
            if (database.Table<ShopItems>().Any(x=> x.Id == shopItem.Id))
            {
                num = database.Update(shopItem);
            }
            num = database.Insert(shopItem);
            database.Commit();
            return num;
        }

        public int Delete(ShopItems shopItem)
        {
            int num;
            num = database.Delete<ShopItems>(shopItem.Id);
            database.Commit();
            return num;
        }

        public List<ShopItems> GetAllShopItems()
        {
            return database.Table<ShopItems>().ToList();
        }



        public ShopItems GetShopItem(int key)
        {
            return database.Table<ShopItems>().Where(x => x.Id == key).FirstOrDefault();
        }

    }
}
