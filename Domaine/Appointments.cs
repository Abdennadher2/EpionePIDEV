using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Appointments
    {

        public int AppointmentsId { get; set; }

        public DateTime Date { get; set; }
        public Boolean ConfirmationPatient { get; set; }
        public Boolean ConfirmationDoctor { get; set; }
        public string State { get; set; }

    }
}
