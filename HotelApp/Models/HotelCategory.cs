using System.Collections.Generic;

namespace HotelApp.Models
{
    public class HotelCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public HotelCategory()
        {
            Hotels = new List<Hotel>();
        }
    }
}