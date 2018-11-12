using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class MedicalCare
    {
        public int MedicalCareId { get; set; }
        public int? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
       
        [Required(ErrorMessage = "Required")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Required")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Required")]
        public string AdditionaInfo { get; set; }
    }
}
