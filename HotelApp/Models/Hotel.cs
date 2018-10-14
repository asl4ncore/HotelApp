using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int HotelCategoryId { get; set; }
        public HotelCategory HotelCategory { get; set; }
        public int HotelTypeId { get; set; }
        public HotelType HotelType { get; set; }
        public int HotelCountryId { get; set; }
        public HotelCountry HotelCountry { get; set; }
        public ICollection<CategoryNumber> CategoryNumbers { get; set; }
        public Hotel()
        {
            CategoryNumbers = new List<CategoryNumber>();
        }
    }
}
