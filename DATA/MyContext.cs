using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using Domaine;

namespace DATA
{
  public  class MyContext : IdentityDbContext<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {


        
        public static MyContext Create()
        {
            return new MyContext();
        }

        static MyContext()
        {
            Database.SetInitializer<MyContext>(null);
        }

        public MyContext() : base("name=EpioneDB")
        {

        }


       
        public DbSet<Adresse> Adresse { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        public DbSet<Curriculum> Curriculms { get; set; }

        public DbSet<Conversation> Conversations { get; set; }

        public DbSet<Step> Steps { get; set; }

    }
}
