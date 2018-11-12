using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Dialog
    {
        public int DialogId { get; set; }
        public String Name { get; set; }
        public String Response { get; set; }
        public String Recognition { get; set; }
        public int? chatFK { get; set; }
        public virtual ChatSession MyChatSession { get; set; }

        public virtual ICollection<Entity> MyEntities { get; set; }
        public virtual ICollection<Intent> MyIntents { get; set; }
    }
}
