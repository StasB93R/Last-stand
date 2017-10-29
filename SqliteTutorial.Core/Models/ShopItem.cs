using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace SqliteTutorial.Core.Models
{
    public class ShopItems
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public bool Mine { get; set; }
        public string Category { get; set; }


    }
}
