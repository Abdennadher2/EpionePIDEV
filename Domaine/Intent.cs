using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Intent
    {
        public int IntentId { get; set; }
        public String Description { get; set; }
        public String UserExemple { get; set; }
        public int dialogFK { get; set; }
        public virtual Dialog MyDialog { get; set; }
    }
}
