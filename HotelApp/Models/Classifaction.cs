using System.Collections.Generic;

namespace HotelApp.Models
{
    public class Classifaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryNumber> CategoryNumbers { get; set; }
        public Classifaction()
        {
            CategoryNumbers = new List<CategoryNumber>();
        }
    }
}