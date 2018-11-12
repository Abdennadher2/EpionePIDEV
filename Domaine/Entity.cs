using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Entity
    {
        public int EntityId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Value { get; set; }
        public String ValueType { get; set; }

        public int dialogFK { get; set; }
        public virtual Dialog MyDialog { get; set; }
    }
}
