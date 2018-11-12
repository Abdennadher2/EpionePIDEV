using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class ChatSession
    {
        public int ChatSessionId { get; set; }
        public String Session { get; set; }
        [DataType(DataType.Date)]
        public DateTime Time { get; set; }
        public virtual ICollection<Dialog> MyDialogs { get; set; }
        public virtual Medecin MyDoctor { get; set; }
        public virtual Patient MyPatient { get; set; }
    }
}
