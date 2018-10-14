using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите ИИН пользователя")]
        public string IIN { get; set; }
        [Required(ErrorMessage = "Укажите фамилию пользователя")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Укажите имя пользователя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Укажите отчество пользователя")]
        public string Patronymic { get; set; }
        [Required(ErrorMessage = "Укажите email пользователя")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Укажите номер пользователя")]
        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Client ()
        {
            Orders = new List<Order>();
        }
    }
}