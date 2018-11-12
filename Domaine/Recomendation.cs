using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Recomendation
    {
        [ForeignKey("Consultation")]
        public int RecomendationId { get; set; }
        [MaxLength]
        public string nameDoctor { get; set; }
        public string description { get; set; }
        public virtual Consultation Consultation { get; set; }
    }
}
