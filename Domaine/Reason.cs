using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Reason
    {
        public int ReasonId { get; set; }
        [Required]
        public string Reas { get; set; }
        public int? DoctorId { get; set; }
        public virtual Medecin Doctor { get; set; }
    }
}
