using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class CategoryNumber
    {
        public int Id { get; set; }
        public int ClassifactionId { get; set; }
        public Classifaction Classifaction { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<Order> Orders { get; set; }
        public CategoryNumber()
        {
            Orders = new List<Order>();
        }
    }
}
