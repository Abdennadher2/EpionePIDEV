using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Message
    {
        public int MessageId { get; set; }
        public DateTime DateMessage { get; set; }
        public string Content { get; set; }
        public string Object { get; set; }


        public int? IdDocS { get; set; }
        [ForeignKey("IdDocS")]
        public virtual User MyUserS { get; set; }
        public int? IdDocR { get; set; }
        [ForeignKey("IdDocR")]
        public virtual User MyUserR { get; set; }
    }
}
