using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Path
    {
         [Key]
        [Required]
        public int PathId { get; set; }
        public bool State { get; set; }

        public int?  PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient MyPatient { get; set; }
        public int? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual Medecin MyDoctor { get; set; }
        public int? StepId { get; set; }
        [ForeignKey("StepId")]
        public  ICollection<Step> Steps { get; set; }

    }
}
