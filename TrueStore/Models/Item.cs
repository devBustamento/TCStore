using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueStore.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public int ProducerId { get; set; }
        public string Price { get; set; }
        public string ItemArtUrl { get; set; }
        public Category Category { get; set; }
        public Producer Producer { get; set; }
    }
}
