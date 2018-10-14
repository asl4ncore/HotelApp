using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int CategoryNumberId { get; set; }
        public CategoryNumber CategoryNumber { get; set; }
        public string Parameters { get; set; }
        public string PayType { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public DateTime DateArrival { get; set; }
        public DateTime DateDeparture { get; set; }

    }
}
