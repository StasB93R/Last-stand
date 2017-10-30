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
        public string Img { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool Mine { get; set; }
        public string Category { get; set; }
        public string Availability { get; set; }
        public string Discount { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }


    }
}
