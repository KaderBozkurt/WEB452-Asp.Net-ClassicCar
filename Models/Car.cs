using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Car { get; set; }
    }
}
