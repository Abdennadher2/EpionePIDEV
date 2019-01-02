using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;
using Domain;
using Domaine;
using ServicePattern;

namespace Service
{
    public class PathService : Service<Step>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public PathService() : base(ut)
        {

        }

        public IEnumerable<Path> GetPathdsByDoctor(int id)
        {
            var res = from req in ut.getRepository<Path>().GetAll()
                where (req.DoctorId ==id)
                select req;
            return res;
        }


    }
}