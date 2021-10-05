using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel2.Models
{
    public class CreateHotelDTO
    {
        
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Hotel  Name is Too Long")]
       
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range (1,5)]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
        
    }

    public class HotelDTO: CreateHotelDTO
    {
        public int Id { get; set; }


    }
}
