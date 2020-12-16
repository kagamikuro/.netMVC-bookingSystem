using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Flight
    {
        public int ID { get; set; }

        [Display(Name = "Departure City")]
        [RegularExpression(@"^[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Departure { get; set; }

        [Display(Name = "Distination City")]
        [RegularExpression(@"^[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Distination { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }
        public int NumOfPassenger { get; set; }

        [Range(1, 500000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public String CreateByUser { get; set; }
    }

    public class FlightDBContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
    }

}