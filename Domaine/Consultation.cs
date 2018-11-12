using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Consultation
    {
        [ForeignKey("Appointment")]
        public int ConsultationId { get; set; }
        public string observation { get; set; }
        public DateTime cons_date { get; set; }

        public DateTime disease { get; set; }
        public DateTime treatment { get; set; }
        public int rating { get; set; }
        public virtual Recomendation recommendation { get; set; }
        public virtual Appointment Appointment { get; set; }

    }
}
