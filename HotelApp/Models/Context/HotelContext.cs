using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Models.Context
{
    public class HotelContext:DbContext
    {
        public DbSet<CategoryNumber> CategoryNumbers{ get;set; }
        public DbSet<Classifaction> Classifactions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelCategory> HotelCategories { get; set; }
        public DbSet<HotelCountry> HotelCountries { get; set; }
        public DbSet<HotelType> HotelTypes { get; set; }
        public DbSet<Order> Orders { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options) : base(options) {}
    }
}
