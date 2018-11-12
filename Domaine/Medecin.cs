
using Domaine;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain
{
    public class Medecin : User


    {


        public string Speciality { get; set; }//Obligatoire
        public int Rpps { get; set; }//Obligatoire
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Seulement les fichers image son permis.")]
        public string Justificatory { get; set; }//upload fichier image
        public int? NotificationId { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public int? IdSession { get; set; }
        public ICollection<ChatSession> ChatSessions { get; set; }
        public ICollection<Location> Locations { get; set; }
        public ICollection<Reason> Reasons { get; set; }
        public int? DispoId { get; set; }
        public ICollection<Disponibility> Disponibilitys { get; set; }
        public int? id_appointment { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}