using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Conversation
    {
        public int ConversationId { get; set; }
        public int IdDocS { get; set; }
        public int IdDocR { get; set; }
        public DateTime DateMessage { get; set; }
    }
}
