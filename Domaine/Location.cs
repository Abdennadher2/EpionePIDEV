using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Location
    {
        public int LocationId { get; set; }
        public float Longitude { get; set; }

        public float Attitude { get; set; }
        public String City { get; set; }

        public int PostalCode { get; set; }

        public int DoctorFk { get; set; }

        public int? DoctorId { get; set; }
        public virtual Medecin Doctor { get; set; }
    }
}
