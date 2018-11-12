using Domain;
using Domaine;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain
{
    public class Patient : User
    {

        public int SocialNumber { get; set; }
        public int? NotificationId { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public int? IdSession { get; set; }
        public ICollection<ChatSession> ChatSessions { get; set; }

        public int? id_appointment { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}