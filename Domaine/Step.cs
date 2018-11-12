using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Step
    {
        public int StepId { get; set; }
        public int Numero { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public string Justification { get; set; }

        
        
        public int? PathId { get; set; }
        
        public virtual Path MyPath { get; set; }
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }


    }
}
