using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace ClassicCar.Models
{
    public class Car
    {
        [Key]
        public int Ad_Number { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public string Transmission { get; set; }

        [DataType(DataType.Date)]
        public DateTime AdDate { get; set; }
        public string Fuel { get; set; }
        public decimal Price { get; set; }
    }
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Car { get; set; }
    }
}
