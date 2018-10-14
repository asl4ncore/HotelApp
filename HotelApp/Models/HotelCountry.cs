using System.Collections.Generic;

namespace HotelApp.Models
{
    public class HotelCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public HotelCountry()
        {
            Hotels = new List<Hotel>();
        }
    }
}