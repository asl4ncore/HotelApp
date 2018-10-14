using System.Collections.Generic;

namespace HotelApp.Models
{
    public class HotelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public HotelType()
        {
            Hotels = new List<Hotel>();
        }
    }
}