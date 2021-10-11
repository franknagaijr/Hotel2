using Hotel2.data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel2.Models
{
    public class CreateCountryDTO
    {
       
        [Required]
        [StringLength(maximumLength:100, ErrorMessage = "Country Name is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Country Name is Too Long")]
        public string ShortName { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }

        public IList<HotelDTO> Hotels { get; set;  }
        
    }
}
