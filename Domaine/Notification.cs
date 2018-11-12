using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Object { get; set; }
        public string Message { get; set; }
        public EnumNotif Status { get; set; }
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int? DoctorId { get; set; }
        public virtual Medecin Doctor { get; set; }
    }
}
