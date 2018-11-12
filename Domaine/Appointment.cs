using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Start_date { get; set; }
        [DataType(DataType.Date)]
        public DateTime End_date { get; set; }
        public EnumApp Statut { get; set; }
        [Required]
        public Boolean validation { get; set; }

        public virtual Consultation consultatation { get; set; }
       
        public virtual Medecin Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
