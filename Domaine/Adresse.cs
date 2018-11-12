using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Adresse
    {
        [Key]
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Required")]
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Required")]   
        public string City { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Town { get; set; }
        [Required(ErrorMessage = "Required")]
        public int PostalCode { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Country { get; set; }
    }
}
