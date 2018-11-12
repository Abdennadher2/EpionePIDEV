using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class MedicalVisit
    {

        public int MedicalVisitId { get; set; }
        [Required(ErrorMessage = "Required")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Required")]
        public int Rating { get; set; }
        [Required(ErrorMessage = "Required")]
        public Boolean State { get; set; }
        public int? AppointmentsId { get; set; }
        [ForeignKey("AppointmentsId")]
        public virtual Appointments Appointments { get; set; }

    }
}
